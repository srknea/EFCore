using EFCore.CodeFirst.Relationships.OneToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = new Category() { Name = "Defterler" };

    category.Products.Add(new Product() { Name = "Defter1", Price = 12.50m, Stock = 100, Barcode = 123456789 });
    category.Products.Add(new Product() { Name = "Defter2", Price = 12.50m, Stock = 100, Barcode = 123455623 });
    category.Products.Add(new Product() { Name = "Defter3", Price = 12.50m, Stock = 100, Barcode = 123565237 });

    _context.Categories.Add(category);
    
    _context.SaveChanges();
}

Console.ReadKey();
