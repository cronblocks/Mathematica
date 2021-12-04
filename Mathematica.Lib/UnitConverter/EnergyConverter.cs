using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum EnergyConversionType {
            MEGAJOULE_TO_KILOWATTHOUR,
            MEGAJOULE_TO_THERM_US,
            MEGAJOULE_TO_HORSEPOWER_HOUR,
            KILOWATTHOUR_TO_MEGAJOULE,
            KILOWATTHOUR_TO_THERM_US,
            KILOWATTHOUR_TO_HORSEPOWER_HOUR,
            JOULE_TO_CALORIE_PHYSICS,
            JOULE_TO_FOOT_POUND_FORCE,
            CALORIE_PHYSICS_TO_JOULE,
            CALORIE_PHYSICS_TO_FOOT_POUND_FORCE,
            KILOJOULE_TO_CALORIE_NUTRITION,
            KILOJOULE_TO_BTU,
            CALORIE_NUTRITION_TO_KILOJOULE,
            CALORIE_NUTRITION_TO_BTU,
            BTU_TO_KILOJOULE,
            BTU_TO_CALORIE_NUTRITION,
            THERM_US_TO_MEGAJOULE,
            THERM_US_TO_KILOWATTHOUR,
            THERM_US_TO_HORSEPOWER_HOUR,
            HORSEPOWER_HOUR_TO_MEGAJOULE,
            HORSEPOWER_HOUR_TO_KILOWATTHOUR,
            HORSEPOWER_HOUR_TO_THERM_US,
            FOOT_POUND_FORCE_TO_JOULE,
            FOOT_POUND_FORCE_TO_CALORIE_PHYSICS
        };
        
        public static double ConvertEnergy(double energy, EnergyConversionType conversionType)
        {
            switch(conversionType)
            {
                case EnergyConversionType.MEGAJOULE_TO_KILOWATTHOUR:                                  return energy * 2.777777777777778e-01;
                case EnergyConversionType.MEGAJOULE_TO_THERM_US:                                      return energy * 9.480434279733486e-03;
                case EnergyConversionType.MEGAJOULE_TO_HORSEPOWER_HOUR:                               return energy * 3.725061361104841e-01;
                case EnergyConversionType.KILOWATTHOUR_TO_MEGAJOULE:                                  return energy * 3.6;
                case EnergyConversionType.KILOWATTHOUR_TO_THERM_US:                                   return energy * 3.412956340704055e-02;
                case EnergyConversionType.KILOWATTHOUR_TO_HORSEPOWER_HOUR:                            return energy * 1.341022089997743;
                case EnergyConversionType.JOULE_TO_CALORIE_PHYSICS:                                   return energy * 2.390057361376673e-01;
                case EnergyConversionType.JOULE_TO_FOOT_POUND_FORCE:                                  return energy * 7.375621492997871e-01;
                case EnergyConversionType.CALORIE_PHYSICS_TO_JOULE:                                   return energy * 4.184;
                case EnergyConversionType.CALORIE_PHYSICS_TO_FOOT_POUND_FORCE:                        return energy * 3.085960032670310;
                case EnergyConversionType.KILOJOULE_TO_CALORIE_NUTRITION:                             return energy * 2.388458966274959e-01;
                case EnergyConversionType.KILOJOULE_TO_BTU:                                           return energy * 9.478170777491506e-01;
                case EnergyConversionType.CALORIE_NUTRITION_TO_KILOJOULE:                             return energy * 4.1868;
                case EnergyConversionType.CALORIE_NUTRITION_TO_BTU:                                   return energy * 3.968320541120144;
                case EnergyConversionType.BTU_TO_KILOJOULE:                                           return energy * 1.0550559;
                case EnergyConversionType.BTU_TO_CALORIE_NUTRITION:                                   return energy * 2.519957724276296e-01;
                case EnergyConversionType.THERM_US_TO_MEGAJOULE:                                      return energy * 105.4804;
                case EnergyConversionType.THERM_US_TO_KILOWATTHOUR:                                   return energy * 2.930011111111111e+01;
                case EnergyConversionType.THERM_US_TO_HORSEPOWER_HOUR:                                return energy * 3.929209623938831e+01;
                case EnergyConversionType.HORSEPOWER_HOUR_TO_MEGAJOULE:                               return energy * 2.68451953689;
                case EnergyConversionType.HORSEPOWER_HOUR_TO_KILOWATTHOUR:                            return energy * 7.456998713583334e-01;
                case EnergyConversionType.HORSEPOWER_HOUR_TO_THERM_US:                                return energy * 2.545041104214622e-02;
                case EnergyConversionType.FOOT_POUND_FORCE_TO_JOULE:                                  return energy * 1.35581794829;
                case EnergyConversionType.FOOT_POUND_FORCE_TO_CALORIE_PHYSICS:                        return energy * 3.240482667997132e-01;
                default: throw new ArgumentException("Unknown EnergyConversionType");
            }
        }
    }
}

