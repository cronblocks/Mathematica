using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum AreaConversionType {
            SQUARE_METER_TO_ACRE,
            SQUARE_METER_TO_SQUARE_FOOT,
            SQUARE_METER_TO_SQUARE_YARD,
            SQUARE_METER_TO_HECTARE,
            ACRE_TO_SQUARE_METER,
            ACRE_TO_HECTARE,
            ACRE_TO_SQUARE_FOOT,
            ACRE_TO_SQUARE_YARD,
            HECTARE_TO_ACRE,
            HECTARE_TO_SQUARE_METER,
            HECTARE_TO_SQUARE_FOOT,
            HECTARE_TO_SQUARE_YARD,
            SQUARE_MILLIMETER_TO_CIRCULAR_MIL,
            SQUARE_MILLIMETER_TO_SQUARE_INCH,
            SQUARE_MILLIMETER_TO_SQUARE_CENTIMETER,
            CIRCULAR_MIL_TO_SQUARE_MILLIMETER,
            CIRCULAR_MIL_TO_SQUARE_INCH,
            CIRCULAR_MIL_TO_SQUARE_CENTIMETER,
            SQUARE_CENTIMETER_TO_SQUARE_INCH,
            SQUARE_CENTIMETER_TO_SQUARE_MILLIMETER,
            SQUARE_CENTIMETER_TO_CIRCULAR_MIL,
            SQUARE_INCH_TO_SQUARE_MILLIMETER,
            SQUARE_INCH_TO_SQUARE_CENTIMETER,
            SQUARE_INCH_TO_CIRCULAR_MIL,
            SQUARE_FOOT_TO_SQUARE_METER,
            SQUARE_FOOT_TO_ACRE,
            SQUARE_FOOT_TO_SQUARE_YARD,
            SQUARE_FOOT_TO_HECTARE,
            SQUARE_YARD_TO_SQUARE_METER,
            SQUARE_YARD_TO_ACRE,
            SQUARE_YARD_TO_SQUARE_FOOT,
            SQUARE_YARD_TO_HECTARE,
            SQUARE_KILOMETER_TO_SQUARE_MILE,
            SQUARE_MILE_TO_SQUARE_KILOMETER
        };
        
        public static double ConvertArea(double area, AreaConversionType conversionType)
        {
            switch(conversionType)
            {
                case AreaConversionType.SQUARE_METER_TO_ACRE:                                         return area * 2.471043692253253e-04;
                case AreaConversionType.SQUARE_METER_TO_SQUARE_FOOT:                                  return area * 1.076391041670972e+01;
                case AreaConversionType.SQUARE_METER_TO_SQUARE_YARD:                                  return area * 1.195990046301080;
                case AreaConversionType.SQUARE_METER_TO_HECTARE:                                      return area * 9.999999999999999e-05;
                case AreaConversionType.ACRE_TO_SQUARE_METER:                                         return area * 4046.873;
                case AreaConversionType.ACRE_TO_HECTARE:                                              return area * 0.4046873;
                case AreaConversionType.ACRE_TO_SQUARE_FOOT:                                          return area * 4.356017843980132e+04;
                case AreaConversionType.ACRE_TO_SQUARE_YARD:                                          return area * 4.840019826644590e+03;
                case AreaConversionType.HECTARE_TO_ACRE:                                              return area * 2.471043692253253;
                case AreaConversionType.HECTARE_TO_SQUARE_METER:                                      return area * 9.999999999999998e+03;
                case AreaConversionType.HECTARE_TO_SQUARE_FOOT:                                       return area * 1.076391041670972e+05;
                case AreaConversionType.HECTARE_TO_SQUARE_YARD:                                       return area * 1.195990046301080e+04;
                case AreaConversionType.SQUARE_MILLIMETER_TO_CIRCULAR_MIL:                            return area * 1.973525241769719e+03;
                case AreaConversionType.SQUARE_MILLIMETER_TO_SQUARE_INCH:                             return area * 1.55000310000620e-03;
                case AreaConversionType.SQUARE_MILLIMETER_TO_SQUARE_CENTIMETER:                       return area * 1.0e-02;
                case AreaConversionType.CIRCULAR_MIL_TO_SQUARE_MILLIMETER:                            return area * 0.000506707479;
                case AreaConversionType.CIRCULAR_MIL_TO_SQUARE_INCH:                                  return area * 7.853981632463265e-07;
                case AreaConversionType.CIRCULAR_MIL_TO_SQUARE_CENTIMETER:                            return area * 5.067074790e-06;
                case AreaConversionType.SQUARE_CENTIMETER_TO_SQUARE_INCH:                             return area * 1.55000310000620e-01;
                case AreaConversionType.SQUARE_CENTIMETER_TO_SQUARE_MILLIMETER:                       return area * 1.0e+02;
                case AreaConversionType.SQUARE_CENTIMETER_TO_CIRCULAR_MIL:                            return area * 1.973525241769719e+05;
                case AreaConversionType.SQUARE_INCH_TO_SQUARE_MILLIMETER:                             return area * 645.16;
                case AreaConversionType.SQUARE_INCH_TO_SQUARE_CENTIMETER:                             return area * 6.4516;
                case AreaConversionType.SQUARE_INCH_TO_CIRCULAR_MIL:                                  return area * 1.273239544980152e+06;
                case AreaConversionType.SQUARE_FOOT_TO_SQUARE_METER:                                  return area * 0.09290304;
                case AreaConversionType.SQUARE_FOOT_TO_ACRE:                                          return area * 2.295674709831516e-05;
                case AreaConversionType.SQUARE_FOOT_TO_SQUARE_YARD:                                   return area * 1.111111111111111e-01;
                case AreaConversionType.SQUARE_FOOT_TO_HECTARE:                                       return area * 9.290303999999999e-06;
                case AreaConversionType.SQUARE_YARD_TO_SQUARE_METER:                                  return area * 0.83612736;
                case AreaConversionType.SQUARE_YARD_TO_ACRE:                                          return area * 2.066107238848365e-04;
                case AreaConversionType.SQUARE_YARD_TO_SQUARE_FOOT:                                   return area * 8.999999999999998;
                case AreaConversionType.SQUARE_YARD_TO_HECTARE:                                       return area * 8.361273599999998e-05;
                case AreaConversionType.SQUARE_KILOMETER_TO_SQUARE_MILE:                              return area * 3.861021004533418e-01;
                case AreaConversionType.SQUARE_MILE_TO_SQUARE_KILOMETER:                              return area * 2.5899885;
                default: throw new ArgumentException("Unknown AreaConversionType");
            }
        }
    }
}

