using System;
using FizzBuzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        [TestMethod]
        public void GetFizzBuzz_FizzNumber_ReturnsFizz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var fizzBuzzString = fizzBuzzService.GetFizzBuzz(3);
            Assert.AreEqual(fizzBuzzString,"Fizz");
        }
        [TestMethod]
        public void GetFizzBuzz_BuzzNumber_ReturnsBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var fizzBuzzString = fizzBuzzService.GetFizzBuzz(5);
            Assert.AreEqual(fizzBuzzString, "Buzz");
        }
        [TestMethod]
        public void GetFizzBuzz_FizzBuzzNumber_ReturnsFizzBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var fizzBuzzString = fizzBuzzService.GetFizzBuzz(15);
            Assert.AreEqual(fizzBuzzString, "FizzBuzz");
        }
        [TestMethod]
        public void GetFizzBuzz_Null_ReturnsEmptyString()
        {
            var fizzBuzzService = new FizzBuzzService();
            var fizzBuzzString = fizzBuzzService.GetFizzBuzz(null);
            Assert.AreEqual(fizzBuzzString, "");
        }
    }
}

