using System;
using System.Text;

namespace DEV_1._3
{
    public enum BusAssignment
    {
        Undefined,
        Intracity,
        Intercity,
        Shuttle,
        Tourist,
    }

    public class Bus : Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public BusAssignment Assigment { get; set; }

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

        public Bus(string model, string serialNumber)
        {
            this.Model = model;
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// Returns all information about this bus as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: bus");
            info.Append($"\nmodel: {this.Model}");
            info.Append($"\nserial number: {this.SerialNumber}");
            info.Append($"\nassigment: {this.Assigment}");
            info.Append($"\nnumber of seats: {this.NumberOfSeats}");
            info.Append(this.Engine != null ? $"\n{this.Engine.GetInfo()}" : String.Empty);
            info.Append(this.Chassis != null ? $"\n{this.Chassis.GetInfo()}" : String.Empty);
            info.Append(this.Transmission != null ? $"\n{this.Transmission.GetInfo()}" : String.Empty);

            return info.ToString();
        }
    }
}