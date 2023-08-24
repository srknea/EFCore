using EFCore.CodeFirst.Relationships.ManyToMany.DataAdd.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var student = new Student(){ Name = "Serkan", Age = 12};

    student.Teachers.Add(new Teacher() { Name = "Murat"});
    student.Teachers.Add(new Teacher() { Name = "Sevgül"});

    _context.Students.Add(student); 

    _context.SaveChanges();
}

Console.ReadKey();
