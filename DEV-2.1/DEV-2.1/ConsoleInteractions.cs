using System;

namespace DEV_2._1
{
    public class ConsoleInteractions
    {
        /// <summary>
        /// Creation of the SerializableCar object using Console
        /// </summary>
        public static SerializableCar CreateCar()
        {
            Console.Write("Input serial number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Input brand Id: ");
            string brandId = Console.ReadLine();
            Console.Write("Input model Id: ");
            string modelId = Console.ReadLine();
            Console.Write("Set price: ");
            Double.TryParse(Console.ReadLine(), out double price);

            return new SerializableCar(serialNumber, brandId, modelId, price);
        }
    }
}