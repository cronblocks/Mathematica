using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class VelocityConverterTests
    {
        [TestMethod]
        public void meter_per_secondTofoot_per_secondTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.METER_PER_SECOND_TO_FOOT_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_per_secondTometer_per_secondTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.FOOT_PER_SECOND_TO_METER_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometer_per_hourTomile_per_hourTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.KILOMETER_PER_HOUR_TO_MILE_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometer_per_hourToknotTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.KILOMETER_PER_HOUR_TO_KNOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mile_per_hourTokilometer_per_hourTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.MILE_PER_HOUR_TO_KILOMETER_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mile_per_hourToknotTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.MILE_PER_HOUR_TO_KNOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void knotTokilometer_per_hourTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.KNOT_TO_KILOMETER_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void knotTomile_per_hourTest()
        {
            double result = UnitConverter.ConvertVelocity(100, UnitConverter.VelocityConversionType.KNOT_TO_MILE_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
