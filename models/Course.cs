﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityassign01.models
{
    public class Course
    {
        [Required]
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }
    }
}
