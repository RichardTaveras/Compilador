using System;
using System.Collections.Generic;

namespace CompilerApp
{
    public class SymbolTable
    {
        private Dictionary<string, string> symbols;

        public SymbolTable()
        {
            symbols = new Dictionary<string, string>();
        }

        public void AddSymbol(string name, string type)
        {
            if (!symbols.ContainsKey(name))
            {
                symbols[name] = type;
            }
        }

        public string GetSymbol(string name)
        {
            if (symbols.ContainsKey(name))
            {
                return symbols[name];
            }
            return null;
        }

        public override string ToString()
        {
            var result = "Symbol Table:\n";
            foreach (var symbol in symbols)
            {
                result += $"{symbol.Key}: {symbol.Value}\n";
            }
            return result;
        }
    }
}
