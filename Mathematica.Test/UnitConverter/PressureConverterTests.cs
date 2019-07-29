using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class PressureConverterTests
    {
        [TestMethod]
        public void standard_atmosphereTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_KILOPASCAL);
            double expected = 10132.5;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_STANDARD_ATMOSPHERE);
            double expected = 0.986923267;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_KILOPASCAL);
            double expected = 10000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_BAR);
            double expected = 1;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_KILOPASCAL);
            double expected = 10;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_MILLIBAR);
            double expected = 1000;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_KILOPASCAL);
            double expected = 689.475729318;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 14.503773773;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopound_force_per_sq_inchTomegapascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPOUND_FORCE_PER_SQ_INCH_TO_MEGAPASCAL);
            double expected = 689.475729318;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megapascalTokilopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MEGAPASCAL_TO_KILOPOUND_FORCE_PER_SQ_INCH);
            double expected = 14.503773773;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_KILOPASCAL);
            double expected = 4.788025898;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 2088.543423312;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_KILOPASCAL);
            double expected = 338.638;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_INCH_OF_MERCURY_32_F);
            double expected = 29.530058647;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_KILOPASCAL);
            double expected = 298.898;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_FOOT_OF_WATER_39P2_F);
            double expected = 33.456229215;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_KILOPASCAL);
            double expected = 24.9082;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_INCH_OF_WATER_39P2_F);
            double expected = 401.474213311;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_KILOPASCAL);
            double expected = 13.33224;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 750.06150504341;
        
            if (expected - result < -0.01 || expected - result > 0.01)
                Assert.Fail();
        }
        
        [TestMethod]
        public void torrTopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.TORR_TO_PASCAL);
            double expected = 13332.236842108;
        
            if (expected - result < -0.01 || expected - result > 0.01)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pascalTotorrTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.PASCAL_TO_TORR);
            double expected = 0.750061683;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
