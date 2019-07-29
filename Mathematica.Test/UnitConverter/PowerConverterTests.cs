using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class PowerConverterTests
    {
        [TestMethod]
        public void ton_refrigerationToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_BTU_PER_HOUR);
            double expected = 1200000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_TON_REFRIGERATION);
            double expected = 0.00833333;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ton_refrigerationTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.TON_REFRIGERATION_TO_KILOWATT);
            double expected = 351.68525;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattToton_refrigerationTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_TON_REFRIGERATION);
            double expected = 28.434516375;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_secondTokilowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_SECOND_TO_KILOWATT);
            double expected = 105.50560;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowattToBtu_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.KILOWATT_TO_BTU_PER_SECOND);
            double expected = 94.78170;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void Btu_per_hourTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.BTU_PER_HOUR_TO_WATT);
            double expected = 29.307107;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattToBtu_per_hourTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_BTU_PER_HOUR);
            double expected = 341.2141633;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTofoot_pounds_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_FOOT_POUNDS_FORCE_PER_SECOND);
            double expected = 55000;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pounds_force_per_secondTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_HORSEPOWER);
            double expected = 0.18181818181818;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_WATT);
            double expected = 74569.9872;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_HORSEPOWER);
            double expected = 0.13410220888;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepowerTowatt_electricTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.HORSEPOWER_TO_WATT_ELECTRIC);
            double expected = 74600;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void watt_electricTohorsepowerTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_ELECTRIC_TO_HORSEPOWER);
            double expected = 0.13404825737;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_force_per_secondTowattTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_WATT);
            double expected = 135.58179483314004;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void wattTofoot_pound_force_per_secondTest()
        {
            double result = UnitConverter.ConvertPower(100, UnitConverter.PowerConversionType.WATT_TO_FOOT_POUND_FORCE_PER_SECOND);
            double expected = 73.75621492772654;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
