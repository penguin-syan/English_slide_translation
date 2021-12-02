using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EST_window
{
    public partial class AppForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vkey);

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        CaptionArea capArea = new CaptionArea();
        AreaSelectForm areaSelectForm = new AreaSelectForm();

        string userDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        bool flgClick = false;
        int flgClickCount = 0;
        static int height = Screen.PrimaryScreen.Bounds.Height;
        static int width = Screen.PrimaryScreen.Bounds.Width;

        public AppForm()
        {
            InitializeComponent();

            LTposLabel.Text = "width : " + width;
            RBposLabel.Text = "height: " + height;
        }


        private void setAreaBusson_Click(object sender, EventArgs e)
        {
            LTposLabel.Text = string.Format("始点 [x, y]");
            RBposLabel.Text = string.Format("終点 [x, y]");

            setAreaButton.Text = "領域選択中";
            setAreaButton.Enabled = false;

            areaSelectForm.selectArea_pBox.Size = new Size(width, height);
            areaSelectForm.selectArea_pBox.Image = null;
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

            if (!System.IO.Directory.Exists(userDoc + "\\EST"))
            {
                Directory.CreateDirectory(userDoc + "\\EST");
            }
            bitmap.Save(userDoc + "\\EST\\file.png");
            //GCP_Vision.detect_dtext(userDoc + "\\EST\\file.png"); //デバッグ時に不要なリクエストを防ぐためにコメントアウトしてもよい
        }


        Bitmap canvas = new Bitmap(width, height);
        Graphics graphic;
        Pen p = new Pen(Color.Yellow, 3);

        private void setAreaTimer_Tick(object sender, EventArgs e)
        {
            graphic = Graphics.FromImage(canvas);
            graphic.Clear(Color.LawnGreen);

            if (GetAsyncKeyState(Keys.LButton) != 0)
            {
                if(!flgClick)
                {
                    capArea.setStartArea(Cursor.Position.X, Cursor.Position.Y);
                    flgClick = true;
                }
                else
                {
                    capArea.setEndArea(Cursor.Position.X, Cursor.Position.Y);
                    graphic.DrawRectangle(p, capArea.xs, capArea.ys, capArea.width, capArea.height);

                    areaSelectForm.selectArea_pBox.Image = canvas;
                }

                flgClickCount++;
            }
            else
            {
                flgClick = false;
                if(flgClickCount > 1)
                {
                    stopCaptionTimer();
                }

            }
        }

        public void stopCaptionTimer()
        {
            flgClick = false;
            setAreaTimer.Stop();

            flgClickCount = 0;
            setAreaButton.Text = "領域選択";
            setAreaButton.Enabled = true;

            LTposLabel.Text = string.Format("始点 [{0:d}, {1:d}]", capArea.xs, capArea.ys);
            RBposLabel.Text = string.Format("終点 [{0:d}, {1:d}]", capArea.xs + capArea.width, capArea.ys + capArea.height);

            areaSelectForm.Hide();
            this.WindowState = FormWindowState.Normal;
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

        private void 更新の確認ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://api.github.com/repos/penguin-syan/English_slide_translation/releases/latest";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.UserAgent = "EST";
            Stream stream = webRequest.GetResponse().GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);

            var objFromJson = JObject.Parse(streamReader.ReadToEnd());
            string versionInfo = (string)objFromJson["tag_name"];

            System.Diagnostics.FileVersionInfo fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (fileVersionInfo.FileVersion == versionInfo)
            {
                MessageBox.Show("実行中のソフトは最新版です．", "最新版", MessageBoxButtons.OK);
            }
            else
            {
                string text = "最新版のソフトが公開されています．\n最新版：" + versionInfo + "\n現行版：" + fileVersionInfo.FileVersion + "\n\n更新しますか？";
                DialogResult d_result = MessageBox.Show(text, "更新バージョンがあります", MessageBoxButtons.YesNo);
                if(d_result == DialogResult.Yes)
                {
                    string downloadURL = (string)objFromJson["assets"][0]["browser_download_url"];
                    string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\EST\\" + (string)objFromJson["assets"][0]["name"];

                    if (!System.IO.Directory.Exists(userDoc + "\\EST"))
                    {
                        Directory.CreateDirectory(userDoc + "\\EST");
                    }

                    System.Net.WebClient webClient = new System.Net.WebClient();
                    webClient.DownloadFile(downloadURL, @filepath);
                    webClient.Dispose();

                    Process.Start(filepath);
                    this.Close();
                }
            }
        }
    }
}
