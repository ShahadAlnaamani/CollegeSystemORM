using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class Faculty_MobileRepository
    {
        private readonly CollegeDbContext _context;

        public Faculty_MobileRepository(CollegeDbContext context)
        {
            _context = context;
        }
    }
}
