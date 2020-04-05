using System;

namespace DEV_1._2
{
    /// <summary>
    /// This program read the number from console and then convert it in another required numeral system
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int inputNumber = 0, numeralSystemSize = 0;
            NumberConverter.InputFromConsole(ref inputNumber, ref numeralSystemSize);
            Console.WriteLine($"Answer: {NumberConverter.ConvertNumeralSystem(inputNumber, numeralSystemSize)}");
        }
    }
}