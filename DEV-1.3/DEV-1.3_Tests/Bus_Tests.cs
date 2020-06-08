using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Bus_Tests
    {
        [Test]
        public void CorrectNumberOfSeatsSet_Test()
        {
            Bus bus = new Bus("MegaBus 3000", "BU000001");
            bus.NumberOfSeats = 58;
            Assert.AreEqual(58, bus.NumberOfSeats);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongNumberOfSeatsSet_Test(int numberOfSeats)
        {
            Bus bus = new Bus("MegaBus 3000", "BU000001");
            Assert.Throws<ArgumentException>(() => bus.NumberOfSeats = numberOfSeats);
        }

        [Test]
        public void GetInfo_Test()
        {
            Bus bus = new Bus("MegaBus 3000", "BU000001");
            bus.Engine = new Engine(400, 7.2, EngineType.Diesel, "EN000003");
            bus.Transmission = new Transmission(TransmissionType.Electrical, 7, "Nike");
            bus.Chassis = new Chassis(6, 8000, "CH000003");
            bus.Assigment = BusAssignment.Tourist;
            bus.NumberOfSeats = 50;

            Assert.DoesNotThrow(() => bus.GetInfo());
        }

        [Test]
        public void GetInfoNullNumberOfSeats_Test()
        {
            Bus bus = new Bus("MegaBus 3000", "BU000001");
            bus.Engine = new Engine(400, 7.2, EngineType.Diesel, "EN000003");
            bus.Transmission = new Transmission(TransmissionType.Electrical, 7, "Nike");
            bus.Chassis = new Chassis(6, 8000, "CH000003");
            bus.Assigment = BusAssignment.Tourist;

            Assert.DoesNotThrow(() => bus.GetInfo());
        }

        [Test]
        public void GetInfoNullChassis_Test()
        {
            Bus bus = new Bus("MegaBus 3000", "BU000001");
            bus.Engine = new Engine(400, 7.2, EngineType.Diesel, "EN000003");
            bus.Transmission = new Transmission(TransmissionType.Electrical, 7, "Nike");
            bus.Assigment = BusAssignment.Tourist;
            bus.NumberOfSeats = 50;

            Assert.DoesNotThrow(() => bus.GetInfo());
        }
    }
}