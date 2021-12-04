using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum PowerConversionType {
            BTU_PER_HOUR_TO_TON_REFRIGERATION,
            BTU_PER_HOUR_TO_WATT,
            BTU_PER_HOUR_TO_KILOWATT,
            BTU_PER_HOUR_TO_HORSEPOWER,
            BTU_PER_HOUR_TO_FOOT_POUND_FORCE_PER_SECOND,
            BTU_PER_HOUR_TO_BTU_PER_SECOND,
            BTU_PER_HOUR_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            BTU_PER_HOUR_TO_WATT_ELECTRIC,
            TON_REFRIGERATION_TO_BTU_PER_HOUR,
            TON_REFRIGERATION_TO_KILOWATT,
            TON_REFRIGERATION_TO_WATT,
            TON_REFRIGERATION_TO_HORSEPOWER,
            TON_REFRIGERATION_TO_FOOT_POUND_FORCE_PER_SECOND,
            TON_REFRIGERATION_TO_BTU_PER_SECOND,
            TON_REFRIGERATION_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            TON_REFRIGERATION_TO_WATT_ELECTRIC,
            KILOWATT_TO_TON_REFRIGERATION,
            KILOWATT_TO_BTU_PER_SECOND,
            KILOWATT_TO_BTU_PER_HOUR,
            KILOWATT_TO_WATT,
            KILOWATT_TO_HORSEPOWER,
            KILOWATT_TO_FOOT_POUND_FORCE_PER_SECOND,
            KILOWATT_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            KILOWATT_TO_WATT_ELECTRIC,
            BTU_PER_SECOND_TO_KILOWATT,
            BTU_PER_SECOND_TO_TON_REFRIGERATION,
            BTU_PER_SECOND_TO_BTU_PER_HOUR,
            BTU_PER_SECOND_TO_WATT,
            BTU_PER_SECOND_TO_HORSEPOWER,
            BTU_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND,
            BTU_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            BTU_PER_SECOND_TO_WATT_ELECTRIC,
            WATT_TO_BTU_PER_HOUR,
            WATT_TO_HORSEPOWER,
            WATT_TO_FOOT_POUND_FORCE_PER_SECOND,
            WATT_TO_TON_REFRIGERATION,
            WATT_TO_KILOWATT,
            WATT_TO_BTU_PER_SECOND,
            WATT_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            WATT_TO_WATT_ELECTRIC,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_HORSEPOWER,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT_ELECTRIC,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_HOUR,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_TON_REFRIGERATION,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_KILOWATT,
            FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_SECOND,
            HORSEPOWER_TO_WATT,
            HORSEPOWER_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            HORSEPOWER_TO_WATT_ELECTRIC,
            HORSEPOWER_TO_BTU_PER_HOUR,
            HORSEPOWER_TO_FOOT_POUND_FORCE_PER_SECOND,
            HORSEPOWER_TO_TON_REFRIGERATION,
            HORSEPOWER_TO_KILOWATT,
            HORSEPOWER_TO_BTU_PER_SECOND,
            WATT_ELECTRIC_TO_HORSEPOWER,
            WATT_ELECTRIC_TO_WATT,
            WATT_ELECTRIC_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            WATT_ELECTRIC_TO_BTU_PER_HOUR,
            WATT_ELECTRIC_TO_FOOT_POUND_FORCE_PER_SECOND,
            WATT_ELECTRIC_TO_TON_REFRIGERATION,
            WATT_ELECTRIC_TO_KILOWATT,
            WATT_ELECTRIC_TO_BTU_PER_SECOND,
            FOOT_POUND_FORCE_PER_SECOND_TO_WATT,
            FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_HOUR,
            FOOT_POUND_FORCE_PER_SECOND_TO_HORSEPOWER,
            FOOT_POUND_FORCE_PER_SECOND_TO_TON_REFRIGERATION,
            FOOT_POUND_FORCE_PER_SECOND_TO_KILOWATT,
            FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_SECOND,
            FOOT_POUND_FORCE_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND,
            FOOT_POUND_FORCE_PER_SECOND_TO_WATT_ELECTRIC
        };
        
        public static double ConvertPower(double power, PowerConversionType conversionType)
        {
            switch(conversionType)
            {
                case PowerConversionType.BTU_PER_HOUR_TO_TON_REFRIGERATION:                           return power * 8.333333333333333e-05;
                case PowerConversionType.BTU_PER_HOUR_TO_WATT:                                        return power * 0.29307107;
                case PowerConversionType.BTU_PER_HOUR_TO_KILOWATT:                                    return power * 2.930710416666666e-04;
                case PowerConversionType.BTU_PER_HOUR_TO_HORSEPOWER:                                  return power * 3.930147784710899e-04;
                case PowerConversionType.BTU_PER_HOUR_TO_FOOT_POUND_FORCE_PER_SECOND:                 return power * 2.161581282801879e-01;
                case PowerConversionType.BTU_PER_HOUR_TO_BTU_PER_SECOND:                              return power * 2.777777119571535e-04;
                case PowerConversionType.BTU_PER_HOUR_TO_FOOT_POUNDS_FORCE_PER_SECOND:                return power * 2.161581281590995e-01;
                case PowerConversionType.BTU_PER_HOUR_TO_WATT_ELECTRIC:                               return power * 2.931890247394331e-01;
                case PowerConversionType.TON_REFRIGERATION_TO_BTU_PER_HOUR:                           return power * 12000;
                case PowerConversionType.TON_REFRIGERATION_TO_KILOWATT:                               return power * 3.5168525;
                case PowerConversionType.TON_REFRIGERATION_TO_WATT:                                   return power * 3.516852840e+03;
                case PowerConversionType.TON_REFRIGERATION_TO_HORSEPOWER:                             return power * 4.716177341653079;
                case PowerConversionType.TON_REFRIGERATION_TO_FOOT_POUND_FORCE_PER_SECOND:            return power * 2.593897539362255e+03;
                case PowerConversionType.TON_REFRIGERATION_TO_BTU_PER_SECOND:                         return power * 3.333332543485842;
                case PowerConversionType.TON_REFRIGERATION_TO_FOOT_POUNDS_FORCE_PER_SECOND:           return power * 2.593897537909194e+03;
                case PowerConversionType.TON_REFRIGERATION_TO_WATT_ELECTRIC:                          return power * 3.518268296873197e+03;
                case PowerConversionType.KILOWATT_TO_TON_REFRIGERATION:                               return power * 2.843451637508255e-01;
                case PowerConversionType.KILOWATT_TO_BTU_PER_SECOND:                                  return power * 9.478169879134378e-01;
                case PowerConversionType.KILOWATT_TO_BTU_PER_HOUR:                                    return power * 3.412141965009906e+03;
                case PowerConversionType.KILOWATT_TO_WATT:                                            return power * 1.000000096677356e+03;
                case PowerConversionType.KILOWATT_TO_HORSEPOWER:                                      return power * 1.341022218490278;
                case PowerConversionType.KILOWATT_TO_FOOT_POUND_FORCE_PER_SECOND:                     return power * 7.375622205828238e+02;
                case PowerConversionType.KILOWATT_TO_FOOT_POUNDS_FORCE_PER_SECOND:                    return power * 7.375622201696530e+02;
                case PowerConversionType.KILOWATT_TO_WATT_ELECTRIC:                                   return power * 1.000402574993747e+03;
                case PowerConversionType.BTU_PER_SECOND_TO_KILOWATT:                                  return power * 1.055056;
                case PowerConversionType.BTU_PER_SECOND_TO_TON_REFRIGERATION:                         return power * 3.000000710862910e-01;
                case PowerConversionType.BTU_PER_SECOND_TO_BTU_PER_HOUR:                              return power * 3.600000853035491e+03;
                case PowerConversionType.BTU_PER_SECOND_TO_WATT:                                      return power * 1.055056102000025e+03;
                case PowerConversionType.BTU_PER_SECOND_TO_HORSEPOWER:                                return power * 1.414853537751479;
                case PowerConversionType.BTU_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND:               return power * 7.781694461992317e+02;
                case PowerConversionType.BTU_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND:              return power * 7.781694457633133e+02;
                case PowerConversionType.BTU_PER_SECOND_TO_WATT_ELECTRIC:                             return power * 1.055480739162603e+03;
                case PowerConversionType.WATT_TO_BTU_PER_HOUR:                                        return power * 3.412141635133076;
                case PowerConversionType.WATT_TO_HORSEPOWER:                                          return power * 1.341022088843808e-03;
                case PowerConversionType.WATT_TO_FOOT_POUND_FORCE_PER_SECOND:                         return power * 7.375621492772654e-01;
                case PowerConversionType.WATT_TO_TON_REFRIGERATION:                                   return power * 2.843451362610897e-04;
                case PowerConversionType.WATT_TO_KILOWATT:                                            return power * 9.999999033226536e-04;
                case PowerConversionType.WATT_TO_BTU_PER_SECOND:                                      return power * 9.478168962810063e-04;
                case PowerConversionType.WATT_TO_FOOT_POUNDS_FORCE_PER_SECOND:                        return power * 7.375621488640948e-01;
                case PowerConversionType.WATT_TO_WATT_ELECTRIC:                                       return power * 1.000402478277481;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_HORSEPOWER:                  return power * 1.818181818181818e-03;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT:                        return power * 1.355817949090909;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_WATT_ELECTRIC:               return power * 1.356363636363636;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_HOUR:                return power * 4.626242873753828;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_FOOT_POUND_FORCE_PER_SECOND:  return power * 1.000000000560185;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_TON_REFRIGERATION:           return power * 3.855202394794857e-04;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_KILOWATT:                    return power * 1.355817818014027e-03;
                case PowerConversionType.FOOT_POUNDS_FORCE_PER_SECOND_TO_BTU_PER_SECOND:              return power * 1.285067160429425e-03;
                case PowerConversionType.HORSEPOWER_TO_WATT:                                          return power * 745.699872;
                case PowerConversionType.HORSEPOWER_TO_FOOT_POUNDS_FORCE_PER_SECOND:                  return power * 550;
                case PowerConversionType.HORSEPOWER_TO_WATT_ELECTRIC:                                 return power * 746;
                case PowerConversionType.HORSEPOWER_TO_BTU_PER_HOUR:                                  return power * 2.544433580564606e+03;
                case PowerConversionType.HORSEPOWER_TO_FOOT_POUND_FORCE_PER_SECOND:                   return power * 5.500000003081017e+02;
                case PowerConversionType.HORSEPOWER_TO_TON_REFRIGERATION:                             return power * 2.120361317137171e-01;
                case PowerConversionType.HORSEPOWER_TO_KILOWATT:                                      return power * 7.456997999077152e-01;
                case PowerConversionType.HORSEPOWER_TO_BTU_PER_SECOND:                                return power * 7.067869382361837e-01;
                case PowerConversionType.WATT_ELECTRIC_TO_HORSEPOWER:                                 return power * 1.340482573726542e-03;
                case PowerConversionType.WATT_ELECTRIC_TO_WATT:                                       return power * 9.995976836461130e-01;
                case PowerConversionType.WATT_ELECTRIC_TO_FOOT_POUNDS_FORCE_PER_SECOND:               return power * 7.372654155495981e-01;
                case PowerConversionType.WATT_ELECTRIC_TO_BTU_PER_HOUR:                               return power * 3.410768874751484;
                case PowerConversionType.WATT_ELECTRIC_TO_FOOT_POUND_FORCE_PER_SECOND:                return power * 7.372654159626031e-01;
                case PowerConversionType.WATT_ELECTRIC_TO_TON_REFRIGERATION:                          return power * 2.842307395626236e-04;
                case PowerConversionType.WATT_ELECTRIC_TO_KILOWATT:                                   return power * 9.995975870076615e-04;
                case PowerConversionType.WATT_ELECTRIC_TO_BTU_PER_SECOND:                             return power * 9.474355740431420e-04;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_WATT:                         return power * 1.3558179483314004;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_HOUR:                 return power * 4.626242871162277;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_HORSEPOWER:                   return power * 1.818181817163301e-03;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_TON_REFRIGERATION:            return power * 3.855202392635231e-04;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_KILOWATT:                     return power * 1.355817817254519e-03;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_BTU_PER_SECOND:               return power * 1.285067159709550e-03;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_FOOT_POUNDS_FORCE_PER_SECOND:  return power * 9.999999994398159e-01;
                case PowerConversionType.FOOT_POUND_FORCE_PER_SECOND_TO_WATT_ELECTRIC:                return power * 1.356363635603822;
                default: throw new ArgumentException("Unknown PowerConversionType");
            }
        }
    }
}

