﻿using System;

namespace DEV_2._1.Commands
{
    class RemoveCarCommand : ICommand
    {
        private CarShop Shop;
        private string SerialNumber;

        /// <summary>
        /// This command search the car by serial number and then remove it from warehouse
        /// </summary>
        public RemoveCarCommand(CarShop receiver, string serialNumber)
        {
            this.Shop = receiver;
            this.SerialNumber = serialNumber;
        }

        public void Execute()
        {         
            try
            {
                this.Shop.RemoveCarFromWarehouse(SerialNumber);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}