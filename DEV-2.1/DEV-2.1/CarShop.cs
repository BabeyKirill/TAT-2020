using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarShop
    {
        private static CarShop instance;
        private XDocument CarDatabase;
        private XDocument BrandsDatabase;
        private string DatabaseXmlFileName;

        protected CarShop(string databaseXmlFileName)
        {
            this.DatabaseXmlFileName = databaseXmlFileName;

            if (File.Exists($"../../{DatabaseXmlFileName}.xml") == false)
            {
                XDocument newEmptyDatabase = new XDocument(new XElement("Cars"));
                newEmptyDatabase.Save($"../../{this.DatabaseXmlFileName}.xml");
            }

            try
            {
                this.CarDatabase = XDocument.Load($"../../{DatabaseXmlFileName}.xml");
                this.BrandsDatabase = XDocument.Load($"../../Brands.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }

        /// <summary>
        /// SingleTone pattern, only one object of class can exist
        /// </summary>
        public static CarShop GetInstance(string databaseXmlFileName)
        {
            if (instance == null)
                instance = new CarShop(databaseXmlFileName);

            return instance;
        }

        /// <summary>
        /// Add the car to Car database
        /// </summary>
        public void AddCarToWarehouse(string serialNumber, string brandId, string model, double price)
        {
            if (price == 0)
            {
                throw new ArgumentException("Invalid price, only positive numbers allowed");
            }

            var existingSerialNumbers = from element in CarDatabase.Element("Cars").Elements("Car")
                                select element.Attribute("SerialNumber").Value;

            if (existingSerialNumbers.Contains(serialNumber) == false)
            {
                XmlDocument xmlDatabase = new XmlDocument();
                xmlDatabase.Load($"../../{this.DatabaseXmlFileName}.xml");
                XmlElement xRoot = xmlDatabase.DocumentElement;
                // creating new car element
                XmlElement car = xmlDatabase.CreateElement("Car");
                // creating attribute SerialNumber for car
                XmlAttribute serialNumberAttribute = xmlDatabase.CreateAttribute("SerialNumber");
                // creating elements for car element
                XmlElement brandNameElement = xmlDatabase.CreateElement("BrandName");
                XmlElement modelElement = xmlDatabase.CreateElement("Model");
                XmlElement priceElement = xmlDatabase.CreateElement("Price");

                // setting values for elements and attributes
                XmlText serialNumberValue = xmlDatabase.CreateTextNode(serialNumber);
                XmlText brandIdValue = xmlDatabase.CreateTextNode(brandId);
                XmlText modelValue = xmlDatabase.CreateTextNode(model);
                XmlText priceValue = xmlDatabase.CreateTextNode(price.ToString());

                //adding elements and attributes in XmlDocument
                serialNumberAttribute.AppendChild(serialNumberValue);
                brandNameElement.AppendChild(brandIdValue);
                modelElement.AppendChild(modelValue);
                priceElement.AppendChild(priceValue);
                car.Attributes.Append(serialNumberAttribute);
                car.AppendChild(brandNameElement);
                car.AppendChild(modelElement);
                car.AppendChild(priceElement);
                xRoot.AppendChild(car);

                xmlDatabase.Save($"../../{this.DatabaseXmlFileName}.xml");
                this.CarDatabase = XDocument.Load($"../../{this.DatabaseXmlFileName}.xml");
            }
            else
            {
                throw new ArgumentException("Car with this serial number already exists in database");
            }
        }

        /// <summary>
        /// Search the car by serial number and then remove it from Car database
        /// </summary>
        public void RemoveCarFromWarehouse(string serialNumber)
        {
            var serialNumbers = from element in CarDatabase.Element("Cars").Elements("Car")
                                select element.Attribute("SerialNumber").Value;

            if (serialNumbers.Contains(serialNumber) == true)
            {
                XmlDocument xmlDatabase = new XmlDocument();
                xmlDatabase.Load($"../../{this.DatabaseXmlFileName}.xml");
                XmlElement xRoot = xmlDatabase.DocumentElement;

                foreach (XmlNode xNode in xRoot)
                {
                    if (xNode.Attributes["SerialNumber"].Value == serialNumber)
                    {
                        xRoot.RemoveChild(xNode);
                    }
                }

                xmlDatabase.Save($"../../{this.DatabaseXmlFileName}.xml");
                this.CarDatabase = XDocument.Load($"../../{this.DatabaseXmlFileName}.xml");
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
            var brandsId = (from element in CarDatabase.Element("Cars").Elements("Car")
                            select element.Element("BrandId").Value)
                           .Distinct();

            return brandsId.Count();
        }

        /// <summary>
        /// This operation returns the number of all cars in warehouse
        /// </summary>
        public int GetCountAll()
        {
            int numberOfCars = (from elements in CarDatabase.Element("Cars").Elements("Car")
                                select elements).Count();

            return numberOfCars;
        }

        /// <summary>
        /// This operation returns the average price of all cars in warehouse
        /// </summary>
        public double GetAveragePrice()
        {
            int totalNumber = GetCountAll();

            double totalCost = 0;

            var prices = from elements in CarDatabase.Element("Cars").Elements("Car")
                         select Double.Parse(elements.Element("Price").Value);

            foreach (var price in prices)
            {
                totalCost += price;
            }

            return totalNumber != 0 ? totalCost / totalNumber : 0;
        }

        /// <summary>
        /// This operation returns the average price of cars of concrete brand which are in warehouse
        /// </summary>
        public double GetAveragePriceType(string BrandName)
        {
            double totalCost = 0;

            var brandIdEnum = (from element in BrandsDatabase.Element("Brands").Elements("Brand")
                              where element.Element("Name").Value == BrandName
                              select element.Attribute("Id").Value);
            string brandId;

            if (brandIdEnum.Count() != 0)
            {
                brandId = brandIdEnum.First();
            }
            else
            {
                return 0;
            }

            var prices = from elements in CarDatabase.Element("Cars").Elements("Car")
                         where elements.Element("BrandId").Value == brandId
                         select Double.Parse(elements.Element("Price").Value);

            int totalNumber = prices.Count();

            foreach (var price in prices)
            {
                totalCost += price;
            }

            return totalNumber != 0 ? totalCost / totalNumber : 0;
        }
    }
}