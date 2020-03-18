using NUnit.Framework;
using DEV_1._2;
using System;

namespace DEV_1._2_Tests
{
    [TestFixture]
    public class NumberConverter_Tests
    {
        [TestCase("0", 0, 3)]
        [TestCase("101", 5, 2)]
        [TestCase("-101", -5, 2)]
        [TestCase("100", 4, 2)]
        [TestCase("22", 8, 3)]
        [TestCase("999", 999, 10)]
        [TestCase("11B", 283, 16)]
        [TestCase("-11B", -283, 16)]
        [TestCase("JB", 391, 20)]
        [TestCase("1111111111111111111111111111111", int.MaxValue, 2)]
        [TestCase("-10000000000000000000000000000000", int.MinValue, 2)]
        public void ConvertNumeralSystem_Test(string correctAnswer, int inputNumber, int numeralSystemSize)
        {
            Assert.AreEqual(correctAnswer, NumberConverter.ConvertNumeralSystem(inputNumber, numeralSystemSize));
        }

        [TestCase(100, 0)]
        [TestCase(100, 1)]
        [TestCase(100, 21)]
        [TestCase(100, 22)]      
        public void ConvertNumeralSystem_OutOfRangeTest(int inputNumber, int numeralSystemSize)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberConverter.ConvertNumeralSystem(inputNumber, numeralSystemSize));
        }
    }  
}
