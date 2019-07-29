using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EnergyConverterTests
    {
        [TestMethod]
        public void kilowatthourTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOWATTHOUR_TO_MEGAJOULE);
            double expected = 360;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megajouleTokilowatthourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_KILOWATTHOUR);
            double expected = 27.777777778;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_physicsTojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_PHYSICS_TO_JOULE);
            double expected = 418.4;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void jouleTocalorie_physicsTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.JOULE_TO_CALORIE_PHYSICS);
            double expected = 23.900573614;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_nutritionTokilojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_NUTRITION_TO_KILOJOULE);
            double expected = 418.68;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilojouleTocalorie_nutritionTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOJOULE_TO_CALORIE_NUTRITION);
            double expected = 23.884589663;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void BtuTokilojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.BTU_TO_KILOJOULE);
            double expected = 105.50559000001674;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilojouleToBtuTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOJOULE_TO_BTU);
            double expected = 94.7817077749;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void therm_USTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.THERM_US_TO_MEGAJOULE);
            double expected = 10548.04;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megajouleTotherm_USTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_THERM_US);
            double expected = 0.948043428;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepower_hourTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.HORSEPOWER_HOUR_TO_MEGAJOULE);
            double expected = 268.451953689;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megajouleTohorsepower_hourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_HORSEPOWER_HOUR);
            double expected = 37.250613611;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_forceTojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.FOOT_POUND_FORCE_TO_JOULE);
            double expected = 135.581794829;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void jouleTofoot_pound_forceTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.JOULE_TO_FOOT_POUND_FORCE);
            double expected = 73.75621493;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
