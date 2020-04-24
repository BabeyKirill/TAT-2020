using System;

namespace CW_4
{
    class DistanceConverter : IConverter
    {
        const double FeetsInOneMeter = 3.28084;

        public double Convert(double input, string direction)
        {
            if (direction == "MF")
            {
                return ConvertMtoF(input);
            }
            else if (direction == "FM")
            {
                return ConvertFtoM(input);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Converts Metres value to Feets
        /// </summary>
        public double ConvertMtoF(double inputMetres)
        {
            return inputMetres * FeetsInOneMeter;
        }

        /// <summary>
        /// Converts Feets value to Metres
        /// </summary>
        public double ConvertFtoM(double inputFeets)
        {
            return inputFeets / FeetsInOneMeter;
        }
    }
}
