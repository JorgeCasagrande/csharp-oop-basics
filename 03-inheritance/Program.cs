using System;

namespace InheritanceExample
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        // Overriding base method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("Generic Animal");
            genericAnimal.MakeSound();

            Dog dog = new Dog("Buddy");
            dog.MakeSound();

            // Polymorphism in action
            Animal polyDog = new Dog("Max");
            polyDog.MakeSound(); // Still says Woof!
        }
    }
}