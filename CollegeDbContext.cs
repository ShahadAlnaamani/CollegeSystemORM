using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace CollegeSystem
{
    public class CollegeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(" Data Source=(local); Initial Catalog=CollegeSystem; Integrated Security=true; TrustServerCertificate=True ");
        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Faculty_Mobile> Faculty_Mobiles { get; set; }
        public DbSet<Hostels> Hostels { get; set; }
        public DbSet<Student_Phones> Student_Phones { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

    }
}
