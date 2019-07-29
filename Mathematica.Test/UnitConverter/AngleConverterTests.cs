using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathematica.Test
{
    [TestClass]
    public class AngleConverterTests
    {
        [TestMethod]
        public void DegreeToRadianTest()
        {
            double result = UnitConverter.ConvertAngle(56, UnitConverter.AngleConversionType.DEGREE_TO_RADIAN);
            double expected = 0.977384;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void RadianToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(0.017453, UnitConverter.AngleConversionType.RADIAN_TO_DEGREE);
            double expected = 1;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void DegreeToMilTest()
        {
            double result = UnitConverter.ConvertAngle(45, UnitConverter.AngleConversionType.DEGREE_TO_MIL);
            double expected = 800;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void MilToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(640, UnitConverter.AngleConversionType.MIL_TO_DEGREE);
            double expected = 36;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void DegreeToGradianTest()
        {
            double result = UnitConverter.ConvertAngle(180, UnitConverter.AngleConversionType.DEGREE_TO_GRADIAN);
            double expected = 200;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void GradianToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(400, UnitConverter.AngleConversionType.GRADIAN_TO_DEGREE);
            double expected = 360;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void DegreeToCircleTest()
        {
            double result = UnitConverter.ConvertAngle(60, UnitConverter.AngleConversionType.DEGREE_TO_CIRCLE);
            double expected = 0.166667;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void CircleToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(0.125, UnitConverter.AngleConversionType.CIRCLE_TO_DEGREE);
            double expected = 45;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void DegreeToRevolutionTest()
        {
            double result = UnitConverter.ConvertAngle(60, UnitConverter.AngleConversionType.DEGREE_TO_REVOLUTION);
            double expected = 0.166667;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void RevolutionToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(0.125, UnitConverter.AngleConversionType.REVOLUTION_TO_DEGREE);
            double expected = 45;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void DegreeToSemiCircleTest()
        {
            double result = UnitConverter.ConvertAngle(90, UnitConverter.AngleConversionType.DEGREE_TO_SEMICIRCLE);
            double expected = 0.5;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void SemiCircleToDegreeTest()
        {
            double result = UnitConverter.ConvertAngle(1, UnitConverter.AngleConversionType.SEMICIRCLE_TO_DEGREE);
            double expected = 180;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
