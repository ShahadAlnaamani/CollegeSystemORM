using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    public class Departments
    {
        [Key]
        public int Dept_ID { get; set; }

        [Required]
        public string DepT_Name { get; set;}

        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }



    }
}
