using System;
using System.Collections.Generic;

namespace webapi1.Models
{
    public partial class SubGrade
    {
        public int SubGradeRecNo { get; set; }
        public int GradeRecNo { get; set; }
        public int SubjectRecNo { get; set; }
        public string SubGradeName { get; set; }
        public double? GradeMax { get; set; }
        public DateTime GradeDate { get; set; }
    }
}
