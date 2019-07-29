using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    public static partial class UnitConverter
    {
        public enum LengthConversionType {
            NANOMETER_TO_ANGSTROM,
            ANGSTROM_TO_NANOMETER,
            METER_TO_FATHOM,
            METER_TO_FOOT,
            METER_TO_FOOT_US_SURVEY,
            METER_TO_YARD,
            METER_TO_INCH,
            METER_TO_CENTIMETER,
            METER_TO_MILLIMETER,
            METER_TO_MIL,
            METER_TO_POINT,
            METER_TO_PICA,
            METER_TO_MICROMETER,
            METER_TO_MICROINCH,
            FATHOM_TO_METER,
            FATHOM_TO_FOOT,
            FATHOM_TO_FOOT_US_SURVEY,
            FATHOM_TO_YARD,
            FATHOM_TO_INCH,
            FATHOM_TO_CENTIMETER,
            FATHOM_TO_MILLIMETER,
            FATHOM_TO_MIL,
            FATHOM_TO_POINT,
            FATHOM_TO_PICA,
            FATHOM_TO_MICROMETER,
            FATHOM_TO_MICROINCH,
            FOOT_TO_METER,
            FOOT_TO_INCH,
            FOOT_TO_FATHOM,
            FOOT_TO_FOOT_US_SURVEY,
            FOOT_TO_YARD,
            FOOT_TO_CENTIMETER,
            FOOT_TO_MILLIMETER,
            FOOT_TO_MIL,
            FOOT_TO_POINT,
            FOOT_TO_PICA,
            FOOT_TO_MICROMETER,
            FOOT_TO_MICROINCH,
            FOOT_US_SURVEY_TO_METER,
            FOOT_US_SURVEY_TO_FATHOM,
            FOOT_US_SURVEY_TO_FOOT,
            FOOT_US_SURVEY_TO_YARD,
            FOOT_US_SURVEY_TO_INCH,
            FOOT_US_SURVEY_TO_CENTIMETER,
            FOOT_US_SURVEY_TO_MILLIMETER,
            FOOT_US_SURVEY_TO_MIL,
            FOOT_US_SURVEY_TO_POINT,
            FOOT_US_SURVEY_TO_PICA,
            FOOT_US_SURVEY_TO_MICROMETER,
            FOOT_US_SURVEY_TO_MICROINCH,
            INCH_TO_FOOT,
            INCH_TO_CENTIMETER,
            INCH_TO_MILLIMETER,
            INCH_TO_METER,
            INCH_TO_FATHOM,
            INCH_TO_FOOT_US_SURVEY,
            INCH_TO_YARD,
            INCH_TO_MIL,
            INCH_TO_POINT,
            INCH_TO_PICA,
            INCH_TO_MICROMETER,
            INCH_TO_MICROINCH,
            CENTIMETER_TO_INCH,
            CENTIMETER_TO_FOOT,
            CENTIMETER_TO_MILLIMETER,
            CENTIMETER_TO_METER,
            CENTIMETER_TO_FATHOM,
            CENTIMETER_TO_FOOT_US_SURVEY,
            CENTIMETER_TO_YARD,
            CENTIMETER_TO_MIL,
            CENTIMETER_TO_POINT,
            CENTIMETER_TO_PICA,
            CENTIMETER_TO_MICROMETER,
            CENTIMETER_TO_MICROINCH,
            MILLIMETER_TO_INCH,
            MILLIMETER_TO_MIL,
            MILLIMETER_TO_POINT,
            MILLIMETER_TO_PICA,
            MILLIMETER_TO_FOOT,
            MILLIMETER_TO_CENTIMETER,
            MILLIMETER_TO_METER,
            MILLIMETER_TO_FATHOM,
            MILLIMETER_TO_FOOT_US_SURVEY,
            MILLIMETER_TO_YARD,
            MILLIMETER_TO_MICROMETER,
            MILLIMETER_TO_MICROINCH,
            MICROMETER_TO_MICROINCH,
            MICROMETER_TO_MIL,
            MICROMETER_TO_MILLIMETER,
            MICROMETER_TO_INCH,
            MICROMETER_TO_POINT,
            MICROMETER_TO_PICA,
            MICROMETER_TO_FOOT,
            MICROMETER_TO_CENTIMETER,
            MICROMETER_TO_METER,
            MICROMETER_TO_FATHOM,
            MICROMETER_TO_FOOT_US_SURVEY,
            MICROMETER_TO_YARD,
            MICROINCH_TO_MICROMETER,
            MICROINCH_TO_MIL,
            MICROINCH_TO_MILLIMETER,
            MICROINCH_TO_INCH,
            MICROINCH_TO_POINT,
            MICROINCH_TO_PICA,
            MICROINCH_TO_FOOT,
            MICROINCH_TO_CENTIMETER,
            MICROINCH_TO_METER,
            MICROINCH_TO_FATHOM,
            MICROINCH_TO_FOOT_US_SURVEY,
            MICROINCH_TO_YARD,
            MIL_TO_MILLIMETER,
            MIL_TO_MICROMETER,
            MIL_TO_INCH,
            MIL_TO_POINT,
            MIL_TO_PICA,
            MIL_TO_FOOT,
            MIL_TO_CENTIMETER,
            MIL_TO_METER,
            MIL_TO_FATHOM,
            MIL_TO_FOOT_US_SURVEY,
            MIL_TO_YARD,
            MIL_TO_MICROINCH,
            YARD_TO_METER,
            YARD_TO_FATHOM,
            YARD_TO_FOOT,
            YARD_TO_FOOT_US_SURVEY,
            YARD_TO_INCH,
            YARD_TO_CENTIMETER,
            YARD_TO_MILLIMETER,
            YARD_TO_MIL,
            YARD_TO_POINT,
            YARD_TO_PICA,
            YARD_TO_MICROMETER,
            YARD_TO_MICROINCH,
            KILOMETER_TO_MILE,
            KILOMETER_TO_NAUTICAL_MILE,
            MILE_TO_KILOMETER,
            MILE_TO_NAUTICAL_MILE,
            NAUTICAL_MILE_TO_KILOMETER,
            NAUTICAL_MILE_TO_MILE,
            POINT_TO_MILLIMETER,
            POINT_TO_INCH,
            POINT_TO_MIL,
            POINT_TO_PICA,
            POINT_TO_FOOT,
            POINT_TO_CENTIMETER,
            POINT_TO_METER,
            POINT_TO_FATHOM,
            POINT_TO_FOOT_US_SURVEY,
            POINT_TO_YARD,
            POINT_TO_MICROMETER,
            POINT_TO_MICROINCH,
            PICA_TO_MILLIMETER,
            PICA_TO_INCH,
            PICA_TO_MIL,
            PICA_TO_POINT,
            PICA_TO_FOOT,
            PICA_TO_CENTIMETER,
            PICA_TO_METER,
            PICA_TO_FATHOM,
            PICA_TO_FOOT_US_SURVEY,
            PICA_TO_YARD,
            PICA_TO_MICROMETER,
            PICA_TO_MICROINCH
        };
        
        public static double ConvertLength(double length, LengthConversionType conversionType)
        {
            switch(conversionType)
            {
                case LengthConversionType.NANOMETER_TO_ANGSTROM:                                      return length * 1.0e+01;
                case LengthConversionType.ANGSTROM_TO_NANOMETER:                                      return length * 0.1;
                case LengthConversionType.METER_TO_FATHOM:                                            return length * 5.468054531814235e-01;
                case LengthConversionType.METER_TO_FOOT:                                              return length * 3.280839895013123;
                case LengthConversionType.METER_TO_FOOT_US_SURVEY:                                    return length * 3.280833436679587;
                case LengthConversionType.METER_TO_YARD:                                              return length * 1.093613298337708;
                case LengthConversionType.METER_TO_INCH:                                              return length * 3.937007874015747e+01;
                case LengthConversionType.METER_TO_CENTIMETER:                                        return length * 9.999999999999997e+01;
                case LengthConversionType.METER_TO_MILLIMETER:                                        return length * 9.999999999999997e+02;
                case LengthConversionType.METER_TO_MIL:                                               return length * 3.937007874015747e+04;
                case LengthConversionType.METER_TO_POINT:                                             return length * 2.845273999886188e+03;
                case LengthConversionType.METER_TO_PICA:                                              return length * 2.371072910491997e+02;
                case LengthConversionType.METER_TO_MICROMETER:                                        return length * 9.999999999999997e+05;
                case LengthConversionType.METER_TO_MICROINCH:                                         return length * 3.937007874015747e+07;
                case LengthConversionType.FATHOM_TO_METER:                                            return length * 1.828804;
                case LengthConversionType.FATHOM_TO_FOOT:                                             return length * 6.000013123359579;
                case LengthConversionType.FATHOM_TO_FOOT_US_SURVEY:                                   return length * 6.000001312333376;
                case LengthConversionType.FATHOM_TO_YARD:                                             return length * 2.000004374453194;
                case LengthConversionType.FATHOM_TO_INCH:                                             return length * 7.200015748031494e+01;
                case LengthConversionType.FATHOM_TO_CENTIMETER:                                       return length * 1.8288040e+02;
                case LengthConversionType.FATHOM_TO_MILLIMETER:                                       return length * 1.828803999999999e+03;
                case LengthConversionType.FATHOM_TO_MIL:                                              return length * 7.200015748031494e+04;
                case LengthConversionType.FATHOM_TO_POINT:                                            return length * 5.203448472087861e+03;
                case LengthConversionType.FATHOM_TO_PICA:                                             return length * 4.336227622999406e+02;
                case LengthConversionType.FATHOM_TO_MICROMETER:                                       return length * 1.8288040e+06;
                case LengthConversionType.FATHOM_TO_MICROINCH:                                        return length * 7.200015748031494e+07;
                case LengthConversionType.FOOT_TO_METER:                                              return length * 0.3048;
                case LengthConversionType.FOOT_TO_INCH:                                               return length * 12;
                case LengthConversionType.FOOT_TO_FATHOM:                                             return length * 1.666663021296979e-01;
                case LengthConversionType.FOOT_TO_FOOT_US_SURVEY:                                     return length * 9.999980314999382e-01;
                case LengthConversionType.FOOT_TO_YARD:                                               return length * 3.333333333333334e-01;
                case LengthConversionType.FOOT_TO_CENTIMETER:                                         return length * 3.047999999999999e+01;
                case LengthConversionType.FOOT_TO_MILLIMETER:                                         return length * 3.047999999999999e+02;
                case LengthConversionType.FOOT_TO_MIL:                                                return length * 1.20e+04;
                case LengthConversionType.FOOT_TO_POINT:                                              return length * 8.672395151653102e+02;
                case LengthConversionType.FOOT_TO_PICA:                                               return length * 7.227030231179607e+01;
                case LengthConversionType.FOOT_TO_MICROMETER:                                         return length * 3.047999999999999e+05;
                case LengthConversionType.FOOT_TO_MICROINCH:                                          return length * 1.20e+07;
                case LengthConversionType.FOOT_US_SURVEY_TO_METER:                                    return length * 0.3048006;
                case LengthConversionType.FOOT_US_SURVEY_TO_FATHOM:                                   return length * 1.666666302129698e-01;
                case LengthConversionType.FOOT_US_SURVEY_TO_FOOT:                                     return length * 1.000001968503937;
                case LengthConversionType.FOOT_US_SURVEY_TO_YARD:                                     return length * 3.333339895013124e-01;
                case LengthConversionType.FOOT_US_SURVEY_TO_INCH:                                     return length * 1.200002362204724e+01;
                case LengthConversionType.FOOT_US_SURVEY_TO_CENTIMETER:                               return length * 3.048005999999999e+01;
                case LengthConversionType.FOOT_US_SURVEY_TO_MILLIMETER:                               return length * 3.048005999999999e+02;
                case LengthConversionType.FOOT_US_SURVEY_TO_MIL:                                      return length * 1.200002362204724e+04;
                case LengthConversionType.FOOT_US_SURVEY_TO_POINT:                                    return length * 8.67241222329710e+02;
                case LengthConversionType.FOOT_US_SURVEY_TO_PICA:                                     return length * 7.227044457617069e+01;
                case LengthConversionType.FOOT_US_SURVEY_TO_MICROMETER:                               return length * 3.048005999999999e+05;
                case LengthConversionType.FOOT_US_SURVEY_TO_MICROINCH:                                return length * 1.200002362204724e+07;
                case LengthConversionType.INCH_TO_FOOT:                                               return length * 8.333333333333333e-02;
                case LengthConversionType.INCH_TO_CENTIMETER:                                         return length * 2.54;
                case LengthConversionType.INCH_TO_MILLIMETER:                                         return length * 25.4;
                case LengthConversionType.INCH_TO_METER:                                              return length * 2.540e-02;
                case LengthConversionType.INCH_TO_FATHOM:                                             return length * 1.388885851080816e-02;
                case LengthConversionType.INCH_TO_FOOT_US_SURVEY:                                     return length * 8.333316929166151e-02;
                case LengthConversionType.INCH_TO_YARD:                                               return length * 2.777777777777778e-02;
                case LengthConversionType.INCH_TO_MIL:                                                return length * 1.0e+03;
                case LengthConversionType.INCH_TO_POINT:                                              return length * 7.226995959710918e+01;
                case LengthConversionType.INCH_TO_PICA:                                               return length * 6.022525192649672;
                case LengthConversionType.INCH_TO_MICROMETER:                                         return length * 2.539999999999999e+04;
                case LengthConversionType.INCH_TO_MICROINCH:                                          return length * 1.0e+06;
                case LengthConversionType.CENTIMETER_TO_INCH:                                         return length * 3.937007874015748e-01;
                case LengthConversionType.CENTIMETER_TO_FOOT:                                         return length * 3.280839895013123e-02;
                case LengthConversionType.CENTIMETER_TO_MILLIMETER:                                   return length * 1.0e+01;
                case LengthConversionType.CENTIMETER_TO_METER:                                        return length * 1.0e-02;
                case LengthConversionType.CENTIMETER_TO_FATHOM:                                       return length * 5.468054531814237e-03;
                case LengthConversionType.CENTIMETER_TO_FOOT_US_SURVEY:                               return length * 3.280833436679587e-02;
                case LengthConversionType.CENTIMETER_TO_YARD:                                         return length * 1.093613298337708e-02;
                case LengthConversionType.CENTIMETER_TO_MIL:                                          return length * 3.937007874015748e+02;
                case LengthConversionType.CENTIMETER_TO_POINT:                                        return length * 2.845273999886188e+01;
                case LengthConversionType.CENTIMETER_TO_PICA:                                         return length * 2.371072910491997;
                case LengthConversionType.CENTIMETER_TO_MICROMETER:                                   return length * 9.999999999999996e+03;
                case LengthConversionType.CENTIMETER_TO_MICROINCH:                                    return length * 3.937007874015748e+05;
                case LengthConversionType.MILLIMETER_TO_INCH:                                         return length * 3.937007874015748e-02;
                case LengthConversionType.MILLIMETER_TO_MIL:                                          return length * 3.937007874015748e+01;
                case LengthConversionType.MILLIMETER_TO_POINT:                                        return length * 2.845273999886189;
                case LengthConversionType.MILLIMETER_TO_PICA:                                         return length * 2.371072910491998e-01;
                case LengthConversionType.MILLIMETER_TO_FOOT:                                         return length * 3.280839895013123e-03;
                case LengthConversionType.MILLIMETER_TO_CENTIMETER:                                   return length * 1.0e-01;
                case LengthConversionType.MILLIMETER_TO_METER:                                        return length * 1.0e-03;
                case LengthConversionType.MILLIMETER_TO_FATHOM:                                       return length * 5.468054531814236e-04;
                case LengthConversionType.MILLIMETER_TO_FOOT_US_SURVEY:                               return length * 3.280833436679587e-03;
                case LengthConversionType.MILLIMETER_TO_YARD:                                         return length * 1.093613298337708e-03;
                case LengthConversionType.MILLIMETER_TO_MICROMETER:                                   return length * 9.999999999999995e+02;
                case LengthConversionType.MILLIMETER_TO_MICROINCH:                                    return length * 3.937007874015748e+04;
                case LengthConversionType.MICROMETER_TO_MICROINCH:                                    return length * 3.937007874015748e+01;
                case LengthConversionType.MICROMETER_TO_MIL:                                          return length * 3.937007874015748e-02;
                case LengthConversionType.MICROMETER_TO_MILLIMETER:                                   return length * 1.0e-03;
                case LengthConversionType.MICROMETER_TO_INCH:                                         return length * 3.937007874015748e-05;
                case LengthConversionType.MICROMETER_TO_POINT:                                        return length * 2.845273999886189e-03;
                case LengthConversionType.MICROMETER_TO_PICA:                                         return length * 2.371072910491998e-04;
                case LengthConversionType.MICROMETER_TO_FOOT:                                         return length * 3.280839895013123e-06;
                case LengthConversionType.MICROMETER_TO_CENTIMETER:                                   return length * 1.0e-04;
                case LengthConversionType.MICROMETER_TO_METER:                                        return length * 1.0e-06;
                case LengthConversionType.MICROMETER_TO_FATHOM:                                       return length * 5.468054531814236e-07;
                case LengthConversionType.MICROMETER_TO_FOOT_US_SURVEY:                               return length * 3.280833436679587e-06;
                case LengthConversionType.MICROMETER_TO_YARD:                                         return length * 1.093613298337708e-06;
                case LengthConversionType.MICROINCH_TO_MICROMETER:                                    return length * 0.0254;
                case LengthConversionType.MICROINCH_TO_MIL:                                           return length * 1.0e-03;
                case LengthConversionType.MICROINCH_TO_MILLIMETER:                                    return length * 2.540e-05;
                case LengthConversionType.MICROINCH_TO_INCH:                                          return length * 1.0e-06;
                case LengthConversionType.MICROINCH_TO_POINT:                                         return length * 7.226995959710921e-05;
                case LengthConversionType.MICROINCH_TO_PICA:                                          return length * 6.022525192649675e-06;
                case LengthConversionType.MICROINCH_TO_FOOT:                                          return length * 8.333333333333333e-08;
                case LengthConversionType.MICROINCH_TO_CENTIMETER:                                    return length * 2.540e-06;
                case LengthConversionType.MICROINCH_TO_METER:                                         return length * 2.540e-08;
                case LengthConversionType.MICROINCH_TO_FATHOM:                                        return length * 1.388885851080816e-08;
                case LengthConversionType.MICROINCH_TO_FOOT_US_SURVEY:                                return length * 8.333316929166150e-08;
                case LengthConversionType.MICROINCH_TO_YARD:                                          return length * 2.777777777777778e-08;
                case LengthConversionType.MIL_TO_MILLIMETER:                                          return length * 0.0254;
                case LengthConversionType.MIL_TO_MICROMETER:                                          return length * 25.4;
                case LengthConversionType.MIL_TO_INCH:                                                return length * 1.0e-03;
                case LengthConversionType.MIL_TO_POINT:                                               return length * 7.226995959710920e-02;
                case LengthConversionType.MIL_TO_PICA:                                                return length * 6.022525192649675e-03;
                case LengthConversionType.MIL_TO_FOOT:                                                return length * 8.333333333333332e-05;
                case LengthConversionType.MIL_TO_CENTIMETER:                                          return length * 2.540e-03;
                case LengthConversionType.MIL_TO_METER:                                               return length * 2.540e-05;
                case LengthConversionType.MIL_TO_FATHOM:                                              return length * 1.388885851080816e-05;
                case LengthConversionType.MIL_TO_FOOT_US_SURVEY:                                      return length * 8.333316929166151e-05;
                case LengthConversionType.MIL_TO_YARD:                                                return length * 2.777777777777778e-05;
                case LengthConversionType.MIL_TO_MICROINCH:                                           return length * 9.999999999999999e+02;
                case LengthConversionType.YARD_TO_METER:                                              return length * 0.9144;
                case LengthConversionType.YARD_TO_FATHOM:                                             return length * 4.999989063890936e-01;
                case LengthConversionType.YARD_TO_FOOT:                                               return length * 3.0;
                case LengthConversionType.YARD_TO_FOOT_US_SURVEY:                                     return length * 2.999994094499814;
                case LengthConversionType.YARD_TO_INCH:                                               return length * 3.599999999999999e+01;
                case LengthConversionType.YARD_TO_CENTIMETER:                                         return length * 9.143999999999997e+01;
                case LengthConversionType.YARD_TO_MILLIMETER:                                         return length * 9.143999999999996e+02;
                case LengthConversionType.YARD_TO_MIL:                                                return length * 3.599999999999999e+04;
                case LengthConversionType.YARD_TO_POINT:                                              return length * 2.601718545495930e+03;
                case LengthConversionType.YARD_TO_PICA:                                               return length * 2.168109069353882e+02;
                case LengthConversionType.YARD_TO_MICROMETER:                                         return length * 9.143999999999997e+05;
                case LengthConversionType.YARD_TO_MICROINCH:                                          return length * 3.599999999999999e+07;
                case LengthConversionType.KILOMETER_TO_MILE:                                          return length * 6.213711922373339e-01;
                case LengthConversionType.KILOMETER_TO_NAUTICAL_MILE:                                 return length * 5.399568034557235e-01;
                case LengthConversionType.MILE_TO_KILOMETER:                                          return length * 1.609344;
                case LengthConversionType.MILE_TO_NAUTICAL_MILE:                                      return length * 8.689762419006479e-01;
                case LengthConversionType.NAUTICAL_MILE_TO_KILOMETER:                                 return length * 1.852;
                case LengthConversionType.NAUTICAL_MILE_TO_MILE:                                      return length * 1.150779448023542;
                case LengthConversionType.POINT_TO_MILLIMETER:                                        return length * 0.35146;
                case LengthConversionType.POINT_TO_INCH:                                              return length * 1.383700787401575e-02;
                case LengthConversionType.POINT_TO_MIL:                                               return length * 1.383700787401575e+01;
                case LengthConversionType.POINT_TO_PICA:                                              return length * 8.333372851215176e-02;
                case LengthConversionType.POINT_TO_FOOT:                                              return length * 1.153083989501312e-03;
                case LengthConversionType.POINT_TO_CENTIMETER:                                        return length * 3.51460e-02;
                case LengthConversionType.POINT_TO_METER:                                             return length * 3.51460e-04;
                case LengthConversionType.POINT_TO_FATHOM:                                            return length * 1.921802445751431e-04;
                case LengthConversionType.POINT_TO_FOOT_US_SURVEY:                                    return length * 1.153081719655408e-03;
                case LengthConversionType.POINT_TO_YARD:                                              return length * 3.843613298337709e-04;
                case LengthConversionType.POINT_TO_MICROMETER:                                        return length * 3.514599999999998e+02;
                case LengthConversionType.POINT_TO_MICROINCH:                                         return length * 1.383700787401575e+04;
                case LengthConversionType.PICA_TO_MILLIMETER:                                         return length * 4.2175;
                case LengthConversionType.PICA_TO_INCH:                                               return length * 1.660433070866142e-01;
                case LengthConversionType.PICA_TO_MIL:                                                return length * 1.660433070866142e+02;
                case LengthConversionType.PICA_TO_POINT:                                              return length * 1.1999943094520e+01;
                case LengthConversionType.PICA_TO_FOOT:                                               return length * 1.383694225721785e-02;
                case LengthConversionType.PICA_TO_CENTIMETER:                                         return length * 4.217500000000001e-01;
                case LengthConversionType.PICA_TO_METER:                                              return length * 4.217500000000001e-03;
                case LengthConversionType.PICA_TO_FATHOM:                                             return length * 2.306151998792654e-03;
                case LengthConversionType.PICA_TO_FOOT_US_SURVEY:                                     return length * 1.383691501919616e-02;
                case LengthConversionType.PICA_TO_YARD:                                               return length * 4.612314085739284e-03;
                case LengthConversionType.PICA_TO_MICROMETER:                                         return length * 4.217499999999998e+03;
                case LengthConversionType.PICA_TO_MICROINCH:                                          return length * 1.660433070866142e+05;
                default: throw new ArgumentException("Unknown LengthConversionType");
            }
        }
    }
}

