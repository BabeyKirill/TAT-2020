﻿using NUnit.Framework;
using DEV_1;

namespace Tests
{
    [TestFixture]
    public class StringAnalyzerTests
    {
        [TestCase(0, null)]
        [TestCase(0, "")]
        [TestCase(1, "a")]
        [TestCase(1, "aaa")]
        [TestCase(6, "abcabc")]
        [TestCase(7, "abc cde")]
        [TestCase(5, "abBbc")]
        [TestCase(5, "abcDDefgh")]
        [TestCase(5, "abcddefgh")]
        [TestCase(4, "ab12223c")]
        [TestCase(5, "abc~~#+-_")]
        [TestCase(4, "abc  de")]
        public void СountSequentiallyDifferent_Test(int correctAnswer, string inputString)
        {
            Assert.AreEqual(correctAnswer, StringAnalyzer.СountSequentiallyDifferent(inputString));
        }
    }
}