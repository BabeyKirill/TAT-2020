using System;

namespace DEV_2._1
{
    class CarShopCommandDefiner
    {
        private Invoker _invoker;
        private CarShop _receiver;

        /// <summary>
        /// This class can define inputed commands for Car shop and execute them
        /// </summary>
        public CarShopCommandDefiner(CarShop receiver)
        {
            this._invoker = new Invoker();
            this._receiver = receiver;
        }

        /// <summary>
        /// This method define inputed command and execute it
        /// </summary>
        public void DefineAndRunCommand(string commandName)
        {
            if (commandName == "add car")
            {
                AddCar();
            }
            else if (commandName.IndexOf("remove car") == 0)
            {
                RemoveCar(commandName);
            }
            else if (commandName == "count types")
            {
                CountTypes();
            }
            else if (commandName == "count all")
            {
                CountAll();
            }
            else if (commandName == "average price")
            {
                AveragePrice();
            }
            else if (commandName.IndexOf("average price type") == 0)
            {
                AveragePriceType(commandName);
            }
            else if (commandName == "help")
            {
                Help();
            }
            else
            {
                Console.WriteLine("Unknown Command");
            }
        }

        private void AddCar()
        {
            ICommand command = new AddCarCommand(_receiver);
            _invoker.SetCommand(command);
            _invoker.ExecuteCommand();
        }

        private void RemoveCar(string commandName)
        {
            if (commandName.Length > ("remove car ").Length)
            {
                string serialNumber = commandName.Substring("remove car ".Length);
                ICommand command = new RemoveCarCommand(_receiver, serialNumber);
                _invoker.SetCommand(command);
                _invoker.ExecuteCommand();
            }
            else
            {
                Console.WriteLine("You should input serial number of removing car");
            }
        }

        private void CountTypes()
        {
            ICommand command = new CountTypesCommand(_receiver);
            _invoker.SetCommand(command);
            _invoker.ExecuteCommand();
        }

        private void CountAll()
        {
            ICommand command = new CountAllCommand(_receiver);
            _invoker.SetCommand(command);
            _invoker.ExecuteCommand();
        }

        private void AveragePrice()
        {
            ICommand command = new AveragePriceCommand(_receiver);
            _invoker.SetCommand(command);
            _invoker.ExecuteCommand();
        }

        private void AveragePriceType(string commandName)
        {
            if (commandName.Length > ("average price type ").Length)
            {
                string brandName = commandName.Substring("average price type ".Length);
                ICommand command = new AveragePriceTypeCommand(_receiver, brandName);
                _invoker.SetCommand(command);
                _invoker.ExecuteCommand();
            }
            else
            {
                Console.WriteLine("You should set required brand");
            }
        }

        private void Help()
        {
            Console.WriteLine("Possible commands: add car; remove car (serial number); ");
            Console.WriteLine("count types; count all; average price; average price type (brand);");
        }
    }
}