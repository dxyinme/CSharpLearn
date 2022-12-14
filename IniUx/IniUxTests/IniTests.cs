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
            var queries = new List<Tuple<string, string, string>> {
                new("normal_test", "t1", "s2248f394j"),
                new("normal_test", "scemi2", "qoe2it74t4"),
                new("normal_test", "ciciInt", "100009"),
                new("normal_test", "uuuQuota", "123983r"),
                new("normal_test", "PPPPP", "你好呀"),
                new("XXXOi我", "tag1", "1"),
                new("XXXOi我", "tag2", "2"),
                new("XXXOi我", "tag3", "3"),
            };
            string normalInfo = @"
[normal_test]
t1=s2248f394j
scemi2=qoe2it74t4
ciciInt=100009
uuuQuota=""123983r""
PPPPP=你好呀
[XXXOi我]
tag1=1
tag2=2
tag3=3
";
            IniBody body = new(normalInfo);
            foreach (var q in queries)
            {
                Assert.Equal(q.Item3, body.GetItem(q.Item1, q.Item2));
            }
        }

        [Fact]
        public void ReadFileNormalTest()
        {
            var queries = new List<Tuple<string, string, string>> {
                
            };
            var fileName = "testdata/normal_withoutmark.ini";
            var content = File.ReadAllText(fileName);
            IniBody body = new(content);
            foreach (var q in queries)
            {
                Assert.Equal(q.Item3, body.GetItem(q.Item1, q.Item2));
            }
        }
    }
}