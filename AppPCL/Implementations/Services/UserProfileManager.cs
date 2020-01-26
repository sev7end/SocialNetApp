using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
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
        UserProfileManager()
        {
            webServices = new WebService();
        }
        public List<IUserMiniProfileDTO> GetUserFriends(int ID)
        {
            var user = webServices.GetUserProfiles().FirstOrDefault(o => o.ID == ID);
            return user.userFriends;
        }

        public IUserProfile LoadUserProfileFromDTO(IUserMiniProfileDTO userProfileDTO)
        {
            var user = webServices.GetUserProfiles().FirstOrDefault(o => o.ID == userProfileDTO.ID);
            return user;
        }

        public void UpdateProfile(IUserProfile userProfile)
        {
            
        }

        public void SetupUserProfileBasics(string _name, string _lastName)
        {
            throw new NotImplementedException();
        }

        public void CreateProfile(string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth)
        {
            throw new NotImplementedException();
        }

        public void AcceptFriendRequest(INotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
