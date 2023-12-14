using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.ExamSchedule
{
    public class ExamScheduleUpdateVM
    {
        public string? ModifiedBy { get; set; }
        public string ExamScheduleCode { get; set; } = null!;
        public string NameSubject { get; set; } = null!;
        public DateTime ExamTime { get; set; }
        public int Status { get; set; }
    }
}
