using Registration.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Implementations.Models
{
    public class AuthenticationData : IAuthenticationData
    {
        public string UserName { get;set; }
        public string Password { get;set; }
    }
}
