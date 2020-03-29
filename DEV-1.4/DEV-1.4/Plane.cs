using System;

namespace DEV_1._4
{
    public class Plane : IFlyable
    {
        // The plane's peculiarity is that its speed increases by 10 kilometers for every 10 kilometers of the traveled path
        // Measurement system in this class is kilometers, kilometers/hours and hours
        public Coordinates CurrentPosition { get; private set; }
        public const double StartSpeed = 200;
        public const double MaxSpeed = 900;
        public const double Acceleration = 10;
        public const double AccelerationDistance = 10;
        public const double MinDistance = 200;

        public Plane(Coordinates startPosition)
        {
            this.CurrentPosition = startPosition;
        }

        /// <summary>
        /// changes the current position of this plane
        /// </summary>
        public void FlyTo(Coordinates newPosition)
        {
            if (CurrentPosition.GetDistance(newPosition) < MinDistance)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.CurrentPosition = newPosition;
        }

        /// <summary>
        /// calculates from the current moment the date of arrival of this plane at the new position and returns the result
        /// </summary>
        public DateTime GetFlyTime(Coordinates newPosition)
        {
            if (CurrentPosition.GetDistance(newPosition) < MinDistance)
            {
                throw new ArgumentOutOfRangeException();
            }

            double distance = CurrentPosition.GetDistance(newPosition);
            double Speed = StartSpeed;
            int maxNumberOfAccelerations = (int)((MaxSpeed - StartSpeed) / Acceleration);
            int numberOfAccelerations = Math.Min((int)(distance / AccelerationDistance), maxNumberOfAccelerations);
            double timeForTrip = 0;

            for (int i = 0; i <= numberOfAccelerations; i++)
            {
                Speed = Speed + Acceleration;
                timeForTrip = timeForTrip + AccelerationDistance / Speed;
            }
         
            distance = distance - numberOfAccelerations * AccelerationDistance;
            timeForTrip = timeForTrip + distance / Speed;
            DateTime timeNow = DateTime.Now;
            return timeNow.AddHours(timeForTrip);
        }
    }
}