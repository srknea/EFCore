using EFCore.CodeFirst.Relationships.DeleteBehaviors.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = _context.Categories.First();

    var products = _context.Products.Where(p => p.CategoryId == category.Id).ToList();

    _context.Products.RemoveRange(products);

    _context.Categories.Remove(category);

    _context.SaveChanges();
}

Console.ReadKey();
