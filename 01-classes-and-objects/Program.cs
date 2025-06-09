using System;

namespace ClassesAndObjects
{
    // This is our class definition
    public class Person
    {
        // Fields or properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method: Behavior of the object
        public void Greet()
        {
            Console.WriteLine($"Hi! My name is {Name} and I'm {Age} years old.");
        }

        public void HaveBirthday()
        {
            Age++;
            Console.WriteLine($"Happy birthday {Name}! Now you're {Age}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object instantiation
            Person person1 = new Person("Alice", 30);

            // Using object methods
            person1.Greet();
            person1.HaveBirthday();
            person1.Greet();

            // Creating another object
            Person person2 = new Person("Bob", 25);
            person2.Greet();
        }
    }
}