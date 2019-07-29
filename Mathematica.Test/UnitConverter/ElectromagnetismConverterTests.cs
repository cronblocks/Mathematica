using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class ElectromagnetismConverterTests
    {
        [TestMethod]
        public void oerstedToampere_per_meterTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.OERSTED_TO_AMPERE_PER_METER);
            double expected = 7957.747154594;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ampere_per_meterTooerstedTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.AMPERE_PER_METER_TO_OERSTED);
            double expected = 1.256637061436;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void maxwellTonanoweberTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.MAXWELL_TO_NANOWEBER);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nanoweberTomaxwellTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.NANOWEBER_TO_MAXWELL);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void gaussTomilliteslaTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.GAUSS_TO_MILLITESLA);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliteslaTogaussTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(10, UnitConverter.ElectromagnetismConversionType.MILLITESLA_TO_GAUSS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ampere_hourTocoulombTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.AMPERE_HOUR_TO_COULOMB);
            double expected = 360000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void coulombToampere_hourTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.COULOMB_TO_AMPERE_HOUR);
            double expected = 0.027777777777777776;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void ohm_circular_mil_per_footTonanoohm_meterTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.OHM_CIRCULAR_MIL_PER_FOOT_TO_NANOOHM_METER);
            double expected = 166.2;
        
            if (expected - result < -0.1 || expected - result > 0.1)
                Assert.Fail();
        }
        
        [TestMethod]
        public void nanoohm_meterToohm_circular_mil_per_footTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(166.2, UnitConverter.ElectromagnetismConversionType.NANOOHM_METER_TO_OHM_CIRCULAR_MIL_PER_FOOT);
            double expected = 100;
        
            if (expected - result < -0.1 || expected - result > 0.1)
                Assert.Fail();
        }
        
        [TestMethod]
        public void mho_per_centimeterTosiemens_per_meterTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.MHO_PER_CENTIMETER_TO_SIEMENS_PER_METER);
            double expected = 10000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void siemens_per_meterTomho_per_centimeterTest()
        {
            double result = UnitConverter.ConvertElectromagnetism(100, UnitConverter.ElectromagnetismConversionType.SIEMENS_PER_METER_TO_MHO_PER_CENTIMETER);
            double expected = 1;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
