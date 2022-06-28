using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial fact = new Factorial();
            
            int a = 5;
            int factorial = Factorial.Fact(a);
            
            Console.WriteLine(factorial);

        }
        
    }
}
