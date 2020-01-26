using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Abstractions.Models
{
    public interface IAuthenticationData
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
