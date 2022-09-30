using System.Diagnostics;

namespace TextAccuracy
{
    public static class UserInput
    {
        public static void ReadInput()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (true)
            {
                TimeSpan timePassed = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                Console.ReadKey

                if(timePassed.TotalSeconds == 10)
                {
                    Console.WriteLine("You finished the challenge with 10% accuracy!");
                    break;
                }
            }
        }
    }
}
