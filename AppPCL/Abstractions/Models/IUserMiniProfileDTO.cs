using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Models
{
    public interface IUserMiniProfileDTO
    {
        int ID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender UserGender { get; set; }
        string UserImage { get; set; }
    }
}
