using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
using AppPCL.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class NotificationManager : INotificationsManager
    {
        IWebServices webServices = null;
        IUserProfileManager profileManager = null;

        NotificationManager()
        {
            profileManager = new UserProfileManager();
            webServices = new WebService();
        }
        public async void FriendRequestGenerator(IUserMiniProfileDTO From, int ToID)
        {
            IUserProfile userProfile = await profileManager.LoadUserProfileFromIDAsync(ToID);
            var item = await webServices.GetUserMiniProfileDTOsAsync();
            var UserDTO = item.FirstOrDefault(o => o.ID == userProfile.ID);
            IUserMiniProfileDTO userMiniProfile = UserDTO;
                
            userProfile.userNotifications.Add(new Notification()
            {
                FromUser = From,
                ToUser = userMiniProfile,
                IsAccepted = false
            });

            //TODO: Finish this off
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
