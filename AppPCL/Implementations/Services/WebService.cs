using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
using AppPCL.Implementations.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class WebService : IWebServices
    {
        private static string APIUrl = "https://wworker-cc787.firebaseio.com/";
        private string UsersTable = "Users";
        private string MessageTable = "Messages";
        private string ProfileTable = "UserProfileData";
        private string ProfileDTOTable = "ProfileDtos";
        private string NotificationTable = "Notifications";

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
        public async Task<FirebaseObject<T>> AddDataOfTypeAsync<T>(T Something, DataType DataType)
        {
            var GetThis = await firebaseClient
                .Child(GetDataTable(DataType))
                .PostAsync(Something);
            return GetThis;
        }
        public async Task UpdateDataOfTypeAsync<T>(T Something, DataType dataType, string KeyOfType)
        {
            await firebaseClient
                .Child(GetDataTable(dataType))
                .Child(KeyOfType)
                .PutAsync(Something);
        }
        public async Task DeleteDataOfTypeAsync<T>(T Something, DataType dataType, string KeyOfType)
        {
            await firebaseClient
                .Child(GetDataTable(dataType))
                .Child(KeyOfType)
                .DeleteAsync();
        }
        #region OldShit
        private async Task<FirebaseObject<string>> AddDataToServerAsync(string data, DataType dataType)
        {
            if (dataType != DataType.Profile)
            {
                var userData = await firebaseClient.Child(GetDataTable(dataType)).PostAsync(data);
                return userData;
            }
            else
                return await firebaseClient.Child(GetDataTable(dataType)).PostAsync(data);
        }
        public async Task UpdateUserProfileAsync(IUserProfile profile)
        {
            var data = JsonConvert.SerializeObject(profile);
            await firebaseClient
                .Child("users")
                .Child(StaticHolders.Instance.CurrentUserKey)
                .Child(ProfileTable)
                .PutAsync(data);
        }
        #endregion
        #region Setters
        public async Task AddItemToDatabaseAsync<T>(T item , DataType dataType)
        {
            var data = JsonConvert.SerializeObject(item);
            await AddDataToServerAsync(data, dataType);
        }
        #endregion
        #region Getters
        public async Task<List<IMessage>> GetAllMessagesAsync() 
        {
            var users = await firebaseClient
                .Child(MessageTable).
                OnceAsync<MessageConversator>();

                var ConvertedMessages = 
                users
                .Select(obj => obj.Object)
                .ToList();

            List<IMessage> AbstractCollection = ConvertedMessages.Select(o => new Message()
            {
                MessageFrom = o.MessageFrom,
                MessageTo = o.MessageTo,
                MessageTime = o.MessageTime,
                Text = o.Text
            }).ToList<IMessage>();

            return AbstractCollection;
        }
        public async Task<List<IUserProfile>> GetUserProfilesAsync()
        {
            var fusers = await firebaseClient
                .Child(MessageTable).
                OnceAsync<UserProfileConversator>();
            var users = fusers
                .Select(obj => obj.Object)
                .ToList();

            List<IUserProfile> AbstractCollection = users.Select(o => new UserProfile()
            {
                ID = o.ID,
                Name = o.Name,
                LastName = o.LastName,
                DateOfBirth = o.DateOfBirth,
                UserGender = o.UserGender,
                UserImage = o.UserImage,
                userFriends = o.userFriends.Cast<IUserMiniProfileDTO>().ToList(),
                userMessages = o.userMessages.Cast<IMessage>().ToList(),
                userNotifications = o.userNotifications.Cast<INotification>().ToList()
            }).ToList<IUserProfile>();

            return AbstractCollection;
        }
        public async Task<List<INotification>> GetNotificationsAsync()
        {
            var notifications = await firebaseClient
                .Child(MessageTable).
                OnceAsync<NotificationConversator>();

                var users = notifications
                .Select(obj => obj.Object)
                .ToList();

            List<INotification> AbstractCollection = users.Select(o => new Notification()
            {
                FromUser = o.FromUser,
                ToUser = o.ToUser,
                IsSeen = o.IsAccepted
            }).ToList<INotification>();

            return AbstractCollection;
        }
        public async Task<List<IUserMiniProfileDTO>> GetUserMiniProfileDTOsAsync()
        {
            var fusers = await firebaseClient
                .Child(ProfileDTOTable).
                OnceAsync<UserMiniProfileDTOConversator>();

            var users = fusers   
                .Select(obj => obj.Object)
                .ToList();

            List<IUserMiniProfileDTO> AbstractCollection = users.Select(o => new UserMiniProfileDTO()
            {
               ID = o.ID,
               DateOfBirth = o.DateOfBirth, 
               UserGender = o.UserGender,
               LastName = o.LastName,
               Name = o.Name,
               UserImage = o.UserImage

            }).ToList<IUserMiniProfileDTO>();

            return AbstractCollection;
        }
        #endregion
    }
}
