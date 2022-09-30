namespace TextAccuracy
{
    public static class ValidateInput
    {
        private static void CheckExceptions(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("Cannot process null values");
            }
            if (word.Length == 0 || word.Length > 256)
            {
                throw new ArgumentOutOfRangeException("The word has either zero length or is too big");
            }
        }

        
        /* Probably too complicated for a typeracer type of game and would make it way too easier for the player to score points, will probably review at some point */

        //private static bool TwoTwisted(string inputWord, string givenWord) 
        //{
        //    if(inputWord.Length == givenWord.Length)
        //    {
        //        return false;
        //    }    

        //    int twisted = 0;
        //    for (int i = 0; i < inputWord.Length; i++)
        //    {
        //        if ((inputWord[i] != givenWord[i]) && (inputWord[i] == givenWord[i+1]))
        //        {
        //            twisted++;
        //        }
        //    }    

        //    return twisted == 1 && inputWord[inputWord.Length - 1] == givenWord[givenWord.Length - 1];
        //}

        /* Same as above
        private static bool OneMissing(string inputWord, string givenWord)
        {
            return inputWord.Length == givenWord.Length - 1 && givenWord.Contains(inputWord);
        }*/

        private static bool OneOff(string inputWord, string givenWord)
        {
            if (givenWord.Length != inputWord.Length)
            {
                return false;
            }

            int offCount = 0;
            for (int i = 0; i <= inputWord.Length; i++)
            {
                if (inputWord[i] != givenWord[i])
                {
                    offCount++;
                }
            }

            return offCount == 1;
        }
    }
}
