using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    public class Message : IMessage
    {
        public IUserMiniProfileDTO MessageFrom { get; set; }
        public IUserMiniProfileDTO MessageTo { get; set; }
        public string Text { get; set; }
        public DateTime MessageTime { get; set; }
    }
}
