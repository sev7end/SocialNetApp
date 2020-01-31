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
    public class UserProfileManager : IUserProfileManager
    {
        IWebServices webServices = null;
        public UserProfileManager()
        {
            webServices = new WebService();
        }
        public List<IUserMiniProfileDTO> GetUserFriends(int ID)
        {
            var user = webServices.GetUserProfiles().FirstOrDefault(o => o.ID == ID);
            return user.userFriends;
        }
        public IUserProfile LoadUserProfileFromID(int ID)
        {
            var user = webServices.GetUserProfiles().FirstOrDefault(o => o.ID == ID);
            return user;
        }
        public IUserProfile LoadUserProfileFromDTO(IUserMiniProfileDTO userProfileDTO)
        {
            var user = webServices.GetUserProfiles().FirstOrDefault(o => o.ID == userProfileDTO.ID);
            return user;
        }

        public void UpdateProfile(IUserProfile userProfile)
        {
            webServices.UpdateUserProfile(userProfile);
        }
        
        public IUserProfile CreateProfile(int _ID, string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth)
        {
            IUserProfile userProfile = new UserProfile()
            {
                Name = _Name,
                LastName = _LastName,
                UserImage = _ImageURL,
                DateOfBirth = _DateOfBirth,
                ID = _ID,
                IsProfileSetup = false,
                userFriends = new List<IUserMiniProfileDTO>(),
                userMessages = new List<IMessage>(),
                userNotifications = new List<INotification>()
            };
            return userProfile;
        }
    }
}
