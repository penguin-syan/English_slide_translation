using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EST_window
{

    public class TextBlocks
    {
        public int x, y, width, height;
        string text;

        public void setBlockLocation(int x0, int y0, int x1, int y1)
        {
            this.x = x0;
            this.y = y0;
            this.width = x1 - x0;
            this.height = y1 - y0;
        }

        public void setBlockText(string text)
        {
            this.text = text;
        }

        public string getBlockText()
        {
            return this.text;
        }

        public string getBlockLocation()
        {
            return $"({this.x}, {this.y}, {this.width}, {this.height})";
        }
    }


    public class AreaLabel : Label
    {
        public AreaLabel(TextBlocks textBlocks)
        {
            double widthScale = (double)Program.appForm.pictureBox1.Size.Width / Program.appForm.pictureBox1.Image.Width;
            double heightScale = (double)Program.appForm.pictureBox1.Size.Height / Program.appForm.pictureBox1.Image.Height;
            double scale = (widthScale < heightScale) ? widthScale : heightScale;
            Console.WriteLine("image scale: ({0}, {1}, {2})", widthScale, heightScale, scale);
            Console.WriteLine("image size: ({0}, {1})", Program.appForm.pictureBox1.Image.Width, Program.appForm.pictureBox1.Image.Height);

            //AppForm内の要素にアクセスするため，AppFormと同一のスレッドで実行
            Program.appForm.Invoke((Action)(() =>
            {
                this.AutoSize = false;
                this.Size = new System.Drawing.Size((int)(textBlocks.width * scale), (int)(textBlocks.height* scale));
                this.Parent = Program.appForm.pictureBox1;
                this.Location = new System.Drawing.Point((int)(textBlocks.x * scale), (int)(textBlocks.y * scale));
                this.BackColor = System.Drawing.Color.Red;
                Program.appForm.pictureBox1.Controls.Add(this);
                this.Text = textBlocks.getBlockText();
            }));
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Program.appForm.sourceTextBox.Text = this.Text;
            if (Program.appForm.autoTranslateWhenClickLabel.Checked)
                Program.appForm.translateButton.PerformClick();
        }
    }
}
