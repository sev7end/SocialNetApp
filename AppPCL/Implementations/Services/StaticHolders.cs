using AppPCL.Abstractions.Models;
using AppPCL.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class StaticHolders
    {
        private static StaticHolders _instance = null;
        private static readonly object locker = new object();
        private StaticHolders() { }
        public static StaticHolders Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (locker)
                    {
                        if(_instance == null)
                        {
                            _instance = new StaticHolders();
                        }
                    }
                }
                return _instance;
            }
        }
        public string CurrentUserKey { get; set; }
        public int CurrentUserID { get; set; }
        public IUserProfile CurrentUser { get; set; }
        public IUserMiniProfileDTO CurrentUserDTO { get; set; }

        public void SignOut()
        {
            CurrentUser = null;
            CurrentUserDTO = null;
            CurrentUserID = -1;
            CurrentUserKey = null;
        }
    }
}
