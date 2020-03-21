using System;
using System.Text;

namespace DEV_1._3
{
    public class Truck : Vehicle
    {
        public Engine Engine { get; private set; }
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }

        private double _usefulVolume;
        public double UsefulVolume
        {
            get
            {
                return _usefulVolume;
            }
            set
            {
                if (value > 0)
                {
                    _usefulVolume = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Hardcode creation of the truck
        /// </summary>
        public Truck()
        {
            this.Engine = new Engine(1000, 9.8, EngineType.Diesel, "EN000002");
            this.Chassis = new Chassis(6, 10000, "CH000002");
            this.Transmission = new Transmission(TransmissionType.Combined, 6, "Happy wheels");
            Model = "MegaTruck 3000";
            SerialNumber = "TR000001";
            UsefulVolume = 82.5;
            Height = 3.8;
            Width = 3.5;
        }

        /// <summary>
        /// Returns all information about this truck as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: truck");
            info.Append($"\nmodel: {Model}");
            info.Append($"\nserial number: {SerialNumber}");
            info.Append($"\nuseful volume: {UsefulVolume}");
            info.Append($"\nheight: {Height}");
            info.Append($"\nwidth: {Width}");
            info.Append($"\n{this.Engine.GetInfo()}");
            info.Append($"\n{this.Chassis.GetInfo()}");
            info.Append($"\n{this.Transmission.GetInfo()}");

            return info.ToString();
        }
    }
}
