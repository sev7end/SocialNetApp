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
        public bool LoginUser(string _Email, string _Password)
        {
            IAuthenticationData userCredintals = new AuthenticationData()
            {
                UserName = _Email,
                Password = _Password,
            };
            var user = _WebWorkerService.GetUsersFromDatabase().FirstOrDefault(o => 
            o.authenticationData.UserName == userCredintals.UserName 
            && o.authenticationData.Password == userCredintals.Password);
            if(user != null)
            {
                var UserData = _WebWorkerService.GetFirebaseClient<UserDTO>();
                StaticWebManager.Instance.userInstance = user;
                StaticHolders.Instance.CurrentUser = user.UserProfileData;
                StaticHolders.Instance.CurrentUserDTO = _WebService.GetUserMiniProfileDTOs().FirstOrDefault(o => o.ID == user.ID);
                StaticHolders.Instance.CurrentUserKey = UserData.FirstOrDefault(o => o.Object.ID == user.ID).Key;
                StaticHolders.Instance.CurrentUserID = user.ID;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckUserExistence(string _UserName) 
        {
            return _WebWorkerService.GetUsersFromDatabase().FirstOrDefault(o => o.authenticationData.UserName == _UserName) != null ? true : false;
        }
        public void RegisterNewUser(string _name, string _lastName, string _Email, string _password,string ImageURL)
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
            _WebService.AddItemToDatabase<UserMiniProfileDTO>(new UserMiniProfileDTO()
            {
                ID = _WebWorkerService.GetLatestID(),
                Name = _name,
                LastName = _lastName,
                UserImage = ImageURL,
            }, DataType.ProfileDTO);
            _WebWorkerService.AddUserToDatabase(new User()
            {
                UserProfileData = _UserManager.CreateProfile(_WebWorkerService.GetLatestID(), _name, _lastName, ImageURL, DateTime.Now),
                authenticationData = new AuthenticationData() { UserName = _Email, Password = _password },
                ID = _WebWorkerService.GetLatestID()
            }) ;
           
        }
    }
}
