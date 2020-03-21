using System;
using System.Linq;
using System.Text;

namespace DEV_1._3
{
    public enum EngineType
    {
        Undefined,
        Petrol,
        Gas,
        Diesel,
        Electrical,
    }

    public class Engine
    {
        public EngineType Type { get; private set; }

        private double _power;
        public double Power
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value > 0)
                {
                    _power = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _volume;
        public double Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                if (value > 0)
                {
                    _volume = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private string allowableSerialNumberSymbols = "0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
        private string _serialNumber;
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }

                foreach (char c in value)
                {
                    if (allowableSerialNumberSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException();
                    }
                }

                _serialNumber = value;
            }
        }

        public Engine(double power, double volume, EngineType type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Engine:");

            info.Append($" power: {Power};");
            info.Append($" volume: {Volume};");           

            if (Type != EngineType.Undefined)
            {
                info.Append($" type: {Type};");
            }

            if (SerialNumber != null)
            {
                info.Append($" serial number: {SerialNumber};");
            }

            return info.ToString();
        }
    }
}
