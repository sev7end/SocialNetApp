using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Abstractions.Models
{
    public interface IUser
    {
        int ID { get; set; }
        IAuthenticationData authenticationData { get; set; }
        IUserProfile UserProfileData { get; set; }
    }
}
