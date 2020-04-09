using System;

namespace DEV_2._1
{
    class AveragePriceCommand : ICommand
    {
        private CarShop Shop;

        /// <summary>
        /// This Command prints in console the average price of all cars in warehouse
        /// </summary>
        public AveragePriceCommand(CarShop receiver)
        {
            this.Shop = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"Average price of all cars {this.Shop.GetAveragePrice()}");
        }
    }
}