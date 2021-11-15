using System;

namespace OOPFUN
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Alex", "Stack", 29);
            // newPerson.FirstName = "Alex";
            // newPerson.LastName = "Stack";
            // newPerson.Age = 29;

            Person otherPerson = new Person("Malcom", "Reynolds", 31);

            newPerson.SayHi();
            otherPerson.SayHi();

            Console.WriteLine("Hello World!");
        }
    }
}
