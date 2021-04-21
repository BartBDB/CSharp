using System;

namespace GettersandSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pieter = new Person();
            pieter.SetAge(22);
            Console.WriteLine(pieter.GetAge());
        }
    }
}
