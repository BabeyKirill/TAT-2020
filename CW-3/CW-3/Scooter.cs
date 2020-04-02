using System;
using System.Text;

namespace CW_3
{
    public class Scooter : Vehicle
    {
        public Engine Engine { get; set; }
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

        public Scooter()
        {
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
