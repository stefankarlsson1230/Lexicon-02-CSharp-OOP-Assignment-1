using System.Collections.Generic;

namespace Excercise_1
{
    internal class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructors
        public Person(string firstName, string lastName, int age) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Methods
        public void Speak()
        {
            Console.WriteLine($"Hello my name is {FirstName} {LastName}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old";        
        }
    }
}
