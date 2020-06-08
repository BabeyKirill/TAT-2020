using System;

namespace DEV_1._4
{
    public struct Coordinates
    {
        public double XCoordinate;
        public double YCoordinate;
        public double Height;

        public Coordinates(double xCoordinate, double yCoordinate, double height)
        {
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException("Height can't be below zero");
            }

            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            this.Height = height;
        }

        public double GetDistance(Coordinates newPosition)
        {
            return Math.Sqrt(Math.Pow(newPosition.XCoordinate - this.XCoordinate, 2) +
                Math.Pow(newPosition.YCoordinate - this.YCoordinate, 2) +
                Math.Pow(newPosition.Height - this.Height, 2));
        }
    }
}