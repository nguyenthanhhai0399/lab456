﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigSchool1.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CourseId{get; set;}
        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}