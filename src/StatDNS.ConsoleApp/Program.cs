using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Refit;

namespace StatDNS.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        private static async Task MainAsync(string[] args)
        {
            const string apiUrl = "http://api.statdns.com";
            const string domain = "statdns.net";

            var client = RestService.For<IStatDNSApi>(apiUrl);

            Console.WriteLine("Retrieving A record(s) for '{0}':", domain);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetA(domain)));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Retrieving CNAME record(s) for '{0}':", domain);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetTXT(domain)));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Retrieving MX record(s) for '{0}':", domain);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetMX(domain)));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Retrieving TXT record(s) for '{0}':", domain);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetTXT(domain)));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Retrieving NS record(s) for '{0}':", domain);
            Console.WriteLine(JsonConvert.SerializeObject(await client.GetNS(domain)));
            Console.WriteLine(Environment.NewLine);

            Console.ReadLine();


            //Retrieving A record(s) for 'statdns.net':
            //{"Answer":[{"Class":"IN","Name":"statdns.net.","RData":"46.19.37.108","RDLength"
            //:4,"TTL":543,"Type":"A"}],"Authority":[{"Class":"IN","Name":"statdns.net.","RDat
            //a":"ns1.statdns.com.","RDLength":17,"TTL":543,"Type":"NS"},{"Class":"IN","Name":
            //"statdns.net.","RData":"ns2.statdns.com.","RDLength":6,"TTL":543,"Type":"NS"}],"
            //Question":[{"Name":"statdns.net.","Type":"A","Class":"IN"}]}


            //Retrieving CNAME record(s) for 'statdns.net':
            //{"Answer":[{"Class":"IN","Name":"statdns.net.","RData":"\"Get more information o
            //n : http://www.statdns.net\"","RDLength":49,"TTL":483,"Type":"TXT"}],"Authority"
            //:[{"Class":"IN","Name":"statdns.net.","RData":"ns1.statdns.com.","RDLength":17,"
            //TTL":542,"Type":"NS"},{"Class":"IN","Name":"statdns.net.","RData":"ns2.statdns.c
            //om.","RDLength":6,"TTL":542,"Type":"NS"}],"Question":[{"Name":"statdns.net.","Ty
            //pe":"TXT","Class":"IN"}]}


            //Retrieving MX record(s) for 'statdns.net':
            //{"Answer":[{"Class":"IN","Name":"statdns.net.","RData":"10 statdns.net.","RDLeng
            //th":4,"TTL":543,"Type":"MX"}],"Authority":[{"Class":"IN","Name":"statdns.net.","
            //RData":"ns1.statdns.com.","RDLength":17,"TTL":542,"Type":"NS"},{"Class":"IN","Na
            //me":"statdns.net.","RData":"ns2.statdns.com.","RDLength":6,"TTL":542,"Type":"NS"
            //}],"Question":[{"Name":"statdns.net.","Type":"MX","Class":"IN"}]}


            //Retrieving TXT record(s) for 'statdns.net':
            //{"Answer":[{"Class":"IN","Name":"statdns.net.","RData":"\"Get more information o
            //n : http://www.statdns.net\"","RDLength":49,"TTL":483,"Type":"TXT"}],"Authority"
            //:[{"Class":"IN","Name":"statdns.net.","RData":"ns1.statdns.com.","RDLength":17,"
            //TTL":542,"Type":"NS"},{"Class":"IN","Name":"statdns.net.","RData":"ns2.statdns.c
            //om.","RDLength":6,"TTL":542,"Type":"NS"}],"Question":[{"Name":"statdns.net.","Ty
            //pe":"TXT","Class":"IN"}]}


            //Retrieving NS record(s) for 'statdns.net':
            //{"Answer":[{"Class":"IN","Name":"statdns.net.","RData":"ns1.statdns.com.","RDLen
            //gth":17,"TTL":541,"Type":"NS"},{"Class":"IN","Name":"statdns.net.","RData":"ns2.
            //statdns.com.","RDLength":6,"TTL":541,"Type":"NS"}],"Authority":null,"Question":[
            //{"Name":"statdns.net.","Type":"NS","Class":"IN"}]}
        }
    }
}