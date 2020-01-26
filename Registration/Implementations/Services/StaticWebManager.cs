using Registration.Abstractions.Models;
using Registration.Implementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Implementations.Services
{
    public class StaticWebManager
    {
        private static StaticWebManager _instance = null;

        private static readonly object root = new object();
        public static StaticWebManager Instance 
        { 
            get
            {
                if(_instance == null)
                {
                    lock (root)
                    {
                        if(_instance == null)
                        {
                            _instance = new StaticWebManager();
                        }
                    }
                }
                return _instance;
            } 
        }
        public IUser userInstance { get; set; }

    }
}
