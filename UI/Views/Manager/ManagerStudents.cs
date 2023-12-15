using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views.Class;
using UI.Views.ExamSchedule;
using UI.Views.Semester;
using UI.Views.Student;
using UI.Views.Subject;
using UI.Views.Teacher;
using UI.Views.Transcript;

namespace UI.Views.Manager
{
    public partial class ManagerStudents : Form
    {
        public ManagerStudents()
        {
            InitializeComponent();
        }

        private void quảnLýThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudents frmobj = new FrmStudents();
            frmobj.Show();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacher frmobj = new FrmTeacher();
            frmobj.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubject frmobj = new FrmSubject();
            frmobj.Show();
        }

        private void quảnLýLớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClassTC frmobj = new FrmClassTC();
            frmobj.Show();
        }

        private void quảnLýHọcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemester frmobj = new FrmSemester();
            frmobj.Show();
        }

        private void quảnLýLịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamSchedule frmobj = new FrmExamSchedule();
            frmobj.Show();
        }

        private void quảnLýBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTranscript frmobj = new FrmTranscript();
            frmobj.Show();
        }
    }
}
