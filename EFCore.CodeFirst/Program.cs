using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var product = new Product() { Id = 2, Name = "Pilot Kalem", Price = 1, Stock = 1, Description = null, Barcode = "A-0020-Z" };

    Console.WriteLine($"First state: {_context.Entry(product).State}");


    _context.Update(product);

    Console.WriteLine($"Second state: {_context.Entry(product).State}");


    await _context.SaveChangesAsync();
    Console.WriteLine($"State after save changes: {_context.Entry(product).State}");
}

Console.ReadLine();
