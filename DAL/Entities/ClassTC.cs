using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class ClassTC : EntityBase
    {
        public string CodeSubject { get; set; } = null!;//foreign
        public string TeacherCode { get; set; } = null!;//foreign
        public string SemesterCode { get; set; } = null!;//foreign
        public string ClassCode { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public int QuantityStudent { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ICollection<Transcript> Transcript { get; set; }
    }
}
