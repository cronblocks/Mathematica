using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum TemperatureConversionType {
            CELSIUS_TO_FAHRENHEIT, CELSIUS_TO_KELVIN,
            FAHRENHEIT_TO_CELSIUS, FAHRENHEIT_TO_KELVIN,
            KELVIN_TO_CELSIUS, KELVIN_TO_FAHRENHEIT
        };
        
        public static double ConvertTemperature(double temparature, TemperatureConversionType conversionType)
        {
            switch (conversionType)
            {
                case TemperatureConversionType.CELSIUS_TO_FAHRENHEIT: return (temparature * 9.0 / 5.0) + 32.0;
                case TemperatureConversionType.CELSIUS_TO_KELVIN:     return temparature + 273.15;
                case TemperatureConversionType.FAHRENHEIT_TO_CELSIUS: return (temparature - 32.0) * 5.0 / 9.0;
                case TemperatureConversionType.FAHRENHEIT_TO_KELVIN:  return (temparature + 459.67) / 1.8;
                case TemperatureConversionType.KELVIN_TO_CELSIUS:     return temparature - 273.15;
                case TemperatureConversionType.KELVIN_TO_FAHRENHEIT:  return (1.8 * temparature) - 459.67;
                default: throw new ArgumentException("Unknown TemperatureConversionType");
            }
        }
    }
}
