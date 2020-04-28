using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DEV_2._1
{
    class CarShop
    {
        private static CarShop Instance;
        //private XDocument CarDatabase;
        //private XDocument BrandsDatabase;
        private List<SerializableCar> CarDatabase;
        private List<SerializableBrand> BrandDatabase;
        private string CarsXmlFileName;
        private string BrandsXmlFileName;

        protected CarShop(string carsXmlFileName, string brandsXmlFileName)
        {
            this.CarsXmlFileName = carsXmlFileName;
            this.BrandsXmlFileName = brandsXmlFileName;

            if (File.Exists($"../../{CarsXmlFileName}.xml") == false || File.Exists($"../../{BrandsXmlFileName}.xml") == false)
            {
                throw new FileNotFoundException();
            }

            object objectForDeserializingCars = new List<SerializableCar>();        
            DatabaseManager.XmlDeserialize(ref objectForDeserializingCars, this.CarsXmlFileName);
            CarDatabase = (List<SerializableCar>)objectForDeserializingCars;

            object objectForDeserializingBrands = new List<SerializableBrand>();
            DatabaseManager.XmlDeserialize(ref objectForDeserializingBrands, this.BrandsXmlFileName);
            BrandDatabase = (List<SerializableBrand>)objectForDeserializingBrands;

            //this.CarDatabase = XDocument.Load($"../../{CarsXmlFileName}.xml");
            //this.BrandsDatabase = XDocument.Load($"../../Brands.xml");
        }

        /// <summary>
        /// SingleTone pattern, only one object of class can exist
        /// </summary>
        public static CarShop GetInstance(string carsXmlFileName, string brandsXmlFileName)
        {
            if (Instance == null)
                Instance = new CarShop(carsXmlFileName, brandsXmlFileName);

            return Instance;
        }


        /// <summary>
        /// Add the car to Car database
        /// </summary>
        public void AddCarToWarehouse(SerializableCar car)
        {
            if (CarDatabase.Contains(car) == false)
            {
                CarDatabase.Add(car);
                UpdateXmlDatabase(CarDatabase, CarsXmlFileName);
            }
            else
            {
                throw new ArgumentException("this car already exists in database");
            }
        }

        /// <summary>
        /// Search the car by serial number and then remove it from Car database
        /// </summary>
        public void RemoveCarFromWarehouse(string serialNumber)
        {
            SerializableCar removedCar = (CarDatabase.Where(t => t.SerialNumber == serialNumber)).First();

            if (removedCar != null)
            {
                CarDatabase.Remove(removedCar);
                UpdateXmlDatabase(CarDatabase, CarsXmlFileName);
            }
            else
            {
                throw new ArgumentException("Car with this serial number is not found in database");
            }
        }

        /// <summary>
        /// This operation returns the number of brands of cars in warehouse
        /// </summary>
        public int GetCountTypes()
        {
            var brandsId = CarDatabase.Select(t => t.BrandId).Distinct();
            return brandsId.Count();
        }

        /// <summary>
        /// This operation returns the number of all cars in warehouse
        /// </summary>
        public int GetCountAll()
        {
            return CarDatabase.Count();
        }

        /// <summary>
        /// This operation returns the average price of all cars in warehouse
        /// </summary>
        public double GetAveragePrice()
        {
            double totalCost = 0;
            IEnumerable<double> prices = CarDatabase.Select(t => t.Price);

            foreach (double price in prices)
            {
                totalCost += price;
            }

            return prices.Count() != 0 ? totalCost / prices.Count() : 0;
        }

        /// <summary>
        /// This operation returns the average price of cars of concrete brand which are in warehouse
        /// </summary>
        public double GetAveragePriceType(string BrandName)
        {
            double totalCost = 0;
            IEnumerable<string> brandIdEnum = BrandDatabase.Where(t => t.Name == BrandName).Select(t => t.Id);
            IEnumerable<double> prices = CarDatabase.Where(t => brandIdEnum.Contains(t.BrandId)).Select(t => t.Price);

            foreach (double price in prices)
            {
                totalCost += price;
            }

            return prices.Count() != 0 ? totalCost / prices.Count() : 0;
        }

        /// <summary>
        /// This method rewrites selected database
        /// </summary>
        private void UpdateXmlDatabase(object database, string xmlFileName)
        {
            DatabaseManager.XmlSerialize(database, xmlFileName);
        }
    }
}