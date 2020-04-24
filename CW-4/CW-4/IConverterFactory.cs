namespace CW_4
{
    interface IConverterFactory
    {
        IConverter CreateDistanceConverter();
        IConverter CreateTemperatureConverter();
    }
}