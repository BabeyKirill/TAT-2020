using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DEV_2._1
{
    class CarShopEventHandler
    {
        public CarShop Shop { get; set; }
        public string DatabaseXmlFileName { get; set; }

        public CarShopEventHandler(CarShop shop, string databaseXmlFileName)
        {
            this.Shop = shop;
            this.DatabaseXmlFileName = databaseXmlFileName;
        }

        public void UpdateWarehouseXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));

            using (FileStream fs = new FileStream($@"../../{DatabaseXmlFileName}.xml", FileMode.Create))
            {
                formatter.Serialize(fs, this.Shop.CarWarehose);
            }
        }
    }
}
