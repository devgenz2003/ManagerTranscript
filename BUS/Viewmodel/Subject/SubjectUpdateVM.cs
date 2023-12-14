using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmodel.Subject
{
    public class SubjectUpdateVM
    {
        public string SubjectCode { get; set; } = null!;
        public string NameSubject { get; set; } = null!;
        public int NumberofCredits { get; set; }
        public int Status { get; set; }
    }
}
