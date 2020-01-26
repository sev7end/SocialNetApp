using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
using AppPCL.Implementations.Models;
using Firebase.Database;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AppPCL.Implementations.Services
{
    public class WebService : IWebServices
    {
        private static string APIUrl = "https://wworker-cc787.firebaseio.com/";
        private string MessageTable = "messages";
        private string ProfileTable = "profiles";
        private string ProfileDTOTable = "profiledtos";
        private string NotificationTable = "notificatins";

        private FirebaseClient firebaseClient = new FirebaseClient(APIUrl);

        private string GetDataTable(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Message:
                    return MessageTable;
                case DataType.Notification:
                    return NotificationTable;
                case DataType.Profile:
                    return ProfileTable;
                case DataType.ProfileDTO:
                    return ProfileDTOTable;
                default:
                    return null;
            }
        }
        private FirebaseObject<string> AddDataToServer(string data, DataType dataType)
        {
            if (dataType != DataType.Profile)
            {
                var userData = firebaseClient.Child(GetDataTable(dataType)).PostAsync(data).Result;
                return null;
            }
            else
                return firebaseClient.Child(GetDataTable(dataType)).PostAsync(data).Result;
        }
        public void UpdateUserProfile(IUserProfile profile)
        {

        }
        public void AddMessageToDatabase(IMessage message)
        {
            var data = JsonConvert.SerializeObject(message);
            AddDataToServer(data, DataType.Message);
        }
        public void AddNotificationToDatabase(INotification notification)
        {
            var data = JsonConvert.SerializeObject(notification);
            AddDataToServer(data, DataType.Notification);
        }
        public void AddProfileToServer(IUserProfile profile)
        {
            var data = JsonConvert.SerializeObject(profile);
            AddDataToServer(data, DataType.Profile);
        }
        public void AddProfileDtoToServer(IUserMiniProfileDTO profileDto)
        {
            var data = JsonConvert.SerializeObject(profileDto);
            AddDataToServer(data, DataType.ProfileDTO);
        }
        public List<IMessage> GetAllMessages() 
        {
            var users = firebaseClient
                .Child(MessageTable).
                OnceAsync<MessageConversator>()
                .Result
                .Select(obj => obj.Object)
                .ToList();

            List<IMessage> AbstractCollection = users.Select(o => new Message()
            {
                MessageFrom = o.MessageFrom,
                MessageTo = o.MessageTo,
                MessageTime = o.MessageTime,
                Text = o.Text
            }).ToList<IMessage>();

            return AbstractCollection;
        }
        public List<IUserProfile> GetUserProfiles()
        {
            var users = firebaseClient
                .Child(MessageTable).
                OnceAsync<UserProfileConversator>()
                .Result
                .Select(obj => obj.Object)
                .ToList();

            List<IUserProfile> AbstractCollection = users.Select(o => new UserProfile()
            {
                ID = o.ID,
                Name = o.Name,
                LastName = o.LastName,
                DateOfBirth = o.DateOfBirth,
                UserImage = o.UserImage,
                userFriends = o.userFriends.Cast<IUserMiniProfileDTO>().ToList(),
                userMessages = o.userMessages.Cast<IMessage>().ToList(),
                userNotifications = o.userNotifications.Cast<INotification>().ToList()
            }).ToList<IUserProfile>();

            return AbstractCollection;
        }
        public List<INotification> GetNotifications()
        {
            var users = firebaseClient
                .Child(MessageTable).
                OnceAsync<NotificationConversator>()
                .Result
                .Select(obj => obj.Object)
                .ToList();

            List<INotification> AbstractCollection = users.Select(o => new Notification()
            {
                FromUser = o.FromUser,
                ToUser = o.ToUser,
                IsAccepted = o.IsAccepted
            }).ToList<INotification>();

            return AbstractCollection;
        }
        public List<IUserMiniProfileDTO> GetUserMiniProfileDTOs()
        {
            var users = firebaseClient
                .Child(MessageTable).
                OnceAsync<UserMiniProfileDTOConversator>()
                .Result
                .Select(obj => obj.Object)
                .ToList();

            List<IUserMiniProfileDTO> AbstractCollection = users.Select(o => new UserMiniProfileDTO()
            {
               ID = o.ID,
               DateOfBirth = o.DateOfBirth, 
               LastName = o.LastName,
               Name = o.Name,
               UserImage = o.UserImage

            }).ToList<IUserMiniProfileDTO>();

            return AbstractCollection;
        }
    }
}
