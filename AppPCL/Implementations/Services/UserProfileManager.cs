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
        public async Task<List<IUserMiniProfileDTO>> GetUserFriendsAsync(int ID)
        {
            var user = await webServices.GetUserProfilesAsync();
            var ToBeRetrieved = user.FirstOrDefault(o => o.ID == ID);
            return ToBeRetrieved.userFriends;
        }
        public async Task<List<IUserMiniProfileDTO>> GetUserDTOsByNamesAsync(string name, string lastname)
        {
            var user = await webServices.GetUserMiniProfileDTOsAsync();
            var ToBeRetrieved = user.Where(o => o.Name == name || o.LastName.ToLower() == lastname.ToLower() 
            || $"{name.ToLower()}" == $"{o.Name.ToLower()} {o.LastName.ToLower()}").ToList();
            return ToBeRetrieved;
        }
        public async Task<IUserProfile> LoadUserProfileFromIDAsync(int ID)
        {
            var user = await webServices.GetUserProfilesAsync();
            var ToBeRetrieved = user.FirstOrDefault(o => o.ID == ID);
            return ToBeRetrieved;
        }
        public async Task<IUserProfile> LoadUserProfileFromDTOAsync(IUserMiniProfileDTO userProfileDTO)
        {
            var user = await webServices.GetUserProfilesAsync();
            var ToBeRetrieved = user.FirstOrDefault(o => o.ID == userProfileDTO.ID);
            return ToBeRetrieved;
        }

        public async Task UpdateProfileAsync(IUserProfile userProfile)
        {
            await webServices.UpdateUserProfileAsync(userProfile);
        }
        
        public IUserProfile CreateProfile(int _ID, string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth,Gender _userGender)
        {
            IUserProfile userProfile = new UserProfile()
            {
                Name = _Name,
                LastName = _LastName,
                UserImage = _ImageURL,
                DateOfBirth = _DateOfBirth,
                UserGender = _userGender,
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
