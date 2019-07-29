using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class RadiologyConverterTests
    {
        [TestMethod]
        public void megabecquerelTocurieTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MEGABECQUEREL_TO_CURIE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void curieTomegabecquerelTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.CURIE_TO_MEGABECQUEREL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void grayToradTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.GRAY_TO_RAD);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void radTograyTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.RAD_TO_GRAY);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void sievertToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.SIEVERT_TO_REM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void sievertTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.SIEVERT_TO_MILLISIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void sievertTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.SIEVERT_TO_MILLIREM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void sievertTomicrosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.SIEVERT_TO_MICROSIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_SIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_MILLISIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_MILLIREM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void remTomicrosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.REM_TO_MICROSIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_REM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_MILLIREM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertTosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_SIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millisievertTomicrosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLISIEVERT_TO_MICROSIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_MILLISIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremTomicrosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_MICROSIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_REM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void milliremTosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MILLIREM_TO_SIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microsievertTomilliremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MICROSIEVERT_TO_MILLIREM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microsievertTomillisievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MICROSIEVERT_TO_MILLISIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microsievertToremTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MICROSIEVERT_TO_REM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void microsievertTosievertTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.MICROSIEVERT_TO_SIEVERT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void coulomb_per_kilogramToroentgenTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.COULOMB_PER_KILOGRAM_TO_ROENTGEN);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void roentgenTocoulomb_per_kilogramTest()
        {
            double result = UnitConverter.ConvertRadiology(100, UnitConverter.RadiologyConversionType.ROENTGEN_TO_COULOMB_PER_KILOGRAM);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
