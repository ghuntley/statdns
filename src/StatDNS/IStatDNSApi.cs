using System.Threading.Tasks;
using Refit;

namespace StatDNS
{
    public interface IStatDNSApi
    {
        [Get("/{domain}/a")]
        Task<StatDNSResponse> GetA(string domain);

        [Get("/{domain}/aaaa")]
        Task<StatDNSResponse> GetAAAA(string domain);

        [Get("/{domain}/cert")]
        Task<StatDNSResponse> GetCERT(string domain);

        [Get("/{domain}/dhcid")]
        Task<StatDNSResponse> GetDHCID(string domain);

        [Get("/{domain}/dlv")]
        Task<StatDNSResponse> GetDLV(string domain);

        [Get("/{domain}/dnskey")]
        Task<StatDNSResponse> GetDNSKEY(string domain);

        [Get("/{domain}/ds")]
        Task<StatDNSResponse> GetDS(string domain);

        [Get("/{domain}/hinfo")]
        Task<StatDNSResponse> GetHINFO(string domain);

        [Get("/{domain}/ipseckey")]
        Task<StatDNSResponse> GetIPSECKEY(string domain);

        [Get("/{domain}/kx")]
        Task<StatDNSResponse> GetKX(string domain);

        [Get("/{domain}/loc")]
        Task<StatDNSResponse> GetLOC(string domain);

        [Get("/{domain}/mx")]
        Task<StatDNSResponse> GetMX(string domain);

        [Get("/{domain}/naptr")]
        Task<StatDNSResponse> GetNAPTR(string domain);

        [Get("/{domain}/ns")]
        Task<StatDNSResponse> GetNS(string domain);

        [Get("/{domain}/nsec3param")]
        Task<StatDNSResponse> GetNSEC3PARAM(string domain);

        [Get("/{domain}/rrsig")]
        Task<StatDNSResponse> GetRRSIG(string domain);

        [Get("/{domain}/soa")]
        Task<StatDNSResponse> GetSOA(string domain);

        [Get("/{domain}/spf")]
        Task<StatDNSResponse> GetSPF(string domain);

        [Get("/{domain}/sshfp")]
        Task<StatDNSResponse> GetSSHFP(string domain);

        [Get("/{domain}/txt")]
        Task<StatDNSResponse> GetTXT(string domain);
    }
}