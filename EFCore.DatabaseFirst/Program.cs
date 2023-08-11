// See https://aka.ms/new-console-template for more information

using EFCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

//var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options)
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
        Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}");
    });
}

Console.ReadLine();
