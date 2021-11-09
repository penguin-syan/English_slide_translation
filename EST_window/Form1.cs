using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EST_window
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vkey);

        bool flgClick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void setAreaBusson_Click(object sender, EventArgs e)
        {
            setAreaTimer.Start();
        }

        private void startTranslation_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(200, 200, 800, 500);
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(new Point(rectangle.X, rectangle.Y), new Point(0, 0), bitmap.Size);
            graphics.Dispose();

            pictureBox1.Image = bitmap;
        }

        private void setAreaTimer_Tick(object sender, EventArgs e)
        {
            if(GetAsyncKeyState(Keys.LButton) != 0)
            {
                if(flgClick == false)
                {
                    LTposLabel.Text = string.Format("始点 [{0:d}, {1:d}]", Cursor.Position.X, Cursor.Position.Y);
                    flgClick = true;
                }
                else
                {
                    RBposLabel.Text = string.Format("終点 [{0:d}, {1:d}]", Cursor.Position.X, Cursor.Position.Y);
                }
            }
            else
            {
                flgClick = false;
            }
        }
    }
}
