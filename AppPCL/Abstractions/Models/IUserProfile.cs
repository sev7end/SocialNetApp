using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Models
{
    public interface IUserProfile
    {
        int ID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string UserImage { get; set; }
        bool IsProfileSetup { get; set; }
        List<IUserMiniProfileDTO> userFriends { get; set; }
        List<INotification> userNotifications { get; set; }
        List<IMessage> userMessages { get; set; }
    }
}
