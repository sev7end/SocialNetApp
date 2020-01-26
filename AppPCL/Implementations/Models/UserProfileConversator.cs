using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    class UserProfileConversator
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserImage { get; set; }
        public List<UserMiniProfileDTO> userFriends { get; set; }
        public List<Notification> userNotifications { get; set; }
        public List<Message> userMessages { get; set; }
    }
}
