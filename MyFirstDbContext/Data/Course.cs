using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDbContext.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public List<Student> Students { get; set; }
    }
}
