using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Chassis_Tests
    {
        [Test]
        public void CorrectParametersSetInConstructor_Test()
        {
            Chassis chassis = new Chassis(4, 2000, "CH000001");
            Assert.IsTrue(4 == chassis.NumberOfWheels && 2000 == chassis.BearingСapacity && "CH000001" == chassis.SerialNumber);
        }

        [TestCase(0, 2000, "CH000001")]
        [TestCase(-1, 2000, "CH000001")]
        [TestCase(4, 0, "CH000001")]
        [TestCase(4, -1, "CH000001")]
        [TestCase(4, 2000, "CH$00abc")]
        [TestCase(4, 2000, null)]
        [TestCase(4, 2000, "")]
        public void WrongParametersSetInConstructor_Test(int numberOfWheels, int bearingCapacity, string serialNumber)
        {
            Assert.Throws<ArgumentException>(() => new Chassis(numberOfWheels, bearingCapacity, serialNumber));
        }

        [Test]
        public void GetInfo_Test()
        {
            Chassis chassis = new Chassis(4, 2000, "CH000001");
            Assert.DoesNotThrow(() => chassis.GetInfo());
        }
    }
}
