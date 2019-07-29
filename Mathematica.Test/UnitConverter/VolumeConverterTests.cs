using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class VolumeConverterTests
    {
        [TestMethod]
        public void acre_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_CUBIC_METER);
            double expected = 123348.18375475;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(10000, UnitConverter.VolumeConversionType.CUBIC_METER_TO_ACRE_FOOT);
            double expected = 8.1071319378991;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_US_GALLONS);
            double expected = 4200.7926023778;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_BARREL_OIL);
            double expected = 2.3805031446541;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_CUBIC_METER);
            double expected = 15.8987;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BARREL_OIL);
            double expected = 628.9810;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_LITER);
            double expected = 15898.73;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(15898.73, UnitConverter.VolumeConversionType.LITER_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_CUBIC_METER);
            double expected = 76.4554857984;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_CUBIC_YARD);
            double expected = 130.79506193144;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_CUBIC_METER);
            double expected = 2.8316846592;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_CUBIC_FOOT);
            double expected = 3531.4666721489;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_LITER);
            double expected = 2831.6846592;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_CUBIC_FOOT);
            double expected = 3.5314666721489;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_CUBIC_METER);
            double expected = 0.2359737216;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BOARD_FOOT);
            double expected = 42377.600065786;

            if (expected - result < -0.01 || expected - result > 0.01)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_CUBIC_METER);
            double expected = 283.16846592;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_REGISTER_TON);
            double expected = 35.314666721489;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_CUBIC_METER);
            double expected = 3.523907016688;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BUSHEL);
            double expected = 2837.7593258402;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_LITER);
            double expected = 378.5412;
        
            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_GALLON);
            double expected = 26.4172;

            if (expected - result < -0.001 || expected - result > 0.001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_LITER);
            double expected = 94.6352946;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_QUART_LIQUID);
            double expected = 105.66882094326;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_LITER);
            double expected = 47.3176473;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_PINT_LIQUID);
            double expected = 211.33764188652;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void fluid_ounceTomilliliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.FLUID_OUNCE_TO_MILLILITER);
            double expected = 2957.35295625;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliliterTofluid_ounceTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.MILLILITER_TO_FLUID_OUNCE);
            double expected = 3.3814022701843;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_inchTocubic_centimeterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_INCH_TO_CUBIC_CENTIMETER);
            double expected = 1638.7064;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_centimeterTocubic_inchTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_CENTIMETER_TO_CUBIC_INCH);
            double expected = 6.1023744094732;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
