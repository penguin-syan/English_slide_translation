using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Vision.V1;


namespace EST_window
{
    class GCP_Vision
    {
        public static void detect_dtext(string imageFilepass)
        {
            ImageAnnotatorClient ia_client = ImageAnnotatorClient.Create();
            ProductSearchClient ps_client = ProductSearchClient.Create();
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
