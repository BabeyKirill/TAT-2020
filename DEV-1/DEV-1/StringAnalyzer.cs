using System;

namespace DEV_1
{
    /// <summary>
    /// A class that contains methods for string analysis
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// Returns the maximum number of Sequentially different characters in the string
        /// </summary>
        /// <param name="inputString">considered string</param>
        public static int SequentiallyDifferentСount(string inputString)
        {
            if (inputString == null || inputString == string.Empty)
            {
                throw new NullReferenceException();
            }

            int count = 1;
            int maxCount = 1;

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i - 1] != inputString[i])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            return maxCount;
        }
    }
}