using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Services
{
    public interface IWebServices
    {
        void AddMessageToDatabase(IMessage message);
        void AddNotificationToDatabase(INotification notification);
        void AddProfileDtoToServer(IUserMiniProfileDTO profileDto);
        List<IUserProfile> GetUserProfiles();
        List<INotification> GetNotifications();
        List<IUserMiniProfileDTO> GetUserMiniProfileDTOs();
    }
}
