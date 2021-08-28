# Mathematica
**_Mathematica_** is a C# library to facilitate _mathematical calculations_ and _unit conversions_.

## Mathematical Expression Evaluation
The library includes **_ExpressionEvaluator_** class to facilitate conversion of mathematical expressions provided as string, and returns the calculated result of provided expression.

```csharp
double result;
result = ExpressionEvaluator.Evaluate("sqrt(9*9)");                   // result = 9
result = ExpressionEvaluator.Evaluate("abs(-5000+1-1) + abs(-5000)"); // result = 10000
```

Supported operations / operators in order of precedence are:
```
[], {}, ()
/, *
+, -
sin(x), cos(x), tan(x), sinh(x), cosh(x), tanh(x), asin(x), acos(x), atan(x)
cot(x), sec(x), csc(x), cosec(x)
pow(x, y), loge(x), log10(x), log(N, base), sqrt(x), abs(x)
```

## Unit Conversion
The **_UnitConverter_** class included in library facilitates conversion of values from one unit to another.

```csharp
double result;
result = UnitConverter.ConvertAngle(45, UnitConverter.AngleConversionType.DEGREE_TO_MIL);       // 800
result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_METER); // 404687.3
```

It is a rather simple implementation of its kind, however the unit conversion is done thru generated code.

For details, please see the code of this library as it is intended to be a simplest library in this domain.
