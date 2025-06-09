using System;
using System.Collections.Generic;

namespace AbstractionExample
{
    // Abstract class
    public abstract class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        // Abstract method (must be implemented)
        public abstract void Drive();
    }

    // Concrete class 1
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car 🚗");
        }
    }

    // Concrete class 2
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a bike 🚴");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car(),
                new Bike()
            };

            foreach (var v in vehicles)
            {
                v.StartEngine();
                v.Drive();
            }
        }
    }
}