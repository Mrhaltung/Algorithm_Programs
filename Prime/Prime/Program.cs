using System;

namespace Prime
{
    class Program
    {
        static void Main()
        {
            bool isPrime = true;
            int i, j;

            Console.WriteLine(" Prime Number Between 1 to 100");
            Console.WriteLine("\n Prime Numbers are : ");
         
            for (i = 2; i <= 10; i++)
            {
                for (j = 2; j <= 10; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\n " + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
