using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    // Interface declaration
    public interface IPlayable
    {
        void Play();
    }

    // Class 1 implementing the interface
    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Strumming the guitar 🎸");
        }
    }

    // Class 2 implementing the interface
    public class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano 🎹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IPlayable> instruments = new List<IPlayable>
            {
                new Guitar(),
                new Piano()
            };

            foreach (var instrument in instruments)
            {
                instrument.Play(); // Interface-based polymorphism
            }
        }
    }
}