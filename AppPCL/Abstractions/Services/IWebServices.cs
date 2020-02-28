using AppPCL.Abstractions.Models;
using AppPCL.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Services
{
    public interface IWebServices
    {
        Task<List<IMessage>> GetAllMessagesAsync();
        Task<List<IUserProfile>> GetUserProfilesAsync();
        Task<List<INotification>> GetNotificationsAsync();
        Task<List<IUserMiniProfileDTO>> GetUserMiniProfileDTOsAsync();
        Task UpdateUserProfileAsync(IUserProfile profile);
        Task AddItemToDatabaseAsync<T>(T item, DataType dataType);
    }
}
