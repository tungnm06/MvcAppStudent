﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
    }
}