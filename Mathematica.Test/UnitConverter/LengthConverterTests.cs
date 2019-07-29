using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class LengthConverterTests
    {
        [TestMethod]
        public void angstromTonanometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.ANGSTROM_TO_NANOMETER);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nanometerToangstromTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.NANOMETER_TO_ANGSTROM);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_METER);
            double expected = 182.88;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FATHOM);
            double expected = 54.680664916885;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_METER);
            double expected = 30.48;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FOOT);
            double expected = 328.0839895;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTometerTest()
        {
            double result = UnitConverter.ConvertLength(328.08334, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FOOT_US_SURVEY);
            double expected = 328.08334;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_INCH);
            double expected = 1200;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_FOOT);
            double expected = 8.3333333333;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_CENTIMETER);
            double expected = 254;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_INCH);
            double expected = 39.37007874;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_MILLIMETER);
            double expected = 2540;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_INCH);
            double expected = 3.937007874;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_MICROMETER);
            double expected = 2.54;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_MICROINCH);
            double expected = 3937.0078740157;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_MILLIMETER);
            double expected = 2.54;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_MIL);
            double expected = 3937.0078740157482;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_MICROMETER);
            double expected = 2540;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_MIL);
            double expected = 3.937007874015748;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_METER);
            double expected = 91.44;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_YARD);
            double expected = 109.36132983;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mileTokilometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILE_TO_KILOMETER);
            double expected = 160.935;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometerTomileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.KILOMETER_TO_MILE);
            double expected = 62.136887563;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nautical_mileTokilometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.NAUTICAL_MILE_TO_KILOMETER);
            double expected = 185.2;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometerTonautical_mileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.KILOMETER_TO_NAUTICAL_MILE);
            double expected = 53.995680345572;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(284.5274, UnitConverter.LengthConversionType.POINT_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_POINT);
            double expected = 284.5274;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_MILLIMETER);
            double expected = 421.75;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTopicaTest()
        {
            double result = UnitConverter.ConvertLength(421.75, UnitConverter.LengthConversionType.MILLIMETER_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
    }
}
