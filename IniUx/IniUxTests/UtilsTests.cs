using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IniUxTests
{
    public class UtilsTests
    {
        [Fact]
        public static void RemoveEndMarkTest1() 
        {
            var queries = new List<Tuple<string, string>>{
                new("xxxxxxx=wenf742t2tjer2o388", "xxxxxxx=wenf742t2tjer2o388"),
                new("xxxxxxx=wenf742t2tjer2o388 ;2233333333121313jr8", "xxxxxxx=wenf742t2tjer2o388 "),
                new("efuefe8;ej839=weej11-2", "efuefe8"),
                new("[\"dfdfdfcccci9;\"];", "[\"dfdfdfcccci9;\"]"),
                new("ufkfru=\"ddfdfd;f233333\"", "ufkfru=\"ddfdfd;f233333\""),
            };
            foreach (var query in queries)
            {
                var markBefore = query.Item1;
                IniUx.Utils.RemoveEndMark(ref markBefore);
                Assert.Equal(query.Item2, markBefore);
            }
        }
    }
}
