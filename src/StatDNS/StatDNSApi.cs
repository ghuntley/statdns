using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace StatDNS
{
    public interface IStatDNSApi
    {
        [Get("/users/{user}")]
        Task<User> GetUser(string user);
    }
}
