using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            string wordToChange;
            string newWord;
            string newSentence;
            char[] array;
           

            Console.WriteLine(sentence);
            Console.WriteLine("Which word in the above sentence would you like to change?");
            wordToChange = Console.ReadLine();

            bool b = sentence.Contains(wordToChange);

            if (b == true)
            {
                Console.WriteLine("What would you like to change that word to?");
                newWord = Console.ReadLine();
                newSentence = sentence.Replace(wordToChange, newWord);
                Console.WriteLine(newSentence);
            }
            else
            {
                Console.WriteLine("Sorry, I could not find the word:" + wordToChange);
                array = wordToChange.ToArray();
                Array.Reverse(array);
                Console.WriteLine(array);
            }
            Console.ReadKey();
        }
    }
}
