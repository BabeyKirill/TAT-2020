using NUnit.Framework;
using DEV_1._4;
using System;

namespace DEV_1._4_Tests
{
    class Plane_Tests
    {
        [Test]
        public void GetFlyTime_BelowMinDistanceTest()
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(199, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => plane.GetFlyTime(newPosition));
        }

        [TestCase(0.705803, 200, 0, 5)]
        [TestCase(1.857053, 1000, 0, 5)]
        public void CaulculateTimeForTrip_CorrectDistanceTest(double expected, double newPositionX, double newPositionY, double newPositionZ)
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(newPositionX, newPositionY, newPositionZ);
            double actual = plane.CaulculateTimeForTrip(newPosition);
            double roundingError = 0.000001;     //0,0036 seconds
            Assert.IsTrue(Math.Abs(expected - actual) < roundingError);
        }

        [Test]
        public void FlyTo_CorrectDistanceTest()
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(200, 0, 5);
            plane.FlyTo(newPosition);
            Assert.AreEqual(newPosition, plane.CurrentPosition);
        }

        [Test]
        public void FlyTo_BelowMinDistanceTest()
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(199, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => plane.FlyTo(newPosition));
        }
    }
}