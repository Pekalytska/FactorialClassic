using System;

namespace FactorialClassic
{
    class Program
    {
        static int Factorial(int factorial)
        { 
            if (factorial > 1)
            {
                int result = Factorial(factorial-1);
                return factorial * result;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int factorial = Int32.Parse(Console.ReadLine());
            int factor = Factorial(factorial);
            Console.WriteLine(factor);
        }
    }
}
