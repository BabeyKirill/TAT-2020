using System;

namespace DEV_1._4
{
    public class Bird : IFlyable
    {
        // The bird's peculiarity is that its speed is set randomly in the range from 0 to 20 kilometres per hour
        // Measurement system in this class is kilometers, kilometers/hours and hours
        public Coordinates CurrentPosition { get; private set; }
        public const int MinSpeed = 0;
        public const int MaxSpeed = 20;
        public double Speed { get; private set; }

        public Bird(Coordinates startPosition)
        {
            this.CurrentPosition = startPosition;
            this.Speed = Randomizer.rnd.Next(MinSpeed, MaxSpeed + 1);
        }

        /// <summary>
        /// changes the current position of this bird
        /// </summary>
        public void FlyTo(Coordinates newPosition)
        {
            if (this.Speed != 0)
            {
                this.CurrentPosition = newPosition;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// calculates from the current moment the date of arrival of this bird at the new position and returns the result
        /// </summary>
        public DateTime GetFlyTime(Coordinates newPosition)
        {
            if (this.Speed != 0)
            {
                double timeForTrip = CurrentPosition.GetDistance(newPosition) / this.Speed;
                DateTime timeNow = DateTime.Now;
                return timeNow.AddHours(timeForTrip);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}