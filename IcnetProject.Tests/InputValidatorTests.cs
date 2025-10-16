using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IcnetProject;

namespace IcnetProject.Tests
{
    [TestClass]
    public class InputValidatorTests
    {
        // --------------------------
        // ValidateAndParseInput Tests
        // --------------------------
        [TestMethod]
        public void ValidateAndParseInput_GivenValidNumber_ReturnsParsedDouble()
        {
            var input = "3.14";

            double result = InputValidator.ValidateAndParseInput(input);

            Assert.AreEqual(3.14, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ValidateAndParseInput_GivenInvalidNumber_ThrowsFormatException()
        {
            InputValidator.ValidateAndParseInput("abc");
        }

        [TestMethod]
        public void ValidateAndParseInput_GivenIntegerString_ReturnsParsedDouble()
        {
            double result = InputValidator.ValidateAndParseInput("42");
            Assert.AreEqual(42.0, result);
        }
    }
}
