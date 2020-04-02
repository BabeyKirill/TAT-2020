using System;
using System.Text;

namespace CW_3
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
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }

        public BusAssignment Assigment { get; private set; }

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

        public Bus(Chassis chassis, Transmission transmission, BusAssignment busAssignment)
        {
            this.Chassis = new Chassis(6, 8000, "CH000003");
            this.Transmission = new Transmission(TransmissionType.Electrical, 7, "Nike");
            this.Assigment = busAssignment;
        }

        /// <summary>
        /// Returns all information about this bus as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: bus");       
            info.Append($"\nmodel: {Model}");
            info.Append($"\nserial number: {SerialNumber}");
            info.Append($"\nassigment: {Assigment}");
            info.Append($"\nnumber of seats: {NumberOfSeats}");
            info.Append($"\n{this.Engine.GetInfo()}");
            info.Append($"\n{this.Chassis.GetInfo()}");
            info.Append($"\n{this.Transmission.GetInfo()}");

            return info.ToString();
        }
    }
}