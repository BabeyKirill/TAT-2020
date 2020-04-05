using System;
using System.Text;

namespace DEV_1._3
{
    public class Truck : Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        private double? _usefulVolume;
        public double? UsefulVolume
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

        private double? _height;
        public double? Height
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

        private double? _width;
        public double? Width
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

        public Truck(string model, string serialNumber)
        {
            this.Model = model;
            this.SerialNumber = serialNumber;
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
            info.Append(this.Engine != null ? $"\n{this.Engine.GetInfo()}" : String.Empty);
            info.Append(this.Chassis != null ? $"\n{this.Chassis.GetInfo()}" : String.Empty);
            info.Append(this.Transmission != null ? $"\n{this.Transmission.GetInfo()}" : String.Empty);

            return info.ToString();
        }
    }
}
