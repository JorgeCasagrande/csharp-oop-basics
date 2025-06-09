using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
    // Base class
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class 1
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class 2
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // List of base type
            List<Shape> shapes = new List<Shape>
            {
                new Circle(),
                new Square(),
                new Shape()
            };

            foreach (var shape in shapes)
            {
                shape.Draw(); // Calls correct override based on actual type
            }
        }
    }
}
