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

namespace EST_window
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            this.GCkey_textBox.Text = ConfigurationManager.AppSettings["GC_key"];
            this.deeplKey_textBox.Text = ConfigurationManager.AppSettings["DeepL_key"];
            this.deepl_mode.Text = ConfigurationManager.AppSettings["DeepL_type"];
            this.proxy_enabled.Checked = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
            this.proxy_url.Text = ConfigurationManager.AppSettings["proxy_url"];
            this.proxy_url.Enabled = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
            this.proxy_port.Text = ConfigurationManager.AppSettings["proxy_port"];
            this.proxy_port.Enabled = ConfigurationManager.AppSettings["proxy_enabled"].Equals("true");
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
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["GC_key"].Value = this.GCkey_textBox.Text;
            config.AppSettings.Settings["DeepL_key"].Value = this.deeplKey_textBox.Text;
            config.AppSettings.Settings["DeepL_type"].Value = this.deepl_mode.Text;
            config.AppSettings.Settings["proxy_enabled"].Value = this.proxy_enabled.Checked ? "true": "false";
            config.AppSettings.Settings["proxy_url"].Value = this.proxy_url.Text;
            config.AppSettings.Settings["proxy_port"].Value = this.proxy_port.Text;
            config.Save();
            this.Close();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void proxy_enabled_CheckedChanged(object sender, EventArgs e)
        {
            proxy_url.Enabled = proxy_enabled.Checked;
            proxy_port.Enabled = proxy_enabled.Checked;
        }
    }
}
