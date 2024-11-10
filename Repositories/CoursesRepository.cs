using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{

    public class CoursesRepository
    {
        private readonly CollegeDbContext _context;

        public CoursesRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Courses> GetAllCourses()
        {
            return _context.Courses.Include(s => s.CoursesStudents).Include(d => d.Departments).Include(f => f.Faculty).ToList();
        }

        public Courses GetCoursesById(int CID)
        {
            return _context.Courses.Find(CID);
        }

        public void AddCourses(Courses course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }


        public void UpdateCourses(Courses courses)
        {
            _context.Courses.Update(courses);
            _context.SaveChanges();
        }

        public void DeleteCourses(int CID)
        {
            var course = GetCoursesById(CID);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public Courses GetCoursesByDepartment(int did)
        {
            return _context.Courses.FirstOrDefault(d => d.DID == did);
        }

        public Courses GetCoursesByDuration(int duration)
        {
            return _context.Courses.FirstOrDefault(d => d.Duration == duration);
        }
    }
}
