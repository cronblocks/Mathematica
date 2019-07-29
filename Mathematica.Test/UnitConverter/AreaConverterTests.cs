using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class AreaConverterTests
    {
        [TestMethod]
        public void acreTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_METER);
            double expected = 404687.3;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterToacreTest()
        {
            double result = UnitConverter.ConvertArea(404687.3, UnitConverter.AreaConversionType.SQUARE_METER_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acreTohectareTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_HECTARE);
            double expected = 40.468564224;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void hectareToacreTest()
        {
            double result = UnitConverter.ConvertArea(40.468564224, UnitConverter.AreaConversionType.HECTARE_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void circular_milTosquare_millimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.CIRCULAR_MIL_TO_SQUARE_MILLIMETER);
            double expected = 0.050670748;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_millimeterTocircular_milTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILLIMETER_TO_CIRCULAR_MIL);
            double expected = 197352.524139;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_inchTosquare_centimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_INCH_TO_SQUARE_CENTIMETER);
            double expected = 645.16;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_centimeterTosquare_inchTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_CENTIMETER_TO_SQUARE_INCH);
            double expected = 15.500031000062;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_inchTosquare_millimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_INCH_TO_SQUARE_MILLIMETER);
            double expected = 64516;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_millimeterTosquare_inchTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILLIMETER_TO_SQUARE_INCH);
            double expected = 0.15500031;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_footTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_FOOT_TO_SQUARE_METER);
            double expected = 9.290304;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterTosquare_footTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_SQUARE_FOOT);
            double expected = 1076.391041670972;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_yardTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_YARD_TO_SQUARE_METER);
            double expected = 83.612736;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterTosquare_yardTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_SQUARE_YARD);
            double expected = 119.599004630108;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_mileTosquare_kilometerTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILE_TO_SQUARE_KILOMETER);
            double expected = 258.998811;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_kilometerTosquare_mileTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_KILOMETER_TO_SQUARE_MILE);
            double expected = 38.6102159;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
