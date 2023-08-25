using EFCore.CodeFirst.RelatedDataLoad.EagerLoading.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    // Eager loading with nested property
    var productFeature = _context.ProductFeatures
        .Include(pf => pf.Product)
        .ThenInclude(p => p.Category)
        .First();

    Console.WriteLine($"{productFeature.Product.Category.Name} - {productFeature.Product.Name} - {productFeature.Color}");

}

Console.ReadKey();
