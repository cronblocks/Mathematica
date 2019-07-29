using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class RadiologyConverterTests
    {
        [TestMethod]
        public void curieTomegabecquerelTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.CURIE_TO_MEGABECQUEREL);
            double expected = 3700000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megabecquerelTocurieTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MEGABECQUEREL_TO_CURIE);
            double expected = 0.002702703;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void radTograyTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.RAD_TO_GRAY);
            double expected = 1;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void grayToradTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.GRAY_TO_RAD);
            double expected = 10000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_SIEVERT);
            double expected = 1;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void sievertToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.SIEVERT_TO_REM);
            double expected = 10000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_MILLISIEVERT);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_REM);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_MILLISIEVERT);
            double expected = 1;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_MILLIREM);
            double expected = 10000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremTomicrosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_MICROSIEVERT);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microsievertTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MICROSIEVERT_TO_MILLIREM);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void roentgenTocoulomb_per_kilogramTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.ROENTGEN_TO_COULOMB_PER_KILOGRAM);
            double expected = 0.0258;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void coulomb_per_kilogramToroentgenTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.COULOMB_PER_KILOGRAM_TO_ROENTGEN);
            double expected = 387596.89922481;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
