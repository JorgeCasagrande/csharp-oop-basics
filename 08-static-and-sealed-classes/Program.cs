using System;

namespace StaticAndSealedExample
{
    // Static class: cannot be instantiated, only static members allowed
    public static class MathUtilities
    {
        // Static method to calculate square of an integer
        public static int Square(int x)
        {
            return x * x;
        }
    }

    // Sealed class: cannot be inherited
    public sealed class BaseLogger
    {
        // Instance method to log a message to the console
        public void Log(string message)
        {
            Console.WriteLine($"Log entry: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using static class without creating an instance
            int num = 5;
            int squared = MathUtilities.Square(num);
            Console.WriteLine($"The square of {num} is {squared}");

            // Using sealed class instance
            BaseLogger logger = new BaseLogger();
            logger.Log("This is a log message.");

            // The following would cause a compile-time error:
            // class DerivedLogger : BaseLogger { }  // ERROR: Cannot inherit from sealed class
        }
    }
}
