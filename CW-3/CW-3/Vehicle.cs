using System;
using System.Linq;

namespace CW_3
{
    /// <summary>
    /// a class that contains the necessary fields for any type of vehicle
    /// </summary>
    public abstract class Vehicle
    {
        protected string allowableModelSymbols = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm ";
        protected string _model;
        public string Model
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                foreach (char c in value)
                {
                    if (allowableModelSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException();
                    }
                }

                _serialNumber = value;
            }
        }

        protected string allowableSerialNumberSymbols = "0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
        protected string _serialNumber;
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
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

        public abstract string GetInfo();
    }
}