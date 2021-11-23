using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 87, 34 };
            int temp;
            for(int j = 0; j <=arr.Length - 2; j++)
            {
                for(int i = 0; i <= arr.Length-2; i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted");
            foreach(int p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }
    }
}
