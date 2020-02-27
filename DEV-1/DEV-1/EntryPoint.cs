using System;

namespace DEV_1
{
    /// <summary>
    /// This programm count the maximum number of repeated consecutive characters in a string
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string theString;
            Console.WriteLine("Enter the string: ");

            while (true)
            {
                theString = Console.ReadLine();

                if (theString.Length <= 1)
                {
                    Console.WriteLine("The minimum line length is 2 characters. Try again: ");
                    continue;
                }

                break;
            }

            StringAnalyzer analyzer = new StringAnalyzer();
            Console.WriteLine(analyzer.ToCountSameCharacters(theString));
        }
    }
}
