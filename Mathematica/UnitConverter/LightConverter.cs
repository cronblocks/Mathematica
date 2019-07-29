using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum LightConversionType {
            NANOMETER_TO_ANGSTROM,
            ANGSTROM_TO_NANOMETER,
            CANDELA_PER_SQ_METER_TO_LAMBERT,
            CANDELA_PER_SQ_METER_TO_CANDELA_PER_SQ_INCH,
            CANDELA_PER_SQ_METER_TO_FOOTLAMBERT,
            LAMBERT_TO_CANDELA_PER_SQ_METER,
            LAMBERT_TO_CANDELA_PER_SQ_INCH,
            LAMBERT_TO_FOOTLAMBERT,
            CANDELA_PER_SQ_INCH_TO_CANDELA_PER_SQ_METER,
            CANDELA_PER_SQ_INCH_TO_LAMBERT,
            CANDELA_PER_SQ_INCH_TO_FOOTLAMBERT,
            FOOTLAMBERT_TO_CANDELA_PER_SQ_METER,
            FOOTLAMBERT_TO_LAMBERT,
            FOOTLAMBERT_TO_CANDELA_PER_SQ_INCH,
            LUX_TO_LUMEN_PER_SQ_FOOT,
            LUX_TO_PHOT,
            LUX_TO_FOOTCANDLE,
            LUMEN_PER_SQ_FOOT_TO_LUX,
            LUMEN_PER_SQ_FOOT_TO_PHOT,
            LUMEN_PER_SQ_FOOT_TO_FOOTCANDLE,
            PHOT_TO_LUX,
            PHOT_TO_LUMEN_PER_SQ_FOOT,
            PHOT_TO_FOOTCANDLE,
            FOOTCANDLE_TO_LUX,
            FOOTCANDLE_TO_LUMEN_PER_SQ_FOOT,
            FOOTCANDLE_TO_PHOT
        };
        
        public static double ConvertLight(double light, LightConversionType conversionType)
        {
            switch(conversionType)
            {
                case LightConversionType.NANOMETER_TO_ANGSTROM:                                       return light * 1.0e+01;
                case LightConversionType.ANGSTROM_TO_NANOMETER:                                       return light * 0.1;
                case LightConversionType.CANDELA_PER_SQ_METER_TO_LAMBERT:                             return light * 3.141592653589701e-04;
                case LightConversionType.CANDELA_PER_SQ_METER_TO_CANDELA_PER_SQ_INCH:                 return light * 6.451600000000832e-04;
                case LightConversionType.CANDELA_PER_SQ_METER_TO_FOOTLAMBERT:                         return light * 2.918635079290997e-01;
                case LightConversionType.LAMBERT_TO_CANDELA_PER_SQ_METER:                             return light * 3183.098861838;
                case LightConversionType.LAMBERT_TO_CANDELA_PER_SQ_INCH:                              return light * 2.053608061703669;
                case LightConversionType.LAMBERT_TO_FOOTLAMBERT:                                      return light * 9.290303999011634e+02;
                case LightConversionType.CANDELA_PER_SQ_INCH_TO_CANDELA_PER_SQ_METER:                 return light * 1550.003100006;
                case LightConversionType.CANDELA_PER_SQ_INCH_TO_LAMBERT:                              return light * 4.869478352020112e-01;
                case LightConversionType.CANDELA_PER_SQ_INCH_TO_FOOTLAMBERT:                          return light * 4.523893420687303e+02;
                case LightConversionType.FOOTLAMBERT_TO_CANDELA_PER_SQ_METER:                         return light * 3.4262591;
                case LightConversionType.FOOTLAMBERT_TO_LAMBERT:                                      return light * 1.076391041785486e-03;
                case LightConversionType.FOOTLAMBERT_TO_CANDELA_PER_SQ_INCH:                          return light * 2.210485320956285e-03;
                case LightConversionType.LUX_TO_LUMEN_PER_SQ_FOOT:                                    return light * 9.290304000008391e-02;
                case LightConversionType.LUX_TO_PHOT:                                                 return light * 1.0e-04;
                case LightConversionType.LUX_TO_FOOTCANDLE:                                           return light * 9.290304000008391e-02;
                case LightConversionType.LUMEN_PER_SQ_FOOT_TO_LUX:                                    return light * 10.7639104167;
                case LightConversionType.LUMEN_PER_SQ_FOOT_TO_PHOT:                                   return light * 1.076391041670e-03;
                case LightConversionType.LUMEN_PER_SQ_FOOT_TO_FOOTCANDLE:                             return light * 1.0;
                case LightConversionType.PHOT_TO_LUX:                                                 return light * 10000;
                case LightConversionType.PHOT_TO_LUMEN_PER_SQ_FOOT:                                   return light * 9.290304000008391e+02;
                case LightConversionType.PHOT_TO_FOOTCANDLE:                                          return light * 9.290304000008391e+02;
                case LightConversionType.FOOTCANDLE_TO_LUX:                                           return light * 10.7639104167;
                case LightConversionType.FOOTCANDLE_TO_LUMEN_PER_SQ_FOOT:                             return light * 1.0;
                case LightConversionType.FOOTCANDLE_TO_PHOT:                                          return light * 1.076391041670e-03;
                default: throw new ArgumentException("Unknown LightConversionType");
            }
        }
    }
}

