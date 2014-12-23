using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace StatDNS
{
    public class StatDNSResponse
    {

        public List<StatDNSAnswer> Answer { get; set; }

        public List<StatDNSAuthority> Authority { get; set; }


        public List<StatDNSQuestion> Question { get; set; }
    }
}