using System;
using System.Collections.Generic;

namespace VirtualOverrideExample
{
    // Base class with virtual method
    public class Printer
    {
        public virtual void Print()
        {
            Console.WriteLine("Printing a document...");
        }
    }

    // Derived class 1
    public class PDFPrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Printing as PDF 📝");
        }
    }

    // Derived class 2
    public class ImagePrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Printing an image 🖼️");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Printer> printers = new List<Printer>
            {
                new Printer(),
                new PDFPrinter(),
                new ImagePrinter()
            };

            foreach (var printer in printers)
            {
                printer.Print(); // Dynamic dispatch based on runtime type
            }
        }
    }
}