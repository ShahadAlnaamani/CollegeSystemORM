using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeSystem.Models
{
    public class Hostels
    {
        [Key]
        public int Host_ID { get; set; }
        public int No_Of_Seats { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Host_Name { get; set; }

        public virtual ICollection<Students> Students { get; set; }

    }
}
