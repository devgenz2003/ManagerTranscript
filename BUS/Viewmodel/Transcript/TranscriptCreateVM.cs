using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.Transcript
{
    public class TranscriptCreateVM
    {
        public string TranscriptCode { get; set; } = null!;
        public string StudentCode { get; set; } = null!;
        public string ExamCode { get; set; } = null!;
        public string ClassCode { get; set; } = null!;
        public string SubjectCode { get; set; } = null!;
        //key foreign
        public int NumberCredits { get; set; }
        public float Attendance { get; set; } //điểm chuyên cần
        public float ConditionPoint { get; set; }
        public float TestScore { get; set; }
        public int Status { get; set; }

    }
}
