using EFCore.CodeFirst.Relationships.OneToOne.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var product = new Product{ Name = "Tükenmez Kalem", Price = 10.5m, Stock = 10, Barcode = 120321549, 
        ProductFeature = new ProductFeature() { Width = 10, Height = 50, Color = "Red"} 
    };
 
    _context.Products.Add(product);

    _context.SaveChanges();
}

Console.ReadKey();
