namespace DEV_1
{
    /// <summary>
    /// A class that contains methods for string analysis
    /// </summary>
    class StringAnalyzer
    {
        /// <summary>
        /// Returns the maximum number of repeated consecutive characters in a string
        /// </summary>
        /// <param name="str">considered string</param>
        public int ToCountSameCharacters(string str)
        {
            if (str.Length == 0)
                return 0;

            if (str.Length == 1)
                return 1;

            int count = 1;
            int maxCount = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i-1] == str[i])
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
