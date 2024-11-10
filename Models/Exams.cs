using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    public class Exams
    {
        [Key]
        public int Exam_Code { get; set; }

        public int Room_No { get; set; }

        [Required]
        public DateOnly Date {  get; set; }

        [Required]
        public TimeOnly Time { get; set; }

        [ForeignKey("Departments")]
        public int DID { get; set; }
        public Departments Departments { get; set; }
    }
}
