namespace StatDNS
{
    public class StatDNSAnswer
    {
        public StatDNSClass Class { get; set; }

        public string Name { get; set; }
        public string RData { get; set; }

        public int RDLength { get; set; }

        public int TTL { get; set; }

        public string Type { get; set; }
    }
}