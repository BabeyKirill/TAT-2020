using System;

namespace DEV_2._1.Commands
{
    class CountAllCommand : ICommand
    {
        private CarShop Shop;

        /// <summary>
        /// This command prints in console the number of all cars in warehouse
        /// </summary>
        public CountAllCommand(CarShop receiver)
        {
            this.Shop = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"Conut of all cars is {this.Shop.GetCountAll()}");
        }
    }
}