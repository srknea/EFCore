using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var product = await _context.Products.FirstAsync();
    
    Console.WriteLine($"First state: {_context.Entry(product).State}");


    _context.Entry(product).State = EntityState.Deleted;

    //_context.Remove(product);

    Console.WriteLine($"Last state: {_context.Entry(product).State}");
    
    
    await _context.SaveChangesAsync();

    Console.WriteLine($"State after save changes: {_context.Entry(product).State}");
}

Console.ReadLine();
