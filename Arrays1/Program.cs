using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array1 = new int[5] { 1,2,3,4,5};
            Console.WriteLine(array1);

            //array1[0] = 100;
            //array1[array1.Length - 1] = 200;

            foreach (int item in array1)
            {
                // item++;
                Console.WriteLine(item);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i]++;
            }

            foreach (int item in array1)
            {
                // item++;
                Console.WriteLine(item);
            }

            Console.ReadKey();

            //int x;
            //Console.WriteLine(x);
        }
    }
}
