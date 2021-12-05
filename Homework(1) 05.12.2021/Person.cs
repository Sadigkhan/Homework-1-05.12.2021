using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1__05._12._2021
{
    internal class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Salam");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
