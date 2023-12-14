using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.Teacher
{
    public class TeacherCreateVM
    {
        public string TeacherCode { get; set; } = null!;
        public string FullNameTeacher { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public int Status { get; set; }
    }
}
