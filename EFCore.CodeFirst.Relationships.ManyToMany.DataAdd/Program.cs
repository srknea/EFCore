using EFCore.CodeFirst.Relationships.ManyToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var teacher = new Teacher()
    {
        Name = "Zeynep",
        Students = new List<Student>() 
        { 
            new Student() { Name = "Fidan", Age = 10 },
            new Student() { Name = "Canan", Age = 11 },
            new Student() { Name = "Ömer", Age = 12 },
            new Student() { Name = "Batuhan", Age = 13 }
        }
    };

    _context.Teachers.Add(teacher); 

    _context.SaveChanges();
}

Console.ReadKey();
