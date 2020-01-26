using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Models
{
    public interface IMessage
    {
        IUserMiniProfileDTO MessageFrom { get; set; }
        IUserMiniProfileDTO MessageTo { get; set; }
        string Text { get; set; }
        DateTime MessageTime { get; set; }
    }
}
