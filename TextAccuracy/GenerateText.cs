using System.Net;
using System.Linq;

namespace TextAccuracy
{
    public static class GenerateText
    {
        public static string RandomText()
        {
            var client = new WebClient();
            string text = "";
            string downloadedString = client.DownloadString("https://random-word-api.herokuapp.com/word?number=30");
            string[] split = downloadedString.Split(new[] {',', '[', ']', '"'});

            foreach (string word in split)
            {
                text += word + ' ';
            }
            text = text.Trim();
            text = text.

            return text;
        }
    }
}
