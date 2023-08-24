using EFCore.CodeFirst.Relationships.OneToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = new Category() { Name = "Kalemler" };

    var product = new Product() { Name = "Pilot Kalem", Price = 12.50m, Stock = 100, Barcode = 123456789, Category = category };

    _context.Products.Add(product);

    _context.SaveChanges();
}

Console.ReadKey();
