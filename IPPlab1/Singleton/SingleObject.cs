using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Singleton
{
    public class SingleObject {
        private static SingleObject instance = new SingleObject();

         private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return instance;
        }

        public void ShowAddress()
        {
            Console.WriteLine("We are waiting for you at address: Studentilor 9");
        }
    }
}