using AppPCL.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    public class Notification : INotification
    {
        public IUserMiniProfileDTO FromUser { get; set; }
        public IUserMiniProfileDTO ToUser { get; set; }
        public bool IsAccepted { get; set; }
    }
}
