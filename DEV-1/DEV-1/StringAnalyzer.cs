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
        /// <param name="inputString">considered string</param>
        public int ToCountSameCharacters(string inputString)
        {
            if (inputString.Length <= 1)
                throw new System.ArgumentException("parameter 'inputString' length must not be less than two characters");

            int count = 1;
            int maxCount = 0;

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i - 1] == inputString[i])
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