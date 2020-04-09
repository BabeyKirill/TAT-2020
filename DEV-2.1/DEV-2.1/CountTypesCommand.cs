﻿using System;

namespace DEV_2._1
{    
    class CountTypesCommand : ICommand   
    {
        private readonly CarShop Shop;

        /// <summary>
        /// This command prints in console the number of brands of cars in warehouse
        /// </summary>
        public CountTypesCommand(CarShop receiver)
        {
            this.Shop = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"Conut of brands is {this.Shop.GetCountTypes()}");
        }
    }
}