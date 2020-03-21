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
            Bus bus = new Bus();
            bus.NumberOfSeats = 58;
            Assert.AreEqual(58, bus.NumberOfSeats);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongNumberOfSeatsSet_Test(int numberOfSeats)
        {
            Bus bus = new Bus();
            Assert.Throws<ArgumentException>(() => bus.NumberOfSeats = numberOfSeats);
        }

        [Test]
        public void CorrectBusAssignmentSet_Test()
        {
            Bus bus = new Bus();
            bus.Assigment = BusAssignment.Undefined;
            Assert.AreEqual(BusAssignment.Undefined, bus.Assigment);
        }

        [Test]
        public void GetInfo_Test()
        {
            Bus bus = new Bus();
            Assert.DoesNotThrow(() => bus.GetInfo());
        }
    }
}