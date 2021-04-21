using System;

namespace arraysandloops
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;

            int[] getallen = { 10, 20, 30, 40, 50, 60 };

            int opsomming = 0;

            foreach (int eenGetal in getallen)
            {
                //Console.WriteLine(eenGetal);
                opsomming += eenGetal;
            }

            for(int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine(getallen[i]);
            }    

        }
    }
}
