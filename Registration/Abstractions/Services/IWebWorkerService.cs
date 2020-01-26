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
        void AddUserToDatabase(User user);
        List<IUser> GetUsersFromDatabase();
        int GetLatestID();
    }
}
