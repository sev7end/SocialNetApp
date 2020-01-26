using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Services
{
    public interface INotificationsManager
    {
        List<INotificationsManager> LoadUserNotifications(IUserMiniProfileDTO userMiniProfileDTO);
        void SendNotification(NotificationType type, IUserMiniProfileDTO DestinationUser);
        void FriendRequestGenerator(IUserMiniProfileDTO From, IUserMiniProfileDTO To);
    }
}
