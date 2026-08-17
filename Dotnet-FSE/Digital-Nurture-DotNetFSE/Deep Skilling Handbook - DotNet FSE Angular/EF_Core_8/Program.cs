using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();
            
            // Note: Lab 3 requires running EF Core CLI migrations before this runs:
            // dotnet ef migrations add InitialCreate
            // dotnet ef database update

            Console.WriteLine("--- Lab 4: Inserting Initial Data ---");
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };
            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };
            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            Console.WriteLine("--- Lab 5: Retrieving Data ---");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }
        }
    }
}