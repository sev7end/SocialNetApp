using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Models
{
    public class MessageConversator
    {
        public UserMiniProfileDTO MessageFrom { get; set; }
        public UserMiniProfileDTO MessageTo { get; set; }
        public string Text { get; set; }
        public DateTime MessageTime { get; set; }
    }
}
