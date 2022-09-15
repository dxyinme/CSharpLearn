using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniUx.Exception
{
    public class ParseKvPairException : System.Exception
    {

        public string? Line { get; }

        public int ArrLength { get; }
        public ParseKvPairException() { }
        public ParseKvPairException(string? line, int arrLength) 
        {
            Line = line;
            ArrLength = arrLength;
        }
    }
}
