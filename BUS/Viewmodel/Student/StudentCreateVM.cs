using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.Student
{
    public class StudentCreateVM
    {
        public string StudentCode { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime BirthDay { get; set; }
        public string HomeTown { get; set; } = null!;
        public int Status { get; set; }

    }
}
