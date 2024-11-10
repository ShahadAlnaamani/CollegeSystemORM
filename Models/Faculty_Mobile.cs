using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    [PrimaryKey(nameof (FID),nameof (Mobile_No))]
    public class Faculty_Mobile
    {
        [ForeignKey("faculty")]
        public int FID { get; set; }

        [Required]
        public string Mobile_No { get; set; }

        public Faculty faculty { get; set; }
    }
}
