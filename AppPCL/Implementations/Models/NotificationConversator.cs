using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    class NotificationConversator
    {
        public UserMiniProfileDTO FromUser { get; set; }
        public UserMiniProfileDTO ToUser { get; set; }
        public bool IsAccepted { get; set; }
    }
}
