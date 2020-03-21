using System;
using System.Text;

namespace DEV_1._3
{
    public class Scooter : Vehicle
    {
        public Engine Engine { get; private set; }
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }

        private int _maxSpeed;
        public int MaxSpeed
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

        private double _weight;
        public double Weight
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
        public Scooter()
        {
            this.Engine = new Engine(25.5, 0.8, EngineType.Electrical, "EN000004");
            this.Chassis = new Chassis(2, 150, "CH000004");
            this.Transmission = new Transmission(TransmissionType.Mechanical, 6, "Disney");
            Model = "MegaScooter 3000";
            SerialNumber = "SC000001";
            MaxSpeed = 60;
            Weight = 63;
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
            info.Append($"\n{this.Engine.GetInfo()}");
            info.Append($"\n{this.Chassis.GetInfo()}");
            info.Append($"\n{this.Transmission.GetInfo()}");

            return info.ToString();
        }
    }
}
