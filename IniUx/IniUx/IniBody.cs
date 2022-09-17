
using IniUx.Exception;

namespace IniUx
{

    public class IniBody
    {
        Dictionary<string, IniSection> _str2sections 
        {
            get; set; 
        }


        public IniBody(string iniInfoStr)
        {
            _str2sections = new();
            var lines = iniInfoStr.Split("\n");
            string? sectionName;
            IniSection? Section = null;
            foreach (var lineProc in lines)
            {
                var line = lineProc.Trim();
                if (line.Length <= 0) continue;
                if (line[0] == '[' && line[^1] == ']')
                {
                    sectionName = line[1..^1];
                    Section = _str2sections[sectionName] = new(sectionName);
                    continue;
                }
                if (Section == null) {
                    throw new ParseNullSectionException();
                }
                try
                {
                    var res = ParseLineToKv(line);
                    Section.Kv.Add(res.Key, res.Value);
                }
                catch (ParseKvPairException e)
                {
                    Console.WriteLine($"Line={e.Line}, ArrLength={e.ArrLength}");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Dictionary<string, IniSection>.KeyCollection Sections() 
        {
            return _str2sections.Keys;
        }

        public string? GetItem(string sectionName, string key)
        {
            var exist = _str2sections.TryGetValue(sectionName, out IniSection? section);
            if (!exist || section == null) {
                return null;
            }
            section.Kv.TryGetValue(key,out string? res);
            return res;
        }
        static private KeyValuePair<string, string> ParseLineToKv(string line)
        {
            var p = line.Trim().Split("=");
            if (p.Length < 2)
            {
                throw new ParseKvPairException(line, p.Length);
            }
            if (p[1][0] == '"' && p[1][^1] == '"')
            {
                p[1] = p[1][1..^1];
            }
            return new KeyValuePair<string, string>(p[0], p[1]);
        }
    }
}
