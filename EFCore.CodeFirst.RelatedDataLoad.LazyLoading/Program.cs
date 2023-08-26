using EFCore.CodeFirst.RelatedDataLoad.LazyLoading.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = new Category() { Name = "Kalemler" };

    category.Products.Add(new Product()
    {
        Name = "Pilot Kalem",
        Price = 12.50m,
        Stock = 100,
        Barcode = 123456789,
        ProductFeature = new ProductFeature()
        {
            Width = 10,
            Height = 20,
            Color = "Mavi"
        }
    });

    category.Products.Add(new Product()
    {
        Name = "Kurşun Kalem",
        Price = 40.50m,
        Stock = 200,
        Barcode = 123456789,
        ProductFeature = new ProductFeature()
        {
            Width = 10,
            Height = 20,
            Color = "Siyah"
        }
    });

    await _context.AddAsync(category);

    await _context.SaveChangesAsync();
}

Console.ReadKey();