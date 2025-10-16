using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IcnetProject;

namespace IcnetProject.Tests
{
    [TestClass]
    public class CalculationUtilityTests
    {

        // --------------------------
        // GetSum Tests
        // --------------------------
        [TestMethod]
        public void GetSum_GivenThreeNumbers_ReturnsCorrectSum()
        {
            double sum = CalculationUtility.GetSum(1, 2, 3);
            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void GetSum_GivenNegativeNumbers_ReturnsCorrectSum()
        {
            double sum = CalculationUtility.GetSum(-1, 2, 3);
            Assert.AreEqual(4, sum);
        }

        // --------------------------
        // GetProduct Tests
        // --------------------------
        [TestMethod]
        public void GetProduct_GivenThreeNumbers_ReturnsCorrectProduct()
        {
            double product = CalculationUtility.GetProduct(2, 3, 4);
            Assert.AreEqual(24, product);
        }

        [TestMethod]
        public void GetProduct_GivenZero_ReturnsZero()
        {
            double product = CalculationUtility.GetProduct(5, 0, 2);
            Assert.AreEqual(0, product);
        }

        [TestMethod]
        public void GetProduct_GivenNegativeNumbers_ReturnsCorrectProduct()
        {
            double product = CalculationUtility.GetProduct(-2, 3, 4);
            Assert.AreEqual(-24, product);
        }

        // --------------------------
        // GetSumOfFirstTwoDividedByThird Tests
        // --------------------------
        [TestMethod]
        public void GetSumOfFirstTwoDividedByThird_ValidNumbers_ReturnsCorrectResult()
        {
            double result = CalculationUtility.GetSumOfFirstTwoDividedByThird(4, 2, 3);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void GetSumOfFirstTwoDividedByThird_ThirdNumberZero_ThrowsDivideByZeroException()
        {
            CalculationUtility.GetSumOfFirstTwoDividedByThird(1, 2, 0);
        }

        [TestMethod]
        public void GetSumOfFirstTwoDividedByThird_NegativeNumbers_ReturnsCorrectResult()
        {
            double result = CalculationUtility.GetSumOfFirstTwoDividedByThird(-4, 2, 3);
            Assert.AreEqual(-0.6666666666666666, result, 1e-10);
        }
    }
}
