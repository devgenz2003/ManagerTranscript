using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.ClassTC
{
    public class ClassTCUpdateVM
    {
        public string? ModifiedBy { get; set; }
        public string CodeSubject { get; set; } = null!;//foreign
        public string TeacherCode { get; set; } = null!;//foreign
        public string SemesterCode { get; set; } = null!;
        public string ClassCode { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public int QuantityStudent { get; set; }

        public int Status { get; set; }
    }
}
