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
        Task<List<IUserMiniProfileDTO>> GetUserDTOsByNamesAsync(string name, string lastname);
        Task<IUserProfile> LoadUserProfileFromIDAsync(int ID);
        Task UpdateProfileAsync(IUserProfile userProfile);
        IUserProfile CreateProfile(int _ID, string _Name, string _LastName, string _ImageURL, DateTime _DateOfBirth, Gender _userGender);
        Task<List<IUserMiniProfileDTO>> GetUserFriendsAsync(int ID);
        Task<IUserProfile> LoadUserProfileFromDTOAsync(IUserMiniProfileDTO userProfileDTO);
    }
}
