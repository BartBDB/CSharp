using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(20, 50);

            Calculator calc2 = new Calculator();
            int multiply = calc2.Multiply(20, 30);

            Calculator calc3 = new Calculator();
            int devide = calc2.Devide(10, 2);
        }
    }

    class Calculator
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("a + b = " + c);
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("a * b = " + c);
            return c;
        }

        public int Devide(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("a : b = " + c);
            return c;
        }
    }
}
