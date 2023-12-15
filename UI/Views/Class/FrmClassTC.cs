using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.ClassTC;
using BUS.Viewmodel.Student;
using System.Formats.Asn1;

namespace UI.Views.Class
{
    public partial class FrmClassTC : Form
    {
        private readonly IClassTCService _IClassTCService;
        private readonly ITeacherService _ITeacherService;
        private readonly ISubjectService _ISubjectService;
        private readonly ISemesterService _ISemesterService;
        private string Code { get; set; }
        private ClassTCVM _cltc;
        private List<ClassTCVM> _lstClassTCVM;
        public FrmClassTC()
        {
            InitializeComponent();
            _IClassTCService = new ClassTCService();
            _ISubjectService = new SubjectService();
            _ITeacherService = new TeacherService();
            _ISemesterService = new SemesterService();
            LoadSubject();
            LoadSemester();
            LoadTeacher();
            LoadClass();
            _lstClassTCVM = new List<ClassTCVM>();
        }
        private async void LoadData()
        {
            try
            {
                dtg_data.ColumnCount = 7;
                dtg_data.Columns[0].Name = "Mã";
                dtg_data.Columns[1].Name = "Tên lớp";
                dtg_data.Columns[2].Name = "Mã môn học";
                dtg_data.Columns[3].Name = "Học kỳ";
                dtg_data.Columns[4].Name = "Mã giảng viên";
                dtg_data.Columns[5].Name = "Số lượng";
                dtg_data.Columns[6].Name = "Trạng thái";
                dtg_data.Rows.Clear();

                _lstClassTCVM = await _IClassTCService.GetAllAsync();
                if (!string.IsNullOrWhiteSpace(tb_code.Text))
                {
                    _lstClassTCVM = _lstClassTCVM.Where(c => c.ClassCode.Equals(tb_code.Text.Trim())).ToList();
                }

                foreach (var load in _lstClassTCVM)
                {
                    dtg_data.Rows.Add(load.ClassCode,
                                      load.ClassName,
                                      load.CodeSubject,
                                      load.SemesterCode,
                                      load.TeacherCode,
                                      load.QuantityStudent,
                                      load.Status == 1 ? "Hoạt động" : "Tạm ngưng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_data_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadTeacher()
        {
            foreach (var data in await _ITeacherService.GetAllAsync())
            {
                cbb_codeteacher.Items.Add(data.TeacherCode);
            }
        }
        private async void LoadClass()
        {
            foreach (var data in await _IClassTCService.GetAllAsync())
            {
                cbb_classtc.Items.Add(data.ClassCode);
            }
        }
        private async void LoadSubject()
        {
            foreach (var data in await _ISubjectService.GetAllAsync())
            {
                cbb_codesubject.Items.Add(data.SubjectCode);
            }
        }
        private async void LoadSemester()
        {
            foreach (var data in await _ISemesterService.GetAllAsync())
            {
                cbb_ses.Items.Add(data.SemesterCode);
                cbb_sescheck.Items.Add(data.SemesterCode);
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new ClassTCCreateVM
                {
                    ClassCode = tb_code.Text,
                    ClassName = tb_name.Text,
                    CodeSubject = cbb_codesubject.Text,
                    SemesterCode = cbb_ses.Text,
                    TeacherCode = cbb_codeteacher.Text,
                    QuantityStudent = Convert.ToInt32(tb_quantity.Text),
                    Status = cb_status.Checked ? 1 : 0
                };
                await _IClassTCService.CreateAsync(data);
                MessageBox.Show("Success");
                LoadData();
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _IClassTCService.GetByIDAsync(tb_code.Text);
            if (check == null)
            {
                MessageBox.Show("Vui lòng chọn");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var data = new ClassTCUpdateVM
                    {
                        ClassCode = tb_code.Text,
                        ClassName = tb_name.Text,
                        SemesterCode = cbb_ses.Text,
                        CodeSubject = cbb_codesubject.Text,
                        TeacherCode = cbb_codeteacher.Text,
                        QuantityStudent = Convert.ToInt32(tb_quantity.Text),
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _IClassTCService.UpdateAsync(_cltc.ClassCode, data);
                    MessageBox.Show("Success");
                    LoadData();
                }
            }
        }
        private async void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Code = dtg_data.Rows[e.RowIndex].Cells[0].Value.ToString();

                _cltc = await _IClassTCService.GetByIDAsync(Code);

                tb_code.Text = _cltc.ClassCode;
                tb_name.Text = _cltc.ClassName;
                cbb_ses.Text = _cltc.SemesterCode;
                cbb_codesubject.Text = _cltc.CodeSubject;
                cbb_codeteacher.Text = _cltc.TeacherCode;
                tb_quantity.Text = Convert.ToInt32(_cltc.QuantityStudent).ToString();
                cb_status.Checked = (_cltc.Status == 1);
            }
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
                    _IClassTCService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void btn_stc_Click(object sender, EventArgs e)
        {
            string semesterCode = cbb_sescheck.Text;
            ShowNumberOfClassesForSemester(semesterCode);
        }
        private async void ShowNumberOfClassesForSemester(string semesterCode)
        {
            try
            {
                int numberOfClasses = await _IClassTCService.GetNumberOfCreditClassesBySemesterCodeAsync(semesterCode);
                MessageBox.Show($"Số lượng lớp tín chỉ trong học kỳ {semesterCode} là: {numberOfClasses}", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi truy vấn số lượng lớp tín chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task ShowTeacherInCharge(string classCode)
        {
            try
            {
                var classDetails = await _IClassTCService.GetByIDAsync(classCode);

                if (classDetails != null)
                {
                    string teacherCode = classDetails.TeacherCode;

                    var teacherDetails = await _ITeacherService.GetByIDAsync(teacherCode);
                    if (teacherDetails != null)
                    {
                        MessageBox.Show($"Teacher Name: {teacherDetails.FullNameTeacher}\n" +
                                        $"Email: {teacherDetails.Email}",
                                        "Giảng viên phụ trách",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Teacher information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Class information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_teacher_Click(object sender, EventArgs e)
        {
            string classCode = cbb_classtc.Text;
            ShowTeacherInCharge(classCode);
        }
    }
}
