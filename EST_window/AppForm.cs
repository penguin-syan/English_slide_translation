using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EST_window
{
    public partial class AppForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vkey);

        CaptionArea capArea = new CaptionArea();
        AreaSelectForm areaSelectForm = new AreaSelectForm();

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

            areaSelectForm.Show();
            this.WindowState = FormWindowState.Minimized;

            setAreaTimer.Start();
        }


        private void startTranslation_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(capArea.xs, capArea.ys, capArea.width, capArea.height);
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            this.Visible = false;
            Thread.Sleep(200);
            graphics.CopyFromScreen(new Point(rectangle.X, rectangle.Y), new Point(0, 0), bitmap.Size);
            graphics.Dispose();
            this.Visible = true;

            pictureBox1.Image = bitmap;

            string userDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!System.IO.Directory.Exists(userDoc + "\\EST"))
            {
                Directory.CreateDirectory(userDoc + "\\EST");
            }
            bitmap.Save(userDoc + "\\EST\\file.png");
            //GCP_Vision.detect_dtext(userDoc + "\\EST\\file.png"); //デバッグ時に不要なリクエストを防ぐためにコメントアウトしてもよい
        }


        private void setAreaTimer_Tick(object sender, EventArgs e)
        {
            if(GetAsyncKeyState(Keys.LButton) != 0)
            {
                if(flgClick == false)
                {
                    capArea.setStartArea(Cursor.Position.X, Cursor.Position.Y);
                    flgClick = true;
                }
                else
                {
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

                    LTposLabel.Text = string.Format("始点 [{0:d}, {1:d}]", capArea.xs, capArea.ys);
                    RBposLabel.Text = string.Format("終点 [{0:d}, {1:d}]", capArea.xs + capArea.width, capArea.ys + capArea.height);

                    areaSelectForm.Hide();
                    this.WindowState = FormWindowState.Normal;
                }

            }
        }

        private void 初期設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void gitリポジトリToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/penguin-syan/English_slide_translation");
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ヘルプの表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/penguin-syan/English_slide_translation/wiki");
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm versionForm = new VersionForm();
            versionForm.Show();
        }
    }
}
