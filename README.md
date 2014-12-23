
# IStatDNS Generator

On http://www.statdns.com/api/ via the developer console inject jQuery as per https://ghuntley.com/embed-jquery-via-developer-console/ and then run the following code:

 
    window.apibuilder = ""
    $('a').each(function() {
        var link = $(this).attr('href');
    
        if (link)
        {
            if (link.indexOf("http://api.statdns.com/statdns.net") > -1)
            {
                var segments = link.split("/");
                var route = segments[4];
            
                var methodname = "Get" + route.toUpperCase();
            
                window.apibuilder += '[Get("/{domain}/' + route + '")]';
                window.apibuilder += "\n";
                window.apibuilder += 'Task<StatDNSResponse> ' + methodname + '(string domain);';
                window.apibuilder += "\n\n";
            }

        }
    });

    console.debug(window.apibuilder);


Example output:

    [Get("{domain}/a)]
    Task<StatDNSResponse> GetA(string domain);

    [Get("{domain}/aaaa)]
    Task<StatDNSResponse> GetAAAA(string domain);

    [Get("{domain}/cert)]
    Task<StatDNSResponse> GetCERT(string domain);

    [Get("{domain}/dhcid)]
    Task<StatDNSResponse> GetDHCID(string domain);

    [Get("{domain}/dlv)]
    Task<StatDNSResponse> GetDLV(string domain);

    [Get("{domain}/dnskey)]
    Task<StatDNSResponse> GetDNSKEY(string domain);

    [Get("{domain}/ds)]
    Task<StatDNSResponse> GetDS(string domain);

    [Get("{domain}/hinfo)]
    Task<StatDNSResponse> GetHINFO(string domain);

    [Get("{domain}/ipseckey)]
    Task<StatDNSResponse> GetIPSECKEY(string domain);

    [Get("{domain}/kx)]
    Task<StatDNSResponse> GetKX(string domain);

    [Get("{domain}/loc)]
    Task<StatDNSResponse> GetLOC(string domain);

    [Get("{domain}/mx)]
    Task<StatDNSResponse> GetMX(string domain);

    [Get("{domain}/naptr)]
    Task<StatDNSResponse> GetNAPTR(string domain);

    [Get("{domain}/ns)]
    Task<StatDNSResponse> GetNS(string domain);

    [Get("{domain}/nsec3param)]
    Task<StatDNSResponse> GetNSEC3PARAM(string domain);

    [Get("{domain}/rrsig)]
    Task<StatDNSResponse> GetRRSIG(string domain);

    [Get("{domain}/soa)]
    Task<StatDNSResponse> GetSOA(string domain);

    [Get("{domain}/spf)]
    Task<StatDNSResponse> GetSPF(string domain);

    [Get("{domain}/sshfp)]
    Task<StatDNSResponse> GetSSHFP(string domain);

    [Get("{domain}/txt)]
    Task<StatDNSResponse> GetTXT(string domain);


# Integration Test Generator

On http://www.statdns.com/api/ via the developer console inject jQuery as per https://ghuntley.com/embed-jquery-via-developer-console/ and then run the following code:

    window.testbuilder  += '';
    $('a').each(function() {
        var link = $(this).attr('href');

        if (link)
        {
            if (link.indexOf('http://api.statdns.com/statdns.net') > -1)
            {
                var segments = link.split('/');
                var route = segments[4].toUpperCase();

                var methodname = 'Get' + route;

                window.testbuilder  += '[Test] \n';
                window.testbuilder  += 'public async void ' + methodname + '() \n';
                window.testbuilder  += '{ \n';
                window.testbuilder  += '    var response = await Client.' + methodname + '(Domain); \n';

                window.testbuilder  += '    response.Question.Single().Name.Should().Be(Domain + "."); \n';
                window.testbuilder  += '    response.Question.Single().Type.Should().Be(StatDNSType.' + route +'); \n';
                window.testbuilder  += '    response.Question.Single().Class.Should().Be(StatDNSClass.Internet); \n';
                window.testbuilder  += '} \n\n\n';

            }

        }
    });

    console.debug(window.testbuilder);

Example Output:

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
