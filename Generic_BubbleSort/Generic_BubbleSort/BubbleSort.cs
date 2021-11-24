using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_BubbleSort
{
    class BubbleSort<T> where T : IComparable
    {
        private readonly T[] list;

        public BubbleSort(T[] list)
        {
            this.list = list;        
        }

        internal void test(T[] list)
        { 
            bool KeepIterating = true;
            while (KeepIterating)
            {
                KeepIterating = false;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    for (int j = 0; j < list.Length; j++)
                        {
                        T x = list[i];
                        T y = list[i + 1];
                        if (x.CompareTo(y) > 0)
                        {
                            list[i] = y;
                            list[i + 1] = x;
                            KeepIterating = true;
                        }
                    }
                }
            }
            foreach(T p in list)
            {
                Console.Write(p + "-->");

            }
            Console.Write("\n    ");
        }
    }
}
