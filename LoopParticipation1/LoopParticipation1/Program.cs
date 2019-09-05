using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Jason Lohmer
namespace LoopParticipation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            int sum = 0;

            for (counter = 1; counter <= 100; counter++)
            {
                sum = sum + counter;
            }
            Console.WriteLine(sum);


            // Problem 2 - Ask the user if they want to iterate

            string answer = string.Empty;
            counter = 0;

            Console.WriteLine("Do you want to iterate again?");
            answer = Console.ReadLine();

            while(answer.ToLower() != "no")
            {
                Console.WriteLine("Do you want to iterate again?");
                answer = Console.ReadLine();
                counter++;
            }

            Console.WriteLine(counter);

            counter = 0;
            answer = string.Empty;

            do
            {
                Console.WriteLine("Do you want to iterate again?");
                answer = Console.ReadLine().ToLower;
                counter++;
            } while (answer.ToLower() != "no");
            counter--;

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
