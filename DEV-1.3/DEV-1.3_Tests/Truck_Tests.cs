using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Truck_Tests
    {
        [Test]
        public void CorrectUsefulVolumeSet_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.UsefulVolume = 82.5;
            Assert.AreEqual(82.5, truck.UsefulVolume);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongUsefulVolumeSet_Test(double usefulVolume)
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            Assert.Throws<ArgumentException>(() => truck.UsefulVolume = usefulVolume);
        }

        [Test]
        public void CorrectHeightSet_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.Height = 3.8;
            Assert.AreEqual(3.8, truck.Height);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongHeightSet_Test(double height)
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            Assert.Throws<ArgumentException>(() => truck.Height = height);
        }

        [Test]
        public void CorrectWidthtSet_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.Width = 3.6;
            Assert.AreEqual(3.6, truck.Width);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongWidthSet_Test(double width)
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            Assert.Throws<ArgumentException>(() => truck.Width = width);
        }

        [Test]
        public void GetInfo_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.Engine = new Engine(1000, 9.8, EngineType.Diesel, "EN000002");
            truck.Chassis = new Chassis(6, 10000, "CH000002");
            truck.Transmission = new Transmission(TransmissionType.Combined, 6, "Happy wheels");
            truck.UsefulVolume = 82.5;
            truck.Height = 3.8;
            truck.Width = 3.5;
            Assert.DoesNotThrow(() => truck.GetInfo());
        }

        [Test]
        public void GetInfoNullHeight_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.Engine = new Engine(1000, 9.8, EngineType.Diesel, "EN000002");
            truck.Chassis = new Chassis(6, 10000, "CH000002");
            truck.Transmission = new Transmission(TransmissionType.Combined, 6, "Happy wheels");
            truck.UsefulVolume = 82.5;
            truck.Width = 3.5;
            Assert.DoesNotThrow(() => truck.GetInfo());
        }

        [Test]
        public void GetInfoNullChassis_Test()
        {
            Truck truck = new Truck("MegaTruck 3000", "TR000001");
            truck.Engine = new Engine(1000, 9.8, EngineType.Diesel, "EN000002");
            truck.Transmission = new Transmission(TransmissionType.Combined, 6, "Happy wheels");
            truck.UsefulVolume = 82.5;
            truck.Height = 3.8;
            truck.Width = 3.5;
            Assert.DoesNotThrow(() => truck.GetInfo());
        }
    }
}