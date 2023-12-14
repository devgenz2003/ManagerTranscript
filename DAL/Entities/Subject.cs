using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Subject : EntityBase
    {
        public string SubjectCode { get; set; } = null!;
        public string NameSubject { get; set; } = null!;
        public int NumberofCredits { get; set; }
        public virtual ICollection<Transcript> Transcript { get; set; }
        public virtual ICollection<ClassTC> ClassTC { get;set; }
        public virtual ICollection<StudentSubject> StudentSubject { get; set; }
    }
}
