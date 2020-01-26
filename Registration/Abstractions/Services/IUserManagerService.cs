using Registration.Abstractions.Models;
using Registration.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Abstractions.Services
{
    public interface IUserManagerService
    {
        void RegisterNewUser(string _name, string _lastName, string _Email, string _password);
        bool CheckUserExistence(string _UserName);
        IUser LoginUser(string _Email, string _Password);
    }
}
