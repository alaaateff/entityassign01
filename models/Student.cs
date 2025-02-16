using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityassign01.models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string FName { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string lName { get; set; }
        public string Address { get; set; }
        [Range(20, 60)]
        public int Age { get; set; }


    }
}
