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
    public partial class AreaSelectForm : Form
    {
        public AreaSelectForm()
        {
            InitializeComponent();
        }

        private void AreaSelectForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                Program.appForm.stopCaptionTimer();
            }
        }
    }
}
