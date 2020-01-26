using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Abstractions.Models
{
    public interface INotification
    {
        IUserMiniProfileDTO FromUser { get; set; }
        IUserMiniProfileDTO ToUser { get; set; }
        bool IsAccepted { get; set; }
    }
}
