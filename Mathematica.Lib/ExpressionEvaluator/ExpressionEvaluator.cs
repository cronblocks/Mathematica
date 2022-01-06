using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Mathematica
{
    public static class ExpressionEvaluator
    {
        public enum AngleType { DEGREE, RADIAN };
        private static AngleType angle_type;

        // Avoid previous term being sub-text of any term coming later in sequence
        private static List<string> supportedFunctionality = new List<string>() {
                                      "asin", "acos", "atan", "sinh", "cosh", "tanh",
                                      "sin", "cosec", "cos", "tan", "cot", "sec", "csc", 
                                      "pow", "logn", "log10", "log", "sqrt", "abs", "pi", "e" };

        private static int MAX_PARSING_ITERATIONS = 100;

        /******************************************************************
         * This function evaluates the result of provided expression in
         * string format. The expression may contain following symbols
         * (in order of precedence):
         * 1. [], {}, ()
         * 2. sin(x), cos(x), tan(x), sinh(x), cosh(x), tanh(x), asin(x), acos(x), atan(x)
         * 3. cot(x), sec(x), csc(x) or cosec(x) ___more being included___
         * 4. pow(x,y), loge(x), log10(x), log(N,base), sqrt(x), abs(x)
         * 5. /, *
         * 6. +, -
         ******************************************************************/
        public static double Evaluate(string expression)
        {
            return Evaluate(expression, AngleType.DEGREE);
        }

        public static double Evaluate(string expression, AngleType angleType)
        {
            angle_type = angleType;
            string expr = expression;
            int iterCount = 0;

            if (expr.CharCount('[') != expr.CharCount(']'))
                throw new ArgumentException("Count of '[' and ']' do not match.");
            if (expr.CharCount('{') != expr.CharCount('}'))
                throw new ArgumentException("Count of '{' and '}' do not match.");
            if (expr.CharCount('(') != expr.CharCount(')'))
                throw new ArgumentException("Count of '(' and ')' do not match.");

            expr = expr.SanitizeExpression();
            if (expr == "") return 0;
            
            do
            {
                expr = expr.Solve01ValueBraces();
                expr = expr.Solve02ValueBraces();
                expr = expr.SolveMathFunctions();

                if(iterCount++ >= MAX_PARSING_ITERATIONS)
                {
                    throw new ArgumentException($"Max iterations({MAX_PARSING_ITERATIONS}) reached, please check for syntax and try reducing your expression.");
                }
            } while (expr.CharCount('[') + expr.CharCount('{') + expr.CharCount('(') + expr.CharCount('_') > 0);
            
            return SolveBasicMath(expr);
        }

        //----------------------------------------------------
        // "string" Extension methods
        //----------------------------------------------------
        private static int CharCount(this string str, char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch) count++;
            }

            return count;
        }

        private static string SanitizeExpression(this string expression)
        {
            string sanitizee = Regex.Replace(expression, @"\s+", " ").Trim();

            // Checking for undefined operation between 2 values
            if (Regex.Match(sanitizee, @"[0-9.] [0-9.]").Success)
            {
                throw new ArgumentException("Undefined operation between " + Regex.Match(sanitizee, @"[0-9.]+ +[0-9.]+").Value.Replace(" ", " & "));
            }

            // Checking for undefined functions
            Match match = Regex.Match(sanitizee, @"[a-z]+", RegexOptions.IgnoreCase);
            while (match.Success)
            {
                if (!supportedFunctionality.Contains(match.Value) && !supportedFunctionality.Contains(match.Value.ToLower()))
                {
                    throw new ArgumentException("The expression contains unsupported token " + match.Value + ".");
                }
                match = match.NextMatch();
            }

            // Sanitizing the string
            sanitizee = Regex.Replace(sanitizee, @"[+] *[+]*", " + ");             // multiple signs
            sanitizee = Regex.Replace(sanitizee, @"[-] *[-]*", " - ");
            sanitizee = Regex.Replace(sanitizee, @"[*] *[*]*", " * ");
            sanitizee = Regex.Replace(sanitizee, @"[/] *[/]*", " / ");
            sanitizee = Regex.Replace(sanitizee, @"[,] *[,]*", " , ");
            sanitizee = Regex.Replace(sanitizee, @"\. *\.+", ".");                 // multiple "."
            sanitizee = Regex.Replace(sanitizee, @"[\n\r\t\v\b\e\f\a_]+", " ");    // unwanted chars in input
            sanitizee = Regex.Replace(sanitizee, @"[\[][. ,+*/-]*[\]]", "");       // Removing empty braces
            sanitizee = Regex.Replace(sanitizee, @"[\{][. ,+*/-]*[\}]", "");
            sanitizee = Regex.Replace(sanitizee, @"[\(][. ,+*/-]*[\)]", "");

            // Converting functions into tokens
            for (int i = 0; i < supportedFunctionality.Count; i++)
            {
                if (supportedFunctionality[i] == "e")
                {
                    sanitizee = Regex.Replace(
                        sanitizee, supportedFunctionality[i],
                        " (" + Constants.e + ") ", RegexOptions.IgnoreCase);
                }
                else if (supportedFunctionality[i] == "pi")
                {
                    sanitizee = Regex.Replace(
                        sanitizee, supportedFunctionality[i],
                        " (" + Constants.PI + ") ", RegexOptions.IgnoreCase);
                }
                else
                {
                    sanitizee = Regex.Replace(
                        sanitizee, supportedFunctionality[i] + " *([\\(\\[\\{])",
                        " _" + (i + 1) + "_ $1", RegexOptions.IgnoreCase);
                }
            }

            sanitizee = Regex.Replace(sanitizee, @"\s+", " ").Trim();            // removing whitespaces
            sanitizee = Regex.Replace(sanitizee, @"^-([\(\{\[])", "-1 * $1");    // leading "-" sign
            sanitizee = Regex.Replace(sanitizee, @"([\(\{\[]) *-", "$1-1 * ");
            sanitizee = Regex.Replace(sanitizee, @"[+*/-]$", "");
            sanitizee = Regex.Replace(sanitizee, @"^[+*/]$", "");
            sanitizee = Regex.Replace(sanitizee, @" \. ", " * ");                // "." as * operation
            sanitizee = Regex.Replace(sanitizee, @"([0-9])\. ", "$1.0 ");        // adding trailing "0"
            sanitizee = Regex.Replace(sanitizee, @"\s\.([0-9])", " 0.$1");       // adding leading "0"
            sanitizee = Regex.Replace(sanitizee, @"([0-9\)\}\]])\s*([\[\{\(])", "$1 * $2"); // implicit multiplication
            sanitizee = Regex.Replace(sanitizee, @"([\]\}\)])\s*([0-9\(\{\[])", "$1 * $2");

            // Checking for unidentified tokens
            match = Regex.Match(sanitizee, @"[^0-9._, \[\{\(\]\}\)+*/-]+");
            if (match.Success)
            {
                throw new ArgumentException("The expression contains unsupported token \"" + match.Value + "\".");
            }

            // Checking for mismatching brace closings like 2+{5-)6
            if (Regex.Match(sanitizee, @"[\(][0-9._, +*/-]*[\]\}]").Success ||
                Regex.Match(sanitizee, @"[\[][0-9._, +*/-]*[\)\}]").Success ||
                Regex.Match(sanitizee, @"[\{][0-9._, +*/-]*[\]\)]").Success ||
                Regex.Match(sanitizee, @"[\[\{][0-9._, +*/-]*[\)]").Success ||
                Regex.Match(sanitizee, @"[\(\{][0-9._, +*/-]*[\]]").Success ||
                Regex.Match(sanitizee, @"[\[\(][0-9._, +*/-]*[\}]").Success)
            {
                throw new ArgumentException("The expression contains mismatching braces.");
            }

            // Checking for empty arguments
            if (Regex.Match(sanitizee, @"[\(\{\[][, +*/-]*[\]\}\)]").Success ||
                Regex.Match(sanitizee, @",[ +*/-]*[\]\}\)]").Success ||
                Regex.Match(sanitizee, @"[\[\{\(][ +*/-]*,").Success)
            {
                throw new ArgumentException("Invalid/Null argument(s).");
            }

            return sanitizee;
        }

        // Simplifies all the braces except of the form of (x,y) used for special functions
        private static string Solve01ValueBraces(this string expression)
        {
            string solution = Regex.Replace(expression, @"\s+", " ").Trim();

            while (Regex.Match(solution, @"[\(\{\[][0-9. +*/-]*[\]\}\)]").Success)
            {
                solution = Regex.Replace(solution, @"[\(\{\[][0-9. +*/-]*[\]\}\)]",
                    new MatchEvaluator(match =>
                    {
                        return SolveBasicMath(match.Value.Substring(1, match.Value.Length - 2)).ToString();
                    }));
            }
            
            return solution;
        }

        // Simplifies all the braces of the form of (x+z,y+q) used for special functions
        private static string Solve02ValueBraces(this string expression)
        {
            string solution = Regex.Replace(expression, @"\s+", " ").Trim();

            while (Regex.Match(solution, @"[\(\{\[][0-9. +*/-]+[+*/-][0-9. +*/-]*,").Success)
            {
                solution = Regex.Replace(solution, @"[\(\{\[][0-9. +*/-]+[+*/-][0-9. +*/-]*,",
                    new MatchEvaluator(match =>
                    {
                        return "(" + SolveBasicMath(match.Value.Substring(1, match.Value.Length - 2)).ToString() + " ,";
                    }));
            }

            while (Regex.Match(solution, @",[0-9. +*/-]+[+*/-][0-9. +*/-]*[\)\}\]]").Success)
            {
                solution = Regex.Replace(solution, @",[0-9. +*/-]+[+*/-][0-9. +*/-]*[\)\}\]]",
                    new MatchEvaluator(match =>
                    {
                        return ", " + SolveBasicMath(match.Value.Substring(1, match.Value.Length - 2)).ToString() + ")";
                    }));
            }

            return solution;
        }

        private static string SolveMathFunctions(this string expression)
        {
            double result = 0, arg1, arg2;
            int funcIndex = 0;
            string funcName = null;

            string solution = Regex.Replace(expression, @"\s+", " ").Trim();

            // Solving 01 argument functions
            while (Regex.Match(solution, @"_\d+_ +[0-9.+-]+").Success)
            {
                solution = Regex.Replace(solution, @"_\d+_ +[0-9.+-]+",
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value, @" +");

                        if (args.Length > 0)
                        {
                            if(!int.TryParse(args[0].Trim('_', ' '), out funcIndex)) throw new ArgumentException("Unexpected error occurred while parsing.");
                            funcIndex--; // Saved token was INDEX+1
                        }

                        funcName = supportedFunctionality[funcIndex];

                        if (args.Length < 2) throw new ArgumentException("Not enough arguments for solving \"" + funcName + "\".");

                        if (!double.TryParse(args[1], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        switch(funcName)
                        {
                            // Two argument functions pow(x, y), log(N, base) are handled separately
                            case "sin":   result = Math.Sin(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);       break;
                            case "cos":   result = Math.Cos(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);       break;
                            case "tan":   result = Math.Tan(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);       break;
                            case "cot":   result = 1 / Math.Tan(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);   break;
                            case "sec":   result = 1 / Math.Cos(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);   break;
                            case "csc":   result = 1 / Math.Sin(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);   break;
                            case "cosec": result = 1 / Math.Sin(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);   break;
                            case "asin":  result = Math.Asin(arg1); if (angle_type == AngleType.DEGREE) result *= 180 / Math.PI; break;
                            case "acos":  result = Math.Acos(arg1); if (angle_type == AngleType.DEGREE) result *= 180 / Math.PI; break;
                            case "atan":  result = Math.Atan(arg1); if (angle_type == AngleType.DEGREE) result *= 180 / Math.PI; break;
                            case "sinh":  result = Math.Sinh(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);      break;
                            case "cosh":  result = Math.Cosh(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);      break;
                            case "tanh":  result = Math.Tanh(angle_type == AngleType.DEGREE ? arg1 * Math.PI / 180 : arg1);      break;
                            case "logn":  result = Math.Log(arg1);                                                               break;
                            case "log10": result = Math.Log10(arg1);                                                             break;
                            case "sqrt":  result = Math.Sqrt(arg1);                                                              break;
                            case "abs":   result = Math.Abs(arg1);                                                               break;
                            default:                                                                                             break;
                        }

                        if (result == double.NaN) throw new Exception("The result of computations is NaN.");
                        return (result).ToString();
                    }));
            }

            // Solving 02 argument functions
            while (Regex.Match(solution, @"_\d+_ *[\[\{\(] *[0-9.+-]+ *, *[0-9.+-]+ *[\)\}\]]").Success)
            {
                solution = Regex.Replace(solution, @"_\d+_ *[\[\{\(] *[0-9.+-]+ *, *[0-9.+-]+ *[\)\}\]]",
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value.Replace('(', ' ').Replace(')', ' ')
                                                               .Replace('{', ' ').Replace('}', ' ')
                                                               .Replace('[', ' ').Replace(']', ' ')
                                                               .Replace(',', ' '), @" +");

                        if (args.Length > 0)
                        {
                            if (!int.TryParse(args[0].Trim('_', ' '), out funcIndex)) throw new ArgumentException("Unexpected error occurred while parsing.");
                            funcIndex--; // Saved token was INDEX+1
                        }

                        funcName = supportedFunctionality[funcIndex];

                        if (args.Length < 3) throw new ArgumentException("Not enough arguments for solving \"" + funcName + "\".");

                        if (!double.TryParse(args[1], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");
                        if (!double.TryParse(args[2], out arg2)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        switch (funcName)
                        {
                            // Two argument functions pow(x, y), log(N, base) are handled separately
                            case "pow": result = Math.Pow(arg1, arg2);   break;
                            case "log": result = Math.Log(arg1, arg2);   break;
                            default:
                                break;
                        }

                        if (result == double.NaN) throw new Exception("The result of computations is NaN.");
                        return (result).ToString();
                    }));
            }

            return solution;
        }
        
        private static double SolveBasicMath(string expression)
        {
            double result = 0, arg1, arg2;
            Regex additionRegex       = new Regex(@"[0-9.+-]+ +\+ +[0-9.+-]+");
            Regex subtractionRegex    = new Regex(@"[0-9.+-]+ +- +[0-9.+-]+");
            Regex multiplicationRegex = new Regex(@"[0-9.+-]+ +\* +[0-9.+-]+");
            Regex divisionRegex       = new Regex(@"[0-9.+-]+ +/ +[0-9.+-]+");

            string solution = Regex.Replace(expression, @"\s+", " ").Trim();

            while (divisionRegex.Match(solution).Success)
            {
                solution = divisionRegex.Replace(solution,
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value, @" +/ +");

                        if (args.Length < 2) throw new ArgumentException("Not enough arguments for solving \"" + match.Value + "\".");
                        if (!double.TryParse(args[0], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");
                        if (!double.TryParse(args[1], out arg2)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        return (arg1 / arg2).ToString();
                    }));
            }

            while (multiplicationRegex.Match(solution).Success)
            {
                solution = multiplicationRegex.Replace(solution,
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value, @" +\* +");

                        if (args.Length < 2) throw new ArgumentException("Not enough arguments for solving \"" + match.Value + "\".");
                        if (!double.TryParse(args[0], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");
                        if (!double.TryParse(args[1], out arg2)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        return (arg1 * arg2).ToString();
                    }));
            }

            while (additionRegex.Match(solution).Success)
            {
                solution = additionRegex.Replace(solution,
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value, @" +\+ +");

                        if (args.Length < 2) throw new ArgumentException("Not enough arguments for solving \"" + match.Value + "\".");
                        if (!double.TryParse(args[0], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");
                        if (!double.TryParse(args[1], out arg2)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        return (arg1 + arg2).ToString();
                    }));
            }

            while (subtractionRegex.Match(solution).Success)
            {
                solution = subtractionRegex.Replace(solution,
                    new MatchEvaluator(match =>
                    {
                        string[] args = Regex.Split(match.Value, @" +- +");

                        if (args.Length < 2) throw new ArgumentException("Not enough arguments for solving \"" + match.Value + "\".");
                        if (!double.TryParse(args[0], out arg1)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");
                        if (!double.TryParse(args[1], out arg2)) throw new ArgumentException("Error occurred while parsing \"" + match.Value + "\".");

                        return (arg1 - arg2).ToString();
                    }));
            }

            if (!double.TryParse(solution, out result))
                throw new ArgumentException("Error occurred while parsing \"" + expression + "\".");

            return result;
        }
    }
}
