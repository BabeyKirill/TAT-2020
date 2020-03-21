using NUnit.Framework;
using DEV_1._3;
using System;

namespace DEV_1._3_Tests
{
    [TestFixture]
    public class Engine_Tests
    {
        [Test]
        public void CorrectParametersSetInConstructor_Test()
        {
            Engine engine = new Engine(250.5, 4.5, EngineType.Petrol, "EN000001");
            Assert.IsTrue(250.5 == engine.Power && 4.5 == engine.Volume && EngineType.Petrol == engine.Type && "EN000001" == engine.SerialNumber);
        }

        [TestCase(0, 4.5, "EN000001")]
        [TestCase(-1, 4.5, "EN000001")]
        [TestCase(250, 0, "EN000001")]
        [TestCase(250, -1, "EN000001")]
        [TestCase(250, 4.5, "EN@0&001")]
        [TestCase(250, 4.5, null)]
        [TestCase(250, 4.5, "")]
        public void WrongParametersSetInConstructor_Test(double power, double volume, string serialNumber)
        {
            Assert.Throws<ArgumentException>(() => new Engine(power, volume, EngineType.Diesel, serialNumber));
        }

        [Test]
        public void GetInfo_Test()
        {
            Engine engine = new Engine(250.5, 4.5, EngineType.Petrol, "EN000001");
            Assert.DoesNotThrow(() => engine.GetInfo());
        }
    }
}