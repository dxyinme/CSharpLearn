using IniUx.Exception;

namespace IniUx
{
    public class IniSection
    {
        public string SectionName { get; }

        public Dictionary<string, string> Kv { get; set; }

        public IniSection(string sectionName)
        { 
            Kv = new();
            SectionName = sectionName;
        }

        public IniSection(string sectionName, Dictionary<string, string> kv) : this(sectionName)
        {
            Kv = kv;
        }
    }
}
