using System;
using System.Linq;
using System.Text;

namespace DEV_1._3
{
    public class Chassis
    {
        private int _numberOfWheels;
        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            private set
            {
                if (value > 0)
                {
                    _numberOfWheels = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private int _bearingCapacity;
        public int BearingСapacity
        {
            get
            {
                return _bearingCapacity;
            }
            private set
            {
                if (value > 0)
                {
                    _bearingCapacity = value;
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

        public Chassis(int numberOfWheels, int bearingCapacity, string serialNumber)
        {
            NumberOfWheels = numberOfWheels;
            BearingСapacity = bearingCapacity;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Chassis:");

            info.Append($" number of wheels: {NumberOfWheels};");           

            info.Append($" bearing capacity: {BearingСapacity};");            

            if (SerialNumber != null)
            {
                info.Append($" serial number: {SerialNumber};");
            }

            return info.ToString();         
        }
    }
}
