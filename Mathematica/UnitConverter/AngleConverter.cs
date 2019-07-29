using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum AngleConversionType {
            DEGREE_TO_RADIAN, RADIAN_TO_DEGREE,
            DEGREE_TO_MIL, MIL_TO_DEGREE,
            DEGREE_TO_GRADIAN, GRADIAN_TO_DEGREE,
            DEGREE_TO_CIRCLE, CIRCLE_TO_DEGREE,
            DEGREE_TO_REVOLUTION, REVOLUTION_TO_DEGREE,
            DEGREE_TO_SEMICIRCLE, SEMICIRCLE_TO_DEGREE
        };

        public static double ConvertAngle(double angle, AngleConversionType conversionType)
        {
            switch(conversionType)
            {
                case AngleConversionType.DEGREE_TO_RADIAN:     return angle * Constants.PI / 180.0;
                case AngleConversionType.RADIAN_TO_DEGREE:     return angle * 180.0 / Constants.PI;
                case AngleConversionType.DEGREE_TO_MIL:        return angle * 17.7777777778;
                case AngleConversionType.MIL_TO_DEGREE:        return angle / 17.7777777778;
                case AngleConversionType.DEGREE_TO_GRADIAN:    return angle * 10.0 / 9.0;
                case AngleConversionType.GRADIAN_TO_DEGREE:    return angle * 9.0 / 10.0;
                case AngleConversionType.DEGREE_TO_CIRCLE:
                case AngleConversionType.DEGREE_TO_REVOLUTION: return angle / 360.0;
                case AngleConversionType.CIRCLE_TO_DEGREE:
                case AngleConversionType.REVOLUTION_TO_DEGREE: return angle * 360.0;
                case AngleConversionType.DEGREE_TO_SEMICIRCLE: return angle / 180.0;
                case AngleConversionType.SEMICIRCLE_TO_DEGREE: return angle * 180.0;
                default: throw new ArgumentException("Unknown AngleConversionType");
            }
        }
    }
}
