using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests.Unit_Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_ToOne_ContainsTheNumberOne()
        {
            var expected = new List<string> { "1" };
            var actual = FizzBuzz.To(1);
            Assert.AreSame(expected, actual);
        }
    }
}
