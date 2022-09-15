using System;
using IniUx;

namespace IniUx.Example 
{
    class ExampleNormal
    {
        static public void Main()
        {
            Dictionary<string, string> wanted = new();
            string normalInfo = @"
[normal_test]
t1=s2248f394j
scemi2=qoe2it74t4
ciciInt=100009
uuuQuota=""123983r""
PPPPP=你好呀";
            IniBody iniBody = new(normalInfo);
            Console.WriteLine(normalInfo);
            foreach (var v in iniBody.Sections()) 
            { 
                Console.WriteLine(v);
            }
        }
    }
    
}