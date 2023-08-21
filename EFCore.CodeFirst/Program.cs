using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{

    _context.Products.Add(new() { Name = "Kara Kalem", Price = 1200, Stock = 2400, Barcode= "A-0100-Z" });
    
    _context.SaveChanges();
}

Console.ReadLine();
