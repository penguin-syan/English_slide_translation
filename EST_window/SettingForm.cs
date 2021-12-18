using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using DeepL;

namespace EST_window
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            this.GCkey_textBox.Text = ConfigurationManager.AppSettings["GC_key"];
            this.deeplKey_textBox.Text = ConfigurationManager.AppSettings["DeepL_key"];
            this.proxy_enabled.Checked = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
            this.proxy_url.Text = ConfigurationManager.AppSettings["proxy_url"];
            this.proxy_url.Enabled = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
            this.proxy_port.Text = ConfigurationManager.AppSettings["proxy_port"];
            this.proxy_port.Enabled = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
            this.targetLangBox.Text = ConfigurationManager.AppSettings["targetLang"];
            this.sourceLangBox.Text = ConfigurationManager.AppSettings["sourceLang"];
            this.autoTranslateCheckbox.Checked = ConfigurationManager.AppSettings["autoTranslate"].Equals("true");
            
            get_deepl_usage();
        }

        private void GCkey_reference_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if(dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                GCkey_textBox.Text = openFileDialog1.FileName;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Program.appForm.Enabled = true;
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["GC_key"].Value = this.GCkey_textBox.Text;
            config.AppSettings.Settings["DeepL_key"].Value = this.deeplKey_textBox.Text;
            config.AppSettings.Settings["proxy_enabled"].Value = this.proxy_enabled.Checked ? "true": "false";
            config.AppSettings.Settings["proxy_url"].Value = this.proxy_url.Text;
            config.AppSettings.Settings["proxy_port"].Value = this.proxy_port.Text;
            config.AppSettings.Settings["targetLang"].Value = this.targetLangBox.Text;
            config.AppSettings.Settings["sourceLang"].Value = this.sourceLangBox.Text;
            config.AppSettings.Settings["autoTranslate"].Value = this.autoTranslateCheckbox.Checked ? "true" : "false";
            config.Save();
            Program.appForm.Enabled = true;
            this.Close();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void proxy_enabled_CheckedChanged(object sender, EventArgs e)
        {
            proxy_url.Enabled = proxy_enabled.Checked;
            proxy_port.Enabled = proxy_enabled.Checked;
        }

        private async void get_deepl_usage()
        {
            var authKey = ConfigurationManager.AppSettings["DeepL_key"];
            Translator translator;

            try
            {
                translator = new Translator(authKey);
            }
            catch (System.ArgumentException)
            {
                return;
            }

            var usage = await translator.GetUsageAsync();
            if (usage.AnyLimitReached)
            {
                deepl_usageLabel.Text = "Limit exceeded.";
                deepl_usageBar.Value = 500000;
            }
            else if (usage.Character != null)
            {
                string usage_str = usage.Character.ToString().Split(' ')[0];
                Console.WriteLine(usage_str);
                deepl_usageBar.Value = Int32.Parse(usage_str);
                deepl_usageLabel.Text = String.Format("{0:#,0}/500,000", usage_str);
            }
            else
            {
                deepl_usageLabel.Text = "ERROR";
            }

        }
    }
}
