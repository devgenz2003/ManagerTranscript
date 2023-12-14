using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class StudentSubject : EntityBase
    {
        public string SubjectCode { get; set; } = null!;
        public string StudentCode { get; set; } = null!;

        public virtual Student Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
