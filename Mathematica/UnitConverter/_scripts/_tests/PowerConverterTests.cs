using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class PowerConverterTests
    {
        [TestMethod]
        public void Btu_per_hourToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_WATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_HORSEPOWER);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_TON_REFRIGERATION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_KILOWATT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_WATT_ELECTRIC);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
