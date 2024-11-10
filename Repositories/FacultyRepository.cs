using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class FacultyRepository
    {
        private readonly CollegeDbContext _context;

        public FacultyRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Faculty> GetAllFaculty()
        {
            return _context.Faculty.Include(s => s.Subjects).Include(d => d.Departments).Include(c => c.Courses).ToList();
        }

        public Faculty GetFacultyById(int FID)
        {
            return _context.Faculty.Find(FID);
        }

        public void AddFaculty(Faculty faculty)
        {
            _context.Faculty.Add(faculty);
            _context.SaveChanges();
        }


        public void UpdateFaculty(Faculty faculty)
        {
            _context.Faculty.Update(faculty);
            _context.SaveChanges();
        }

        public void DeleteFaculty(int FID)
        {
            var faculty = GetHostelById(FID);
            if (faculty != null)
            {
                _context.Faculty.Remove(faculty);
                _context.SaveChanges();
            }
        }

        public Faculty GetFacultyByDepartment(int did)
        {
            return _context.Faculty.FirstOrDefault(d => d.DID == did);
        }

        public Faculty GetFacultyByMobileNumber(string number)
        {
            return _context.Faculty.Include(n => n.Faculty_Mobile).FirstOrDefault(m => m.Mobile_Number == number);
        }

        public Faculty CalculateAverageSalary()
        {
            return _context.Faculty(Average(Salary));
        }
    }
}
