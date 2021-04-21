using System;
using System.Collections.Generic;
using System.Text;

namespace GettersandSetters
{
    class Person
    {
        private int age;

        public void SetAge(int anAge)
        {
            age = anAge;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
