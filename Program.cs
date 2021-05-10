using System;

namespace ConsoleApp78
{
    class Program
    {
       
        private static bool isPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
               
            }
            return result;
        }
         static void Main(string[] args)
        {
            if (isPrimeNumber(4))
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not prime number");
            }
        }
    }
 
}
