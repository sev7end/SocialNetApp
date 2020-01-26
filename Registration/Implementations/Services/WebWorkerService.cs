using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using Registration.Abstractions.Models;
using Registration.Abstractions.Services;
using Registration.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Registration.Implementations.Services
{
    public class WebWorkerService : IWebWorkerService
    {
       
        private void Log(string text) { Console.WriteLine(text); }

        private const string API = "https://wworker-cc787.firebaseio.com/";

        private FirebaseClient client = new FirebaseClient(API);
        
        private const string UserTable = "users";
        
        public void AddUserToDatabase(User user)
        {
            string Data = JsonConvert.SerializeObject(user);
            var userData = client.Child("users").PostAsync(Data).Result;

            Log("Uploaded user to db");
        }
        public List<FirebaseObject<T>> GetFirebaseClient<T>()
        {
            var users = client
                .Child(UserTable)
                .OnceAsync<T>()
                .Result
                .ToList();

            return users;
        }
        public List<IUser> GetUsersFromDatabase()
        {
            var users = client
                .Child(UserTable).
                OnceAsync<UserDTO>()
                .Result
                .Select(obj => obj.Object)
                .ToList();
            
            List<IUser> AbstractCollection = users.Select(o => new User()
            {
               //get user profile data here
                ID = o.ID,
                authenticationData = new AuthenticationData()
                {
                    UserName = o.authenticationData.UserName,
                    Password = o.authenticationData.Password
                }
            }).ToList<IUser>();

            return AbstractCollection;
        }
        public int GetLatestID()
        {
            var users = GetUsersFromDatabase();
            if (users.Count != 0)
                return users[users.Count-1].ID + 1;
            else
                return 1;
        }
    }
}
