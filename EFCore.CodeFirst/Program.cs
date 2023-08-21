using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    
    var products = await _context.Products.ToListAsync();
    var customers = await _context.Customers.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock} - {p.Barcode} ---> {_context.Entry(p).State}");
    });

    Console.WriteLine("- - - - - - - - - - -");

    customers.ForEach(c =>
    {
        Console.WriteLine($"{c.Id} - {c.Name} - {c.City} - {c.Email} ---> {_context.Entry(c).State}");
    });

    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

    _context.ChangeTracker.Entries().ToList().ForEach(e =>
    {
        Console.WriteLine($"{e.Entity.GetType().Name} - {e.State}"); 
    });

    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

    _context.ChangeTracker.Entries().ToList().ForEach(e =>
    {
        if (e.Entity is Product p)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock} - {p.Barcode} ---> {_context.Entry(p).State}");
        }
        else if (e.Entity is Customer c)
        {
            Console.WriteLine($"{c.Id} - {c.Name} - {c.City} - {c.Email} ---> {_context.Entry(c).State}");

        }
    });

}

Console.ReadLine();



