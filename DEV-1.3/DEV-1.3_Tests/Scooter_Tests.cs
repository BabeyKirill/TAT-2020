using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Scooter_Tests
    {
        [Test]
        public void CorrectWeightSet_Test()
        {
            Scooter scooter = new Scooter();
            scooter.Weight = 63.5;
            Assert.AreEqual(63.5, scooter.Weight);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongWeightSet_Test(double weight)
        {
            Scooter scooter = new Scooter();
            Assert.Throws<ArgumentException>(() => scooter.Weight = weight);
        }

        [Test]
        public void CorrectMaxSpeedSet_Test()
        {
            Scooter scooter = new Scooter();
            scooter.MaxSpeed = 50;
            Assert.AreEqual(50, scooter.MaxSpeed);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongMaxSpeedSet_Test(int maxSpeed)
        {
            Scooter scooter = new Scooter();
            Assert.Throws<ArgumentException>(() => scooter.MaxSpeed = maxSpeed);
        }

        [Test]
        public void GetInfo_Test()
        {
            Scooter scooter = new Scooter();
            Assert.DoesNotThrow(() => scooter.GetInfo());
        }
    }
}