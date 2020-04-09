using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2._1
{
    class AddCarCommand : ICommand
    {
        private CarShop Shop;

        /// <summary>
        /// This Command asks to set a car and then add it in warehouse
        /// </summary>
        public AddCarCommand(CarShop receiver)
        {
            this.Shop = receiver;
        }

        public void Execute()
        {
            Console.Write("Input brand name: ");
            string brandName = Console.ReadLine();
            Console.Write("Input model: ");
            string model = Console.ReadLine();
            Console.Write("Input serial number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Set price: ");
            Double.TryParse(Console.ReadLine(), out double price);
            this.Shop.AddCarToWarehouse(new Car(brandName, model, serialNumber, price));
        }
    }
}