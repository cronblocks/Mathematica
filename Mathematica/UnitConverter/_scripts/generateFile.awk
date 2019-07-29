BEGIN{
	convertingUnitFor = "";
	
	fromUnit = "";
	toUnit = "";
	mFactor = "";
	
	enum  = "";
	funct = "";
	testCases = "";
	
	isFirstEntry = 1;
}

function outputToFile()
{
	enum = enum "\n        };";
	
	funct = funct "\n                default: throw new ArgumentException(\"Unknown " convertingUnitFor "ConversionType\");"
	funct = funct "\n            }\n        }";
	
	outFileName  = outDirConversion "/" convertingUnitFor "Converter.cs";
	testFileName = outDirTests "/" convertingUnitFor "ConverterTests.cs";
	
	print "Creating " outFileName " and " testFileName;
	
	print "using System;"                                  > outFileName;
	print "using System.Collections.Generic;"             >> outFileName;
	print "using System.Linq;"                            >> outFileName;
	print "using System.Text;"                            >> outFileName;
	print "using System.Threading.Tasks;"                 >> outFileName;
	print ""                                              >> outFileName;
	print "namespace Mathematica"                         >> outFileName;
	print "{"                                             >> outFileName;
	print "    public static partial class UnitConverter" >> outFileName;
	print "    {"                                         >> outFileName;
	print                    enum                         >> outFileName;
	print "        "                                      >> outFileName;
	print                    funct                        >> outFileName;
	print "    }"                                         >> outFileName;
	print "}"                                             >> outFileName;
	print ""                                              >> outFileName;
	
	print "using System;"                                         > testFileName;
	print "using Microsoft.VisualStudio.TestTools.UnitTesting;"  >> testFileName;
	print "using Mathematica;"                                   >> testFileName;
	print ""                                                     >> testFileName;
	print "namespace Mathematica.Test"                           >> testFileName;
	print "{"                                                    >> testFileName;
	print "    [TestClass]"                                      >> testFileName;
	print "    public class " convertingUnitFor "ConverterTests" >> testFileName;
	print "    {"                                                >> testFileName;
	print                    testCases                           >> testFileName;
	print "    }"                                                >> testFileName;
	print "}"                                                    >> testFileName;
}

/^[ \t]*[_a-zA-Z]/{
	if($1 ~ /^_/)
	{
		if(convertingUnitFor != "")
		{
			outputToFile();
		}
		
		convertingUnitFor = $0;
			gsub("_", "", convertingUnitFor);
			gsub(" *", "", convertingUnitFor);
		
		enum  = "        public enum " convertingUnitFor "ConversionType {";
		funct = "        public static double Convert" convertingUnitFor "(double " tolower(convertingUnitFor)", " convertingUnitFor "ConversionType conversionType)\n";
		funct = funct "        {\n            switch(conversionType)\n            {";
		
		testCases = "";
		
		isFirstEntry = 1;
	}
	else
	{
		if($0 != "" && convertingUnitFor != "")
		{
			toUnit = $1;
				gsub("-+",      "_", toUnit);
				gsub("[([{]+", "_", toUnit);
				gsub("[)]}]+", "",  toUnit);
			
			fromUnit = $2;
				gsub("-+",     "_", fromUnit);
				gsub("[([{]+", "_", fromUnit);
				gsub("[)]}]+", "",  fromUnit);
			
			mFactor = $3;
			
			if(isFirstEntry == 1)
			{
				enum = enum "\n            "  toupper(fromUnit) "_TO_" toupper(toUnit);
			}
			else
			{
				enum = enum ",\n            " toupper(fromUnit) "_TO_" toupper(toUnit);
			}
			
			var = convertingUnitFor "ConversionType." toupper(fromUnit) "_TO_" toupper(toUnit) ": ";
			funct = funct "\n                case " sprintf("%-80s ", var);
			funct = funct "return " tolower(convertingUnitFor) " * " mFactor ";";
			
			if(isFirstEntry != 1){ testCases = testCases "\n        \n";}
			testCases = testCases "        [TestMethod]\n";
			testCases = testCases "        public void " fromUnit "To" toUnit "Test()\n";
			testCases = testCases "        {\n";
			testCases = testCases "            double result = UnitConverter.Convert" convertingUnitFor "(100, UnitConverter." convertingUnitFor "ConversionType." toupper(fromUnit) "_TO_" toupper(toUnit) ");\n";
			testCases = testCases "            double expected = 100;\n";
			testCases = testCases "        \n";
			testCases = testCases "            if (expected - result < -0.0001 || expected - result > 0.0001)\n";
			testCases = testCases "                Assert.Fail();\n";
			testCases = testCases "        }";
			
			isFirstEntry = 0;
		}
	}
}

END{
	outputToFile();
	print "\nCompleted...";
}