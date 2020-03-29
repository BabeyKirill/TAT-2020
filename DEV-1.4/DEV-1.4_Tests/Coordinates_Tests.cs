using NUnit.Framework;
using DEV_1._4;
using System;

namespace DEV_1._4_Tests
{
    [TestFixture]
    public class Coordinates_Tests
    {
        [Test]
        public void StartPosition_Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Coordinates(0, 0, -1));
        }

        [Test]
        public void GetDistance_Test()
        {
            Coordinates firstPoint = new Coordinates(-10, 0, 0);
            Coordinates secondPoint = new Coordinates(0, 10, 5);
            double expected = Math.Sqrt(Math.Pow(secondPoint.XCoordinate - firstPoint.XCoordinate, 2) +
                Math.Pow(secondPoint.YCoordinate - firstPoint.YCoordinate, 2) +
                Math.Pow(secondPoint.Height - firstPoint.Height, 2));

            Assert.True(expected - firstPoint.GetDistance(secondPoint) < double.Epsilon);
        }
    }
}