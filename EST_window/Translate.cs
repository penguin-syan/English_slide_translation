using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DeepL;

namespace EST_window
{
    public class Translate
    {
        public static async Task<string> translateWithDeepL(string sourceText)
        {
            var authKey = ConfigurationManager.AppSettings["DeepL_key"];
            Translator translator;

            try
            {
                translator = new Translator(authKey);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("DeepL APIを使用するためのAPI keyが設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            string sourceLang = setTranslateLangage(ConfigurationManager.AppSettings["sourceLang"]);
            string targetLang = setTranslateLangage(ConfigurationManager.AppSettings["targetLang"]);

            var resultText = await translator.TranslateTextAsync(
                sourceText,
                sourceLang,
                targetLang);

            return resultText.ToString();

        }

        protected static string setTranslateLangage(string setting)
        {
            switch (setting)
            {
                case "日本語":
                    return LanguageCode.Japanese;
                case "英語":
                    return LanguageCode.English;
                default:
                    return null;
            }
        }
    }
}
