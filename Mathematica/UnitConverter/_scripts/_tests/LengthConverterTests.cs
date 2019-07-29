using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class LengthConverterTests
    {
        [TestMethod]
        public void nanometerToangstromTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.NANOMETER_TO_ANGSTROM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void angstromTonanometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.ANGSTROM_TO_NANOMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void meterTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.METER_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void FathomTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FATHOM_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_US_surveyTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.FOOT_US_SURVEY_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inchTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.INCH_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void centimeterTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.CENTIMETER_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeterTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILLIMETER_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void micrometerToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROMETER_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microinchToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MICROINCH_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MIL_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void yardTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.YARD_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometerTomileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.KILOMETER_TO_MILE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilometerTonautical_mileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.KILOMETER_TO_NAUTICAL_MILE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mileTokilometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILE_TO_KILOMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mileTonautical_mileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.MILE_TO_NAUTICAL_MILE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nautical_mileTokilometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.NAUTICAL_MILE_TO_KILOMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nautical_mileTomileTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.NAUTICAL_MILE_TO_MILE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTopicaTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_PICA);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pointTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.POINT_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTomillimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_MILLIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaToinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTomilTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_MIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTopointTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_POINT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTofootTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTocentimeterTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaToFathomTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_FATHOM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTofoot_US_surveyTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_FOOT_US_SURVEY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaToyardTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTomicrometerTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_MICROMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void picaTomicroinchTest()
        {
            double result = UnitConverter.ConvertLength(100, UnitConverter.LengthConversionType.PICA_TO_MICROINCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
