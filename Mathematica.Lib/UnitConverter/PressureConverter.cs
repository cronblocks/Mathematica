using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum PressureConversionType {
            KILOPASCAL_TO_STANDARD_ATMOSPHERE,
            KILOPASCAL_TO_BAR,
            KILOPASCAL_TO_MILLIBAR,
            KILOPASCAL_TO_POUND_FORCE_PER_SQ_INCH,
            KILOPASCAL_TO_POUND_FORCE_PER_SQ_FOOT,
            KILOPASCAL_TO_INCH_OF_MERCURY_32_F,
            KILOPASCAL_TO_FOOT_OF_WATER_39P2_F,
            KILOPASCAL_TO_INCH_OF_WATER_39P2_F,
            KILOPASCAL_TO_MILLIMETER_OF_MERCURY_32_F,
            STANDARD_ATMOSPHERE_TO_KILOPASCAL,
            STANDARD_ATMOSPHERE_TO_BAR,
            STANDARD_ATMOSPHERE_TO_MILLIBAR,
            STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_INCH,
            STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_FOOT,
            STANDARD_ATMOSPHERE_TO_INCH_OF_MERCURY_32_F,
            STANDARD_ATMOSPHERE_TO_FOOT_OF_WATER_39P2_F,
            STANDARD_ATMOSPHERE_TO_INCH_OF_WATER_39P2_F,
            STANDARD_ATMOSPHERE_TO_MILLIMETER_OF_MERCURY_32_F,
            BAR_TO_KILOPASCAL,
            BAR_TO_STANDARD_ATMOSPHERE,
            BAR_TO_MILLIBAR,
            BAR_TO_POUND_FORCE_PER_SQ_INCH,
            BAR_TO_POUND_FORCE_PER_SQ_FOOT,
            BAR_TO_INCH_OF_MERCURY_32_F,
            BAR_TO_FOOT_OF_WATER_39P2_F,
            BAR_TO_INCH_OF_WATER_39P2_F,
            BAR_TO_MILLIMETER_OF_MERCURY_32_F,
            MILLIBAR_TO_KILOPASCAL,
            MILLIBAR_TO_STANDARD_ATMOSPHERE,
            MILLIBAR_TO_BAR,
            MILLIBAR_TO_POUND_FORCE_PER_SQ_INCH,
            MILLIBAR_TO_POUND_FORCE_PER_SQ_FOOT,
            MILLIBAR_TO_INCH_OF_MERCURY_32_F,
            MILLIBAR_TO_FOOT_OF_WATER_39P2_F,
            MILLIBAR_TO_INCH_OF_WATER_39P2_F,
            MILLIBAR_TO_MILLIMETER_OF_MERCURY_32_F,
            POUND_FORCE_PER_SQ_INCH_TO_KILOPASCAL,
            POUND_FORCE_PER_SQ_INCH_TO_STANDARD_ATMOSPHERE,
            POUND_FORCE_PER_SQ_INCH_TO_BAR,
            POUND_FORCE_PER_SQ_INCH_TO_MILLIBAR,
            POUND_FORCE_PER_SQ_INCH_TO_POUND_FORCE_PER_SQ_FOOT,
            POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_MERCURY_32_F,
            POUND_FORCE_PER_SQ_INCH_TO_FOOT_OF_WATER_39P2_F,
            POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_WATER_39P2_F,
            POUND_FORCE_PER_SQ_INCH_TO_MILLIMETER_OF_MERCURY_32_F,
            MEGAPASCAL_TO_KILOPOUND_FORCE_PER_SQ_INCH,
            KILOPOUND_FORCE_PER_SQ_INCH_TO_MEGAPASCAL,
            POUND_FORCE_PER_SQ_FOOT_TO_KILOPASCAL,
            POUND_FORCE_PER_SQ_FOOT_TO_STANDARD_ATMOSPHERE,
            POUND_FORCE_PER_SQ_FOOT_TO_BAR,
            POUND_FORCE_PER_SQ_FOOT_TO_MILLIBAR,
            POUND_FORCE_PER_SQ_FOOT_TO_POUND_FORCE_PER_SQ_INCH,
            POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_MERCURY_32_F,
            POUND_FORCE_PER_SQ_FOOT_TO_FOOT_OF_WATER_39P2_F,
            POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_WATER_39P2_F,
            POUND_FORCE_PER_SQ_FOOT_TO_MILLIMETER_OF_MERCURY_32_F,
            INCH_OF_MERCURY_32_F_TO_KILOPASCAL,
            INCH_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE,
            INCH_OF_MERCURY_32_F_TO_BAR,
            INCH_OF_MERCURY_32_F_TO_MILLIBAR,
            INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH,
            INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT,
            INCH_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F,
            INCH_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F,
            INCH_OF_MERCURY_32_F_TO_MILLIMETER_OF_MERCURY_32_F,
            FOOT_OF_WATER_39P2_F_TO_KILOPASCAL,
            FOOT_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE,
            FOOT_OF_WATER_39P2_F_TO_BAR,
            FOOT_OF_WATER_39P2_F_TO_MILLIBAR,
            FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH,
            FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT,
            FOOT_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F,
            FOOT_OF_WATER_39P2_F_TO_INCH_OF_WATER_39P2_F,
            FOOT_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F,
            INCH_OF_WATER_39P2_F_TO_KILOPASCAL,
            INCH_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE,
            INCH_OF_WATER_39P2_F_TO_BAR,
            INCH_OF_WATER_39P2_F_TO_MILLIBAR,
            INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH,
            INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT,
            INCH_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F,
            INCH_OF_WATER_39P2_F_TO_FOOT_OF_WATER_39P2_F,
            INCH_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F,
            MILLIMETER_OF_MERCURY_32_F_TO_KILOPASCAL,
            MILLIMETER_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE,
            MILLIMETER_OF_MERCURY_32_F_TO_BAR,
            MILLIMETER_OF_MERCURY_32_F_TO_MILLIBAR,
            MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH,
            MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT,
            MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_MERCURY_32_F,
            MILLIMETER_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F,
            MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F,
            PASCAL_TO_TORR,
            TORR_TO_PASCAL
        };
        
        public static double ConvertPressure(double pressure, PressureConversionType conversionType)
        {
            switch(conversionType)
            {
                case PressureConversionType.KILOPASCAL_TO_STANDARD_ATMOSPHERE:                        return pressure * 9.869232667160128e-03;
                case PressureConversionType.KILOPASCAL_TO_BAR:                                        return pressure * 1.0e-02;
                case PressureConversionType.KILOPASCAL_TO_MILLIBAR:                                   return pressure * 1.0e+01;
                case PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_INCH:                    return pressure * 1.450377377299644e-01;
                case PressureConversionType.KILOPASCAL_TO_POUND_FORCE_PER_SQ_FOOT:                    return pressure * 2.088543423329662e+01;
                case PressureConversionType.KILOPASCAL_TO_INCH_OF_MERCURY_32_F:                       return pressure * 2.953005864669647e-01;
                case PressureConversionType.KILOPASCAL_TO_FOOT_OF_WATER_39P2_F:                       return pressure * 3.345622921531760e-01;
                case PressureConversionType.KILOPASCAL_TO_INCH_OF_WATER_39P2_F:                       return pressure * 4.014742133112790;
                case PressureConversionType.KILOPASCAL_TO_MILLIMETER_OF_MERCURY_32_F:                 return pressure * 7.500616827040158;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_KILOPASCAL:                        return pressure * 101.325;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_BAR:                               return pressure * 1.013250;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_MILLIBAR:                          return pressure * 1.013250e+03;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_INCH:           return pressure * 1.469594877548864e+01;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_POUND_FORCE_PER_SQ_FOOT:           return pressure * 2.116216623688780e+03;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_INCH_OF_MERCURY_32_F:              return pressure * 2.992133192376520e+01;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_FOOT_OF_WATER_39P2_F:              return pressure * 3.389952425242056e+01;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_INCH_OF_WATER_39P2_F:              return pressure * 4.067937466376535e+02;
                case PressureConversionType.STANDARD_ATMOSPHERE_TO_MILLIMETER_OF_MERCURY_32_F:        return pressure * 7.599999999998440e+02;
                case PressureConversionType.BAR_TO_KILOPASCAL:                                        return pressure * 100;
                case PressureConversionType.BAR_TO_STANDARD_ATMOSPHERE:                               return pressure * 9.869232667160128e-01;
                case PressureConversionType.BAR_TO_MILLIBAR:                                          return pressure * 1.0e+03;
                case PressureConversionType.BAR_TO_POUND_FORCE_PER_SQ_INCH:                           return pressure * 1.450377377299644e+01;
                case PressureConversionType.BAR_TO_POUND_FORCE_PER_SQ_FOOT:                           return pressure * 2.088543423329662e+03;
                case PressureConversionType.BAR_TO_INCH_OF_MERCURY_32_F:                              return pressure * 2.953005864669647e+01;
                case PressureConversionType.BAR_TO_FOOT_OF_WATER_39P2_F:                              return pressure * 3.345622921531760e+01;
                case PressureConversionType.BAR_TO_INCH_OF_WATER_39P2_F:                              return pressure * 4.014742133112790e+02;
                case PressureConversionType.BAR_TO_MILLIMETER_OF_MERCURY_32_F:                        return pressure * 7.500616827040158e+02;
                case PressureConversionType.MILLIBAR_TO_KILOPASCAL:                                   return pressure * 0.1;
                case PressureConversionType.MILLIBAR_TO_STANDARD_ATMOSPHERE:                          return pressure * 9.869232667160128e-04;
                case PressureConversionType.MILLIBAR_TO_BAR:                                          return pressure * 1.0e-03;
                case PressureConversionType.MILLIBAR_TO_POUND_FORCE_PER_SQ_INCH:                      return pressure * 1.450377377299644e-02;
                case PressureConversionType.MILLIBAR_TO_POUND_FORCE_PER_SQ_FOOT:                      return pressure * 2.088543423329662;
                case PressureConversionType.MILLIBAR_TO_INCH_OF_MERCURY_32_F:                         return pressure * 2.953005864669647e-02;
                case PressureConversionType.MILLIBAR_TO_FOOT_OF_WATER_39P2_F:                         return pressure * 3.345622921531760e-02;
                case PressureConversionType.MILLIBAR_TO_INCH_OF_WATER_39P2_F:                         return pressure * 4.014742133112790e-01;
                case PressureConversionType.MILLIBAR_TO_MILLIMETER_OF_MERCURY_32_F:                   return pressure * 7.500616827040159e-01;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_KILOPASCAL:                    return pressure * 6.89475729318;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_STANDARD_ATMOSPHERE:           return pressure * 6.804596390999260e-02;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_BAR:                           return pressure * 6.894757293180e-02;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_MILLIBAR:                      return pressure * 6.894757293180e+01;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_POUND_FORCE_PER_SQ_FOOT:       return pressure * 1.440000000012531e+02;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_MERCURY_32_F:          return pressure * 2.036025872223436;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_FOOT_OF_WATER_39P2_F:          return pressure * 2.306725803846128;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_INCH_OF_WATER_39P2_F:          return pressure * 2.768067260251644e+01;
                case PressureConversionType.POUND_FORCE_PER_SQ_INCH_TO_MILLIMETER_OF_MERCURY_32_F:    return pressure * 5.171493257158376e+01;
                case PressureConversionType.MEGAPASCAL_TO_KILOPOUND_FORCE_PER_SQ_INCH:                return pressure * 1.450377377299644e-01;
                case PressureConversionType.KILOPOUND_FORCE_PER_SQ_INCH_TO_MEGAPASCAL:                return pressure * 6.89475729318;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_KILOPASCAL:                    return pressure * 0.04788025898;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_STANDARD_ATMOSPHERE:           return pressure * 4.725414160375030e-04;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_BAR:                           return pressure * 4.7880258980e-04;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_MILLIBAR:                      return pressure * 4.7880258980e-01;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_POUND_FORCE_PER_SQ_INCH:       return pressure * 6.944444444384012e-03;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_MERCURY_32_F:          return pressure * 1.413906855698415e-02;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_FOOT_OF_WATER_39P2_F:          return pressure * 1.601892919323649e-02;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_INCH_OF_WATER_39P2_F:          return pressure * 1.922268930713580e-01;
                case PressureConversionType.POUND_FORCE_PER_SQ_FOOT_TO_MILLIMETER_OF_MERCURY_32_F:    return pressure * 3.591314761884286e-01;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_KILOPASCAL:                       return pressure * 3.38638;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE:              return pressure * 3.342097211941771e-02;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_BAR:                              return pressure * 3.386380e-02;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_MILLIBAR:                         return pressure * 3.386380e+01;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH:          return pressure * 4.911528942939968e-01;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT:          return pressure * 7.072601677895101e+01;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F:             return pressure * 1.132955054901672;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F:             return pressure * 1.359544246473049e+01;
                case PressureConversionType.INCH_OF_MERCURY_32_F_TO_MILLIMETER_OF_MERCURY_32_F:       return pressure * 2.539993881075225e+01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_KILOPASCAL:                       return pressure * 2.98898;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE:              return pressure * 2.949893905748828e-02;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_BAR:                              return pressure * 2.988980e-02;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_MILLIBAR:                         return pressure * 2.988980e+01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH:          return pressure * 4.335148973201090e-01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT:          return pressure * 6.242614521463894e+01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F:             return pressure * 8.826475469380283e-01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_INCH_OF_WATER_39P2_F:             return pressure * 1.199998394103147e+01;
                case PressureConversionType.FOOT_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F:       return pressure * 2.241919368368649e+01;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_KILOPASCAL:                       return pressure * 0.249082;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_STANDARD_ATMOSPHERE:              return pressure * 2.458248211201579e-03;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_BAR:                              return pressure * 2.490820e-03;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_MILLIBAR:                         return pressure * 2.490820;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_INCH:          return pressure * 3.612628978925499e-02;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_POUND_FORCE_PER_SQ_FOOT:          return pressure * 5.202185729697989;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_INCH_OF_MERCURY_32_F:             return pressure * 7.355406067836451e-02;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_FOOT_OF_WATER_39P2_F:             return pressure * 8.333344485409738e-02;
                case PressureConversionType.INCH_OF_WATER_39P2_F_TO_MILLIMETER_OF_MERCURY_32_F:       return pressure * 1.868268640512817;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_KILOPASCAL:                 return pressure * 0.13332236842108;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_STANDARD_ATMOSPHERE:        return pressure * 1.315789473684481e-03;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_BAR:                        return pressure * 1.33322368421080e-03;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_MILLIBAR:                   return pressure * 1.33322368421080;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_INCH:    return pressure * 1.933677470459429e-02;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_POUND_FORCE_PER_SQ_FOOT:    return pressure * 2.784495557485809;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_MERCURY_32_F:       return pressure * 3.937017358390966e-02;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_FOOT_OF_WATER_39P2_F:       return pressure * 4.460463717424674e-02;
                case PressureConversionType.MILLIMETER_OF_MERCURY_32_F_TO_INCH_OF_WATER_39P2_F:       return pressure * 5.352549297864960e-01;
                case PressureConversionType.PASCAL_TO_TORR:                                           return pressure * 7.500615050434136e-03;
                case PressureConversionType.TORR_TO_PASCAL:                                           return pressure * 133.3224;
                default: throw new ArgumentException("Unknown PressureConversionType");
            }
        }
    }
}

