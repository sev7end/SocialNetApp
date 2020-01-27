using AppPCL.Abstractions.Models;
using AppPCL.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class MessagesManager : IMessagesManager
    {
        public void AddMessageToConverstation(IUserMiniProfileDTO MessageFrom, IUserMiniProfileDTO MessageTo, string text)
        {
            throw new NotImplementedException();
        }

        public List<IMessage> LoadUserMessages(IUserMiniProfileDTO userMiniProfileDTO)
        {
            throw new NotImplementedException();
        }
    }
}
