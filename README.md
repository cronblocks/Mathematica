# Mathematica
**_Mathematica_** is a C# library to facilitate mathematical _calculations_ and _unit conversions_.

## Mathematical Expression Evaluation
The library includes **_ExpressionEvaluator_** class to facilitate conversion of mathematical expression provided as a string, and returns the calculated result of provided expression.

```csharp
double result;
result = ExpressionEvaluator.Evaluate("sqrt(9*9)");                   // result = 9
result = ExpressionEvaluator.Evaluate("abs(-5000+1-1) + abs(-5000)"); // result = 10000
```

Supported operations/ operators are:
* [], {}, ()
* /, *
* +, -
* sin(x), cos(x), tan(x), sinh(x), cosh(x), tanh(x), asin(x), acos(x), atan(x)
* cot(x), sec(x), csc(x), cosec(x)
* pow(x, y), loge(x), log10(x), log(N, base), sqrt(x), abs(x)

## Unit Conversion
The library includes **_UnitConverter_** class to facilitate conversion of values from one unit to another.

```csharp
double result;
result = UnitConverter.ConvertAngle(45, UnitConverter.AngleConversionType.DEGREE_TO_MIL);       // 800
result = UnitConverter.ConvertArea(100, UnitConverter.AreaConversionType.ACRE_TO_SQUARE_METER); // 404687.3
```