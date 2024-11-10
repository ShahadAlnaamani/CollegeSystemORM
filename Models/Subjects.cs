using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    public class Subjects
    {
        [Key]
        public int Subject_ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Subject_Name { get; set; }

        [ForeignKey("Faculty")]
        public int F_ID { get; set; }
        public Faculty Faculties { get; set; }  



    }
}
