using System;
using System.Collections.Generic;

namespace FinancialForecasting
{
    class Program
    {
        // Standard Recursive Approach: O(2^N) Time Complexity (without optimization)
        public static double PredictFutureValue(double pastValue, double growthRate, int years)
        {
            // Base case: 0 years remaining
            if (years == 0) return pastValue;
            
            // Recursive call
            return PredictFutureValue(pastValue * (1 + growthRate), growthRate, years - 1);
        }

        // Optimized Recursive Approach (Memoization): O(N) Time Complexity
        private static Dictionary<int, double> _memoCache = new Dictionary<int, double>();

        public static double PredictFutureValueOptimized(double pastValue, double growthRate, int years)
        {
            if (years == 0) return pastValue;
            
            // Return cached result if we have already calculated this specific remaining year count
            if (_memoCache.ContainsKey(years))
            {
                return _memoCache[years];
            }

            // Calculate, cache the result, and return
            double result = PredictFutureValueOptimized(pastValue * (1 + growthRate), growthRate, years - 1);
            _memoCache[years] = result;
            return result;
        }

        static void Main(string[] args)
        {
            double presentValue = 1000.00;
            double annualGrowthRate = 0.05; // 5% growth
            int forecastYears = 10;

            Console.WriteLine("--- Standard Recursion ---");
            double futureVal1 = PredictFutureValue(presentValue, annualGrowthRate, forecastYears);
            Console.WriteLine($"Value after {forecastYears} years: ${Math.Round(futureVal1, 2)}");

            Console.WriteLine("\n--- Optimized Recursion (Memoization) ---");
            double futureVal2 = PredictFutureValueOptimized(presentValue, annualGrowthRate, forecastYears);
            Console.WriteLine($"Value after {forecastYears} years: ${Math.Round(futureVal2, 2)}");
        }
    }
}