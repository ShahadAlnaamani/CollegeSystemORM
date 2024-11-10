using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class ExamsRepository
    {
        private readonly CollegeDbContext _context;

        public ExamsRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Exams> GetAllExams()
        {
            return _context.Exams.Include(d => d.Departments).Include(c => c.Courses).Include(cs => cs.CoursesStudents).Include(s => s.Students).ToList();
        }

        public Exams GetExamsById(int EID)
        {
            return _context.Exams.Find(EID);
        }

        public void AddExams(Exams exams)
        {
            _context.Courses.Add(exams);
            _context.SaveChanges();
        }


        public void UpdateExams(Exams exams)
        {
            _context.Exams.Update(exams);
            _context.SaveChanges();
        }

        public void DeleteExams(int EID)
        {
            var exams = GetExamsById(EID);
            if (exams != null)
            {
                _context.Exams.Remove(exams);
                _context.SaveChanges();
            }
        }

        public List<Exams> GetExamsByDate(DateOnly date)
        {
            return _context.Exams.FirstOrDefault(d => d.Date == date);
        }

        public List<Exams> CountExamsByDepartment(int did)
        {
            return _context.Exams.Where(c => c.DID = did).Count();
        }

        public List<Exams> GetExamsByStudent(int SID)
        {
            return _context.Exams.Include(d => d.Departments).Include(c => c.Courses).Include(cs => cs.CoursesStudents).Where(s=> s.StudentsS_ID == SID);
        }

        public List<Exams> CountExamsByDepartment(int did)
        {
            return _context.Exams.Where(c => c.DID = did).Count();
        }
    }
}
