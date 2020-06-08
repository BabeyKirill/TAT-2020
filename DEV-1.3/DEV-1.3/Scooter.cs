using System;
using System.Text;

namespace DEV_1._3
{
    public class Scooter : Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        private int? _maxSpeed;
        public int? MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double? _weight;
        public double? Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Hardcode creation of the scooter
        /// </summary>
        public Scooter(string model, string serialNumber)
        {
            this.Model = model;
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// Returns all information about this scooter as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: scooter");
            info.Append($"\nmodel: {Model}");
            info.Append($"\nserial number: {SerialNumber}");
            info.Append($"\nmax speed: {MaxSpeed}");
            info.Append($"\nweight: {Weight}");
            info.Append(this.Engine != null ? $"\n{this.Engine.GetInfo()}" : String.Empty);
            info.Append(this.Chassis != null ? $"\n{this.Chassis.GetInfo()}" : String.Empty);
            info.Append(this.Transmission != null ? $"\n{this.Transmission.GetInfo()}" : String.Empty);

            return info.ToString();
        }
    }
}
