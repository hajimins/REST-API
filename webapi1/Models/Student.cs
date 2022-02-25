using System;
using System.Collections.Generic;

namespace webapi1.Models
{
    public partial class Student
    {
        public int StudentRecNo { get; set; }
        public string StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentMajor { get; set; }
        public double? StudentFinalGrade { get; set; }
    }
}
