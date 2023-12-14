using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class ExamSchedule : EntityBase
    {
        public string ExamScheduleCode { get; set; } = null!;
        public string NameSubject { get; set; } = null!;
        public DateTime ExamTime { get; set; }
        public virtual ICollection<Transcript> Transcript { get; set; }

    }
}
