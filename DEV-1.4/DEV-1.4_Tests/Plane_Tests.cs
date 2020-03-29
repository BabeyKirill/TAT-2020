using NUnit.Framework;
using DEV_1._4;
using System;

namespace DEV_1._4_Tests
{
    class Plane_Tests
    {
        [Test]
        public void GetFlyTime_CorrectDistanceTest()
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(200, 0, 5);
            Assert.DoesNotThrow(() => plane.GetFlyTime(newPosition));
        }

        [Test]
        public void GetFlyTime_BelowMinDistanceTest()
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newPosition = new Coordinates(199, 0, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => plane.GetFlyTime(newPosition));
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