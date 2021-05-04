using System;

namespace FizzBuzz
{
    class Program
    {
        private static void Main()
        {
            for (int num = 0; num < 40; num++)
            {
                string result = (num % 3 == 0 && num % 5 == 0) ? "fizzbuzz" : num % 3 == 0 ? "fizz" : num % 5 == 0 ? "buzz" : null;
                Console.WriteLine(result);
            }
        }
    }
}
