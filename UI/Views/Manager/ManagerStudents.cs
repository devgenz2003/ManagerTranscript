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
        private void ShowFormInPanel(Form form)
        {
            this.view_share.Controls.Clear();
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;

            form.Location = new Point(
                (this.view_share.Width - form.Width) / 2,
                (this.view_share.Height - form.Height) / 2
            );

            this.view_share.Controls.Add(form);
            form.Show();
        }

        private void quảnLýThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmStudents frmobj = new FrmStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size; 
            ShowFormInPanel(frmobj);
            frmobj.Show();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmTeacher frmobj = new FrmTeacher() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);

            frmobj.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmSubject frmobj = new FrmSubject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);

            frmobj.Show();
        }

        private void quảnLýLớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmClassTC frmobj = new FrmClassTC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);

            frmobj.Show();
        }

        private void quảnLýHọcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmSemester frmobj = new FrmSemester() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);

            frmobj.Show();
        }

        private void quảnLýLịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmExamSchedule frmobj = new FrmExamSchedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);

            frmobj.Show();
        }

        private void quảnLýBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_share.Controls.Clear();
            FrmTranscript frmobj = new FrmTranscript() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.view_share.Controls.Add(frmobj);
            frmobj.Size = this.view_share.Size;
            ShowFormInPanel(frmobj);
            frmobj.Show();
        }
    }
}
