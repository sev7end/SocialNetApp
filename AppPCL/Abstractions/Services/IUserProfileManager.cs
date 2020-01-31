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
        IUserProfile LoadUserProfileFromID(int ID);
        void UpdateProfile(IUserProfile userProfile);
        IUserProfile CreateProfile(int _ID, string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth);
        List<IUserMiniProfileDTO> GetUserFriends(int ID);
        IUserProfile LoadUserProfileFromDTO(IUserMiniProfileDTO userProfileDTO);
    }
}
