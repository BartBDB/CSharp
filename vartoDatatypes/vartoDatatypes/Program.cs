using System;

namespace vartoDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables en datatypes

            int integer = 1;
            string word = "word";
            float pi = 3.14f;

            Console.WriteLine(integer);
            Console.WriteLine(word);
            Console.WriteLine(pi);

            //arrays

            int[] myNumbers = { 10, 20, 30, 40, 50, 60 };

            //loops

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void Variables()
        {
            //var -> datatypes

            int a = 1;
            float b = 0.5f;
            double c = 1.32142412441d;
            string d = "Word";
            char e = 'c';
            bool f = true;
        }
    }
}
