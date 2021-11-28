using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EST_window
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();

            System.Diagnostics.FileVersionInfo fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            versionLabel.Text = "Version " + fileVersionInfo.FileVersion;
        }

        private void vframe_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vframe_license_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/penguin-syan/English_slide_translation/blob/main/LICENSE");
        }
    }
}
