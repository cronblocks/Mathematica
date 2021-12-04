using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum AccelerationConversionType {
            METER_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED,
            METER_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED,
            METER_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY,
            INCH_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED,
            INCH_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED,
            INCH_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY,
            FOOT_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED,
            FOOT_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED,
            FOOT_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY,
            STANDARD_ACCELERATION_OF_GRAVITY_TO_METER_PER_SECOND_SQUARED,
            STANDARD_ACCELERATION_OF_GRAVITY_TO_INCH_PER_SECOND_SQUARED,
            STANDARD_ACCELERATION_OF_GRAVITY_TO_FOOT_PER_SECOND_SQUARED
        };
        
        public static double ConvertAcceleration(double acceleration, AccelerationConversionType conversionType)
        {
            switch(conversionType)
            {
                case AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED:  return acceleration * 3.937007874015748e+01;
                case AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED:  return acceleration * 3.280839895013123;
                case AccelerationConversionType.METER_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY:  return acceleration * 1.019716212977928e-01;
                case AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED:  return acceleration * 0.0254;
                case AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_FOOT_PER_SECOND_SQUARED:   return acceleration * 8.333333333333331e-02;
                case AccelerationConversionType.INCH_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY:  return acceleration * 2.590079180963937e-03;
                case AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_METER_PER_SECOND_SQUARED:  return acceleration * 0.3048;
                case AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_INCH_PER_SECOND_SQUARED:   return acceleration * 1.20e+01;
                case AccelerationConversionType.FOOT_PER_SECOND_SQUARED_TO_STANDARD_ACCELERATION_OF_GRAVITY:  return acceleration * 3.108095017156725e-02;
                case AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_METER_PER_SECOND_SQUARED:  return acceleration * 9.80665;
                case AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_INCH_PER_SECOND_SQUARED:  return acceleration * 3.860885826771653e+02;
                case AccelerationConversionType.STANDARD_ACCELERATION_OF_GRAVITY_TO_FOOT_PER_SECOND_SQUARED:  return acceleration * 3.217404855643044e+01;
                default: throw new ArgumentException("Unknown AccelerationConversionType");
            }
        }
    }
}

