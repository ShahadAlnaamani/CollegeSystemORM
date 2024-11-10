using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class SubjectsRepository
    {
        private readonly CollegeDbContext _context;

        public SubjectsRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Subjects> GetAllSubjects()
        {
            return _context.Subjects.Include(f => f.Faculty).ToList();
        }

        public Subjects GetSubjectsById(int SID)
        {
            return _context.Subjects.Find(SID);
        }

        public void AddSubjects(Subjects subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }


        public void UpdateSubjects(Subjects subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
        }

        public void DeleteHostel(int SID)
        {
            var subject = GetSubjectsById(SID);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                _context.SaveChanges();
            }
        }

        public Subjects GetSubjectsByCity(int FID)
        {
            return _context.Subjects.FirstOrDefault(f => f.F_ID == FID);
        }


        public Subjects CountSubjects()
        {
            return _context.Subjects.Count();
        }

    }
}
