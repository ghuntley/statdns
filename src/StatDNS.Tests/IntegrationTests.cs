using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Refit;

namespace StatDNS.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        public const string BaseApiUrl = "http://api.statdns.com";
        public const string Domain = "statdns.net";
        public readonly IStatDNSApi Client;

        public IntegrationTests()
        {
            Client = RestService.For<IStatDNSApi>(BaseApiUrl);
        }


        public async void GetA()
        {
            var response = await Client.GetA(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.A);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetAAAA()
        {
            var response = await Client.GetAAAA(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.AAAA);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetCERT()
        {
            var response = await Client.GetCERT(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.CERT);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetDHCID()
        {
            var response = await Client.GetDHCID(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.DHCID);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetDLV()
        {
            var response = await Client.GetDLV(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.DLV);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetDNSKEY()
        {
            var response = await Client.GetDNSKEY(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.DNSKEY);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetDS()
        {
            var response = await Client.GetDS(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.DS);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetHINFO()
        {
            var response = await Client.GetHINFO(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.HINFO);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetIPSECKEY()
        {
            var response = await Client.GetIPSECKEY(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.IPSECKEY);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetKX()
        {
            var response = await Client.GetKX(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.KX);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetLOC()
        {
            var response = await Client.GetLOC(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.LOC);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetMX()
        {
            var response = await Client.GetMX(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.MX);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetNAPTR()
        {
            var response = await Client.GetNAPTR(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.NAPTR);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetNS()
        {
            var response = await Client.GetNS(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.NS);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetNSEC3PARAM()
        {
            var response = await Client.GetNSEC3PARAM(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.NSEC3PARAM);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetRRSIG()
        {
            var response = await Client.GetRRSIG(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.RRSIG);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetSOA()
        {
            var response = await Client.GetSOA(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.SOA);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetSPF()
        {
            var response = await Client.GetSPF(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.SPF);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetSSHFP()
        {
            var response = await Client.GetSSHFP(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.SSHFP);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }


        [Test]
        public async void GetTXT()
        {
            var response = await Client.GetTXT(Domain);
            response.Question.Single().Name.Should().Be(Domain + ".");
            response.Question.Single().Type.Should().Be(StatDNSType.TXT);
            response.Question.Single().Class.Should().Be(StatDNSClass.Internet);
        }
    }
}