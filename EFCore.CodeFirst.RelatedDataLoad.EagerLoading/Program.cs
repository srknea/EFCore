using EFCore.CodeFirst.RelatedDataLoad.EagerLoading.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = _context.Categories.First();

    // Eager loading
    var categoryWithProducts = _context.Categories
        .Include(c => c.Products)
        .First();

    // Eager loading with nested property
    var categoryWithProductsAndProductFeatures = _context.Categories
        .Include(c => c.Products)
        .ThenInclude(p => p.ProductFeature)
        .First();

}

Console.ReadKey();
