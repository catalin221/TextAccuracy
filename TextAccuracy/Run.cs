namespace TextAccuracy
{
    public static class Run
    {
        public static void Run()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine(@"Welcome to the challenge! You have 60 seconds to finish it from the beginning of the first key press, " +
                              "at the end you will receive the accuracy, additionally each run will be saved in a .txt file on your Desktop containing the accuracy");

            bool run = true;
            while (run)
            {
                GenerateText.RandomText();

            }


            SaveResult.SaveToFile(desktopPath, percentage, tryCount);
        }
    }
}
