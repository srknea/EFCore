using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    /*
    foreach (var item in products)
    {
        Console.WriteLine($"{item.Id} - {item.Name} - {item.Price}");
    }
    */

    products.ForEach(p =>
    {
        var state = _context.Entry(p).State;

        Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock} --- State: {state}");
    });
}

Console.ReadLine();
