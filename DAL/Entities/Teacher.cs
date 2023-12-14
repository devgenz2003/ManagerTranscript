using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Teacher : EntityBase
    {
        public string TeacherCode { get; set; } = null!;
        public string FullNameTeacher { get; set; } = null!;
        public int PhoneNumber { get; set; } 
        public string Email { get; set; } = null!;

        public virtual ICollection<ClassTC> ClassTC { get; set; } 
    }
}
