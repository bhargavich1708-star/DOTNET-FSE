# Exercise 7: Financial Forecasting Tool

## Scenario
This module implements a financial forecasting tool that predicts future values based on past data and growth rates using recursive algorithms.

## Concepts Implemented
* **Recursion:** A method where the solution to a problem depends on solutions to smaller instances of the same problem. We break down the multi-year forecast into single-year recursive steps.
* **Memoization (Caching):** An optimization technique used primarily to speed up computer programs by storing the results of expensive function calls.

## Analysis
* **Standard Recursion Time Complexity:** In complex recursive trees (like calculating Fibonacci sequences or branching financial models), standard recursion can lead to O(2^N) time complexity due to redundant calculations of overlapping subproblems.
* **Optimized Solution:** By implementing a `Dictionary<int, double>` to cache the results of specific year markers, we reduce the time complexity down to **O(N)**. The program checks the cache before performing computation, preventing excessive memory stack usage.

## How to Run
Navigate to this directory in your terminal and compile/run the C# file using the .NET CLI:
\`\`\`bash
dotnet run
\`\`\`