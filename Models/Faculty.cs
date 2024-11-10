using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeSystem.Models
{
    public class Faculty
    {
        [Key]
        public int F_Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set;}

        [MaxLength(10000)]
        public float Salary { get; set;}

        [ForeignKey("Departments")]
        public int DID { get; set; }
        public virtual Departments Departments { get; set; }


        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Faculty_Mobile> Faculty_Mobiles { get; set; }

    }
}
