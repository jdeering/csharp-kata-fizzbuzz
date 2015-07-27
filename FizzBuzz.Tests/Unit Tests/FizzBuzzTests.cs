using System.Collections.Generic;
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
    }
}
