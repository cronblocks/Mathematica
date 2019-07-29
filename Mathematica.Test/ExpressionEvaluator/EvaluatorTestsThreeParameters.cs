using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EvaluatorTestsThreeParameters
    {
        [TestMethod]
        public void SimpleAdditionTest()
        {
            double result = ExpressionEvaluator.Evaluate("(1+3+55)");
            double expected = 59;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void DecimalPointAdditionTest()
        {
            double result = ExpressionEvaluator.Evaluate("10.4+3.3+60.4");
            double expected = 74.1;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleSubtractionTest()
        {
            double result = ExpressionEvaluator.Evaluate("100-30-50");
            double expected = 20;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleMultiplicationTest()
        {
            double result = ExpressionEvaluator.Evaluate("5*3*2");
            double expected = 30;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleDivisionTest()
        {
            double result = ExpressionEvaluator.Evaluate("33/3/11");
            double expected = 1;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SimplePowerTest()
        {
            double result = ExpressionEvaluator.Evaluate("3^3^1");
            double expected = 27;

            Assert.AreEqual<double>(expected, result);
        }
    }
}
