using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades according to its subject: ");
            int[]grades = new int[5];
            string[] subject = { "Math ", "Science ", "English ", "GMRC ", "P.E " };
            double sum = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.Write(subject[i]+": ");
                grades[i]=Convert.ToInt32(Console.ReadLine());
                sum += grades[i];

            }
            double ave = sum / grades.Length;
            Console.WriteLine("The average is " + ave + " and round off to " + Math.Round(ave));
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}
