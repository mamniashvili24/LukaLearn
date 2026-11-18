using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CarDbContext context = new();
            context.Database.EnsureCreated();

            foreach (var category in context.Categories.Include(c => c.Cars))
            {
                Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}");
                foreach (var car in category.Cars)
                {
                    Console.WriteLine($"    Car Id: {car.Id}, Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Price: {car.Price}");
                }
            }


            var cars = from c in context.Cars/*.Include(c => c.Category)*/
                       select c;

            Console.Clear();
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.CategoryId} {c.Id}: {c.Brand} - {c.Model}");
            }

            #region MyRegion

            context.Database.EnsureCreated();

            var categories = new List<Category>
            {
                new()
                {
                    Name = "Sedans",
                    Cars = new List<Car>
                    {
                        new() { Brand = "Toyota", Model = "Camry", Year = 2025, Price = 28900m },
                        new() { Brand = "Honda", Model = "Accord", Year = 2025, Price = 29200m },
                        new() { Brand = "Nissan", Model = "Altima", Year = 2025, Price = 27350m },
                        new() { Brand = "Hyundai", Model = "Elantra", Year = 2025, Price = 22300m },
                        new() { Brand = "Kia", Model = "K5", Year = 2025, Price = 27500m },
                        new() { Brand = "Mazda", Model = "Mazda3 Sedan", Year = 2025, Price = 24600m },
                        new() { Brand = "Subaru", Model = "Legacy", Year = 2025, Price = 25990m },
                        new() { Brand = "Volkswagen", Model = "Jetta", Year = 2025, Price = 23250m },
                        new() { Brand = "Chevrolet", Model = "Malibu", Year = 2025, Price = 26100m },
                        new() { Brand = "BMW", Model = "330i", Year = 2025, Price = 45500m }
                    }
                },
                new()
                {
                    Name = "SUVs",
                    Cars = new List<Car>
                    {
                        new() { Brand = "Toyota", Model = "RAV4", Year = 2025, Price = 30400m },
                        new() { Brand = "Honda", Model = "CR-V", Year = 2025, Price = 31600m },
                        new() { Brand = "Nissan", Model = "Rogue", Year = 2025, Price = 29800m },
                        new() { Brand = "Hyundai", Model = "Tucson", Year = 2025, Price = 28700m },
                        new() { Brand = "Kia", Model = "Sportage", Year = 2025, Price = 28600m },
                        new() { Brand = "Mazda", Model = "CX-5", Year = 2025, Price = 30200m },
                        new() { Brand = "Subaru", Model = "Forester", Year = 2025, Price = 30000m },
                        new() { Brand = "Ford", Model = "Escape", Year = 2025, Price = 29150m },
                        new() { Brand = "Chevrolet", Model = "Equinox", Year = 2025, Price = 28900m },
                        new() { Brand = "Jeep", Model = "Grand Cherokee", Year = 2025, Price = 39600m }
                    }
                },
                new()
                {
                    Name = "Trucks",
                    Cars = new List<Car>
                    {
                        new() { Brand = "Ford", Model = "F-150", Year = 2025, Price = 38700m },
                        new() { Brand = "Chevrolet", Model = "Silverado 1500", Year = 2025, Price = 39200m },
                        new() { Brand = "Ram", Model = "1500", Year = 2025, Price = 40300m },
                        new() { Brand = "Toyota", Model = "Tacoma", Year = 2025, Price = 33600m },
                        new() { Brand = "GMC", Model = "Sierra 1500", Year = 2025, Price = 40400m },
                        new() { Brand = "Nissan", Model = "Frontier", Year = 2025, Price = 32100m },
                        new() { Brand = "Ford", Model = "Maverick", Year = 2025, Price = 25800m },
                        new() { Brand = "Honda", Model = "Ridgeline", Year = 2025, Price = 40350m },
                        new() { Brand = "Toyota", Model = "Tundra", Year = 2025, Price = 41700m },
                        new() { Brand = "Chevrolet", Model = "Colorado", Year = 2025, Price = 31900m }
                    }
                },
                new()
                {
                    Name = "Electric",
                    Cars = new List<Car>
                    {
                        new() { Brand = "Tesla", Model = "Model 3", Year = 2025, Price = 38990m },
                        new() { Brand = "Tesla", Model = "Model Y", Year = 2025, Price = 44990m },
                        new() { Brand = "Hyundai", Model = "IONIQ 5", Year = 2025, Price = 41900m },
                        new() { Brand = "Kia", Model = "EV6", Year = 2025, Price = 42900m },
                        new() { Brand = "Ford", Model = "Mustang Mach-E", Year = 2025, Price = 39995m },
                        new() { Brand = "Volkswagen", Model = "ID.4", Year = 2025, Price = 38995m },
                        new() { Brand = "Chevrolet", Model = "Equinox EV", Year = 2025, Price = 34995m },
                        new() { Brand = "BMW", Model = "i4", Year = 2025, Price = 52900m },
                        new() { Brand = "Mercedes-Benz", Model = "EQE SUV", Year = 2025, Price = 79900m },
                        new() { Brand = "Nissan", Model = "Ariya", Year = 2025, Price = 41400m }
                    }
                },
                new()
                {
                    Name = "Sports Cars",
                    Cars = new List<Car>
                    {
                        new() { Brand = "Chevrolet", Model = "Corvette Stingray", Year = 2025, Price = 68300m },
                        new() { Brand = "Porsche", Model = "911 Carrera", Year = 2025, Price = 120100m },
                        new() { Brand = "BMW", Model = "M4 Coupe", Year = 2025, Price = 79800m },
                        new() { Brand = "Toyota", Model = "GR Supra", Year = 2025, Price = 56250m },
                        new() { Brand = "Nissan", Model = "Z", Year = 2025, Price = 43110m },
                        new() { Brand = "Ford", Model = "Mustang GT", Year = 2025, Price = 43500m },
                        new() { Brand = "Subaru", Model = "BRZ", Year = 2025, Price = 31800m },
                        new() { Brand = "Mazda", Model = "MX-5 Miata", Year = 2025, Price = 29700m },
                        new() { Brand = "Audi", Model = "TT RS", Year = 2025, Price = 76000m },
                        new() { Brand = "Jaguar", Model = "F-Type", Year = 2025, Price = 79900m }
                    }
                }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges(); 

            #endregion
        }
    }

    class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=G12_CarDb;User Id=sa;Password=PAssw0rd!;TrustServerCertificate=True;");
        }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Car>? Cars { get; set; }
    }

    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryRefId { get; set; }
        public Category Category { get; set; } = null!;
        public Documentation Documentation { get; set; } = null!;
    }

    class Documentation
    {
        [ForeignKey("Car")]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Car Car { get; set; } = null!;
    }
}
