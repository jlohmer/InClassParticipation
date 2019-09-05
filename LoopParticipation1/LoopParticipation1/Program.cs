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
            Console.ReadKey();
        }
    }
}
