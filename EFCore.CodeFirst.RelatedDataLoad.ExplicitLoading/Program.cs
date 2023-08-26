using EFCore.CodeFirst.RelatedDataLoad.ExplicitLoading.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var product = _context.Products.First();

    _context.Entry(product)
        .Reference(p => p.ProductFeature)
        .Load();

    Console.WriteLine(product.ProductFeature.Color);
}

Console.ReadKey();