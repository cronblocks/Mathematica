using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EvaluatorTestsTwoParameters
    {
        [TestMethod]
        public void SimpleAdditionTest()
        {
            double result = ExpressionEvaluator.Evaluate("1+3");
            double expected = 4;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void DecimalPointAdditionTest()
        {
            double result = ExpressionEvaluator.Evaluate("10.4+3.3");
            double expected = 13.7;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleSubtractionTest()
        {
            double result = ExpressionEvaluator.Evaluate("1-3");
            double expected = -2;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleMultiplicationTest()
        {
            double result = ExpressionEvaluator.Evaluate("5*3");
            double expected = 15;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleDivisionTest()
        {
            double result = ExpressionEvaluator.Evaluate("33/3");
            double expected = 11;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void SimplePowerTest()
        {
            double result = ExpressionEvaluator.Evaluate("3^3");
            double expected = 27;

            Assert.AreEqual<double>(expected, result);
        }
    }
}
