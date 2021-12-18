using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

using Google.Cloud.Vision.V1;


namespace EST_window
{
    class GCP_Vision
    {
        public static void detect_dtext(string imageFilepass)
        {
            ImageAnnotatorClientBuilder ia_client_builder = new ImageAnnotatorClientBuilder
            {
                CredentialsPath = ConfigurationManager.AppSettings["GC_key"]
        };
            ImageAnnotatorClient ia_client = null;
            try
            {
                ia_client = ia_client_builder.Build();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Google Cloudに接続するためのkeyファイルが設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Image img = Image.FromFile(imageFilepass);

            TextAnnotation text = ia_client.DetectDocumentText(img);

            if (!(text == null))
            {
                var page = text.Pages[0];
                TextBlocks[] textBlocks = new TextBlocks[page.Blocks.LongCount()];
                for(int i = 0; i < page.Blocks.LongCount(); i++)
                    textBlocks[i] = new TextBlocks();

                for(int i = 0; i < page.Blocks.LongCount(); i++)
                {
                    var block = page.Blocks[i];

                    textBlocks[i].setBlockLocation(
                        block.BoundingBox.Vertices[0].X,
                        block.BoundingBox.Vertices[0].Y,
                        block.BoundingBox.Vertices[2].X,
                        block.BoundingBox.Vertices[2].Y);

                    foreach (var paragraph in block.Paragraphs)
                    {
                        string str = "";
                        foreach (var word in paragraph.Words)
                            str += string.Join("", word.Symbols.Select(s => s.Text)) + " ";

                        textBlocks[i].setBlockText(str);
                    }
                }


                AreaLabel[] label = new AreaLabel[textBlocks.Length];
                for(int i = 0; i < textBlocks.Length; i++)
                {
                    TextBlocks tblock = textBlocks[i];
                    label[i] = new AreaLabel(tblock);

                    Console.Write(tblock.getBlockLocation() + " ");
                    Console.WriteLine(tblock.getBlockText());
                }
            }
            else
            {
                MessageBox.Show("文字列が検出されませんでした","エラー" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


    class TextBlocks{
        public int x, y, width, height;
        string text;

        public void setBlockLocation(int x0, int y0, int x1, int y1)
        {
            this.x = x0;
            this.y = y0;
            this.width = x1 - x0;
            this.height = y1 - y0;

            Console.WriteLine($"{x0}, {y0}, {x1}, {y1}");
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

    class AreaLabel : Label
    {
        public AreaLabel(TextBlocks textBlocks)
        {
            double widthScale = (double)Program.appForm.pictureBox1.Size.Width / Program.appForm.rectangle.Width;
            double heightScale = (double)Program.appForm.pictureBox1.Size.Height / Program.appForm.rectangle.Height;

            this.AutoSize = false;
            this.Size = new System.Drawing.Size(textBlocks.width, textBlocks.height);
            this.Parent = Program.appForm.pictureBox1;
            this.Location = new System.Drawing.Point((int)(textBlocks.x * widthScale), (int)(textBlocks.y * heightScale));
            Program.appForm.pictureBox1.Controls.Add(this);

            this.Text = textBlocks.getBlockText();
        }
    }
}
