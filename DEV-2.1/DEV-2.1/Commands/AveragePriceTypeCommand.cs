﻿using System;

namespace DEV_2._1.Commands
{
    class AveragePriceTypeCommand : ICommand
    {
        private CarShop Shop;
        private string BrandName;

        /// <summary>
        /// This command prints in console the average price of cars of concrete brand which are in warehouse
        /// </summary>
        public AveragePriceTypeCommand(CarShop receiver, string brandName)
        {
            this.Shop = receiver;
            this.BrandName = brandName;
        }

        public void Execute()
        {
            Console.WriteLine($"Average price of all cars of this brand is {this.Shop.GetAveragePriceType(this.BrandName)}");
        }
    }
}