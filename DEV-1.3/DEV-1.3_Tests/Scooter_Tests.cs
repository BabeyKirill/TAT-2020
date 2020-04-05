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
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            scooter.Weight = 63.5;
            Assert.AreEqual(63.5, scooter.Weight);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongWeightSet_Test(double weight)
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            Assert.Throws<ArgumentException>(() => scooter.Weight = weight);
        }

        [Test]
        public void CorrectMaxSpeedSet_Test()
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            scooter.MaxSpeed = 50;
            Assert.AreEqual(50, scooter.MaxSpeed);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongMaxSpeedSet_Test(int maxSpeed)
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            Assert.Throws<ArgumentException>(() => scooter.MaxSpeed = maxSpeed);
        }

        [Test]
        public void GetInfo_Test()
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            scooter.Engine = new Engine(25.5, 0.8, EngineType.Electrical, "EN000004");
            scooter.Chassis = new Chassis(2, 150, "CH000004");
            scooter.Transmission = new Transmission(TransmissionType.Mechanical, 6, "Disney");
            scooter.MaxSpeed = 60;
            scooter.Weight = 63;
            Assert.DoesNotThrow(() => scooter.GetInfo());
        }

        [Test]
        public void GetInfoNullEngine_Test()
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            scooter.Chassis = new Chassis(2, 150, "CH000004");
            scooter.Transmission = new Transmission(TransmissionType.Mechanical, 6, "Disney");
            scooter.MaxSpeed = 60;
            scooter.Weight = 63;
            Assert.DoesNotThrow(() => scooter.GetInfo());
        }

        [Test]
        public void GetInfoNullMaxSpeed_Test()
        {
            Scooter scooter = new Scooter("MegaScooter 3000", "SC000001");
            scooter.Engine = new Engine(25.5, 0.8, EngineType.Electrical, "EN000004");
            scooter.Chassis = new Chassis(2, 150, "CH000004");
            scooter.Transmission = new Transmission(TransmissionType.Mechanical, 6, "Disney");
            scooter.Weight = 63;
            Assert.DoesNotThrow(() => scooter.GetInfo());
        }
    }
}