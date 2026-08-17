using System;

namespace UpskillExercises
{
    // Exercise 3: Primary Constructor (C# 12 feature)
    public class Person(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;

        public void DisplayInfo() => Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Exercise 2: Reference Type Custom Class
    public class CustomRefType
    {
        public int Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Exercise 1: Hello World ---
            Console.WriteLine("Hello World!");
            Console.WriteLine("-----------------------------");

            // --- Exercise 2: Value vs Reference Types ---
            int valType = 10;
            CustomRefType refType = new CustomRefType { Value = 10 };

            ModifyValues(valType, refType);
            
            Console.WriteLine($"Value Type after method: {valType}"); // Remains 10
            Console.WriteLine($"Reference Type after method: {refType.Value}"); // Changes to 20
            Console.WriteLine("-----------------------------");

            // --- Exercise 3: Primary Constructors ---
            Person p = new Person("Alice", 28);
            p.DisplayInfo();
            Console.WriteLine("-----------------------------");

            // --- Exercise 4: Type Inference with var and new() ---
            var number = 42;
            var text = "Hello Type Inference";
            CustomRefType inferredObj = new(); // new() shorthand

            Console.WriteLine($"number is {number.GetType()}, value: {number}");
            Console.WriteLine($"text is {text.GetType()}, value: {text}");
            Console.WriteLine("-----------------------------");

            // --- Exercise 5: Conditional Logic for Grades ---
            Console.Write("Enter a score (0-100) to calculate grade: ");
            if (int.TryParse(Console.ReadLine(), out int score))
            {
                // Pattern matching switch
                string grade = score switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };
                Console.WriteLine($"Your grade is: {grade}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        // Helper method for Exercise 2
        static void ModifyValues(int v, CustomRefType r)
        {
            v = 20;
            r.Value = 20;
        }
    }
}