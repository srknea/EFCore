using EFCore.CodeFirst.RelatedDataLoad.LazyLoading.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    Console.WriteLine("Loading categories...\n");

    var category = _context.Categories.First();

    Console.WriteLine("\nLoading products...\n");

    var products = category.Products;

    foreach (var item in products)
    {
        Console.WriteLine($"\nProduct Feature: {item.ProductFeature}\n");
    }
}

Console.ReadKey();