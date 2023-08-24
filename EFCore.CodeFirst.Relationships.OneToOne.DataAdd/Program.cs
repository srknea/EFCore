using EFCore.CodeFirst.Relationships.OneToOne.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var productFeature = new ProductFeature() { Width = 80, Height = 70, Color = "Siyah",
        Product = new Product() { Name = "Kurşun Kalem", Price = 10.5m, Stock = 10, Barcode = 120548154 }
    };

    _context.ProductFeatures.Add(productFeature);

    _context.SaveChanges();
}

Console.ReadKey();
