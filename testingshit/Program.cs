using Registration.Abstractions.Services;
using Registration.Implementations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingshit
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserManagerService userManager = new UserManagerService();
            //userManager.RegisterNewUser("tornikea", "qurdadzea", "seva", "123a");
            //IWebWorkerService webWorker = new WebWorkerService();
            //var users = webWorker.GetUsersFromDatabase();
            //var user = userManager.LoginUser("seva", "123a");
            Console.ReadKey();
        }
    }
}
