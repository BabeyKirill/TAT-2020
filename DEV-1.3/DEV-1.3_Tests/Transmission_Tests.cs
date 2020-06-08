using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Transmission_Tests
    {
        [Test]
        public void CorrectParametersSetInConstructor_Test()
        {
            Transmission transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle1");
            Assert.IsTrue(TransmissionType.Mechanical == transmission.Type && 5 == transmission.NumberOfGears && "Nestle1" == transmission.Manufacturer);
        }

        [TestCase(0, "Nestle1")]
        [TestCase(-1, "Nestle1")]
        [TestCase(5, "Nes%^tle1")]
        [TestCase(5, null)]
        [TestCase(5, "")]
        public void WrongParametersSetInConstructor_Test(int numberOfGears, string manufacturer)
        {
            Assert.Throws<ArgumentException>(() => new Transmission(TransmissionType.Mechanical, numberOfGears, manufacturer));
        }

        [Test]
        public void GetInfo_Test()
        {
            Transmission transmission = new Transmission(TransmissionType.Mechanical, 5, "Nestle1");
            Assert.DoesNotThrow(() => transmission.GetInfo());
        }
    }
}