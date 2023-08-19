using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var newProduct = new Product() { Name = "Kurşun Kalem", Price = 100, Stock = 200, Barcode = "A-0040-Z" };

    Console.WriteLine($"First state: {_context.Entry(newProduct).State}");


    _context.Entry(newProduct).State = EntityState.Added;

    //await _context.Products.AddAsync(newProduct);

    Console.WriteLine($"Last state: {_context.Entry(newProduct).State}");



    await _context.SaveChangesAsync();

    Console.WriteLine($"State after save changes: {_context.Entry(newProduct).State}");
}

Console.ReadLine();
