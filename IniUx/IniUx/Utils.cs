using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniUx
{
    public class Utils
    {
        public static bool IsAllMark(string line) 
        {
            return line.Trim()[0] == ';';
        }

        public static void RemoveEndMark(ref string line) 
        {
            bool hasOneQuota = false;
            for (int i = 0; i < line.Length; i++) 
            {
                if (line[i] == '"') 
                {
                    hasOneQuota = !hasOneQuota;
                }
                if (line[i] == ';')
                {
                    if (!hasOneQuota)
                    {
                        line = line[0..i];
                        return;
                    }
                }
            }
        }
    }
}
