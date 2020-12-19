using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the tree height please: ");
            int n = int.Parse(Console.ReadLine());

            int baseTree = 2 * n - 1;
            int j;
            

            for (int i = 1; i <= n; i++)
            {

                int a = 2 * i -1; // number of asterixes

                // sequence of spaces 
                for (j = 0; j < (baseTree - a)/2; j++)
                {
                    Console.Write(" ");
                }

                // sequence of asterixes
                for (j = 0; j < a; j++)
                {
                    Console.Write("*");
                }

                // sequence of spaces 
                for (j = 0; j < (baseTree - a) / 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
