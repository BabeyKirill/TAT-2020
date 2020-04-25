using System;

namespace CW_4
{
    class TemperatureConverter : IConverter
    {
        const double CelsiumToFahrenheitCoefficient = 1.8;
        const double FahrenheitToCelsiumCoefficient = 0.555555;
        const int CelsiumToFahrenheitIncrease = 32;

        public double Convert(double input, string direction)
        {
            if (direction == "CF")
            {
                return ConvertCtoF(input);
            }
            else if (direction == "FC")
            {
                return ConvertFtoC(input);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Converts Celsium value to Fahrenheit
        /// </summary>
        public double ConvertCtoF(double inputCelsium)
        {
            return inputCelsium * CelsiumToFahrenheitCoefficient + CelsiumToFahrenheitIncrease;
        }

        /// <summary>
        /// Converts Fahrenheit value to Celsium
        /// </summary>
        public double ConvertFtoC(double inputFahrenheit)
        {
            return (inputFahrenheit - CelsiumToFahrenheitIncrease) * FahrenheitToCelsiumCoefficient;
        }
    }
}