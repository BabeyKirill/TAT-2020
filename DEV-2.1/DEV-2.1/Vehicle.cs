using System;
using System.Linq;

namespace DEV_2._1
{
    /// <summary>
    /// a class that contains the necessary fields for any type of vehicle
    /// </summary>
    public abstract class Vehicle
    {
        protected string allowableNameSymbols = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm ";
        protected string _brandName;
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("manufacturer name can't be null or empty");
                }

                foreach (char c in value)
                {
                    if (allowableNameSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException("entered manufacturer name contains invalid characters");
                    }
                }

                _brandName = value;
            }
        }

        protected string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("model name can't be null or empty");
                }

                foreach (char c in value)
                {
                    if (allowableNameSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException("entered model name contains invalid characters");
                    }
                }

                _model = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("serial number can't be null or empty");
                }

                foreach (char c in value)
                {
                    if (allowableSerialNumberSymbols.Contains(c) == false)
                    {
                        throw new ArgumentException("entered serial number contains invalid characters");
                    }
                }

                _serialNumber = value;
            }
        }

        protected double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("price can't be below zero");
                }

                _price = value;
            }
        }

    }
}