using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number please: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n-1; i >= 0; i--) // i - counting rows, also number of spaces
            {
                if (i == n-1 || i == n-2 || i == 0)
                {
                    // step 1. printing out spaces
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    // step 2. printing out 'X', x = n-s = n - i
                    for (int k = 0; k < n - i; k++)
                    {
                        Console.Write("X");
                    }

                    // new line
                    Console.WriteLine();
                }
                else
                {

                    // step 1. printing out spaces
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    // print out 1 star
                    Console.Write("X");

                    for (int k = 0; k < n - i - 2; k++)
                    {
                        Console.Write(" ");
                    }

                    // print out 1 star
                    Console.Write("X");

                    // new line
                    Console.WriteLine();

                }
            }

            Console.ReadKey();
        }
    }
}
