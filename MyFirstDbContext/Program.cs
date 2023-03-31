// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MyFirstDbContext.Data;


//Assicura che il Database sia sempre aggiornato all'ultima migration
using(var ctx = new MyFirstDbContext2())
{
    ctx.Database.Migrate();
}
//Course c = new Course()
//{
//    Title = "Test",
//    Students = new List<Student>()
//    {
//        new Student() { Name= "Domenico", Surname = "Sironi" },
//        new Student() { Name= "Riccardo", Surname = "Sterchele" },
//        new Student() { Name= "Stefano", Surname = "Braglia" },
//        new Student() { Name= "Lorenzo", Surname = "Canavesi" },
//        new Student() { Name= "Oleksandr", Surname = "Dzyamba" },
//        new Student() { Name= "Andrea", Surname = "Ronzio" }
//    }
//};
//using(MyFirstDbContext2 ctx = new MyFirstDbContext2())
//{
//    ctx.Courses.Add(c);
//    ctx.SaveChanges();
//    Console.WriteLine($"{c.CourseId} - {c.Title}");
//    c.Students.ForEach(s => 
//        Console.WriteLine($"\t{s.StudentId} - {s.Name} {s.Surname} - Corso: {s.CourseId}")
//    );
//}

List<Student> students;
using(MyFirstDbContext2 ctx = new MyFirstDbContext2())
{
    students = ctx.Students.Include(s => s.Course).ToList();
    var student = ctx.Students.Include(s => s.Course).Where(s => s.Course.CourseId > 1).OrderBy(s => s.StudentId).ToList();
}

var studentModels = students.ConvertAll(Mapper.MapStudentToModel);

foreach(Student s in students)
{
    Console.WriteLine($"{s.StudentId} - {s.Name}");
}


