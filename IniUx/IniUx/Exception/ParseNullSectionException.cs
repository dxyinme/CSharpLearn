using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniUx.Exception
{
    public class ParseNullSectionException : System.Exception
    {
        public string message { get; }
        public ParseNullSectionException() 
        {
            message = "ParseNullSectionException";
        }
    }
}
