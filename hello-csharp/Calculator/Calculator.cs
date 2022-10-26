using System;

namespace Calculator
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int divide(int a, int b)
        {
            if(b == 0)
            {
                throw new ArgumentException();
            }
            return a / b;
        }
    }
}
