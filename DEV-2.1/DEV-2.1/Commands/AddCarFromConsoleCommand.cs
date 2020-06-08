using System;

namespace DEV_2._1.Commands
{
    class AddCarFromConsoleCommand : ICommand
    {
        private CarShop Shop;
        private SerializableCar NewCar;

        /// <summary>
        /// This Command add a car in warehouse
        /// </summary>
        public AddCarFromConsoleCommand(CarShop receiver, SerializableCar newCar)
        {
            this.Shop = receiver;
            if (newCar != null)
            {
                this.NewCar = newCar;
            }
            else
            {
                throw new ArgumentException("Attempt to add a car that is null");
            }
        }

        public void Execute()
        {
            
            this.Shop.AddCarToWarehouse(NewCar);
        }
    }
}