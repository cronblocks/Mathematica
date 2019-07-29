using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class EnergyConverterTests
    {
        [TestMethod]
        public void megajouleTokilowatthourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_KILOWATTHOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megajouleTotherm_USTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_THERM_US);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void megajouleTohorsepower_hourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.MEGAJOULE_TO_HORSEPOWER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowatthourTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOWATTHOUR_TO_MEGAJOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowatthourTotherm_USTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOWATTHOUR_TO_THERM_US);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilowatthourTohorsepower_hourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOWATTHOUR_TO_HORSEPOWER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void jouleTocalorie_physicsTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.JOULE_TO_CALORIE_PHYSICS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void jouleTofoot_pound_forceTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.JOULE_TO_FOOT_POUND_FORCE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_physicsTojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_PHYSICS_TO_JOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_physicsTofoot_pound_forceTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_PHYSICS_TO_FOOT_POUND_FORCE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilojouleTocalorie_nutritionTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOJOULE_TO_CALORIE_NUTRITION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void kilojouleToBtuTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.KILOJOULE_TO_BTU);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_nutritionTokilojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_NUTRITION_TO_KILOJOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void calorie_nutritionToBtuTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.CALORIE_NUTRITION_TO_BTU);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void BtuTokilojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.BTU_TO_KILOJOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void BtuTocalorie_nutritionTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.BTU_TO_CALORIE_NUTRITION);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void therm_USTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.THERM_US_TO_MEGAJOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void therm_USTokilowatthourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.THERM_US_TO_KILOWATTHOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void therm_USTohorsepower_hourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.THERM_US_TO_HORSEPOWER_HOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepower_hourTomegajouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.HORSEPOWER_HOUR_TO_MEGAJOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepower_hourTokilowatthourTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.HORSEPOWER_HOUR_TO_KILOWATTHOUR);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void horsepower_hourTotherm_USTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.HORSEPOWER_HOUR_TO_THERM_US);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_forceTojouleTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.FOOT_POUND_FORCE_TO_JOULE);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
        
        [TestMethod]
        public void foot_pound_forceTocalorie_physicsTest()
        {
            double result = UnitConverter.ConvertEnergy(100, UnitConverter.EnergyConversionType.FOOT_POUND_FORCE_TO_CALORIE_PHYSICS);
            double expected = 100;
        
            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
