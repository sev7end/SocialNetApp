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
        private WebWorkerService _WebWorkerService = null;
        public UserManagerService() {
            _WebService = new WebService();
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
        public void RegisterNewUser(string _name, string _lastName, string _Email, string _password)
        {
            _WebService.AddProfileToServer(new UserProfile()
            {
                ID = _WebWorkerService.GetLatestID(),
                Name = _name,
                LastName = _lastName
            });
            _WebService.AddProfileDtoToServer(new UserMiniProfileDTO()
            {
                ID = _WebWorkerService.GetLatestID(),
                Name = _name,
                LastName = _lastName
            });
            _WebWorkerService.AddUserToDatabase(new User()
            {
                //add profiledata here
                authenticationData = new AuthenticationData() { UserName = _Email, Password = _password },
                ID = _WebWorkerService.GetLatestID()
            });
           
        }
    }
}
