using System;
using System.Xml.Serialization;

namespace DEV_2._1
{
    public class SerializableBrand
    {
        [XmlAttribute]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        private int _numberOfEmployees;
        public int NumberOfEmployees
        {
            get
            {
                return _numberOfEmployees;
            }
            set
            {
                if (value >= 0)
                {
                    _numberOfEmployees = value;
                }
                else
                {
                    throw new ArgumentException("number of employees can't be below zero");
                }
            }
        }

        public SerializableBrand()
        {
        }

        public SerializableBrand(string id, string name, string owner, int numberOfEmployees)
        {
            this.Id = id;
            this.Name = name;
            this.Owner = owner;
            this.NumberOfEmployees = numberOfEmployees;
        }
    }

}