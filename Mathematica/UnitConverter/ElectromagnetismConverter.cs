using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum ElectromagnetismConversionType {
            AMPERE_PER_METER_TO_OERSTED,
            OERSTED_TO_AMPERE_PER_METER,
            NANOWEBER_TO_MAXWELL,
            MAXWELL_TO_NANOWEBER,
            MILLITESLA_TO_GAUSS,
            GAUSS_TO_MILLITESLA,
            COULOMB_TO_AMPERE_HOUR,
            AMPERE_HOUR_TO_COULOMB,
            NANOOHM_METER_TO_OHM_CIRCULAR_MIL_PER_FOOT,
            OHM_CIRCULAR_MIL_PER_FOOT_TO_NANOOHM_METER,
            SIEMENS_PER_METER_TO_MHO_PER_CENTIMETER,
            MHO_PER_CENTIMETER_TO_SIEMENS_PER_METER
        };
        
        public static double ConvertElectromagnetism(double electromagnetism, ElectromagnetismConversionType conversionType)
        {
            switch(conversionType)
            {
                case ElectromagnetismConversionType.AMPERE_PER_METER_TO_OERSTED:                      return electromagnetism * 1.256637061436038e-02;
                case ElectromagnetismConversionType.OERSTED_TO_AMPERE_PER_METER:                      return electromagnetism * 79.57747154594;
                case ElectromagnetismConversionType.NANOWEBER_TO_MAXWELL:                             return electromagnetism * 1.0e-01;
                case ElectromagnetismConversionType.MAXWELL_TO_NANOWEBER:                             return electromagnetism * 10;
                case ElectromagnetismConversionType.MILLITESLA_TO_GAUSS:                              return electromagnetism * 1.0e+01;
                case ElectromagnetismConversionType.GAUSS_TO_MILLITESLA:                              return electromagnetism * 0.1;
                case ElectromagnetismConversionType.COULOMB_TO_AMPERE_HOUR:                           return electromagnetism * 2.777777777777778e-04;
                case ElectromagnetismConversionType.AMPERE_HOUR_TO_COULOMB:                           return electromagnetism * 3600;
                case ElectromagnetismConversionType.NANOOHM_METER_TO_OHM_CIRCULAR_MIL_PER_FOOT:       return electromagnetism * 6.015305342914512e-01;
                case ElectromagnetismConversionType.OHM_CIRCULAR_MIL_PER_FOOT_TO_NANOOHM_METER:       return electromagnetism * 1.662426;
                case ElectromagnetismConversionType.SIEMENS_PER_METER_TO_MHO_PER_CENTIMETER:          return electromagnetism * 1.0e-02;
                case ElectromagnetismConversionType.MHO_PER_CENTIMETER_TO_SIEMENS_PER_METER:          return electromagnetism * 100;
                default: throw new ArgumentException("Unknown ElectromagnetismConversionType");
            }
        }
    }
}

