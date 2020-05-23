using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Jessica";
            Console.WriteLine(person1.Name);
        }

        class Person
        {
            public string Name;
            public int Age;
            public string Gender;
        }
    }
}
