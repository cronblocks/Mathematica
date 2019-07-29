using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class AccelerationConverterTests
    {
        [TestMethod]
        public void meter_per_second_squaredToinch_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meter_per_second_squaredTofoot_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meter_per_second_squaredTostandard_acceleration_of_gravityTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_per_second_squaredTometer_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_per_second_squaredTofoot_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_per_second_squaredTostandard_acceleration_of_gravityTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_per_second_squaredTometer_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_per_second_squaredToinch_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_per_second_squaredTostandard_acceleration_of_gravityTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_acceleration_of_gravityTometer_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_METER_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_acceleration_of_gravityToinch_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_INCH_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_acceleration_of_gravityTofoot_per_second_squaredTest()
        {
            double result = UnitConverter.ConvertAcceleration(100, UnitConverter.AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_FOOT_PER_SECOND_SQUARED);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
