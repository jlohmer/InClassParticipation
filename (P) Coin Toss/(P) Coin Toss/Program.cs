using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
