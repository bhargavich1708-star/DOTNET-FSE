# EF Core 8.0 Hands-On Labs (1-5)
Contains the implementation for a Retail Inventory System using Entity Framework Core.

## Lab 3: Migrations (Commands to run in terminal)
To apply the database schema, ensure the EF CLI tools are installed and run:
1. `dotnet tool install --global dotnet-ef`
2. `dotnet ef migrations add InitialCreate`
3. `dotnet ef database update`