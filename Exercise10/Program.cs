using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1 - create a triange with a specific character '*'
            // step 2 - replace '*' by a number

            Console.WriteLine("Give a number please: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // i - row number
            {
                for (int j = 0; j <= i; j++) // j - number of columns
                {
                    Console.Write("{0,4} ", (i+1)*(j+1)); 
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
