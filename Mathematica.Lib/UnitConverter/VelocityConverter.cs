using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum VelocityConversionType {
            METER_PER_SECOND_TO_FOOT_PER_SECOND,
            FOOT_PER_SECOND_TO_METER_PER_SECOND,
            KILOMETER_PER_HOUR_TO_MILE_PER_HOUR,
            KILOMETER_PER_HOUR_TO_KNOT,
            MILE_PER_HOUR_TO_KILOMETER_PER_HOUR,
            MILE_PER_HOUR_TO_KNOT,
            KNOT_TO_KILOMETER_PER_HOUR,
            KNOT_TO_MILE_PER_HOUR
        };
        
        public static double ConvertVelocity(double velocity, VelocityConversionType conversionType)
        {
            switch(conversionType)
            {
                case VelocityConversionType.METER_PER_SECOND_TO_FOOT_PER_SECOND:                      return velocity * 3.280839895013123;
                case VelocityConversionType.FOOT_PER_SECOND_TO_METER_PER_SECOND:                      return velocity * 0.3048;
                case VelocityConversionType.KILOMETER_PER_HOUR_TO_MILE_PER_HOUR:                      return velocity * 6.213711922373339e-01;
                case VelocityConversionType.KILOMETER_PER_HOUR_TO_KNOT:                               return velocity * 5.399568034557235e-01;
                case VelocityConversionType.MILE_PER_HOUR_TO_KILOMETER_PER_HOUR:                      return velocity * 1.609344;
                case VelocityConversionType.MILE_PER_HOUR_TO_KNOT:                                    return velocity * 8.689762419006479e-01;
                case VelocityConversionType.KNOT_TO_KILOMETER_PER_HOUR:                               return velocity * 1.852;
                case VelocityConversionType.KNOT_TO_MILE_PER_HOUR:                                    return velocity * 1.150779448023542;
                default: throw new ArgumentException("Unknown VelocityConversionType");
            }
        }
    }
}

