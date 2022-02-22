using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extension
    {
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4"); 
        }
        
        public static void M5(this Geek g, string msg)
        {
            Console.WriteLine(msg); 
        }

    }
}
