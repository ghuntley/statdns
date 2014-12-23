using Newtonsoft.Json;

namespace StatDNS
{
    public class StatDNSQuestion
    {
        public string Name { get; set; }

        public StatDNSType Type { get; set; }

        public StatDNSClass Class { get; set; }
    }
}