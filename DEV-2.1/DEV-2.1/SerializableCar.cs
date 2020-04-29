using System;
using System.Xml.Serialization;

namespace DEV_2._1
{
    [Serializable]
    public class SerializableCar
    {
        [XmlAttribute]
        public string SerialNumber { get; set; }
        public string BrandId { get; set; }
        public string ModelId { get; set; }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("price must be above zero");
                }
            }
        }

        public SerializableCar()
        {
        }

        public SerializableCar(string serialNumber, string brandId, string modelId, double price)
        {
            this.SerialNumber = serialNumber;
            this.BrandId = brandId;
            this.ModelId = modelId;
            this.Price = price;
        }
    }
}