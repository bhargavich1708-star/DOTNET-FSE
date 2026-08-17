# Exercise 2: E-commerce Platform Search Function

## Scenario
This module implements and analyzes search functionality for an e-commerce platform where fast data retrieval is crucial for user experience.

## Algorithms Implemented
1. **Linear Search:** * **Best Case:** O(1) if the target is the first element.
   * **Worst/Average Case:** O(N). It checks every element one by one. Suitable only for small or unsorted datasets.
2. **Binary Search:** * **Best Case:** O(1) if the target is in the exact middle.
   * **Worst/Average Case:** O(log N). It repeatedly divides the search interval in half. 

## Analysis & Conclusion
For a high-traffic e-commerce platform, **Binary Search** is highly preferred over Linear Search. While it requires the initial overhead of sorting the array (O(N log N)), subsequent searches are exponentially faster, reducing server load and response times during product queries.

## How to Run
Navigate to this directory in your terminal and compile/run the C# file using the .NET CLI:
\`\`\`bash
dotnet run
\`\`\`