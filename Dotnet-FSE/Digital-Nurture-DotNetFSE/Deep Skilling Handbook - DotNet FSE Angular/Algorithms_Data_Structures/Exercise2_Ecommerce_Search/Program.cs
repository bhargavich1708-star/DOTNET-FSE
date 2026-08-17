using System;
using System.Linq;

namespace EcommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"Product ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }

    class Program
    {
        // Linear Search: O(N) Time Complexity
        public static Product LinearSearch(Product[] products, int targetId)
        {
            foreach (var p in products)
            {
                if (p.ProductId == targetId)
                {
                    return p;
                }
            }
            return null;
        }

        // Binary Search: O(log N) Time Complexity (Requires sorted array)
        public static Product BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (products[mid].ProductId == targetId)
                    return products[mid];
                
                if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }

        static void Main(string[] args)
        {
            Product[] products = {
                new Product(105, "Laptop", "Electronics"),
                new Product(101, "Mouse", "Electronics"),
                new Product(109, "Desk", "Furniture"),
                new Product(102, "Chair", "Furniture")
            };

            Console.WriteLine("--- Linear Search ---");
            Product foundLinear = LinearSearch(products, 109);
            Console.WriteLine(foundLinear != null ? $"Found: {foundLinear}" : "Not found");

            // Binary Search requires the array to be sorted by the search key first
            var sortedProducts = products.OrderBy(p => p.ProductId).ToArray();
            
            Console.WriteLine("\n--- Binary Search ---");
            Product foundBinary = BinarySearch(sortedProducts, 109);
            Console.WriteLine(foundBinary != null ? $"Found: {foundBinary}" : "Not found");
        }
    }
}