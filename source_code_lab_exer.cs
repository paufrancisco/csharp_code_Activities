using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefi_Activity
{

    //<access modifier> delegate <return type> <delegate-name> (<parameters>).
    public delegate double getAnswer(double x, double y);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the 1st number: "); //ask the first number
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: "); //ask the second number
            double num2 = Convert.ToDouble(Console.ReadLine());

            getAnswer getSum = new getAnswer(Add);
            getAnswer getDifference = new getAnswer(Sub);
            getAnswer getQuotient = new getAnswer(Divide);
            getAnswer getProduct = new getAnswer(Multiply);
            getAnswer getModulo = new getAnswer(Modulo);

            
            Console.WriteLine("Enter Operation: "); //let the user choose operation
            string operation = Console.ReadLine();
            
            if (operation == "+")
            {
                Console.WriteLine("You selected addition");
                Console.WriteLine("The result is: " + getSum(num1, num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("You selected subtraction");
                Console.WriteLine("The result is: " + getDifference(num1, num2));
            }
            else if (operation == "/")
            {
                Console.WriteLine("You selected division");
                Console.WriteLine("The result is: "+ getQuotient(num1, num2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("You selected multiply");
                Console.WriteLine("The result is: " + getProduct(num1, num2));
            }
            else if (operation == "%")
            {
                Console.WriteLine("You selected modulo");
                Console.WriteLine("The result is: " + getModulo(num1, num2));
            }
            else
            {
                Console.WriteLine("Input valid operation");
            }
            Console.ReadKey();

        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Modulo(double x, double y)
        {
            return x%y;
        }
    }
}
        