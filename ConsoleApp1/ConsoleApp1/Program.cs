using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Create a function and name it GetDoubleInputFromUser, that will have a return type of double.  
        //Your function should accept 1 parameter, of type string, which will contain the message you want to ask the user. 
        //Your function should ask the message passed in as an argument and get the users response.
        //You should validate that the response the user gave you is of type double (using double.TryParse...), if it is not, you need to re-prompt them until they give you a valid input.
        //After you have a valid input from the user, return the converted value.Your main() function should call your GetDoubleInputFromUser function and multiply the users response by 5. Output the equation and result to the user(e.g.If the user entered the value 10 you would output, "10 * 5 = 50")


        static void Main(string[] args)
        {
            double mult = 5;
            double answer = 0;
            string msg = " ";

            Console.WriteLine(mult + " * " + GetDoubleInputFromUser(msg) + " = " + answer);
            Console.ReadKey();
        }
        static double GetDoubleInputFromUser(string msg)
        {
                Console.WriteLine("Please enter a number.");
                msg = Console.ReadLine();
                double.TryParse(msg, out double result);

                return result;
            
        }
    }

}
