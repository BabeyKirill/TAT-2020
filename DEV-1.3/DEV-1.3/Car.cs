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
        public Engine Engine { get; private set; }
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }
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

        /// <summary>
        /// Hardcode creation of the car
        /// </summary>
        public Car()
        {
            this.Engine = new Engine(250, 4.5, EngineType.Petrol, "EN000001");
            this.Chassis = new Chassis(4, 2000, "CH000001");
            this.Transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle");
            Model = "MegaCar 3000";
            SerialNumber = "CA000001";
            Type = CarType.Sedan;
            NumberOfSeats = 5;
            TrunkVolume = 55.5;          
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