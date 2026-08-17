using System;

namespace SingletonPatternExample
{
    // The Logger class ensures only one instance exists across the application.
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        // 1. Private constructor prevents direct instantiation
        private Logger() { }

        // 2. Public static method to get the single instance (Thread-safe)
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test the Singleton Implementation
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("System initialized.");
            logger2.Log("Processing data...");

            // Verify both variables point to the exact same object in memory
            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("\nSuccess: Both logger instances are exactly the same. Singleton works!");
            }
        }
    }
}