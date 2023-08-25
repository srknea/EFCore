using EFCore.CodeFirst.RelatedDataLoad.EagerLoading.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    // Eager loading with nested property
    var category = _context.Categories
        .Include(c => c.Products)
        .ThenInclude(p => p.ProductFeature)
    .First();

    category.Products.ForEach(product =>
    {
        Console.WriteLine($"{category.Name} - {product.Name} - {product.ProductFeature.Color}");

    });
}

Console.ReadKey();
