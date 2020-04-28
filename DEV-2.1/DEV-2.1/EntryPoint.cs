using System;

namespace DEV_2._1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string carsXmlFileName = "Cars";
            string brandsXmlFileName = "Brands";
            CarShop myShop = CarShop.GetInstance(carsXmlFileName, brandsXmlFileName);    
            CarShopCommandDefiner commandDefiner = new CarShopCommandDefiner(myShop);
            Invoker invoker = new Invoker();

            string commandName = string.Empty;
            Console.WriteLine("Hello! You can write \"help\" to check all commands or \"exit\" to exit the program.");

            while (true)
            {
                Console.Write("\nWrite command: ");
                commandName = Console.ReadLine();

                if (commandName == "exit")
                {
                    Console.WriteLine("Programm was completed by your command");
                    break;
                }
                else if(commandName == "help")
                {
                    Console.WriteLine("Command list: add car; remove car <serial number>; count all;");
                    Console.WriteLine("count types; average price type <brand name>; average price; exit");
                }
                else
                {
                    try
                    {
                        ICommand command = commandDefiner.DefineCommand(commandName);
                        invoker.SetCommand(command);
                        invoker.ExecuteCommand();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            } 
        }
    }
}