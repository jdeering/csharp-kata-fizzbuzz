﻿using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz.Tests.Unit_Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_ToOne_IsJustTheNumberOne()
        {
            var expected = new List<string> { "1" };
            var actual = FizzBuzz.To(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_ToThree_ContainsFizz()
        {
            var expected = new List<string> {"1", "2", "Fizz"};
            var actual = FizzBuzz.To(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_OfOne_IsOne()
        {
            var expected = "1";
            var actual = FizzBuzz.Of(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_OfThree_IsFizz()
        {
            var expected = "Fizz";
            var actual = FizzBuzz.Of(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_OfFive_IsBuzz()
        {
            var expected = "Buzz";
            var actual = FizzBuzz.Of(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
