using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Functions_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jason Lohmer

            Console.WriteLine("There are two choices of functions to run.");
            Console.WriteLine("Option 1: Coin Toss");
            Console.WriteLine("Option 2: Random Guess");
            Console.WriteLine("Which one would you like to run? 1 or 2?");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1")
	            {
                CoinToss();
	            }
            else if (userAnswer == "2")
	            {
                RandomGuess();
	            }
            else
	            {
                Console.WriteLine("Invalid Input.");
                Console.ReadKey();
	            }
        }
        static void CoinToss()
            {
            Random rand = new Random();
            int toss = rand.Next(1, 3);
            string userChoice;
            int userNumber;

            Console.WriteLine("I'm going to flip a coin!");
            Console.WriteLine("heads or tails?");
            userChoice = Console.ReadLine().ToLower();
            
            if (userChoice == "heads") 
            {
                userNumber = 1;
            }
            else if (userChoice == "tails")
            {
                userNumber = 2;
            }
            else
            {
                userNumber = 3;
                Console.WriteLine("You didn't enter heads or tails!");
            }
            if (userNumber == toss)
            {
                Console.WriteLine("Congradulations! You got it right!");
            }
            else
            {
                Console.WriteLine("I'm sorry, but you didn't get it right");
            }
            Console.ReadKey();
            }
        static void RandomGuess()
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
