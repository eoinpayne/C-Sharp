using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10___salesmen
{
    class salesmen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many salesmen will you be entering?");
            int quantityOfSalesmen = 0;
            quantityOfSalesmen = Int32.Parse(Console.ReadLine());

            string[] names = new string [quantityOfSalesmen];
            int[] sales = new int[quantityOfSalesmen];
            int totalSales = 0;
            int highestSale = 0;
            string highestSeller = "";

            //put into method - popualte names
            for (int i = 0; i < names.Length; i++)
            {
                //string name = "";
                Console.WriteLine("enter name: "+ (i+1));
                names[i] = Console.ReadLine();
            }
            //put into method - popualte sales
            for (int i = 0; i < names.Length; i++)
            {
                //string name = "";
                Console.WriteLine("how much did " + names[i] + "sell? ");
                sales[i] = Int32.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " earned: " + sales[i]+ ".");
                totalSales += sales[i];
                if (sales[i]> highestSale)
                {
                    highestSale = sales[i];
                    highestSeller = names[i];
                }
            }
            Console.WriteLine("total sales: " + totalSales);
            Console.WriteLine("highest seller: " + highestSeller + " with: E" + highestSale);
        }
    }
}

//take number from user for length of list
//list = salemen name
//list = pay


//    print salesmen name and sales.
//    total of all sales
//    name of higest seller
    
//For each salesman, their name and value of their sales(in euro) are input.When all salesmen have been input, 
//    the program is required to report the following pieces of information:

