namespace TextAccuracy
{
    public static class SaveResult
    {
        public static void SaveToFile(string path, int percentage, int tryCount)
        {
            string fullPath = path + "Results.txt";

            try
            {
                File.AppendAllText(fullPath, String.Format("You have scored {0} on try {1}", percentage.ToString(), tryCount));
            }
            catch(Exception ex)
            {
                if (ex is ArgumentNullException || ex is DirectoryNotFoundException)
                {
                    Console.WriteLine("The given path {0} does not exist!", path);
                }
                else if (ex is PathTooLongException)
                {
                    Console.WriteLine("The given path has too many characters!");
                }
                else if (ex is UnauthorizedAccessException)
                {
                    Console.WriteLine("The given path is inaccessible due to the location protection level");
                }
            }
        }
    }
}
