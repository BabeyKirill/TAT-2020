using System;
using System.Linq;
using System.Text;

namespace DEV_1._3
{
    public enum TransmissionType
    {
        Undefined,
        Electrical,
        Mechanical,
        Hidrostatic,
        Combined
    }

    public class Transmission
    {
        public TransmissionType Type { get; private set; }

        private int _numberOfGears;
        public int NumberOfGears
        {
            get
            {
                return _numberOfGears;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfGears = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        protected string allowableManufacturerSymbols = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm ";
        private string _manufacturer;
        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                foreach (char c in value)
                {
                    if (allowableManufacturerSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException();
                    }
                }

                _manufacturer = value;
            }
        }

        public Transmission(TransmissionType type, int numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Transmission:");

            if (Type != TransmissionType.Undefined)
            {
                info.Append($" power: {Type};");
            }

            info.Append($" number of gears: {NumberOfGears};");            

            if (Manufacturer != null)
            {
                info.Append($" manufacturer: {Manufacturer};");
            }

            return info.ToString();
        }
    }
}
