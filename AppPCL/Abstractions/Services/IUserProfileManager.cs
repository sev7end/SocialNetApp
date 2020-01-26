using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Services
{
    public interface IUserProfileManager
    {
        void SetupUserProfileBasics(string _name, string _lastName);
        void UpdateProfile(IUserProfile userProfile);
        void CreateProfile(string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth);
        List<IUserMiniProfileDTO> GetUserFriends(int ID);
        IUserProfile LoadUserProfileFromDTO(IUserMiniProfileDTO userProfileDTO);
        void AcceptFriendRequest(INotification notification);
    }
}
