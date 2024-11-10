using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class Student_PhonesRepository
    {
        private readonly CollegeDbContext _context;

        public Student_PhonesRepository(CollegeDbContext context)
        {
            _context = context;
        }
    }
}
