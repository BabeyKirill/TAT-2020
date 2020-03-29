using NUnit.Framework;
using DEV_1._4;
using System;

namespace DEV_1._4_Tests
{
    class Drone_Tests
    {
        [Test]
        public void GetFlyTime_CorrectDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(1000, 0, 5);
            Assert.DoesNotThrow(() => drone.GetFlyTime(newPosition));
        }

        [Test]
        public void GetFlyTime_AboveMaxDistanceTest()
        {
            Drone drone = new Drone(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(1001, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => drone.GetFlyTime(newPosition));
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