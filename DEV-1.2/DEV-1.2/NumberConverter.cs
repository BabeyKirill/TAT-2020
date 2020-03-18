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
        /// <summary>
        /// Converts a number from 10-x numeral system to any other from 2-x to 20-x
        /// </summary>
        /// <param name="inputNumber">Number which will be converted</param>
        /// <param name="numeralSystemSize">Numeral system in which the number will be converted</param>
        public static string ConvertNumeralSystem(int inputNumber, int numeralSystemSize)
        {           
            if (numeralSystemSize < 2 || numeralSystemSize > 20)
            {
                throw new ArgumentOutOfRangeException();
            }

            StringBuilder convertedNumber = new StringBuilder();
            string possibleSymbols = "0123456789ABCDEFGHIJ";
            bool isBelowZero = false;

            if (inputNumber < 0)
            {
                isBelowZero = true;
            }

            do
            {
                convertedNumber.Append(possibleSymbols[Math.Abs(inputNumber % numeralSystemSize)]);
                inputNumber = inputNumber - inputNumber % numeralSystemSize;
                inputNumber = inputNumber / numeralSystemSize;
            }
            while (inputNumber != 0);

            if(isBelowZero == true)
            {
                convertedNumber.Append('-');
            }

            //this construct converts StringBuilder to string and then reverses it
            return new string(convertedNumber.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}