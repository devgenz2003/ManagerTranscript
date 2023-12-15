using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.Student;
namespace UI.Views.Student
{
    public partial class FrmStudents : Form
    {
        private readonly IStudentService _IStudentService;
        private string Code { get; set; }
        private StudentVM _std;
        private List<StudentVM> _lststudents;
        private CancellationTokenSource _cts;
        public FrmStudents()
        {
            InitializeComponent();
            _IStudentService = new StudentService();
            _lststudents = new List<StudentVM>();
            LoadData();
            tb_code.TextChanged += tb_code_TextChanged;
            _cts = new CancellationTokenSource();
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 8;
            dtg_data.Columns[0].Name = "Mã";
            dtg_data.Columns[1].Name = "Tên";
            dtg_data.Columns[2].Name = "Lớp";
            dtg_data.Columns[3].Name = "Quê quán";
            dtg_data.Columns[4].Name = "Giới tính";
            dtg_data.Columns[5].Name = "Năm sinh";
            dtg_data.Columns[6].Name = "Trạng thái";
            dtg_data.Columns[7].Name = "Ngày tạo";
            dtg_data.Rows.Clear();
            _lststudents = await _IStudentService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(tb_code.Text))
            {
                _lststudents = _lststudents.Where(s => s.StudentCode.Equals(tb_code.Text.Trim())).ToList();
            }

            foreach (var student in _lststudents)
            {
                dtg_data.Rows.Add(
                    student.StudentCode,
                    student.FullName,
                    student.Class,
                    student.HomeTown,
                    student.Gender,
                    student.BirthDay.ToString("dd/MM/yyyy"),
                    student.Status == 1 ? "Đang học" : "Đã nghỉ",
                    student.CreateDate.ToString("dd/MM/yyyy")
                );
            }
        }
        private void Reset()
        {
            tb_code.Text = string.Empty;
            tb_name.Text = string.Empty;
            tb_class.Text = string.Empty;
            tb_hometown.Text = string.Empty;
            tb_gender.Text = string.Empty;

            dtp_birthday.Value = DateTime.Now;

            cb_status.Checked = false;

            if (dtg_data.CurrentRow != null)
            {
                dtg_data.ClearSelection();
            }
            Code = string.Empty;
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new StudentCreateVM
                {
                    StudentCode = tb_code.Text,
                    FullName = tb_name.Text,
                    Class = tb_class.Text,
                    HomeTown = tb_hometown.Text,
                    Gender = tb_gender.Text,
                    BirthDay = dtp_birthday.Value,
                    Status = cb_status.Checked ? 1 : 0
                };
                await _IStudentService.CreateAsync(data);
                MessageBox.Show("Success");
                Reset();
                LoadData();
            }

        }
        private void btn_data_Click(object sender, EventArgs e)
        {
            LoadData();
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
                    _IStudentService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    Reset();
                    LoadData();
                }
            }
        }
        private async void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string studentId = dtg_data.Rows[e.RowIndex].Cells[0].Value.ToString();

                _std = await _IStudentService.GetByIDAsync(studentId);

                tb_code.Text = _std.StudentCode;
                tb_class.Text = _std.Class;
                tb_name.Text = _std.FullName;
                tb_gender.Text = _std.Gender;
                dtp_birthday.Value = _std.BirthDay;
                tb_hometown.Text = _std.HomeTown;
                cb_status.Checked = (_std.Status == 1);
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _IStudentService.GetByIDAsync(tb_code.Text);
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
                    var data = new StudentUpdateVM
                    {
                        StudentCode = tb_code.Text,
                        FullName = tb_name.Text,
                        Class = tb_class.Text,
                        Gender = tb_gender.Text,
                        BirthDay = dtp_birthday.Value,
                        HomeTown = tb_hometown.Text,
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _IStudentService.UpdateAsync(_std.StudentCode, data);
                    MessageBox.Show("Success");
                    Reset();
                    LoadData();
                }
            }
        }
        private async void tb_code_TextChanged(object sender, EventArgs e)
        {
            _cts.Cancel();
            _cts.Dispose();
            _cts = new CancellationTokenSource();

            try
            {
                await Task.Delay(300, _cts.Token);
                LoadData();
            }
            catch (TaskCanceledException)
            {

            }
        }
    }
}
