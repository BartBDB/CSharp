using System;

namespace les2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool skyIsBlue = false;
            skyIsBlue = ReverseBoolean(skyIsBlue);
            Console.WriteLine(skyIsBlue);
            
            Divide(4, 0);
        }
        static int Add(int i1, int i2)
        {
            int result = i1 + i2;
            return result;
        }
        static bool ReverseBoolean(bool b1)
        {
            if(b1 == true)
            {
                b1 = false;
            }
            else
            {
                b1 = true;
            }
            return b1;
        }

        static void Divide(float a1, float a2)
        {
            float result = a1 / a2;
            Console.WriteLine("Result = " + result); 
        }


    }
}
