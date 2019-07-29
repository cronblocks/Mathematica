BEGIN{
	convertingUnitFor = "";
	
	fromUnit = "";
	toUnit = "";
	mFactor = "";
	
	unitsDefined[0,0] = 0;  # Each element = [LHS/ToUnit RHS/FromUnit Factor]
	unitsExpanded[0,0] = 0;
	unitsList[0] = 0;
	
	unitsDefinedCount = 0;
	unitsExpandedCount = 0;
	unitsListCount = 0;
}

############################################################################################
####################################### AUX FUNCTIONS ######################################
############################################################################################

function addUnitToList(unit)
{
	for(aul=0; aul < unitsListCount; aul++)
	{
		if(unitsList[aul]==unit)
		{
			return 0;
		}
	}
	
	unitsList[unitsListCount] = unit;
	unitsListCount++;
}

function isConversionDefined(icdFrom, icdTo)
{
	for(__icd=0; __icd < unitsDefinedCount; __icd++)
	{
		if(unitsDefined[__icd,0]==icdTo && unitsDefined[__icd,1]==icdFrom)
		{
			return __icd;
		}
	}
	
	return -1;
}

function addConversionDefined(acdFrom, acdTo, acdFactor)
{
	if(isConversionDefined(acdFrom, acdTo) == -1)
	{
		unitsDefined[unitsDefinedCount,0]  = acdTo;
		unitsDefined[unitsDefinedCount,1]  = acdFrom;
		unitsDefined[unitsDefinedCount,2]  = acdFactor;
		
		unitsDefinedCount++;
	}
}

function addConversionExpanded(aceFrom, aceTo, aceFactor)
{
	for(__ace=0; __ace < unitsExpandedCount; __ace++)
	{
		if(unitsExpanded[__ace,0]==aceTo && unitsExpanded[__ace,1]==aceFrom)
		{
			return -1;
		}
	}
	
	unitsExpanded[unitsExpandedCount,0]  = aceTo;
	unitsExpanded[unitsExpandedCount,1]  = aceFrom;
	unitsExpanded[unitsExpandedCount,2]  = aceFactor;
	
	unitsExpandedCount++;
}

############################################################################################
###################################### MAIN FUNCTIONS ######################################
############################################################################################

function recursiveExpand(reFor)
{
	recUnits[0,0] = 0; # [0=>toUnitName, 1=>factor]
	recUnitsCount = 0;
	
	for(__rex=0; __rex < unitsExpandedCount; __rex++)
	{
		if(unitsExpanded[__rex,1]==reFor)
		{
			recUnits[recUnitsCount,0] = unitsExpanded[__rex,0];
			recUnits[recUnitsCount,1] = unitsExpanded[__rex,2];
			
			recUnitsCount++;
		}
	}
	
	for(__rex=0; __rex < recUnitsCount; __rex++)
	{
		rexUnitFor = recUnits[__rex,0];
		rexUnitFac = recUnits[__rex,1];
		
		for(__rexint=0; __rexint < unitsExpandedCount; __rexint++)
		{
			if(unitsExpanded[__rexint,1]==rexUnitFor)
			{
				__isExist = 0;
				for(__rexver=0; __rexver < recUnitsCount; __rexver++)
				{
					if(recUnits[__rexver,0]==unitsExpanded[__rexint,0])
					{
						__isExist = 1;
						break;
					}
				}
				
				if(__isExist == 0)
				{
					recUnits[recUnitsCount,0] = unitsExpanded[__rexint,0];
					
					__lFactor = sprintf("%.15e", rexUnitFac * unitsExpanded[__rexint,2]);
					sub("0+e", "0e",__lFactor);
					sub("e[+-]00$", "",__lFactor);
					recUnits[recUnitsCount,1] = __lFactor;
					
					recUnitsCount++;
				}
			}
		}
	}
	
	for(__rex=0; __rex < recUnitsCount; __rex++)
	{
		if(reFor != recUnits[__rex,0])
		{
			addConversionExpanded(reFor, recUnits[__rex,0], recUnits[__rex,1]);
		}
	}
}

function expandUnits()
{
	unitsExpandedCount = 0;
	
	for(i=0; i < unitsListCount; i++)
	{
		for(j=0; j < unitsListCount; j++)
		{
			fr0 = unitsList[i];
			to0 = unitsList[j];
			indFwd = isConversionDefined(fr0, to0);
			indRev = isConversionDefined(to0, fr0);
			
			if(fr0 == to0)
			{
				#### Uncomment to add Symmetric-conversion
				#addConversionExpanded(fr0, to0, 1);
			}
			else
			{
				if(indFwd != -1)
				{
					addConversionExpanded(fr0, to0, unitsDefined[indFwd,2]);
				}
				else if(indRev != -1)
				{
					_localConv = sprintf("%.15e", 1/unitsDefined[indRev,2]);
					sub("0+e", "0e",_localConv);
					sub("e[+-]00$", "",_localConv);
					addConversionExpanded(fr0, to0, _localConv);
				}
				
				if(indRev != -1)
				{
					addConversionExpanded(to0, fr0, unitsDefined[indRev,2]);
				}
				else if(indFwd != -1)
				{
					_localConv = sprintf("%.15e", 1/unitsDefined[indFwd,2]);
					sub("0+e", "0e",_localConv);
					sub("e[+-]00$", "",_localConv);
					addConversionExpanded(to0, fr0, _localConv);
				}
			}
		}
	}
	
	for(i=0; i < unitsListCount; i++)
	{
		expandFor = unitsList[i];
		recursiveExpand(expandFor);
	}
}

function outputExpandedUnits()
{
	expandUnits();
	
	print "\n#LHS RHS Factor";
	
	for(ui=0; ui < unitsListCount; ui++)
	{
		outputFor = unitsList[ui];
		
		for(oeu=0; oeu < unitsExpandedCount; oeu++)
		{
			if(unitsExpanded[oeu,1]==outputFor)
			{
				print unitsExpanded[oeu,0] " " unitsExpanded[oeu,1] " " unitsExpanded[oeu,2];
			}
		}
	}
}

/^[ \t]*[_a-zA-Z]/{
	if($1 ~ /^_/)
	{
		if(convertingUnitFor != "")
		{
			outputExpandedUnits();
		}
		
		convertingUnitFor = $0;
		gsub(" *", "", convertingUnitFor);
		
		print convertingUnitFor;
		
		unitsDefinedCount = 0;
		unitsListCount = 0;
	}
	else
	{
		if($0 != "" && convertingUnitFor != "")
		{
			toUnit = $1;
				gsub("-+",      "_", toUnit);
				gsub("[([{]+", "_", toUnit);
				gsub("[)]}]+", "",  toUnit);
			
			fromUnit = $5;
				gsub("-+",     "_", fromUnit);
				gsub("[([{]+", "_", fromUnit);
				gsub("[)]}]+", "",  fromUnit);
			
			mFactor = $3;
			
			addConversionDefined(fromUnit, toUnit, mFactor);
			addUnitToList(toUnit);
			addUnitToList(fromUnit);
		}
	}
}

END{
	outputExpandedUnits();
}
