using EFCore.CodeFirst.Relationships.OneToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = _context.Categories.First(x => x.Name == "Kalemler");

    var product = new Product() { Name = "Kurşun Kalem", Price = 12.50m, Stock = 100, Barcode = 121456789, CategoryId = category.Id };


    _context.Products.Add(product);

    _context.SaveChanges();
}

Console.ReadKey();
