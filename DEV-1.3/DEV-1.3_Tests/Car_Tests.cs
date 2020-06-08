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
            Car car = new Car("MegaCar 3000", "CA000001");
            car.NumberOfSeats = 4;
            Assert.AreEqual(4, car.NumberOfSeats);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongNumberOfSeatsSet_Test(int numberOfSeats)
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            Assert.Throws<ArgumentException>(() => car.NumberOfSeats = numberOfSeats);
        }

        [Test]
        public void CorrectTrunkVolumeSet_Test()
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            car.TrunkVolume = 55.5;
            Assert.AreEqual(55.5, car.TrunkVolume);
        }

        [Test]
        public void WrongTrunkVolumeSet_Test()
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            Assert.Throws<ArgumentException>(() => car.TrunkVolume = -1);
        }

        [Test]
        public void GetInfo_Test()
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            car.Engine = new Engine(250, 4.5, EngineType.Petrol, "EN000001");
            car.Chassis = new Chassis(4, 2000, "CH000001");
            car.Transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle");
            car.Type = CarType.Sedan;
            car.NumberOfSeats = 5;
            car.TrunkVolume = 55.5;
            Assert.DoesNotThrow(() => car.GetInfo());
        }

        [Test]
        public void GetInfoNullTrunkVolume_Test()
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            car.Engine = new Engine(250, 4.5, EngineType.Petrol, "EN000001");
            car.Chassis = new Chassis(4, 2000, "CH000001");
            car.Transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle");
            car.Type = CarType.Sedan;
            car.NumberOfSeats = 5;
            Assert.DoesNotThrow(() => car.GetInfo());
        }

        [Test]
        public void GetInfoNullEngine_Test()
        {
            Car car = new Car("MegaCar 3000", "CA000001");
            car.Chassis = new Chassis(4, 2000, "CH000001");
            car.Transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle");
            car.Type = CarType.Sedan;
            car.NumberOfSeats = 5;
            car.TrunkVolume = 55.5;
            Assert.DoesNotThrow(() => car.GetInfo());
        }
    }
}