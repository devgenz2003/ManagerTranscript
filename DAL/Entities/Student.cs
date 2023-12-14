using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Student : EntityBase
    {
        public string StudentCode { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime BirthDay { get; set; } 
        public string HomeTown { get; set; } = null!;

        public virtual ICollection<StudentSubject> StudentSubject { get; set; }
        public virtual ICollection<Transcript> Transcript { get; set; }
    }
}
