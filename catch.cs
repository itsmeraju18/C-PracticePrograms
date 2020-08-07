//C#: Exception Handling: Handling all exceptions
using System;

namespace Catch_exception
{
    class Program
    {
        public static void Main(string[] args)
        {
             int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch
            {
                Console.WriteLine("oException");
            }
            Console.WriteLine($"Result is {div}");
            
        }
    }
}
