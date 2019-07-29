using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class PressureConverterTests
    {
        [TestMethod]
        public void kilopascalTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopascalTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPASCAL_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void standard_atmosphereTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.STANDARD_ATMOSPHERE_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void barTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.BAR_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millibarTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIBAR_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_inchTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megapascalTokilopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MEGAPASCAL_TO_KILOPOUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilopound_force_per_sq_inchTomegapascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.KILOPOUND_FORCE_PER_SQ_INCH_TO_MEGAPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pound_force_per_sq_footTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_mercury_32_FTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_MERCURY_32_F_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_of_water_39p2_FTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.FOOT_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void inch_of_water_39p2_FTomillimeter_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.INCH_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTokilopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_KILOPASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTostandard_atmosphereTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTobarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_BAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTomillibarTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_MILLIBAR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTopound_force_per_sq_inchTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTopound_force_per_sq_footTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FToinch_of_mercury_32_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_MERCURY_32_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FTofoot_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void millimeter_of_mercury_32_FToinch_of_water_39p2_FTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void pascalTotorrTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.PASCAL_TO_TORR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void torrTopascalTest()
        {
            double result = UnitConverter.ConvertPressure(100, UnitConverter.PressureConversionType.TORR_TO_PASCAL);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
