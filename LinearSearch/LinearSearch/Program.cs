using System;

namespace LinearSearch
{
    class Program
    {
        public static void Main()
        {
            string[] names = new string[]
            {
                "Joe",
                "Rick",
                "Sam",
                "Giovanni",
                "Ramses",
                "Laura",
                "Laurens",
                "Lydia",
                "Eric",
                "Rose"
            };

            string nameToFind = "Joe";

            foreach (string i in names)
            {
                if (i == nameToFind)
                    Console.WriteLine(i);
            }    
        }
    }
}
