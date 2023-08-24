using EFCore.CodeFirst.Relationships.ManyToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var teacher = _context.Teachers.First(x => x.Name == "Zeynep");

    teacher.Students.AddRange(new List<Student>()
        {
            new Student(){ Name = "Hasan", Age = 12 },
            new Student(){ Name = "Hüseyin", Age = 12 },
        }
    );

    /*    
    teacher.Students.AddRange(new[]
        {
            new Student(){ Name = "Hasan", Age = 12 },
            new Student(){ Name = "Hüseyin", Age = 12 }
        }
    );
    */

    _context.SaveChanges();
}

Console.ReadKey();
