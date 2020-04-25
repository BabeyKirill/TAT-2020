namespace CW_4
{
    class ConverterFactory : IConverterFactory
    {
        public IConverter CreateTemperatureConverter()
        {
            return new TemperatureConverter();
        }

        public IConverter CreateDistanceConverter()
        {
            return new DistanceConverter();
        }
    }
}
