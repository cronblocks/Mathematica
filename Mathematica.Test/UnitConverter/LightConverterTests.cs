using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class LightConverterTests
    {
        [TestMethod]
        public void angstromTonanometerTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.ANGSTROM_TO_NANOMETER);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nanometerToangstromTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.NANOMETER_TO_ANGSTROM);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void lambertTocandela_per_sq_meterTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.LAMBERT_TO_CANDELA_PER_SQ_METER);
            double expected = 318309.88618379;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void candela_per_sq_meterTolambertTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.CANDELA_PER_SQ_METER_TO_LAMBERT);
            double expected = 0.031415927;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void candela_per_sq_inchTocandela_per_sq_meterTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.CANDELA_PER_SQ_INCH_TO_CANDELA_PER_SQ_METER);
            double expected = 155000.31000062;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void candela_per_sq_meterTocandela_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.CANDELA_PER_SQ_METER_TO_CANDELA_PER_SQ_INCH);
            double expected = 0.064516;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footlambertTocandela_per_sq_meterTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.FOOTLAMBERT_TO_CANDELA_PER_SQ_METER);
            double expected = 342.625909963;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void candela_per_sq_meterTofootlambertTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.CANDELA_PER_SQ_METER_TO_FOOTLAMBERT);
            double expected = 29.186350796;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void lumen_per_sq_footToluxTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.LUMEN_PER_SQ_FOOT_TO_LUX);
            double expected = 1076.39104167;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void luxTolumen_per_sq_footTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.LUX_TO_LUMEN_PER_SQ_FOOT);
            double expected = 9.290304;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void photToluxTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.PHOT_TO_LUX);
            double expected = 1000000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void luxTophotTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.LUX_TO_PHOT);
            double expected = 0.01;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void footcandleToluxTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.FOOTCANDLE_TO_LUX);
            double expected = 1076.39104167;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void luxTofootcandleTest()
        {
            double result = UnitConverter.ConvertLight(100, UnitConverter.LightConversionType.LUX_TO_FOOTCANDLE);
            double expected = 9.290304;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
