using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {

        public static double getN()
        {
            Console.WriteLine("Enter nth power to multiply by");
            while (true)
            {
                double n = double.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("try again, number must be >=0");
                else return n;
            }
        }

        public static double CalcPower(int num, double n)
        {
            double answer = Math.Pow(num, n);
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter whole number to multiply");
            int number = Int32.Parse(Console.ReadLine());  //check minus
            double n = getN();
            Console.WriteLine("n =" + n);
            double answer = CalcPower(number, n);
            Console.WriteLine(answer);



        }
    }
}




////Design and develop a program that raises a whole number to the nth power.
//The user should input the number and the power the 
//number is to be raised to e.g. 24 = 16, 43 = 64 etc.The program should only accept powers greater than or equal to 0, and display an error 
//    message if an invalid power is entered.A number raised to the power of 0 is 1.

////Write pseudocode and C# for the above problem.