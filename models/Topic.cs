﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityassign01.models
{
    public class Topic
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
