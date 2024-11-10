using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class DepartmentsRepository
    {
        private readonly CollegeDbContext _context;

        public DepartmentsRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Departments> GetAllDepartments()
        {
            return _context.Departments.Include(e => e.Exams).Include(c => c.Courses).ToList();
        }

        public Courses GetDepartmentById(int did)
        {
            return _context.Departments.Find(did);
        }

        public void AddDepartments(Departments department)
        {
            _context.Courses.Add(department);
            _context.SaveChanges();
        }


        public void UpdateDepartments(Departments department)
        {
            _context.Courses.Update(department);
            _context.SaveChanges();
        }

        public void DeleteDepartments(int DID)
        {
            var department = GetDepartmentById(DID);
            if (department != null)
            {
                _context.Departments.Remove(DID);
                _context.SaveChanges();
            }
        }

        public List<Departments> GetDepartmentsWithCourses()
        {
            return _context.Departments.Include(e => e.Courses).ToList();
        }

        public List<Departments> GetDepartmentNames()
        {
            return _context.Departments.Select(p=> new { p.DepT_Name}).ToList();
        }

    }
}
