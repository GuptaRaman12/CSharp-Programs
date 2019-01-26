using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaterCGPA
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int coin1, coin2, coin3, coin4,totalRupees;
            Console.WriteLine("Enter the number of coin of Rupee 10");
            coin1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of coin of Rupee 5");
            coin2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of coin of Rupee 2");
            coin3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of coin of Rupee 1");
            coin4 = int.Parse(Console.ReadLine());
            totalRupees = (coin1 * 10) + (coin2 * 5) + (coin3 * 2) + (coin4 * 1);
            Console.WriteLine("Total Amount in your Piggy Bank is " + totalRupees);
            Console.ReadLine();

        }
    }
}
