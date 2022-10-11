using System.Diagnostics;

namespace TextAccuracy
{
    public static class UserInput
    {
        private static readonly string EscapeChars;

        public static void ReadInput()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            while (true)
            {
                TimeSpan timePassed = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                string word = string.Empty;

                if (!EscapeChars.Contains(inputKey.KeyChar) && char.IsLetter(inputKey.KeyChar))
                {
                    Console.Write(inputKey.KeyChar);
                    word += inputKey.KeyChar;

                    if (inputKey.Key == ConsoleKey.Spacebar)
                    {

                    }

                }

                if (timePassed.TotalSeconds == 10)
                {
                    Console.WriteLine("You finished the challenge with 10% accuracy!");
                    break;
                }
            }
        }
    }
}
