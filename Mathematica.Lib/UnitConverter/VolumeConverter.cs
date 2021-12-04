using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum VolumeConversionType {
            CUBIC_METER_TO_ACRE_FOOT,
            CUBIC_METER_TO_BARREL_OIL,
            CUBIC_METER_TO_CUBIC_YARD,
            CUBIC_METER_TO_CUBIC_FOOT,
            CUBIC_METER_TO_BOARD_FOOT,
            CUBIC_METER_TO_REGISTER_TON,
            CUBIC_METER_TO_BUSHEL,
            CUBIC_METER_TO_US_GALLONS,
            CUBIC_METER_TO_LITER,
            CUBIC_METER_TO_GALLON,
            CUBIC_METER_TO_QUART_LIQUID,
            CUBIC_METER_TO_PINT_LIQUID,
            ACRE_FOOT_TO_CUBIC_METER,
            ACRE_FOOT_TO_BARREL_OIL,
            ACRE_FOOT_TO_CUBIC_YARD,
            ACRE_FOOT_TO_CUBIC_FOOT,
            ACRE_FOOT_TO_BOARD_FOOT,
            ACRE_FOOT_TO_REGISTER_TON,
            ACRE_FOOT_TO_BUSHEL,
            ACRE_FOOT_TO_US_GALLONS,
            ACRE_FOOT_TO_LITER,
            ACRE_FOOT_TO_GALLON,
            ACRE_FOOT_TO_QUART_LIQUID,
            ACRE_FOOT_TO_PINT_LIQUID,
            US_GALLONS_TO_BARREL_OIL,
            US_GALLONS_TO_CUBIC_METER,
            US_GALLONS_TO_LITER,
            US_GALLONS_TO_ACRE_FOOT,
            US_GALLONS_TO_CUBIC_YARD,
            US_GALLONS_TO_CUBIC_FOOT,
            US_GALLONS_TO_BOARD_FOOT,
            US_GALLONS_TO_REGISTER_TON,
            US_GALLONS_TO_BUSHEL,
            US_GALLONS_TO_GALLON,
            US_GALLONS_TO_QUART_LIQUID,
            US_GALLONS_TO_PINT_LIQUID,
            BARREL_OIL_TO_CUBIC_METER,
            BARREL_OIL_TO_US_GALLONS,
            BARREL_OIL_TO_LITER,
            BARREL_OIL_TO_ACRE_FOOT,
            BARREL_OIL_TO_CUBIC_YARD,
            BARREL_OIL_TO_CUBIC_FOOT,
            BARREL_OIL_TO_BOARD_FOOT,
            BARREL_OIL_TO_REGISTER_TON,
            BARREL_OIL_TO_BUSHEL,
            BARREL_OIL_TO_GALLON,
            BARREL_OIL_TO_QUART_LIQUID,
            BARREL_OIL_TO_PINT_LIQUID,
            LITER_TO_BARREL_OIL,
            LITER_TO_CUBIC_FOOT,
            LITER_TO_GALLON,
            LITER_TO_QUART_LIQUID,
            LITER_TO_PINT_LIQUID,
            LITER_TO_CUBIC_METER,
            LITER_TO_US_GALLONS,
            LITER_TO_ACRE_FOOT,
            LITER_TO_CUBIC_YARD,
            LITER_TO_BOARD_FOOT,
            LITER_TO_REGISTER_TON,
            LITER_TO_BUSHEL,
            CUBIC_YARD_TO_CUBIC_METER,
            CUBIC_YARD_TO_ACRE_FOOT,
            CUBIC_YARD_TO_BARREL_OIL,
            CUBIC_YARD_TO_CUBIC_FOOT,
            CUBIC_YARD_TO_BOARD_FOOT,
            CUBIC_YARD_TO_REGISTER_TON,
            CUBIC_YARD_TO_BUSHEL,
            CUBIC_YARD_TO_US_GALLONS,
            CUBIC_YARD_TO_LITER,
            CUBIC_YARD_TO_GALLON,
            CUBIC_YARD_TO_QUART_LIQUID,
            CUBIC_YARD_TO_PINT_LIQUID,
            CUBIC_FOOT_TO_CUBIC_METER,
            CUBIC_FOOT_TO_LITER,
            CUBIC_FOOT_TO_ACRE_FOOT,
            CUBIC_FOOT_TO_BARREL_OIL,
            CUBIC_FOOT_TO_CUBIC_YARD,
            CUBIC_FOOT_TO_BOARD_FOOT,
            CUBIC_FOOT_TO_REGISTER_TON,
            CUBIC_FOOT_TO_BUSHEL,
            CUBIC_FOOT_TO_US_GALLONS,
            CUBIC_FOOT_TO_GALLON,
            CUBIC_FOOT_TO_QUART_LIQUID,
            CUBIC_FOOT_TO_PINT_LIQUID,
            BOARD_FOOT_TO_CUBIC_METER,
            BOARD_FOOT_TO_ACRE_FOOT,
            BOARD_FOOT_TO_BARREL_OIL,
            BOARD_FOOT_TO_CUBIC_YARD,
            BOARD_FOOT_TO_CUBIC_FOOT,
            BOARD_FOOT_TO_REGISTER_TON,
            BOARD_FOOT_TO_BUSHEL,
            BOARD_FOOT_TO_US_GALLONS,
            BOARD_FOOT_TO_LITER,
            BOARD_FOOT_TO_GALLON,
            BOARD_FOOT_TO_QUART_LIQUID,
            BOARD_FOOT_TO_PINT_LIQUID,
            REGISTER_TON_TO_CUBIC_METER,
            REGISTER_TON_TO_ACRE_FOOT,
            REGISTER_TON_TO_BARREL_OIL,
            REGISTER_TON_TO_CUBIC_YARD,
            REGISTER_TON_TO_CUBIC_FOOT,
            REGISTER_TON_TO_BOARD_FOOT,
            REGISTER_TON_TO_BUSHEL,
            REGISTER_TON_TO_US_GALLONS,
            REGISTER_TON_TO_LITER,
            REGISTER_TON_TO_GALLON,
            REGISTER_TON_TO_QUART_LIQUID,
            REGISTER_TON_TO_PINT_LIQUID,
            BUSHEL_TO_CUBIC_METER,
            BUSHEL_TO_ACRE_FOOT,
            BUSHEL_TO_BARREL_OIL,
            BUSHEL_TO_CUBIC_YARD,
            BUSHEL_TO_CUBIC_FOOT,
            BUSHEL_TO_BOARD_FOOT,
            BUSHEL_TO_REGISTER_TON,
            BUSHEL_TO_US_GALLONS,
            BUSHEL_TO_LITER,
            BUSHEL_TO_GALLON,
            BUSHEL_TO_QUART_LIQUID,
            BUSHEL_TO_PINT_LIQUID,
            GALLON_TO_LITER,
            GALLON_TO_BARREL_OIL,
            GALLON_TO_CUBIC_FOOT,
            GALLON_TO_QUART_LIQUID,
            GALLON_TO_PINT_LIQUID,
            GALLON_TO_CUBIC_METER,
            GALLON_TO_US_GALLONS,
            GALLON_TO_ACRE_FOOT,
            GALLON_TO_CUBIC_YARD,
            GALLON_TO_BOARD_FOOT,
            GALLON_TO_REGISTER_TON,
            GALLON_TO_BUSHEL,
            QUART_LIQUID_TO_LITER,
            QUART_LIQUID_TO_BARREL_OIL,
            QUART_LIQUID_TO_CUBIC_FOOT,
            QUART_LIQUID_TO_GALLON,
            QUART_LIQUID_TO_PINT_LIQUID,
            QUART_LIQUID_TO_CUBIC_METER,
            QUART_LIQUID_TO_US_GALLONS,
            QUART_LIQUID_TO_ACRE_FOOT,
            QUART_LIQUID_TO_CUBIC_YARD,
            QUART_LIQUID_TO_BOARD_FOOT,
            QUART_LIQUID_TO_REGISTER_TON,
            QUART_LIQUID_TO_BUSHEL,
            PINT_LIQUID_TO_LITER,
            PINT_LIQUID_TO_BARREL_OIL,
            PINT_LIQUID_TO_CUBIC_FOOT,
            PINT_LIQUID_TO_GALLON,
            PINT_LIQUID_TO_QUART_LIQUID,
            PINT_LIQUID_TO_CUBIC_METER,
            PINT_LIQUID_TO_US_GALLONS,
            PINT_LIQUID_TO_ACRE_FOOT,
            PINT_LIQUID_TO_CUBIC_YARD,
            PINT_LIQUID_TO_BOARD_FOOT,
            PINT_LIQUID_TO_REGISTER_TON,
            PINT_LIQUID_TO_BUSHEL,
            MILLILITER_TO_FLUID_OUNCE,
            FLUID_OUNCE_TO_MILLILITER,
            CUBIC_CENTIMETER_TO_CUBIC_INCH,
            CUBIC_INCH_TO_CUBIC_CENTIMETER
        };
        
        public static double ConvertVolume(double volume, VolumeConversionType conversionType)
        {
            switch(conversionType)
            {
                case VolumeConversionType.CUBIC_METER_TO_ACRE_FOOT:                                   return volume * 8.107131937899257e-04;
                case VolumeConversionType.CUBIC_METER_TO_BARREL_OIL:                                  return volume * 6.289810569775070;
                case VolumeConversionType.CUBIC_METER_TO_CUBIC_YARD:                                  return volume * 1.307950619314392;
                case VolumeConversionType.CUBIC_METER_TO_CUBIC_FOOT:                                  return volume * 3.531466247128476e+01;
                case VolumeConversionType.CUBIC_METER_TO_BOARD_FOOT:                                  return volume * 4.237760394484639e+02;
                case VolumeConversionType.CUBIC_METER_TO_REGISTER_TON:                                return volume * 3.531466672148859e-01;
                case VolumeConversionType.CUBIC_METER_TO_BUSHEL:                                      return volume * 2.837759339278818e+01;
                case VolumeConversionType.CUBIC_METER_TO_US_GALLONS:                                  return volume * 2.642218971186880e+02;
                case VolumeConversionType.CUBIC_METER_TO_LITER:                                       return volume * 1.0e+03;
                case VolumeConversionType.CUBIC_METER_TO_GALLON:                                      return volume * 2.641720372841846e+02;
                case VolumeConversionType.CUBIC_METER_TO_QUART_LIQUID:                                return volume * 1.056688260795735e+03;
                case VolumeConversionType.CUBIC_METER_TO_PINT_LIQUID:                                 return volume * 2.113376298273477e+03;
                case VolumeConversionType.ACRE_FOOT_TO_CUBIC_METER:                                   return volume * 1233.4818375475;
                case VolumeConversionType.ACRE_FOOT_TO_BARREL_OIL:                                    return volume * 7.758367099431841e+03;
                case VolumeConversionType.ACRE_FOOT_TO_CUBIC_YARD:                                    return volume * 1.613333333333307e+03;
                case VolumeConversionType.ACRE_FOOT_TO_CUBIC_FOOT:                                    return volume * 4.355999475745006e+04;
                case VolumeConversionType.ACRE_FOOT_TO_BOARD_FOOT:                                    return volume * 5.227200478474931e+05;
                case VolumeConversionType.ACRE_FOOT_TO_REGISTER_TON:                                  return volume * 4.355999999999929e+02;
                case VolumeConversionType.ACRE_FOOT_TO_BUSHEL:                                        return volume * 3.500324604331216e+04;
                case VolumeConversionType.ACRE_FOOT_TO_US_GALLONS:                                    return volume * 3.259129111782457e+05;
                case VolumeConversionType.ACRE_FOOT_TO_LITER:                                         return volume * 1.23348183754750e+06;
                case VolumeConversionType.ACRE_FOOT_TO_GALLON:                                        return volume * 3.258514099779627e+05;
                case VolumeConversionType.ACRE_FOOT_TO_QUART_LIQUID:                                  return volume * 1.303405777641195e+06;
                case VolumeConversionType.ACRE_FOOT_TO_PINT_LIQUID:                                   return volume * 2.606811279823702e+06;
                case VolumeConversionType.US_GALLONS_TO_BARREL_OIL:                                   return volume * 2.380503144654092e-02;
                case VolumeConversionType.US_GALLONS_TO_CUBIC_METER:                                  return volume * 3.784697676100635e-03;
                case VolumeConversionType.US_GALLONS_TO_LITER:                                        return volume * 3.784697676100635;
                case VolumeConversionType.US_GALLONS_TO_ACRE_FOOT:                                    return volume * 3.068304340520856e-06;
                case VolumeConversionType.US_GALLONS_TO_CUBIC_YARD:                                   return volume * 4.950197669373566e-03;
                case VolumeConversionType.US_GALLONS_TO_CUBIC_FOOT:                                   return volume * 1.336553209873498e-01;
                case VolumeConversionType.US_GALLONS_TO_BOARD_FOOT:                                   return volume * 1.603864191687733;
                case VolumeConversionType.US_GALLONS_TO_REGISTER_TON:                                 return volume * 1.336553370730863e-03;
                case VolumeConversionType.US_GALLONS_TO_BUSHEL:                                       return volume * 1.074006117670142e-01;
                case VolumeConversionType.US_GALLONS_TO_GALLON:                                       return volume * 9.998112956002239e-01;
                case VolumeConversionType.US_GALLONS_TO_QUART_LIQUID:                                 return volume * 3.999245604996440;
                case VolumeConversionType.US_GALLONS_TO_PINT_LIQUID:                                  return volume * 7.998490364801791;
                case VolumeConversionType.BARREL_OIL_TO_CUBIC_METER:                                  return volume * 0.1589873;
                case VolumeConversionType.BARREL_OIL_TO_US_GALLONS:                                   return volume * 42.007926023778;
                case VolumeConversionType.BARREL_OIL_TO_LITER:                                        return volume * 158.9873;
                case VolumeConversionType.BARREL_OIL_TO_ACRE_FOOT:                                    return volume * 1.288931017550371e-04;
                case VolumeConversionType.BARREL_OIL_TO_CUBIC_YARD:                                   return volume * 2.079475374981230e-01;
                case VolumeConversionType.BARREL_OIL_TO_CUBIC_FOOT:                                   return volume * 5.614582836720892;
                case VolumeConversionType.BARREL_OIL_TO_BOARD_FOOT:                                   return volume * 6.737500831660476e+01;
                case VolumeConversionType.BARREL_OIL_TO_REGISTER_TON:                                 return volume * 5.614583512449323e-02;
                case VolumeConversionType.BARREL_OIL_TO_BUSHEL:                                       return volume * 4.511676954017233;
                case VolumeConversionType.BARREL_OIL_TO_GALLON:                                       return volume * 4.199999894331184e+01;
                case VolumeConversionType.BARREL_OIL_TO_QUART_LIQUID:                                 return volume * 1.680000135256097e+02;
                case VolumeConversionType.BARREL_OIL_TO_PINT_LIQUID:                                  return volume * 3.359999915464948e+02;
                case VolumeConversionType.LITER_TO_BARREL_OIL:                                        return volume * 6.289810569775070e-03;
                case VolumeConversionType.LITER_TO_CUBIC_FOOT:                                        return volume * 3.531466672148859e-02;
                case VolumeConversionType.LITER_TO_GALLON:                                            return volume * 2.641720372841846e-01;
                case VolumeConversionType.LITER_TO_QUART_LIQUID:                                      return volume * 1.056688260795735;
                case VolumeConversionType.LITER_TO_PINT_LIQUID:                                       return volume * 2.113376298273477;
                case VolumeConversionType.LITER_TO_CUBIC_METER:                                       return volume * 1.0e-03;
                case VolumeConversionType.LITER_TO_US_GALLONS:                                        return volume * 2.642218971186881e-01;
                case VolumeConversionType.LITER_TO_ACRE_FOOT:                                         return volume * 8.107131937899260e-07;
                case VolumeConversionType.LITER_TO_CUBIC_YARD:                                        return volume * 1.307950619314392e-03;
                case VolumeConversionType.LITER_TO_BOARD_FOOT:                                        return volume * 4.237760394484639e-01;
                case VolumeConversionType.LITER_TO_REGISTER_TON:                                      return volume * 3.531466672148859e-04;
                case VolumeConversionType.LITER_TO_BUSHEL:                                            return volume * 2.837759339278818e-02;
                case VolumeConversionType.CUBIC_YARD_TO_CUBIC_METER:                                  return volume * 0.764554857984;
                case VolumeConversionType.CUBIC_YARD_TO_ACRE_FOOT:                                    return volume * 6.198347107438118e-04;
                case VolumeConversionType.CUBIC_YARD_TO_BARREL_OIL:                                   return volume * 4.808905226920641;
                case VolumeConversionType.CUBIC_YARD_TO_CUBIC_FOOT:                                   return volume * 2.699999675048602e+01;
                case VolumeConversionType.CUBIC_YARD_TO_BOARD_FOOT:                                   return volume * 3.240000296575423e+02;
                case VolumeConversionType.CUBIC_YARD_TO_REGISTER_TON:                                 return volume * 2.70e-01;
                case VolumeConversionType.CUBIC_YARD_TO_BUSHEL:                                       return volume * 2.169622688635086e+01;
                case VolumeConversionType.CUBIC_YARD_TO_US_GALLONS:                                   return volume * 2.020121350278416e+02;
                case VolumeConversionType.CUBIC_YARD_TO_LITER:                                        return volume * 7.645548579840e+02;
                case VolumeConversionType.CUBIC_YARD_TO_GALLON:                                       return volume * 2.019740144491537e+02;
                case VolumeConversionType.CUBIC_YARD_TO_QUART_LIQUID:                                 return volume * 8.078961431660432e+02;
                case VolumeConversionType.CUBIC_YARD_TO_PINT_LIQUID:                                  return volume * 1.615792115593230e+03;
                case VolumeConversionType.CUBIC_FOOT_TO_CUBIC_METER:                                  return volume * 0.02831685;
                case VolumeConversionType.CUBIC_FOOT_TO_LITER:                                        return volume * 28.316846592;
                case VolumeConversionType.CUBIC_FOOT_TO_ACRE_FOOT:                                    return volume * 2.295684390157026e-05;
                case VolumeConversionType.CUBIC_FOOT_TO_BARREL_OIL:                                   return volume * 1.781076224327352e-01;
                case VolumeConversionType.CUBIC_FOOT_TO_CUBIC_YARD:                                   return volume * 3.703704149453274e-02;
                case VolumeConversionType.CUBIC_FOOT_TO_BOARD_FOOT:                                   return volume * 1.200000254265623e+01;
                case VolumeConversionType.CUBIC_FOOT_TO_REGISTER_TON:                                 return volume * 1.000000120352384e-02;
                case VolumeConversionType.CUBIC_FOOT_TO_BUSHEL:                                       return volume * 8.035640554645741e-01;
                case VolumeConversionType.CUBIC_FOOT_TO_US_GALLONS:                                   return volume * 7.481931827425321;
                case VolumeConversionType.CUBIC_FOOT_TO_GALLON:                                       return volume * 7.480519953970663;
                case VolumeConversionType.CUBIC_FOOT_TO_QUART_LIQUID:                                 return volume * 2.992208297771371e+01;
                case VolumeConversionType.CUBIC_FOOT_TO_PINT_LIQUID:                                  return volume * 5.984415963176531e+01;
                case VolumeConversionType.BOARD_FOOT_TO_CUBIC_METER:                                  return volume * 0.002359737;
                case VolumeConversionType.BOARD_FOOT_TO_ACRE_FOOT:                                    return volume * 1.913069919774258e-06;
                case VolumeConversionType.BOARD_FOOT_TO_BARREL_OIL:                                   return volume * 1.484229872448932e-02;
                case VolumeConversionType.BOARD_FOOT_TO_CUBIC_YARD:                                   return volume * 3.086419470569085e-03;
                case VolumeConversionType.BOARD_FOOT_TO_CUBIC_FOOT:                                   return volume * 8.333331567600209e-02;
                case VolumeConversionType.BOARD_FOOT_TO_REGISTER_TON:                                 return volume * 8.333332570536533e-04;
                case VolumeConversionType.BOARD_FOOT_TO_BUSHEL:                                       return volume * 6.696365709991781e-02;
                case VolumeConversionType.BOARD_FOOT_TO_US_GALLONS:                                   return volume * 6.234941868411615e-01;
                case VolumeConversionType.BOARD_FOOT_TO_LITER:                                        return volume * 2.3597370;
                case VolumeConversionType.BOARD_FOOT_TO_GALLON:                                       return volume * 6.23376530744870e-01;
                case VolumeConversionType.BOARD_FOOT_TO_QUART_LIQUID:                                 return volume * 2.493506386465346;
                case VolumeConversionType.BOARD_FOOT_TO_PINT_LIQUID:                                  return volume * 4.987012245958960;
                case VolumeConversionType.REGISTER_TON_TO_CUBIC_METER:                                return volume * 2.8316846592;
                case VolumeConversionType.REGISTER_TON_TO_ACRE_FOOT:                                  return volume * 2.295684113865969e-03;
                case VolumeConversionType.REGISTER_TON_TO_BARREL_OIL:                                 return volume * 1.781076009970608e+01;
                case VolumeConversionType.REGISTER_TON_TO_CUBIC_YARD:                                 return volume * 3.703703703703703;
                case VolumeConversionType.REGISTER_TON_TO_CUBIC_FOOT:                                 return volume * 9.999998796476302e+01;
                case VolumeConversionType.REGISTER_TON_TO_BOARD_FOOT:                                 return volume * 1.200000109842749e+03;
                case VolumeConversionType.REGISTER_TON_TO_BUSHEL:                                     return volume * 8.035639587537358e+01;
                case VolumeConversionType.REGISTER_TON_TO_US_GALLONS:                                 return volume * 7.481930926957094e+02;
                case VolumeConversionType.REGISTER_TON_TO_LITER:                                      return volume * 2.83168465920e+03;
                case VolumeConversionType.REGISTER_TON_TO_GALLON:                                     return volume * 7.480519053672360e+02;
                case VolumeConversionType.REGISTER_TON_TO_QUART_LIQUID:                               return volume * 2.992207937652011e+03;
                case VolumeConversionType.REGISTER_TON_TO_PINT_LIQUID:                                return volume * 5.984415242937888e+03;
                case VolumeConversionType.BUSHEL_TO_CUBIC_METER:                                      return volume * 0.03523907;
                case VolumeConversionType.BUSHEL_TO_ACRE_FOOT:                                        return volume * 2.856877898588676e-05;
                case VolumeConversionType.BUSHEL_TO_BARREL_OIL:                                       return volume * 2.216470749550435e-01;
                case VolumeConversionType.BUSHEL_TO_CUBIC_YARD:                                       return volume * 4.609096343056321e-02;
                case VolumeConversionType.BUSHEL_TO_CUBIC_FOOT:                                       return volume * 1.244455862851977;
                case VolumeConversionType.BUSHEL_TO_BOARD_FOOT:                                       return volume * 1.493347351844718e+01;
                case VolumeConversionType.BUSHEL_TO_REGISTER_TON:                                     return volume * 1.244456012625207e-02;
                case VolumeConversionType.BUSHEL_TO_US_GALLONS:                                       return volume * 9.310933928098244;
                case VolumeConversionType.BUSHEL_TO_LITER:                                            return volume * 3.5239070e+01;
                case VolumeConversionType.BUSHEL_TO_GALLON:                                           return volume * 9.309176913899991;
                case VolumeConversionType.BUSHEL_TO_QUART_LIQUID:                                     return volume * 3.723671159035916e+01;
                case VolumeConversionType.BUSHEL_TO_PINT_LIQUID:                                      return volume * 7.447341531119993e+01;
                case VolumeConversionType.GALLON_TO_LITER:                                            return volume * 3.785412;
                case VolumeConversionType.GALLON_TO_BARREL_OIL:                                       return volume * 2.380952440855339e-02;
                case VolumeConversionType.GALLON_TO_CUBIC_FOOT:                                       return volume * 1.336805631835236e-01;
                case VolumeConversionType.GALLON_TO_QUART_LIQUID:                                     return volume * 4.000000422675305;
                case VolumeConversionType.GALLON_TO_PINT_LIQUID:                                      return volume * 8.0;
                case VolumeConversionType.GALLON_TO_CUBIC_METER:                                      return volume * 3.7854120e-03;
                case VolumeConversionType.GALLON_TO_US_GALLONS:                                       return volume * 1.000188740015847;
                case VolumeConversionType.GALLON_TO_ACRE_FOOT:                                        return volume * 3.068883452330711e-06;
                case VolumeConversionType.GALLON_TO_CUBIC_YARD:                                       return volume * 4.951131969760132e-03;
                case VolumeConversionType.GALLON_TO_BOARD_FOOT:                                       return volume * 1.604166905040689;
                case VolumeConversionType.GALLON_TO_REGISTER_TON:                                     return volume * 1.336805631835236e-03;
                case VolumeConversionType.GALLON_TO_BUSHEL:                                           return volume * 1.074208825601811e-01;
                case VolumeConversionType.QUART_LIQUID_TO_LITER:                                      return volume * 0.9463529;
                case VolumeConversionType.QUART_LIQUID_TO_BARREL_OIL:                                 return volume * 5.952380473157290e-03;
                case VolumeConversionType.QUART_LIQUID_TO_CUBIC_FOOT:                                 return volume * 3.342013726441422e-02;
                case VolumeConversionType.QUART_LIQUID_TO_GALLON:                                     return volume * 2.499999735827962e-01;
                case VolumeConversionType.QUART_LIQUID_TO_PINT_LIQUID:                                return volume * 1.999999788662370;
                case VolumeConversionType.QUART_LIQUID_TO_CUBIC_METER:                                return volume * 9.463529000000001e-04;
                case VolumeConversionType.QUART_LIQUID_TO_US_GALLONS:                                 return volume * 2.500471585817721e-01;
                case VolumeConversionType.QUART_LIQUID_TO_ACRE_FOOT:                                  return volume * 7.672207820113585e-07;
                case VolumeConversionType.QUART_LIQUID_TO_CUBIC_YARD:                                 return volume * 1.237782861644971e-03;
                case VolumeConversionType.QUART_LIQUID_TO_BOARD_FOOT:                                 return volume * 4.010416838825683e-01;
                case VolumeConversionType.QUART_LIQUID_TO_REGISTER_TON:                               return volume * 3.342013726441422e-04;
                case VolumeConversionType.QUART_LIQUID_TO_BUSHEL:                                     return volume * 2.685521780228594e-02;
                case VolumeConversionType.PINT_LIQUID_TO_LITER:                                       return volume * 0.4731765;
                case VolumeConversionType.PINT_LIQUID_TO_BARREL_OIL:                                  return volume * 2.976190551069173e-03;
                case VolumeConversionType.PINT_LIQUID_TO_CUBIC_FOOT:                                  return volume * 1.671007039794045e-02;
                case VolumeConversionType.PINT_LIQUID_TO_GALLON:                                      return volume * 1.250e-01;
                case VolumeConversionType.PINT_LIQUID_TO_QUART_LIQUID:                                return volume * 5.000000528344132e-01;
                case VolumeConversionType.PINT_LIQUID_TO_CUBIC_METER:                                 return volume * 4.7317650e-04;
                case VolumeConversionType.PINT_LIQUID_TO_US_GALLONS:                                  return volume * 1.250235925019809e-01;
                case VolumeConversionType.PINT_LIQUID_TO_ACRE_FOOT:                                   return volume * 3.836104315413389e-07;
                case VolumeConversionType.PINT_LIQUID_TO_CUBIC_YARD:                                  return volume * 6.188914962200165e-04;
                case VolumeConversionType.PINT_LIQUID_TO_BOARD_FOOT:                                  return volume * 2.005208631300861e-01;
                case VolumeConversionType.PINT_LIQUID_TO_REGISTER_TON:                                return volume * 1.671007039794045e-04;
                case VolumeConversionType.PINT_LIQUID_TO_BUSHEL:                                      return volume * 1.342761032002264e-02;
                case VolumeConversionType.MILLILITER_TO_FLUID_OUNCE:                                  return volume * 3.38140227018430e-02;
                case VolumeConversionType.FLUID_OUNCE_TO_MILLILITER:                                  return volume * 29.5735295625;
                case VolumeConversionType.CUBIC_CENTIMETER_TO_CUBIC_INCH:                             return volume * 6.102374409473229e-02;
                case VolumeConversionType.CUBIC_INCH_TO_CUBIC_CENTIMETER:                             return volume * 16.387064;
                default: throw new ArgumentException("Unknown VolumeConversionType");
            }
        }
    }
}

