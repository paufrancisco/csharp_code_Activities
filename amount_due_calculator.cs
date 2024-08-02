using System;

namespace Lab_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize objects
            RunAmountDue run = new RunAmountDue();
            AmountDue due = new AmountDue();

            // Display options to the user
            run.Display();

            // Read user choice
            if (double.TryParse(Console.ReadLine(), out double userChoice))
            {
                switch (userChoice)
                {
                    case 1:
                        // Calculate amount due for price only
                        if (double.TryParse(Console.ReadLine(), out double price1))
                        {
                            double amountDue1 = due.ComputeAmountDue(price1);
                            Console.WriteLine($"The amount due is: {amountDue1:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid price input.");
                        }
                        break;

                    case 2:
                        // Calculate amount due for price and quantity
                        if (double.TryParse(Console.ReadLine(), out double price2) &&
                            double.TryParse(Console.ReadLine(), out double quantity))
                        {
                            double amountDue2 = due.ComputeAmountDue(price2, quantity);
                            Console.WriteLine($"The amount due is: {amountDue2:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid price or quantity input.");
                        }
                        break;

                    case 3:
                        // Calculate amount due for price, quantity, and discount
                        if (double.TryParse(Console.ReadLine(), out double price3) &&
                            double.TryParse(Console.ReadLine(), out double quantity3) &&
                            double.TryParse(Console.ReadLine(), out double discount))
                        {
                            double amountDue3 = due.ComputeAmountDue(price3, quantity3, discount);
                            Console.WriteLine($"The amount due is: {amountDue3:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid price, quantity, or discount input.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.ReadKey();
        }
    }

    class AmountDue
    {
        // Calculate amount due for price only
        public double ComputeAmountDue(double price)
        {
            return price * 1.12;
        }

        // Calculate amount due for price and quantity
        public double ComputeAmountDue(double price, double quantity)
        {
            return (price * quantity) * 1.12;
        }

        // Calculate amount due for price, quantity, and discount
        public double ComputeAmountDue(double price, double quantity, double discount)
        {
            return ((price * quantity) - discount) * 1.12;
        }
    }

    class RunAmountDue
    {
        // Display options to the user
        public void Display()
        {
            Console.WriteLine("Press one of the following options and enter values separated by spaces:");
            Console.WriteLine("1 - Price only");
            Console.WriteLine("2 - Price and quantity");
            Console.WriteLine("3 - Price, quantity, and discount amount");
        }
    }
}
