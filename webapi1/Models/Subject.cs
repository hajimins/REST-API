using System;
using System.Collections.Generic;

namespace webapi1.Models
{
    public partial class Subject
    {
        public int SubjectRecNo { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string Course { get; set; }
        public byte? Semester { get; set; }
        public double? TotalGrade { get; set; }
    }
}
