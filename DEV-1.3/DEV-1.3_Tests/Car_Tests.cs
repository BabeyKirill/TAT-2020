using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Car_Tests
    {
        [Test]
        public void CorrectNumberOfSeatsSet_Test()
        {
            Car car = new Car();
            car.NumberOfSeats = 4;
            Assert.AreEqual(4, car.NumberOfSeats);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongNumberOfSeatsSet_Test(int numberOfSeats)
        {
            Car car = new Car();
            Assert.Throws<ArgumentException>(() => car.NumberOfSeats = numberOfSeats);
        }

        [Test]
        public void CorrectTrunkVolumeSet_Test()
        {
            Car car = new Car();
            car.TrunkVolume = 55.5;
            Assert.AreEqual(55.5, car.TrunkVolume);
        }

        [Test]
        public void WrongTrunkVolumeSet_Test()
        {
            Car car = new Car();
            Assert.Throws<ArgumentException>(() => car.TrunkVolume = -1);
        }

        [Test]
        public void GetInfo_Test()
        {
            Car car = new Car();
            Assert.DoesNotThrow(() => car.GetInfo());
        }
    }
}