using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public void sorting()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i%15!=0))
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5 == 0) && (i % 15 != 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                Console.WriteLine(i);
            }
        }
    }
}
