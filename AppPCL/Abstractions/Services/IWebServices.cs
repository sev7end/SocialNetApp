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
        List<IUserProfile> GetUserProfiles();
        List<INotification> GetNotifications();
        List<IUserMiniProfileDTO> GetUserMiniProfileDTOs();
        void UpdateUserProfile(IUserProfile profile);
        void AddItemToDatabase<T>(T item, DataType dataType);
    }
}
