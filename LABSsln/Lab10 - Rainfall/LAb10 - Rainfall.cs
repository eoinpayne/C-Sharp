using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10___Rainfall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[7] { 2, 4, 1, 7, 6, 4, 6 };
            int totalRain = 0;

            for (int i = 0; i < rainfall.Length; i++)
            {
                totalRain += i;
                if (i > 3.5)
                {
                    Console.WriteLine("day number " + i + "exceeded 3.5cm");
                    // make it so "i" represents day of the week.
                }
            }

            Console.WriteLine("total rainfall in cm : " + totalRain);
            Console.WriteLine("Average rainfall in cm : " + totalRain/rainfall.Length);
        }
    }
}


//Write a program which reads in the rainfall(in cm) amount for a week into an array.
//    The program should then calculate and output the total rainfall for the week and the average rainfall.
//    If on any day the rainfall exceeded 3.5cm a message indicating this should be output to the user. (Rainfall.java)


