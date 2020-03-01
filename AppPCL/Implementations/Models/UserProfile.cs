using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    public class UserProfile : IUserProfile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender UserGender { get; set; }
        public string UserImage { get; set; }
        public List<IUserMiniProfileDTO> userFriends { get; set; }
        public List<INotification> userNotifications { get; set; }
        public List<IMessage> userMessages { get; set; }
        public bool IsProfileSetup {  get; set; }
    }
}
