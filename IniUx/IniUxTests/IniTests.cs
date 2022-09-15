using Xunit;
using IniUx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniUx.Tests
{
    public class IniTests
    {
        [Fact]
        public void ReadContentNormalTest()
        {
            Dictionary<string, string> wanted = new();
            wanted.Add("t1", "s2248f394j");
            wanted.Add("scemi2", "qoe2it74t4");
            wanted.Add("ciciInt", "100009");
            wanted.Add("uuuQuota", "123983r");
            wanted.Add("PPPPP", "你好呀");
            var wantedSectionName = "normal_test";
            string normalInfo = @"
[normal_test]
t1=s2248f394j
scemi2=qoe2it74t4
ciciInt=100009
uuuQuota=""123983r""
PPPPP=你好呀";
            IniSection iniSection = new(normalInfo);
            foreach (var k in wanted) 
            {
                Assert.Equal(k.Value, iniSection.Kv[k.Key]);
            }
            Assert.True(iniSection.Kv.SequenceEqual(wanted));
            Assert.True(iniSection.SectionName.Equals(wantedSectionName));
        }
    }
}