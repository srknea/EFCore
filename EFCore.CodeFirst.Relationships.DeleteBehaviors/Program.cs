using EFCore.CodeFirst.Relationships.DeleteBehaviors.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = new Category()
    {
        Name = "Kalemler",
        Products = new List<Product>()
        {
        new Product () {Name = "Kalem1", Price = 10, Stock = 10, Barcode = 987},
        new Product () {Name = "Kalem2", Price = 10, Stock = 10, Barcode = 988},
        new Product () {Name = "Kalem3", Price = 10, Stock = 10, Barcode = 989}
        }
    };

    _context.Categories.Add(category);
    _context.SaveChanges();
}

Console.ReadKey();
