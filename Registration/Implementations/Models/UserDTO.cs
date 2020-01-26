using Registration.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Implementations.Models
{
    class UserDTO
    {
        public int ID { get; set; }
        public AuthenticationData authenticationData { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
