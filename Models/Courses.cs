using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    public class Courses
    {
        [Key]
        public int courseID { get; set; }

        public int Duration { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }

        [ForeignKey("Departments")]
        public int DID { get; set; }
        public Departments Departments { get; set; }
        public virtual ICollection<Students> Students { get; set; }


    }
}
