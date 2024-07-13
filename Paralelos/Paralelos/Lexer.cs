using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CompilerApp
{
    public static class Lexer
    {
        private static readonly Regex TokenRegex = new Regex(@"\d+|[a-zA-Z_][a-zA-Z0-9_]*|[=+\-*/;()]");

        public static List<string> Analyze(string code)
        {
            var tokens = new List<string>();
            foreach (Match match in TokenRegex.Matches(code))
            {
                tokens.Add(match.Value);
            }
            return tokens;
        }
    }
}
