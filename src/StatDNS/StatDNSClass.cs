using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StatDNS
{
    /// <remarks>http://serverfault.com/questions/220775/what-does-the-in-mean-in-a-zone-file</remarks>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum StatDNSClass
    {
        [EnumMember(Value = "ANY")] Any,

        [EnumMember(Value = "CS")] CSNET,

        [EnumMember(Value = "CH")] CHAOS,

        [EnumMember(Value = "IN")] Internet,

        [EnumMember(Value = "HS")] Hesiod
    }
}
