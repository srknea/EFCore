using EFCore.CodeFirst.Relationships.DeleteBehaviors.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var category = _context.Categories.First();

    _context.Categories.Remove(category);

    _context.SaveChanges();
}

Console.ReadKey();
