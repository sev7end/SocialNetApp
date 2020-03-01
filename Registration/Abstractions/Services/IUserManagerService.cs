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
        Task RegisterNewUserAsync(string _name, string _lastName, string _Email, string _password, string ImageURL, string _UserGender);
        Task<bool> CheckUserExistenceAsync(string _UserName);
        Task<bool> LoginUserAsync(string _Email, string _Password);
    }
}
