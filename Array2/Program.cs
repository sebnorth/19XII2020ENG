using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {

        //        Given an array of ints, return true if 6 appears as either the first or last element in the array.The array will be length 1 or more.


        //firstLast6([1, 2, 6]) → true
        //firstLast6([6, 1, 2, 3]) → true
        //firstLast6([13, 6, 1, 2, 3]) → false

        static bool firstLast6(int[] tab) {

            if (tab[0] == 6 || tab[tab.Length - 1] == 6)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 6 };

            Console.WriteLine(firstLast6(array));

            Console.WriteLine(firstLast6(new int[] {6,1,2,3 }));

            Console.WriteLine(firstLast6(new int[] { 13,6,1,2,3}));

            Console.ReadKey();
        }
    }
}
