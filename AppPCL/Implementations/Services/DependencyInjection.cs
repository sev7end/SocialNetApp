using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public static class DependencyInjection
    {
        static readonly object root = new object();   
        static Dictionary<Type, object> ServiceTypes { get; set; }
        static Dictionary<Type, Type> _Singletons { get; set; }
        static DependencyInjection() { 
            
        }

        public static void AddSingleton<T>(object E) {
            ServiceTypes.Add(typeof(T), E);

        }

        //private void InstatiateObject()
        //{

        //}

        public static object GetType<T>(T type)
        {
            foreach(var items in ServiceTypes)
            {
                if(typeof(T) == items.Key)
                {
                    return items.Value;
                }
            }
            return null;
        }
    }
}
