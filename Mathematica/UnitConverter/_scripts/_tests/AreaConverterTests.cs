using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class AreaConverterTests
    {
        [TestMethod]
        public void square_meterToacreTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterTosquare_footTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_SQUARE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterTosquare_yardTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_SQUARE_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_meterTohectareTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_METER_TO_HECTARE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acreTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acreTohectareTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_HECTARE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acreTosquare_footTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acreTosquare_yardTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void hectareToacreTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.HECTARE_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void hectareTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.HECTARE_TO_SQUARE_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void hectareTosquare_footTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.HECTARE_TO_SQUARE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void hectareTosquare_yardTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.HECTARE_TO_SQUARE_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_millimeterTocircular_milTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILLIMETER_TO_CIRCULAR_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_millimeterTosquare_inchTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILLIMETER_TO_SQUARE_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_millimeterTosquare_centimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILLIMETER_TO_SQUARE_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void circular_milTosquare_millimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.CIRCULAR_MIL_TO_SQUARE_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void circular_milTosquare_inchTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.CIRCULAR_MIL_TO_SQUARE_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void circular_milTosquare_centimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.CIRCULAR_MIL_TO_SQUARE_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_centimeterTosquare_inchTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_CENTIMETER_TO_SQUARE_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_centimeterTosquare_millimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_CENTIMETER_TO_SQUARE_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_centimeterTocircular_milTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_CENTIMETER_TO_CIRCULAR_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_inchTosquare_millimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_INCH_TO_SQUARE_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_inchTosquare_centimeterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_INCH_TO_SQUARE_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_inchTocircular_milTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_INCH_TO_CIRCULAR_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_footTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_FOOT_TO_SQUARE_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_footToacreTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_FOOT_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_footTosquare_yardTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_FOOT_TO_SQUARE_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_footTohectareTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_FOOT_TO_HECTARE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_yardTosquare_meterTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_YARD_TO_SQUARE_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_yardToacreTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_YARD_TO_ACRE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_yardTosquare_footTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_YARD_TO_SQUARE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_yardTohectareTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_YARD_TO_HECTARE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_kilometerTosquare_mileTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_KILOMETER_TO_SQUARE_MILE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void square_mileTosquare_kilometerTest()
        {
            double result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.SQUARE_MILE_TO_SQUARE_KILOMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
