using System;
using System.Collections.Generic;

namespace webapi1.Models
{
    public partial class Grade
    {
        public int GradeRecNo { get; set; }
        public int SubjectRecNo { get; set; }
        public string GradeName { get; set; }
        public byte SubGradeCount { get; set; }
        public double? GradePerCent { get; set; }
    }
}
