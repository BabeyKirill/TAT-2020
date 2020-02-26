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
            string str;
            Console.WriteLine("Enter the string: ");

            while (true)
            {
                str = Console.ReadLine();
                if (str == string.Empty)
                {
                    Console.WriteLine("The string should not be empty. Try again: ");
                    continue;
                }
                break;
            }

            StringAnalyzer analyzer = new StringAnalyzer();
            Console.WriteLine(analyzer.ToCountSameCharacters(str));
        }
    }
}
