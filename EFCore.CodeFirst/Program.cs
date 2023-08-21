using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    
    var products = await _context.Products.AsNoTracking().ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock} - {p.Barcode} ---> {_context.Entry(p).State}");
    });
    
}

Console.ReadLine();
