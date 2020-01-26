using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class NotificationManager : INotificationsManager
    {
        public void FriendRequestGenerator(IUserMiniProfileDTO From, IUserMiniProfileDTO To)
        {
            throw new NotImplementedException();
        }

        public List<INotificationsManager> LoadUserNotifications(IUserMiniProfileDTO userMiniProfileDTO)
        {
            throw new NotImplementedException();
        }

        public void SendNotification(NotificationType type, IUserMiniProfileDTO DestinationUser)
        {
            throw new NotImplementedException();
        }
    }
}
