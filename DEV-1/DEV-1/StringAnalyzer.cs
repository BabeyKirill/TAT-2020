namespace DEV_1
{
    /// <summary>
    /// A class that contains methods for string analysis
    /// </summary>
    class StringAnalyzer
    {
        /// <summary>
        /// Returns the maximum number of repeated consecutive characters in the string
        /// </summary>
        /// <param name="theString">considered string</param>
        public int ToCountSameCharacters(string theString)
        {
            if (theString.Length <= 1)
                throw new System.ArgumentException("parameter 'theString' length must not be less than two characters");

            int count = 1;
            int maxCount = 0;

            for (int i = 1; i < theString.Length; i++)
            {
                if (theString[i - 1] == theString[i])
                {
                    count++;

                    if (maxCount < count)
                        maxCount = count;
                }
                else
                    count = 1;
            }

            return maxCount;
        }
    }
}
