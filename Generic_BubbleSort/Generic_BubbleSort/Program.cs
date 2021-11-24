using System;
using System.Collections.Generic;

namespace Generic_BubbleSort
{
    class Program
    {
        private static object temp;

        
        static void Main(string[] args)
        {
            Console.WriteLine(" Generic Bubble Sort Program ");
            
            int[] intlist = { 3, 85, 34, 21, 16 };

            Console.WriteLine(" \n Unsorted List is : 3 85 34 21 16 \n    a  d  z  e  s ");

            Console.Write(" \n Sorted List is : ");

            new BubbleSort<int>(intlist).test(intlist);

            char[] charlist = { 'a', 'd', 'z', 'e', 's' };
            new BubbleSort<char>(charlist).test(charlist);

            Console.WriteLine("\n \n");
        }
    }
}
