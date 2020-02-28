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
        
        public async Task AddUserToDatabaseAsync(User user)
        {
            string Data = JsonConvert.SerializeObject(user);
            var userData = await client.Child("users").PostAsync(Data);

            Log("Uploaded user to db");
        }
        public async Task<List<FirebaseObject<T>>> GetFirebaseClientAsync<T>()
        {
            var users = await client
                .Child(UserTable)
                .OnceAsync<T>();
            var collection = users
                .ToList();

            return collection;
        }
        public async Task<List<IUser>> GetUsersFromDatabaseAsync()
        {
            var users =
                await client
                .Child(UserTable).
                OnceAsync<UserDTO>();
                var ToBeRetrieved = users
                .Select(obj => obj.Object)
                .ToList();

            List<IUser> AbstractCollection = ToBeRetrieved.Select(o => new User()
            {
                UserProfileData = o.UserProfileData,
                ID = o.ID,
                authenticationData = new AuthenticationData()
                {
                    UserName = o.authenticationData.UserName,
                    Password = o.authenticationData.Password
                }
            }).ToList<IUser>();

            return AbstractCollection;
        }
        public async Task<int> GetLatestIDAsync()
        {
            var users = await GetUsersFromDatabaseAsync();
            if (users.Count != 0)
                return users[users.Count-1].ID + 1;
            else
                return 1;
        }
    }
}
