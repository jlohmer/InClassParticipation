using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
         // Declare Variables
            Random rand = new Random();
            int randNumber = rand.Next(1, 100);
            string userChoice;
            int userNumber;

            // Prompt user to guess the random number
            Console.WriteLine("Guess my number! It's between 1 and 100!");
            userChoice = Console.ReadLine();
            userNumber = Convert.ToInt32(userChoice);
            for (int i = 0; i < 100; i++)
            {
                if (userNumber == randNumber)
                {
                    Console.WriteLine("Congradulations! You guessed my number!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Nope, you're wrong! Guess again!\n");
                    userChoice = Console.ReadLine();
                    userNumber = Convert.ToInt32(userChoice);
                }
            }
        }
    }
}
