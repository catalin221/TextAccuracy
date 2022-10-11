using System.Net;
using System.Linq;

namespace TextAccuracy
{
    public static class GenerateText
    {
        public static string RandomText()
        {
            var client = new HttpClient();
            string text = "";
            string downloadedString = client.GetStringAsync("https://random-word-api.herokuapp.com/word?number=30").Result.ToString();
            string[] split = downloadedString.Split(new[] {',', '[', ']', '"'});  // Get rid of the unnecessary characters from the response

            foreach (string word in split)
            {
                text += word + ' ';
            }

            text = text.Trim();

            return text;
        }
    }
}
