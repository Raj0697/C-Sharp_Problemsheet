using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class money_exchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====MONEY EXCHANGE CALCULATION===========");
            Console.WriteLine("Enter the amount in INR : ");
            double inr = double.Parse(Console.ReadLine());
            double final = inr / 71;
            Console.WriteLine("The USD of the INR money is :" + final);
            Console.ReadKey();
        }
    }
}
