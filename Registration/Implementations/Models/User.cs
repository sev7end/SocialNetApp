using AppPCL.Abstractions.Models;
using AppPCL.Implementations.Models;
using Registration.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Implementations.Models
{
    public class User : IUser
    {
        public int ID { get; set; }
        public IAuthenticationData authenticationData { get; set; }
        public IUserProfile UserProfileData { get; set; }
    }
}
