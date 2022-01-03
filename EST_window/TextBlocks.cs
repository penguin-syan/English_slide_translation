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
        string sourceText, targetText;

        public void setBlockLocation(int x0, int y0, int x1, int y1)
        {
            this.x = x0;
            this.y = y0;
            this.width = x1 - x0;
            this.height = y1 - y0;
        }

        public string getBlockLocation()
        {
            return $"({this.x}, {this.y}, {this.width}, {this.height})";
        }

        public void setBlockText(string text)
        {
            this.text = text;
        }

        public string getBlockText()
        {
            return this.text;
        }

        public void setSourceText(string text)
        {
            this.sourceText = text;
        }

        public string getSourceText()
        {
            return this.sourceText;
        }

        public void setTargetText(string text)
        {
            this.targetText = text;
        }

        public string getTargetText()
        {
            return this.targetText;
        }

        public string outputText()
        {
            if (targetText == null)
                return sourceText;
            else
                return targetText;
        }
    }


    public class AreaLabel : Label
    {
        static int widthDiff, heightDiff;
        static double widthScale, heightScale, scale;
        int indexNum;
        string sourceTest, targetText;

        public static void setStaticVar()
        {
            widthScale = (double)Program.appForm.pictureBox1.Size.Width / Program.appForm.pictureBox1.Image.Width;
            heightScale = (double)Program.appForm.pictureBox1.Size.Height / Program.appForm.pictureBox1.Image.Height;
            scale = (widthScale < heightScale) ? widthScale : heightScale;
            widthDiff = (Program.appForm.pictureBox1.Size.Width - (int)(Program.appForm.pictureBox1.Image.Width * scale)) / 2;
            heightDiff = (Program.appForm.pictureBox1.Size.Height - (int)(Program.appForm.pictureBox1.Image.Height * scale)) / 2;
        }


        public AreaLabel(TextBlocks textBlocks, int indexNum)
        {
            this.indexNum = indexNum;
            this.sourceTest = textBlocks.getSourceText();
            this.targetText = textBlocks.getTargetText();
            //AppForm内の要素にアクセスするため，AppFormと同一のスレッドで実行
            Program.appForm.Invoke((Action)(() =>
            {
                this.AutoSize = false;
                this.Size = new System.Drawing.Size((int)(textBlocks.width * scale), (int)(textBlocks.height* scale));
                this.Parent = Program.appForm.pictureBox1;
                this.Location = new System.Drawing.Point((int)(textBlocks.x * scale) + widthDiff, (int)(textBlocks.y * scale) + heightDiff);
                this.BackColor = System.Drawing.Color.Red;
                Program.appForm.pictureBox1.Controls.Add(this);
                this.Text = textBlocks.getBlockText();
            }));
        }


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Program.appForm.sourceTextBox.Text = this.sourceTest;
            if(targetText != null)
                Program.appForm.translatedTextBox.Text = this.targetText;
            if (Program.appForm.autoTranslateWhenClickLabel.Checked && this.targetText == null)
                Program.appForm.translateButton.PerformClick();
        }
    }
}
