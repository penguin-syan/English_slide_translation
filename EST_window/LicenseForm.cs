using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EST_window
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.ossNameCombo.Text)
            {
                case "DeepLcom / deepl-dotnet":
                    this.licenseViewTextBox.Text = Properties.Resources.deepl_dotnet;
                    break;
                case "Google Cloud Vision V1":
                    this.licenseViewTextBox.Text = Properties.Resources.GoogleCloudVisionV1;
                    break;
                case "Newtonsoft.Json":
                    this.licenseViewTextBox.Text = Properties.Resources.NewtonsoftJson;
                    break;
                default:
                    return;
            }
        }

        private void closeLicenseButton_Click(object sender, EventArgs e)
        {
            Program.appForm.Enabled = true;
            this.Close();
        }
    }
}
