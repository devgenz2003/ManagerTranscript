using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.Semester
{
    public class SemesterCreateVM
    {
        public string SemesterCode { get; set; } = null!;
        public string SemesterName { get; set; } = null!;
        public DateTime SchoolYear { get; set; }
        public int Status { get; set; }
    }
}
