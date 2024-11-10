using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    public class Students
    {
        [Key]
        public int S_ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string State { get; set; }

        [StringLength(6)]
        public string zipcode { get; set; }

        [Required]
        public DateOnly DOB { get; set; }

        [ForeignKey("Hostels")]
        public int Host_ID { get; set; }
        public virtual Hostels Hostels { get; set; }


        [ForeignKey("Faculty")]
        public int FID { get; set; }
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Student_Phones> Student_Phones { get; set; }

    }
}
