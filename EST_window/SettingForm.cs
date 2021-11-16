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
            config.Save();
        }
    }
}
