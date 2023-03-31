using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDbContext.Data
{
    public class MyFirstDbContext2 : DbContext
    {
        public MyFirstDbContext2() : base() { }

        public MyFirstDbContext2(DbContextOptions<MyFirstDbContext2> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyFirstDb;Integrated Security=SSPI;TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
