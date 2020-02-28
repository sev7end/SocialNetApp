using Firebase.Database;
using Registration.Abstractions.Models;
using Registration.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Abstractions.Services
{
    public interface IWebWorkerService
    {
        Task AddUserToDatabaseAsync(User user);
        Task<List<FirebaseObject<T>>> GetFirebaseClientAsync<T>();
        Task<List<IUser>> GetUsersFromDatabaseAsync();
        Task<int> GetLatestIDAsync();
    }
}
