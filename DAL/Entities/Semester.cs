using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Semester : EntityBase
    {
        public string SemesterCode { get; set; } = null!;
        public string SemesterName { get; set; } = null!;
        public DateTime SchoolYear { get; set; }
        public virtual ICollection<ClassTC> ClassTC { get; set; }

    }
}
