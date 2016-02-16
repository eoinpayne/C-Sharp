using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classex
{
    class Manager
    {

        public static int numberOfManagers = 2; 

        public string Name { get; set; } // can set accessability in here
        public string Surname { get; set; }

        public Manager()
        {
            Name = "";
            Surname = "";
        }

        public void SaveManagerToDB()
        {
            //save name to db
        }
        private void GenerateManagerReport()
        {

        }
        //static method, does not need object instantiation to use. "global" to the class, all instantiated objects can see the SAME number of managers. To call you type class.method
        public static void PrintNumberOfManagers() 
        {
            Console.WriteLine(numberOfManagers);
        }
        
    }
}
