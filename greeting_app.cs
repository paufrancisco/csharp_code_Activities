using System;

namespace GreetingApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();  

            int courses;
            Console.Write("Enter the total number of your enrolled courses: ");
            while (!int.TryParse(Console.ReadLine(), out courses))
            {
                Console.Write("Invalid input. Please enter a valid number for courses: ");
            }

            double bookPrice;
            Console.Write("Enter the price of your favorite book: ");
            while (!double.TryParse(Console.ReadLine(), out bookPrice))
            {
                Console.Write("Invalid input. Please enter a valid number for the book price: ");
            }

            
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total enrolled courses: {courses}");
            Console.WriteLine($"Price of my favorite book: {bookPrice:C}");

            // Wait for user to press Enter before closing
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
