// See https://aka.ms/new-console-template for more information

using EFCore.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var dbContext = new EfCoreDatabaseFirstDbContext()) {
    
    var products = await dbContext.Products.ToListAsync();

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