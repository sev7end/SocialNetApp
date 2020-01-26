using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Services
{
    public interface IMessagesManager
    {
        void AddMessageToConverstation(IUserMiniProfileDTO MessageFrom, IUserMiniProfileDTO MessageTo, string text);
        List<IMessage> LoadUserMessages(IUserMiniProfileDTO userMiniProfileDTO);
    }
}
