using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int prices = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of "+prices+ " apple(s): ");
            double priceOf6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of 6 apple(s) is " +priceOf6);
            Console.WriteLine("The value of original price is " + priceOf6);
            
            Console.WriteLine("The value of converted price is " + Math.Floor(priceOf6));
            Console.ReadKey();

        }
    }
}
