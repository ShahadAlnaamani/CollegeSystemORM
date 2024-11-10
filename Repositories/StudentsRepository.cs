using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class StudentsRepository
    {
        private readonly CollegeDbContext _context;

        public StudentsRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Students> GetAllStudents()
        {
            return _context.Students.Include(s => s.Hostels).Include(cs => cs.Courses_Students).Include(c => c.Courses).Include(d => d.Departments).Include(d => d.Projects).Include(e => e.Exams).ToList();
        }

        public Students GetStudentById(int SID)
        {
            return _context.Students.Find(SID);
        }

        public void AddStudent(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Students student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int SID)
        {
            var student = GetStudentById(SID);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public Students GetStudentsByCourse(int CourseID)
        {
            return _context.Students.Include(s => s.CoursesStudents).FirstOrDefault(c => c.CoursescourseID == CourseID);
        }

        public Students GetStudentByHostel (int HID)
        {
            return _context.Students.Find(HID);
        }

        public Students SearchStudents(var input)
        {
            return _context.Students.Where.Contains(input);
        }

        public Students GetStudentsWithAgeAbove(int age)
        {
            return _context.Students.Where(age == (Today - DOB));
        }

    }
}
