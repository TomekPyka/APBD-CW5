﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_CW5.Model
{
    public class Studies
    {
        [Required]
        public int IdStudy { get; set; }
        [Required]
        public string Name { get; set; }
    }
}