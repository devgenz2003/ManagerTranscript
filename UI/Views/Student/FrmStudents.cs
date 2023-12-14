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

        public FrmStudents()
        {
            InitializeComponent();
            _IStudentService = new StudentService();
            //LoadData();
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
            var data = await _IStudentService.GetAllAsync();
            foreach (var load in data)
            {
                dtg_data.Rows
                    .Add(load.StudentCode,
                    load.FullName,
                    load.Class,
                    load.HomeTown,
                    load.Gender,
                    load.BirthDay,
                    load.Status == 1 ? "Đang học" : "Đã nghỉ",
                    load.CreateDate);
            }
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
                    LoadData();
                }
            }
        }
    }
}
