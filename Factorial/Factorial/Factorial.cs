using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class Factorial
    {
        public static int Fact(int a)
        {
            int factorial = 1;

            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
    
}
