using System;
using System.Collections.Generic;

namespace webapi1.Models
{
    public partial class StudentGradeValue
    {
        public int SgvrecNo { get; set; }
        public int StudentRecNo { get; set; }
        public int SubGradeRecNo { get; set; }
        public int StudentGradeValue1 { get; set; }
        public DateTime GradeDate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
