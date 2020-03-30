using NUnit.Framework;
using DEV_1._4;
using System;

namespace DEV_1._4_Tests
{
    class Drone_Tests
    {
        [Test]
        public void GetFlyTime_AboveMaxDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(1001, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => drone.GetFlyTime(newPosition));
        }

        [Test]
        public void CaulculateTimeForTrip_CorrectDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(200, 0, 5);
            double expected = 18.333333;
            double actual = drone.CaulculateTimeForTrip(newPosition);
            double roundingError = 0.000001;     //0,0036 seconds
            Assert.IsTrue(Math.Abs(expected - actual) < roundingError);
        }

        [Test]
        public void FlyTo_CorrectDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(1000, 0, 5);
            drone.FlyTo(newPosition);
            Assert.AreEqual(newPosition, drone.CurrentPosition);
        }

        [Test]
        public void FlyTo_AboveMaxDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(1001, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => drone.FlyTo(newPosition));
        }
    }
}