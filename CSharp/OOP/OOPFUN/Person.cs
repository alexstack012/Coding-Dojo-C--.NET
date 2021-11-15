using System;

namespace OOPFUN
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        //constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hi, My name is {FirstName} {LastName} and I am {Age} Years old");
        }
    }
}