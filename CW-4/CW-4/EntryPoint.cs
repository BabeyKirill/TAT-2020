using System;
using System.Collections.Generic;

namespace CW_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IConverterFactory factory = new ConverterFactory();
            IConverter converter;
            List<double> answers = new List<double>();
            double value;

            if (args.Length < 2)
            {
                throw new ArgumentException();
            }

            for (int i = 1; i < args.Length; i += 2)
            {
                if (Double.TryParse(args[i - 1], out value) == false)
                {
                    throw new ArgumentException();
                }

                if (args[i] == "CF" || args[i] == "FC")
                {
                    converter = factory.CreateTemperatureConverter();
                    answers.Add(converter.Convert(value, args[i]));
                }
                else if (args[i] == "MF" || args[i] == "FM")
                {
                    converter = factory.CreateDistanceConverter();
                    answers.Add(converter.Convert(value, args[i]));
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            foreach(double answer in answers)
            {
                Console.WriteLine($"{answer}  ");
            }
        }
    }
}