using System;
using System.Linq;
using System.Text;

namespace DEV_1._2
{
    /// <summary>
    /// A class that contains methods for converting numbers
    /// </summary>
    public class NumberConverter
    {
        public const int minimumSystemSize = 2;
        public const int maximumSystemSize = 20;

        /// <summary>
        /// Converts a number from 10-x numeral system to specified numeral system
        /// </summary>
        /// <param name="inputNumber">Number which will be converted</param>
        /// <param name="numeralSystemSize">Numeral system in which the number will be converted</param>
        public static string ConvertNumeralSystem(int inputNumber, int numeralSystemSize)
        {
            int NumberForCalculations = inputNumber;

            if (numeralSystemSize < minimumSystemSize || numeralSystemSize > maximumSystemSize)
            {
                throw new ArgumentOutOfRangeException();
            }

            StringBuilder convertedNumber = new StringBuilder();
            string possibleSymbols = "0123456789ABCDEFGHIJ";

            do
            {
                convertedNumber.Append(possibleSymbols[Math.Abs(NumberForCalculations % numeralSystemSize)]);
                NumberForCalculations = NumberForCalculations - NumberForCalculations % numeralSystemSize;
                NumberForCalculations = NumberForCalculations / numeralSystemSize;
            }
            while (NumberForCalculations != 0);

            if (inputNumber < 0)
            {
                convertedNumber.Append('-');
            }

            //this construct converts StringBuilder to string and then reverses it
            return new string(convertedNumber.ToString().ToCharArray().Reverse().ToArray());
        }

        /// <summary>
        /// Sets numbers from the console
        /// </summary>
        /// <param name="inputNumber">Number for converting</param>
        /// <param name="numeralSystemSize">Numeral system in which the number will be converted</param>
        public static void InputFromConsole(ref int inputNumber, ref int numeralSystemSize)
        {
            Console.WriteLine("Input number for converting: ");
            string inputString = Console.ReadLine();

            while (int.TryParse(inputString, out inputNumber) == false || inputString[0] == '0')
            {
                Console.WriteLine("Input number must contains only numbers and must not starts from zero, try again: ");
                inputString = Console.ReadLine();
            }

            Console.WriteLine($"Input required numeral system size from {minimumSystemSize} to {maximumSystemSize}: ");
            inputString = Console.ReadLine();

            while (int.TryParse(inputString, out numeralSystemSize) == false || inputString[0] == '0' ||
                int.Parse(inputString) < minimumSystemSize ||
                int.Parse(inputString) > maximumSystemSize)
            {
                Console.WriteLine($"You must enter only a number from {minimumSystemSize} to {maximumSystemSize}, try again: ");
                inputString = Console.ReadLine();
            }
        }
    }
}