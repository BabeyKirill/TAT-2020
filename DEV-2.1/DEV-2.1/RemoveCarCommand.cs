namespace DEV_2._1
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
            Shop.RemoveCarFromWarehouse(SerialNumber);
        }
    }
}