using System;

namespace SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            for (myInt = 0; myInt < 2; myInt++)
            {
                Switching(myInt);
            }
        }
        static void Switching(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("hallo, dit is case 0");
                    break;
                default:
                    Console.WriteLine("hallo, dit is de default case");
                    break;
            }
        }
    }
}
