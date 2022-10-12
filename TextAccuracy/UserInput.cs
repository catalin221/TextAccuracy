using System.Diagnostics;

namespace TextAccuracy
{
    public static class UserInput
    {
        public static void ReadInput()
        {
            Stopwatch stopwatch = new();

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.WriteLine(GenerateText.RandomText());
                stopwatch.Start(); // We start the timer here so the player won't be affected by the text generation
            }


            while (stopwatch.Elapsed.TotalSeconds <= 5)
            {
                char inputKey = Console.ReadKey(true).KeyChar;
                string word = string.Empty;
                int spaces = 0;

                if (char.IsLetter(inputKey))
                {
                    Console.Write(inputKey);
                    word += inputKey;
                }
                else if (char.IsWhiteSpace(inputKey) && spaces <= 1)
                {
                    Console.Write(inputKey);
                }

                if(stopwatch.Elapsed.TotalSeconds >= 5)
                {
                    break;
                }
            }

            TerminateProgram(stopwatch);
        }

        private static void TerminateProgram(Stopwatch stopwatch)
        {
            stopwatch.Stop();
            Console.WriteLine("You finished the challenge with 10% accuracy! Press the Esc key to terminate the program");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
