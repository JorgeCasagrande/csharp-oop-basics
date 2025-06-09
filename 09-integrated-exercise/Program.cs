using System;
using System.Collections.Generic;

namespace IntegratedExerciseFull
{
    // Abstract employee base class
    public abstract class Employee
    {
        // Encapsulated properties
        public string Name { get; private set; }
        public int ID { get; private set; }

        protected Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // Virtual method to be overridden
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    // Developer class inherits Employee and overrides Work
    public class Developer : Employee
    {
        public Developer(string name, int id) : base(name, id) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }

    // Manager class inherits Employee and overrides Work
    public class Manager : Employee
    {
        public Manager(string name, int id) : base(name, id) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    // ILogger interface
    public interface ILogger
    {
        void Log(string message);
    }

    // Console logger implementation
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }
    }

    // File logger implementation (simulated)
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[File] {message}");
        }
    }

    // Static helper class for formatting logs
    public static class LoggerHelper
    {
        public static string FormatLog(string message)
        {
            return $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        }
    }

    // Sealed critical logger
    public sealed class CriticalLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[CRITICAL] {message.ToUpper()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            List<Employee> employees = new List<Employee>
            {
                new Developer("Alice", 101),
                new Manager("Bob", 102)
            };

            // Create loggers
            List<ILogger> loggers = new List<ILogger>
            {
                new ConsoleLogger(),
                new FileLogger(),
                new CriticalLogger()
            };

            // Employees work and log their actions
            foreach (var employee in employees)
            {
                employee.Work();

                foreach (var logger in loggers)
                {
                    string formatted = LoggerHelper.FormatLog($"{employee.Name} performed work.");
                    logger.Log(formatted);
                }

                Console.WriteLine(); // spacing
            }
        }
    }
}