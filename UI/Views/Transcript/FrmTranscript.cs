using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.Student;
using BUS.Viewmodel.Transcript;
using DAL.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.Transcript
{
    public partial class FrmTranscript : Form
    {
        private string Code { get; set; }
        private readonly ITranscriptService _ITranscriptService;
        private readonly IStudentService _IStudentService;
        private readonly IExamScheduleService _IExamScheduleService;
        private readonly IClassTCService _IClassTCService;
        private readonly ISubjectService _ISubjectService;
        private readonly ManagerStudent_DBContext _dbcontext;
        private TranscriptVM _trs;
        public FrmTranscript()
        {
            InitializeComponent();
            _dbcontext = new ManagerStudent_DBContext();
            _ITranscriptService = new TranscriptService();
            _IStudentService = new StudentService();
            _IExamScheduleService = new ExamScheduleService();
            _IClassTCService = new ClassTCService();
            _ISubjectService = new SubjectService();
            LoadExam();
            LoadStudent();
            LoadClass();
            LoadSubject();
            LoadData();
        }
        private async void LoadStudent()
        {
            foreach (var data in await _IStudentService.GetAllAsync())
            {
                cbb_studentcode.Items.Add(data.StudentCode);
                cbb_studentcodecheck.Items.Add(data.StudentCode);
            }
        }
        private async void LoadExam()
        {
            foreach (var data in await _IExamScheduleService.GetAllAsync())
            {
                cbb_examcode.Items.Add(data.ExamScheduleCode);
            }
        }
        private async void LoadClass()
        {
            foreach (var data in await _IClassTCService.GetAllAsync())
            {
                cbb_classcode.Items.Add(data.ClassCode);
            }
        }
        private async void LoadSubject()
        {
            foreach (var data in await _ISubjectService.GetAllAsync())
            {
                cbb_subjectcode.Items.Add(data.SubjectCode);
                cbb_subjectcodecheck.Items.Add(data.SubjectCode);
            }
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 9;
            dtg_data.Columns[0].Name = "Mã";
            dtg_data.Columns[1].Name = "Mã sinh viên";
            dtg_data.Columns[2].Name = "Mã bài thi";
            dtg_data.Columns[3].Name = "Mã lớp";
            dtg_data.Columns[4].Name = "Mã môn";
            dtg_data.Columns[5].Name = "Tín chỉ";
            dtg_data.Columns[6].Name = "Chuyên cần";
            dtg_data.Columns[7].Name = "Điều kiện";
            dtg_data.Columns[8].Name = "Điểm thi";
            dtg_data.Rows.Clear();
            var data = await _ITranscriptService.GetAllAsync();
            foreach (var load in data)
            {
                dtg_data.Rows
                    .Add(load.TranscriptCode,
                    load.StudentCode,
                    load.ExamCode,
                    load.ClassCode,
                    load.SubjectCode,
                    load.NumberCredits,
                    load.Attendance,
                    load.ConditionPoint,
                    load.TestScore,
                    load.Status == 1 ? "Đậu" : "Trượt");
            }
        }
        private async void btn_data_Click(object sender, EventArgs e)
        {
            string subjectCode = cbb_studentcodecheck.Text;

            try
            {
                var studentsRetaking = await _IStudentService.GetStudentsRetakingSubject(subjectCode);

                string message = "Sinh viên cần học lại môn " + subjectCode + "\n";
                foreach (var student in studentsRetaking)
                {
                    message += "- " + student.StudentCode + "\n";
                }
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                float attendance, conditionPoint, testScore;
                bool isAttendanceValid = float.TryParse(tb_attendance.Text, out attendance);
                bool isConditionPointValid = float.TryParse(tb_conditionpoint.Text, out conditionPoint);
                bool isTestScoreValid = float.TryParse(tb_testscore.Text, out testScore);
                if (isAttendanceValid && isConditionPointValid && isTestScoreValid)
                {
                    var data = new TranscriptCreateVM
                    {
                        TranscriptCode = tb_code.Text,
                        StudentCode = cbb_studentcode.Text,
                        ExamCode = cbb_examcode.Text,
                        ClassCode = cbb_classcode.Text,
                        SubjectCode = cbb_subjectcode.Text,
                        NumberCredits = Convert.ToInt32(tb_credits.Text),
                        Attendance = attendance,
                        ConditionPoint = conditionPoint,
                        TestScore = testScore,
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _ITranscriptService.CreateAsync(data);
                    MessageBox.Show("Success");
                    LoadData();
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Code == null)
            {
                MessageBox.Show("Vui lòng chọn");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    _ITranscriptService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Code = dtg_data.Rows[e.RowIndex].Cells[0].Value.ToString();

                _trs = await _ITranscriptService.GetByIDAsync(Code);
                cbb_classcode.Text = _trs.ClassCode;
                cbb_examcode.Text = _trs.ExamCode;
                cbb_studentcode.Text = _trs.StudentCode;
                cbb_subjectcode.Text = _trs.SubjectCode;
                tb_code.Text = _trs.TranscriptCode;
                tb_credits.Text = Convert.ToInt32(_trs.NumberCredits).ToString();
                tb_attendance.Text = _trs.Attendance.ToString();
                tb_conditionpoint.Text = _trs.ConditionPoint.ToString();
                tb_testscore.Text = _trs.TestScore.ToString();
                cb_status.Checked = (_trs.Status == 1);
            }
        }
        private void btn_avg_Click(object sender, EventArgs e)
        {
            if (_trs != null)
            {
                float averageScore = CalculateAverageScore(_trs);

                MessageBox.Show($"Điểm trung bình: {averageScore}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi trước khi tính điểm trung bình.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private float CalculateAverageScore(TranscriptVM trs)
        {
            float attendanceWeight = 0.1f;  // Ví dụ: 10%
            float conditionPointWeight = 0.3f;  // Ví dụ: 30%
            float testScoreWeight = 0.6f;  // Ví dụ: 60%

            float averageScore = (trs.Attendance * attendanceWeight) +
                                 (trs.ConditionPoint * conditionPointWeight) +
                                 (trs.TestScore * testScoreWeight);

            return averageScore;
        }
        public async Task<float?> GetLowestTestScoreBySubject(string subjectCode)
        {
            var lowestScore = await _dbcontext.Transcript
                .Where(t => t.SubjectCode == subjectCode)
                .MinAsync(t => (float?)t.TestScore);

            return lowestScore;
        }
        private async void btn_pointmin_Click(object sender, EventArgs e)
        {
            string subjectCode = cbb_subjectcodecheck.Text;

            float? lowestScore = await GetLowestTestScoreBySubject(subjectCode);

            if (lowestScore.HasValue)
            {
                MessageBox.Show($"Điểm thi thấp nhất cho môn {subjectCode} là: {lowestScore.Value}", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Không có dữ liệu điểm thi cho môn {subjectCode}", "Thông báo");
            }
        }
        private async void btn_transcript_Click(object sender, EventArgs e)
        {
            string studentId = cbb_studentcodecheck.Text;

            try
            {
                var transcripts = await _IStudentService.GetTranscriptsByStudentCode(studentId);
                StringBuilder message = new StringBuilder();

                message.AppendLine("Bảng điểm của sinh viên: " + studentId);
                message.AppendLine($"{"Mã HP",-10} {"Điểm CC",-15} {"Điểm ĐK",-15} {"Điểm Thi",-15}");

                foreach (var transcript in transcripts)
                {
                    message.AppendLine($"{transcript.SubjectCode,-10} {transcript.Attendance,-15:N2} {transcript.ConditionPoint,-15:N2} {transcript.TestScore,-15:N2}");
                }

                MessageBox.Show(message.ToString(), "Thông Tin Bảng Điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
