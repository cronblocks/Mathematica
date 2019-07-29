using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EvaluatorTestsMisc
    {
        [TestMethod]
        public void BlankTest01()
        {
            double result = ExpressionEvaluator.Evaluate("");
            double expected = 0;

            Assert.AreEqual<double>(expected, result, "Test failed");
        }

        [TestMethod]
        public void BlankTest02()
        {
            double result = ExpressionEvaluator.Evaluate("  \t \t\t\t\t ");
            double expected = 0;

            Assert.AreEqual<double>(expected, result, "Test failed");
        }

        [TestMethod]
        public void SingleOperandTest()
        {
            double result = ExpressionEvaluator.Evaluate("15555");
            double expected = 15555;

            Assert.AreEqual<double>(expected, result, "Test failed");
        }

        [TestMethod]
        public void SimpleSqrtTest1()
        {
            double result = ExpressionEvaluator.Evaluate("sqrt(81)");
            double expected = 9;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleSqrtTest2()
        {
            double result = ExpressionEvaluator.Evaluate("sqrt(9*9)");
            double expected = 9;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleAbsTest1()
        {
            double result = ExpressionEvaluator.Evaluate("abs(-5000)");
            double expected = 5000;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleAbsTest2()
        {
            double result = ExpressionEvaluator.Evaluate("abs(-5000+1-1)");
            double expected = 5000;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void SimpleAbsTest3()
        {
            double result = ExpressionEvaluator.Evaluate("abs(-5000+1-1) + abs(-5000)");
            double expected = 10000;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void MiscEqnTest01()
        {
            double result = ExpressionEvaluator.Evaluate("pow[pow(sin(30),2)+pow[cos{30},2],1]");
            double expected = 1;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void MiscEqnTest02()
        {
            double result = ExpressionEvaluator.Evaluate("pow{sin(30)+cos(60)+tan(45),2}+pow[cot(45)+sec(60)+csc(30),2]");
            double expected = 29;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void MiscEqnTest03()
        {
            double result = ExpressionEvaluator.Evaluate("pow{sin(30)+cos(60)+tan(45),2}+pow[cot(45)+sec(60)+cosec (30),2]");
            double expected = 29;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void BracesTest1()
        {
            double result = ExpressionEvaluator.Evaluate("{1+5}");
            double expected = 6;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void BracesTest2()
        {
            double result = ExpressionEvaluator.Evaluate("{(1)+5}");
            double expected = 6;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void BracesTest3()
        {
            double result = ExpressionEvaluator.Evaluate("{(1)}+[5]");
            double expected = 6;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void BracesTest4()
        {
            double result = ExpressionEvaluator.Evaluate("[{(10   + 6-              6)5}2]");
            double expected = 100;

            Assert.AreEqual<double>(expected, result);
        }

        [TestMethod]
        public void PIValueTest01()
        {
            double result = ExpressionEvaluator.Evaluate("2pi");
            double expected = 2*Constants.PI;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void PIValueTest02()
        {
            double result = ExpressionEvaluator.Evaluate("2pi e");
            double expected = 2 * Constants.PI * Constants.e;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void PIValueTest03()
        {
            double result = ExpressionEvaluator.Evaluate("2pi600");
            double expected = 2 * Constants.PI * 600;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void PIValueTest04()
        {
            double result = ExpressionEvaluator.Evaluate("2e+ pi8000");
            double expected = 2 * Constants.e + Constants.PI * 8000;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
