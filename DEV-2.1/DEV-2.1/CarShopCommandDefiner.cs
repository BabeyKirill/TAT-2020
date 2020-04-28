using System;

namespace DEV_2._1
{
    class CarShopCommandDefiner
    {
        private CarShop Receiver;

        /// <summary>
        /// This class can define inputed commands for Car shop
        /// </summary>
        public CarShopCommandDefiner(CarShop receiver)
        {
            this.Receiver = receiver;
        }

        /// <summary>
        /// This method define inputed command
        /// </summary>
        public ICommand DefineCommand(string commandName)
        {
            ICommand command;

            if (commandName == "add car")
            {
                command = new AddCarCommand(this.Receiver);                
            }
            else if (commandName.IndexOf("remove car") == 0)
            {
                command = SetRemoveCarCommand(commandName);
            }
            else if (commandName == "count types")
            {
                command = new CountTypesCommand(this.Receiver);
            }
            else if (commandName == "count all")
            {
                command = new CountAllCommand(this.Receiver);
            }
            else if (commandName == "average price")
            {
                command = new AveragePriceCommand(this.Receiver);
            }
            else if (commandName.IndexOf("average price type") == 0)
            {
                command = SetAveragePriceTypeCommand(commandName);
            }
            else
            {
                throw new ArgumentException("Unknown command");
            }

            return command;
        }

        private ICommand SetRemoveCarCommand(string commandName)
        {
            if (commandName.Length > ("remove car ").Length)
            {
                string serialNumber = commandName.Substring("remove car ".Length);
                return new RemoveCarCommand(this.Receiver, serialNumber);
            }
            else
            {
                throw new ArgumentException("command parameter is not set");
            }
        }

        private ICommand SetAveragePriceTypeCommand(string commandName)
        {
            if (commandName.Length > ("average price type ").Length)
            {
                string brandName = commandName.Substring("average price type ".Length);
                return new AveragePriceTypeCommand(this.Receiver, brandName);
            }
            else
            {
                throw new ArgumentException("command parameter is not set");
            }
        }
    }
}