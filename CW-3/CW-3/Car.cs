using System;
using System.Text;

namespace CW_3
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
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; set; }
        public CarType Type { get; set; }

        private int _numberOfSeats;
        public int NumberOfSeats
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

        private double _trunkVolume;
        public double TrunkVolume
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

        public Car(Chassis chassis, Transmission transmission, CarType carType)
        {
            this.Chassis = chassis;
            this.Transmission = transmission;
            this.Type = carType;       
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
            info.Append($"\nnumber of seats: {NumberOfSeats}");           
            info.Append($"\ntrunk volume: {TrunkVolume}");           
            info.Append($"\n{this.Engine.GetInfo()}");
            info.Append($"\n{this.Chassis.GetInfo()}");
            info.Append($"\n{this.Transmission.GetInfo()}");

            return info.ToString();
        }
    }
}