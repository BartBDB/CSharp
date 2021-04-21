using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 101; i++)
            {
                if (isOdd(i))
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
