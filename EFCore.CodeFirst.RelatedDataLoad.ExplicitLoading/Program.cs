using EFCore.CodeFirst.RelatedDataLoad.ExplicitLoading.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = _context.Categories.First();

    // Explicit Loading
    _context.Entry(category)
        .Collection(c => c.Products)
        .Load();

    category.Products.ForEach(p => Console.WriteLine(p.Name));
}

Console.ReadKey();