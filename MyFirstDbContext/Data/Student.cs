using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDbContext.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set;}
    }

    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CourseId { get; set; }
    }

    public class Mapper
    {
        public static StudentModel MapStudentToModel(Student student)
        {
            StudentModel model = new StudentModel();
            model.Surname = student.Surname;
            model.Name = student.Name;
            model.CourseId = student.CourseId;
            model.Id = student.StudentId;

            return model;
        }
    }
}
