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
                Console.WriteLine($"Text: {text.Text}");
                foreach(var page in text.Pages)
                {
                    foreach(var block in page.Blocks)
                    {
                        //string box = string.Join(" - ", block.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
                        //Console.WriteLine($"Block {block.BlockType} at {box}");
                        foreach (var paragraph in block.Paragraphs)
                        {
                            //box = string.Join(" - ", paragraph.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
                            //Console.WriteLine($"  Paragraph at {box}");
                            string str = "";
                            foreach (var word in paragraph.Words)
                            {
                                str += string.Join("", word.Symbols.Select(s => s.Text)) + " ";
                            }
                            Console.WriteLine(str);
                        }
                    }
                }
            }
        }
    }
}
