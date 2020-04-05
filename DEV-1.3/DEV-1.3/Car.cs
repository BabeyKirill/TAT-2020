using System;
using System.Text;

namespace DEV_1._3
{
    public enum CarType
    {
        Undefined,
        SUV,
        Sedan,
        Hatchback,
        StationWagon,
        Cabriolet,
        Limousine
    }

    public class Car : Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public CarType Type { get; set; }

        private int? _numberOfSeats;
        public int? NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfSeats = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double? _trunkVolume;
        public double? TrunkVolume
        {
            get
            {
                return _trunkVolume;
            }
            set
            {
                if (value >= 0)
                {
                    _trunkVolume = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Car(string model, string serialNumber)
        {
            this.Model = model;
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// Returns all information about this car as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: car");
            info.Append($"\nmodel: {Model}");
            info.Append($"\nserial number: {SerialNumber}");
            info.Append($"\ntype: {Type}");
            info.Append($"\nnumber of seats: {this.NumberOfSeats}");
            info.Append($"\ntrunk volume: {this.TrunkVolume}");
            info.Append(this.Engine != null ? $"\n{this.Engine.GetInfo()}" : String.Empty);
            info.Append(this.Chassis != null ? $"\n{this.Chassis.GetInfo()}" : String.Empty);
            info.Append(this.Transmission != null ? $"\n{this.Transmission.GetInfo()}" : String.Empty);

            return info.ToString();
        }
    }
}