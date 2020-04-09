using System;

namespace DEV_2._1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string databaseXmlFileName = "WarehouseDatabase";
            CarShop myShop = CarShop.GetInstance(databaseXmlFileName);    
            CarShopCommandDefiner commandDefiner = new CarShopCommandDefiner(myShop);

            string commandName = string.Empty;
            Console.WriteLine("Hello! You can write \"help\" to check all commands or \"exit\" to exit the program.");

            while (true)
            {
                Console.Write("\nWrite command: ");
                commandName = Console.ReadLine();

                if (commandName == "exit")
                {
                    Console.WriteLine("Programm was completed by your command");
                    Environment.Exit(0);
                }
                else
                {
                    commandDefiner.DefineAndRunCommand(commandName);
                }
            }                
        }
    }
}