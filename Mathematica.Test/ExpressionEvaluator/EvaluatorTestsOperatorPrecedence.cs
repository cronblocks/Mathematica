using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EvaluatorTestsOperatorPrecedence
    {
        [TestMethod]
        public void PrecedenceTest1()
        {
            double result = ExpressionEvaluator.Evaluate("1+3*5");
            double expected = 16;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void PrecedenceTest2()
        {
            double result = ExpressionEvaluator.Evaluate("5*3+5");
            double expected = 20;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void PrecedenceTest3()
        {
            double result = ExpressionEvaluator.Evaluate("5*3+5*5/5*5/5*5/5+5*5/5*5/5*5/5*5/5*6/7*7/6+5");
            double expected = 30;

            Assert.AreEqual<double>(expected, result);
        }
    }
}
