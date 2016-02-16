using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classex
{
    class Program
    {
        static void Main(string[] args)
        {                                   // always use default constructor (ctor shortcut)
            Employee e1 = new Employee(); //i no default constructor, .net will put one in


            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e3.Name = "John"; //calling , setting the name.
            string s = e3.Name;

            Manager m = new Manager();
            m.Surname = "walsh";
            m.Name = "john";

            // faster way to initialise that above.
            //open { enter property (or just hit "space") the(,space) will show unused properties
            Manager m2 = new Manager()
            {   Name = "john",
                Surname = "walsh"   };

        }
    }
}
