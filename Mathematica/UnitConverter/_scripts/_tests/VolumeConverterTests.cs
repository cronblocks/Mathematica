using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class VolumeConverterTests
    {
        [TestMethod]
        public void cubic_meterToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_meterTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_METER_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void acre_footTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.ACRE_FOOT_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void US_gallonsTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.US_GALLONS_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barrel_oilTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BARREL_OIL_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void literTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.LITER_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_yardTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_YARD_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_footTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_FOOT_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void board_footTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BOARD_FOOT_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void register_tonTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.REGISTER_TON_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void bushelTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.BUSHEL_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gallonTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.GALLON_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTopint_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_PINT_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void quart_liquidTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.QUART_LIQUID_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_LITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTobarrel_oilTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_BARREL_OIL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTocubic_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_CUBIC_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTogallonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_GALLON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToquart_liquidTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_QUART_LIQUID);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTocubic_meterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_CUBIC_METER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToUS_gallonsTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_US_GALLONS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToacre_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_ACRE_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTocubic_yardTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_CUBIC_YARD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToboard_footTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_BOARD_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidToregister_tonTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_REGISTER_TON);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pint_liquidTobushelTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.PINT_LIQUID_TO_BUSHEL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliliterTofluid_ounceTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.MILLILITER_TO_FLUID_OUNCE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void fluid_ounceTomilliliterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.FLUID_OUNCE_TO_MILLILITER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_centimeterTocubic_inchTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_CENTIMETER_TO_CUBIC_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void cubic_inchTocubic_centimeterTest()
        {
            double result = UnitConverter.ConvertVolume(100, UnitConverter.VolumeConversionType.CUBIC_INCH_TO_CUBIC_CENTIMETER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
