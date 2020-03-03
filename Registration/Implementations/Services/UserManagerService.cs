using AppPCL.Abstractions.Models;
using AppPCL.Implementations.Models;
using AppPCL.Implementations.Services;
using Newtonsoft.Json;
using Registration.Abstractions.Models;
using Registration.Abstractions.Services;
using Registration.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Implementations.Services
{
    public class UserManagerService : IUserManagerService
    {
        private WebService _WebService = null;
        private UserProfileManager _UserManager = null;
        private WebWorkerService _WebWorkerService = null;
        public UserManagerService() {
            _WebService = new WebService();
            _UserManager = new UserProfileManager();
            _WebWorkerService = new WebWorkerService(); 
        }
        public async Task<bool> LoginUserAsync(string _Email, string _Password)
        {
            IAuthenticationData userCredintals = new AuthenticationData()
            {
                UserName = _Email,
                Password = _Password,
            };
            var userToBeLoaded = await _WebWorkerService.GetUsersFromDatabaseAsync();
                var user = userToBeLoaded.FirstOrDefault(o => 
            o.authenticationData.UserName.ToLower() == userCredintals.UserName.ToLower() 
            && o.authenticationData.Password == userCredintals.Password);
            if(user != null)
            {
                var UserData = await _WebWorkerService.GetFirebaseClientAsync<UserDTO>();
                StaticWebManager.Instance.userInstance = user;
                StaticHolders.Instance.CurrentUser = user.UserProfileData;
                var holder = await _WebService.GetUserMiniProfileDTOsAsync();
                StaticHolders.Instance.CurrentUserDTO = holder.FirstOrDefault(o => o.ID == user.ID);
                StaticHolders.Instance.CurrentUserKey = UserData.FirstOrDefault(o => o.Object.ID == user.ID).Key;
                StaticHolders.Instance.CurrentUserID = user.ID;
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> CheckUserExistenceAsync(string _UserName) 
        {
            var holder = await _WebWorkerService.GetUsersFromDatabaseAsync();
            return holder.FirstOrDefault(o => o.authenticationData.UserName == _UserName) != null ? true : false;
        }
        public async Task RegisterNewUserAsync(string _name, string _lastName, string _Email, string _password,string ImageURL,string _UserGender)
        {
            #region unnecessary 
            /*
            _WebService.AddItemToDatabase(new UserProfile()
            {
                ID = _WebWorkerService.GetLatestID(),
                Name = _name,
                LastName = _lastName
            });*/
            #endregion
            Gender gender;
            Enum.TryParse(_UserGender, out gender);
            await _WebService.AddItemToDatabaseAsync<UserMiniProfileDTO>(new UserMiniProfileDTO()
            {
                ID = await _WebWorkerService.GetLatestIDAsync(),
                Name = _name,
                UserGender = gender,
                LastName = _lastName,
                UserImage = ImageURL,
            }, DataType.ProfileDTO) ;
           await _WebWorkerService.AddUserToDatabaseAsync(new User()
            {
                UserProfileData = _UserManager.CreateProfile(await _WebWorkerService.GetLatestIDAsync(), _name, _lastName, ImageURL, DateTime.Now, gender),
                authenticationData = new AuthenticationData() { UserName = _Email, Password = _password },
                ID = await _WebWorkerService.GetLatestIDAsync()
            }) ;
           
        }
    }
}
