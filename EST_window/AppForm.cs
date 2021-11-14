using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EST_window
{
    public partial class AppForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vkey);

        CaptionArea capArea = new CaptionArea();

        bool flgClick = false;
        int flgClickCount = 0;

        public AppForm()
        {
            InitializeComponent();
        }

        private void setAreaBusson_Click(object sender, EventArgs e)
        {
            LTposLabel.Text = string.Format("始点 [x, y]");
            RBposLabel.Text = string.Format("終点 [x, y]");

            setAreaButton.Text = "領域選択中";
            setAreaButton.Enabled = false;

            this.WindowState = FormWindowState.Minimized;

            setAreaTimer.Start();
        }

        private void startTranslation_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(capArea.xs, capArea.ys, capArea.width, capArea.height);
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(new Point(rectangle.X, rectangle.Y), new Point(0, 0), bitmap.Size);
            graphics.Dispose();

            pictureBox1.Image = bitmap;

            string userDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!System.IO.Directory.Exists(userDoc + "\\EST"))
            {
                Directory.CreateDirectory(userDoc + "\\EST");
            }
            bitmap.Save(userDoc + "\\EST\\file.png");
            GCP_Vision.detect_dtext(userDoc + "\\EST\\file.png");
        }

        private void setAreaTimer_Tick(object sender, EventArgs e)
        {
            if(GetAsyncKeyState(Keys.LButton) != 0)
            {
                if(flgClick == false)
                {
                    LTposLabel.Text = string.Format("始点 [{0:d}, {1:d}]", Cursor.Position.X, Cursor.Position.Y);
                    capArea.setStartArea(Cursor.Position.X, Cursor.Position.Y);
                    flgClick = true;
                }
                else
                {
                    RBposLabel.Text = string.Format("終点 [{0:d}, {1:d}]", Cursor.Position.X, Cursor.Position.Y);
                    capArea.setEndArea(Cursor.Position.X, Cursor.Position.Y);
                }

                flgClickCount++;
            }
            else
            {
                flgClick = false;
                if(flgClickCount > 1)
                {
                    setAreaTimer.Stop();

                    flgClickCount = 0;
                    setAreaButton.Text = "領域選択";
                    setAreaButton.Enabled = true;

                    this.WindowState = FormWindowState.Normal;
                }

            }
        }
    }
}
