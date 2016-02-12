using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)

        {
            int carCount = 0;
            int passengerCount = 0;
            int chargesCount = 0;
            int singlePassengerCarCount = 0;
            string morePassengersToLoad = "yes";
            do
            {
                carCount++;
                Console.WriteLine("Enter reg of car number" + carCount);
                string carReg = Console.ReadLine();
                carReg.ToUpper();  //put in method
                Console.WriteLine("how many passengers in car with reg" + carReg);
                int numberOfPassengers = Int32.Parse(Console.ReadLine()); //make sure only >0
                int chargePerCar = 100;
                passengerCount += numberOfPassengers;
                if (numberOfPassengers > 1)
                {
                    for (int i = 0; i < numberOfPassengers; i++)
                    {
                        Console.WriteLine("is passenger" + i + "under 18? Yes or No");
                        string under18 = Console.ReadLine();
                        under18.ToLower();
                        if (under18 == "yes") chargePerCar += 10;
                        else if (under18 == "no") chargePerCar += 20;  //put in method                        
                    }                    
                }   else singlePassengerCarCount++;
                chargesCount += chargePerCar;
                Console.WriteLine("carCount" + carCount);
                Console.WriteLine("chargesCount" + chargesCount);
                Console.WriteLine("passengerCount" + passengerCount);
                Console.WriteLine("singlePassengerCarCount" + singlePassengerCarCount);

                Console.WriteLine("More cars to board?");
                morePassengersToLoad = Console.ReadLine();
                morePassengersToLoad.ToLower();
            } while (morePassengersToLoad == "yes");

            Console.WriteLine("finished loading cars");
            Console.WriteLine("Total carCount " + carCount);
            Console.WriteLine("Total chargesCount " + chargesCount);
            Console.WriteLine("Total passengerCount " + passengerCount);
            Console.WriteLine("Total singlePassengerCarCount " + singlePassengerCarCount);

            //    break if no more cars
            //        ====
            //    print total cars + total passengers
            //    print total charges
            //    print total number of cars with only 1 passenger


        }
    }
}
