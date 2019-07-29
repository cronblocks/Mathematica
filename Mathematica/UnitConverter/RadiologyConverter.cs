using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum RadiologyConversionType {
            MEGABECQUEREL_TO_CURIE,
            CURIE_TO_MEGABECQUEREL,
            GRAY_TO_RAD,
            RAD_TO_GRAY,
            SIEVERT_TO_REM,
            SIEVERT_TO_MILLISIEVERT,
            SIEVERT_TO_MILLIREM,
            SIEVERT_TO_MICROSIEVERT,
            REM_TO_SIEVERT,
            REM_TO_MILLISIEVERT,
            REM_TO_MILLIREM,
            REM_TO_MICROSIEVERT,
            MILLISIEVERT_TO_REM,
            MILLISIEVERT_TO_MILLIREM,
            MILLISIEVERT_TO_SIEVERT,
            MILLISIEVERT_TO_MICROSIEVERT,
            MILLIREM_TO_MILLISIEVERT,
            MILLIREM_TO_MICROSIEVERT,
            MILLIREM_TO_REM,
            MILLIREM_TO_SIEVERT,
            MICROSIEVERT_TO_MILLIREM,
            MICROSIEVERT_TO_MILLISIEVERT,
            MICROSIEVERT_TO_REM,
            MICROSIEVERT_TO_SIEVERT,
            COULOMB_PER_KILOGRAM_TO_ROENTGEN,
            ROENTGEN_TO_COULOMB_PER_KILOGRAM
        };
        
        public static double ConvertRadiology(double radiology, RadiologyConversionType conversionType)
        {
            switch(conversionType)
            {
                case RadiologyConversionType.MEGABECQUEREL_TO_CURIE:                                  return radiology * 2.702702702702703e-05;
                case RadiologyConversionType.CURIE_TO_MEGABECQUEREL:                                  return radiology * 37000;
                case RadiologyConversionType.GRAY_TO_RAD:                                             return radiology * 1.0e+02;
                case RadiologyConversionType.RAD_TO_GRAY:                                             return radiology * 0.01;
                case RadiologyConversionType.SIEVERT_TO_REM:                                          return radiology * 1.0e+02;
                case RadiologyConversionType.SIEVERT_TO_MILLISIEVERT:                                 return radiology * 1.0e+03;
                case RadiologyConversionType.SIEVERT_TO_MILLIREM:                                     return radiology * 1.0e+05;
                case RadiologyConversionType.SIEVERT_TO_MICROSIEVERT:                                 return radiology * 1.0e+06;
                case RadiologyConversionType.REM_TO_SIEVERT:                                          return radiology * 0.01;
                case RadiologyConversionType.REM_TO_MILLISIEVERT:                                     return radiology * 10;
                case RadiologyConversionType.REM_TO_MILLIREM:                                         return radiology * 1.0e+03;
                case RadiologyConversionType.REM_TO_MICROSIEVERT:                                     return radiology * 1.0e+04;
                case RadiologyConversionType.MILLISIEVERT_TO_REM:                                     return radiology * 1.0e-01;
                case RadiologyConversionType.MILLISIEVERT_TO_MILLIREM:                                return radiology * 1.0e+02;
                case RadiologyConversionType.MILLISIEVERT_TO_SIEVERT:                                 return radiology * 1.0e-03;
                case RadiologyConversionType.MILLISIEVERT_TO_MICROSIEVERT:                            return radiology * 1.0e+03;
                case RadiologyConversionType.MILLIREM_TO_MILLISIEVERT:                                return radiology * 0.01;
                case RadiologyConversionType.MILLIREM_TO_MICROSIEVERT:                                return radiology * 10;
                case RadiologyConversionType.MILLIREM_TO_REM:                                         return radiology * 1.0e-03;
                case RadiologyConversionType.MILLIREM_TO_SIEVERT:                                     return radiology * 1.0e-05;
                case RadiologyConversionType.MICROSIEVERT_TO_MILLIREM:                                return radiology * 1.0e-01;
                case RadiologyConversionType.MICROSIEVERT_TO_MILLISIEVERT:                            return radiology * 1.0e-03;
                case RadiologyConversionType.MICROSIEVERT_TO_REM:                                     return radiology * 1.0e-04;
                case RadiologyConversionType.MICROSIEVERT_TO_SIEVERT:                                 return radiology * 1.0e-06;
                case RadiologyConversionType.COULOMB_PER_KILOGRAM_TO_ROENTGEN:                        return radiology * 3.875968992248062e+03;
                case RadiologyConversionType.ROENTGEN_TO_COULOMB_PER_KILOGRAM:                        return radiology * 0.000258;
                default: throw new ArgumentException("Unknown RadiologyConversionType");
            }
        }
    }
}

