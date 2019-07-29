using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematica;

namespace Mathematica.Test
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheitTest()
        {
            double result = UnitConverter.ConvertTemperature(100, UnitConverter.TemperatureConversionType.CELSIUS_TO_FAHRENHEIT);
            double expected = 212;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void CelsiusToKelvinTest()
        {
            double result = UnitConverter.ConvertTemperature(100, UnitConverter.TemperatureConversionType.CELSIUS_TO_KELVIN);
            double expected = 373.15;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        //-------------------------------------------------------------------------------------------------
        [TestMethod]
        public void FahrenheitToCelsiusTest()
        {
            double result = UnitConverter.ConvertTemperature(200, UnitConverter.TemperatureConversionType.FAHRENHEIT_TO_CELSIUS);
            double expected = 93.3333;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void FahrenheitToKelvinTest()
        {
            double result = UnitConverter.ConvertTemperature(200, UnitConverter.TemperatureConversionType.FAHRENHEIT_TO_KELVIN);
            double expected = 366.4833;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        //-------------------------------------------------------------------------------------------------
        [TestMethod]
        public void KelvinToCelsiusTest()
        {
            double result = UnitConverter.ConvertTemperature(500, UnitConverter.TemperatureConversionType.KELVIN_TO_CELSIUS);
            double expected = 226.85;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }

        [TestMethod]
        public void KelvinToFahrenheitTest()
        {
            double result = UnitConverter.ConvertTemperature(500, UnitConverter.TemperatureConversionType.KELVIN_TO_FAHRENHEIT);
            double expected = 440.33;

            if (expected - result < -0.0001 || expected - result > 0.0001)
                Assert.Fail();
        }
    }
}
