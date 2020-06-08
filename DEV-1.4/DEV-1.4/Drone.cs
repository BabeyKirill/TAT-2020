using System;

namespace DEV_1._4
{
    public class Drone : IFlyable
    {
        //The drone's peculiarity is that it stops for 1 minute every 10 minutes
        // Measurement system in this class is kilometers, kilometers/hours and hours
        public Coordinates CurrentPosition { get; private set; }
        public const double Speed = 12;
        public const double StopPeriod = 0.166666666;        // 10 minutes in hours
        public const double StopTime = 0.016666666;         // 1 minute in hours
        public const double MaxDistance = 1000;

        public Drone(Coordinates startPosition)
        {
            this.CurrentPosition = startPosition;
        }

        /// <summary>
        /// changes the current position of this drone
        /// </summary>
        public void FlyTo(Coordinates newPosition)
        {
            if (CurrentPosition.GetDistance(newPosition) > MaxDistance)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.CurrentPosition = newPosition;
        }

        /// <summary>
        /// calculates from the current moment the date of arrival of this drone at the new position and returns the result    
        /// </summary>
        public DateTime GetFlyTime(Coordinates newPosition)
        {
            double timeForTrip = CaulculateTimeForTrip(newPosition);
            DateTime timeNow = DateTime.Now;
            return timeNow.AddHours(timeForTrip);
        }

        /// <summary>
        /// calculates time for trip in hours
        /// </summary>
        public double CaulculateTimeForTrip(Coordinates newPosition)
        {
            if (CurrentPosition.GetDistance(newPosition) > MaxDistance)
            {
                throw new ArgumentOutOfRangeException();
            }

            double distance = CurrentPosition.GetDistance(newPosition);
            double stopDistance = Speed * StopPeriod;
            int numberOfStops = (int)(distance / stopDistance);
            double timeForTrip = distance / Speed + numberOfStops * StopTime;
            return timeForTrip;
        }
    }
}