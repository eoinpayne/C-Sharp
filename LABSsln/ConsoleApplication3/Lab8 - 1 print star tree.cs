using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string star = "*";
            for (int i = 1; i <= 5; i++)
            {
                string star = new String('*', i);

                Console.WriteLine(star);
            }
        }
    }
}
