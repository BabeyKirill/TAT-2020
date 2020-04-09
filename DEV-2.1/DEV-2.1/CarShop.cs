using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace DEV_2._1
{
    class CarShop
    {
        public delegate void ShopStateHandler();
        public event ShopStateHandler CarListChanged;   //this event is nessesary for updating database

        private static CarShop instance;
        public List<Car> CarWarehose;

        protected CarShop()
        {
            CarWarehose = new List<Car>();
        }

        /// <summary>
        /// SingleTone pattern, only one object of class can exist
        /// </summary>
        public static CarShop GetInstance()
        {
            if (instance == null)
                instance = new CarShop();

            return instance;
        }

        /// <summary>
        /// set list CarWarehouse from XMl file
        /// </summary>
        public void InitializeFromXml(string databaseXmlFileName)
        {
            if (File.Exists($@"../../{databaseXmlFileName}.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));

                try
                {
                    using (FileStream fs = new FileStream($@"../../{databaseXmlFileName}.xml", FileMode.OpenOrCreate))
                    {
                        this.CarWarehose = (List<Car>)formatter.Deserialize(fs);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
            else
            {
                throw new FileNotFoundException("xml database not found");
            }
        }

        /// <summary>
        /// Add the car to list CarWarehouse
        /// </summary>
        public void AddCarToWarehouse(Car car)
        {
            this.CarWarehose.Add(car);
            CarListChanged();
        }

        /// <summary>
        /// Search the car by serial number and then remove it from list CarWarehouse
        /// </summary>
        public void RemoveCarFromWarehouse(string serialNumber)
        {
            foreach(Car car in CarWarehose)
            {
                if(car.SerialNumber == serialNumber)
                {
                    this.CarWarehose.Remove(car);
                    CarListChanged();
                    break;
                }
            }
        }

        /// <summary>
        /// This operation returns the number of brands of cars in warehouse
        /// </summary>
        public int GetCountTypes()
        {
            List<string> brands = new List<string>();

            foreach(Car car in CarWarehose)
            {
                if(brands.Contains(car.BrandName) == false)
                {
                    brands.Add(car.BrandName);
                }
            }

            return brands.Count;
        }

        /// <summary>
        /// This operation returns the number of all cars in warehouse
        /// </summary>
        public int GetCountAll()
        {
            return CarWarehose.Count();
        }

        /// <summary>
        /// This operation returns the average price of all cars in warehouse
        /// </summary>
        public double GetAveragePrice()
        {
            int totalNumber = GetCountAll();
            double totalCost = 0;

            foreach (Car car in CarWarehose)
            {
                totalCost += car.Price;
            }

            return totalCost / totalNumber;
        }

        /// <summary>
        /// This operation returns the average price of cars of concrete brand which are in warehouse
        /// </summary>
        public double GetAveragePriceType(string BrandName)
        {
            double totalBrandCost = 0;
            int numberOfCars = 0;

            foreach (Car car in CarWarehose)
            {
                if(car.BrandName == BrandName)
                {
                    numberOfCars++;
                    totalBrandCost += car.Price;
                }
            }

            return numberOfCars > 0 ? totalBrandCost / numberOfCars : 0;
        }
    }
}