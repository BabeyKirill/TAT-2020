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
            Truck truck = new Truck();
            truck.UsefulVolume = 82.5;
            Assert.AreEqual(82.5, truck.UsefulVolume);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongUsefulVolumeSet_Test(double usefulVolume)
        {
            Truck truck = new Truck();
            Assert.Throws<ArgumentException>(() => truck.UsefulVolume = usefulVolume);
        }

        [Test]
        public void CorrectHeightSet_Test()
        {
            Truck truck = new Truck();
            truck.Height = 3.8;
            Assert.AreEqual(3.8, truck.Height);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongHeightSet_Test(double height)
        {
            Truck truck = new Truck();
            Assert.Throws<ArgumentException>(() => truck.Height = height);
        }

        [Test]
        public void CorrectWidthtSet_Test()
        {
            Truck truck = new Truck();
            truck.Width = 3.6;
            Assert.AreEqual(3.6, truck.Width);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WrongWidthSet_Test(double width)
        {
            Truck truck = new Truck();
            Assert.Throws<ArgumentException>(() => truck.Width = width);
        }

        [Test]
        public void GetInfo_Test()
        {
            Truck truck = new Truck();
            Assert.DoesNotThrow(() => truck.GetInfo());
        }
    }
}