using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 100;
           
            int count = 0;
            int guess = 2, val = 0;
            Console.WriteLine("Computer will guess the number you have choices between 1 to 100");
            Console.WriteLine("Choice the number ");
            Console.ReadKey();
            
            Console.WriteLine("Count {0}", count);
           
            while (guess != 1)
            {
                val = (end + start) / 2;

                Console.WriteLine("Your Number is "+ val + " or not ");
                Console.WriteLine("1. Yes this is my number.");
                Console.WriteLine("2. Greater than " + val);
                Console.WriteLine("3. Smaller than " + val);
                Console.Write("Your choics is : ");
                guess = Convert.ToInt32(Console.ReadLine());
                switch(guess)
                {
                    case 1:
                        Console.WriteLine(val + " Yes we found your Number");
                        break;
                    case 2:
                        Console.WriteLine(val + " is greater than");
                        start = val;
                        break;
                    case 3:
                        Console.WriteLine(val + " is smaller than");
                        end = val;
                        break;

                    default:
                        Console.WriteLine("You choice wrong option");
                        break;
                }
                count++;
                Console.WriteLine("Count {0}", count);
            }
            Console.WriteLine("We got it. The number is {0}. It took me {1} guesses.", val, count);
            
        }
    }
}
