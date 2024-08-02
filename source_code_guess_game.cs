using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace guess_game
{
    class InvalidGuessException : Exception
    {
        public InvalidGuessException(string message) : base(message)
        {
        }
    }

    class OutOfRangeException : Exception
    {
        public OutOfRangeException(string message) : base(message)
        {
        }
    }
    
    public class InvalidUserInputException : Exception
    { 
        public InvalidUserInputException(string message): base(message){ } 
    
    }

    class Program
    {
        public static void Main(string[]args)
        {
           
            Random rnd = new Random();
            int rNum = rnd.Next(1, 50);

            int guess;
            int trials = 0;
            bool correctGuess = false;

            Console.WriteLine("Guess a number from 1 to 50!");
            do
            {
                try
                {
                     
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        throw new InvalidUserInputException("Invalid input.\nGuess a number from 1 and 50! ");
                    }


                    if (guess < 1 || guess > 50)
                    {
                        throw new OutOfRangeException("Out of range.\nGuess a number from 1 and 50! ");
                    }

                    trials++;


                    if (guess == rNum)
                    {
                        correctGuess = true;
                    }
                    else
                    {

                        Console.WriteLine(guess < rNum ? "Too Low. Try Again" : "Too High. Try Again.");
                    }
                }
                catch (InvalidUserInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            } while (!correctGuess);

            Console.WriteLine($"You got it in {trials} attempt(s)!");
            Console.ReadLine();
        }
    }
}