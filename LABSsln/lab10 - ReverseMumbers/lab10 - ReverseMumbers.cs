using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___ReverseMumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            //Array listOf5 = new Array[4];
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //sum all items in list
            int total = 0;
            foreach (int item in numbers)
            {
              total += item;
                
            } Console.WriteLine("total: " + total);

            //print forward
            Console.WriteLine("forward");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }


            //print in reverse
            Console.WriteLine("reverse");
            for (int i = numbers.Length-1 ; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
