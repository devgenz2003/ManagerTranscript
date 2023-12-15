using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.ClassTC;
using BUS.Viewmodel.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.Teacher
{
    public partial class FrmTeacher : Form
    {
        private readonly ITeacherService _ITeacherService;
        private string Code;
        private TeacherVM _tcr;
        public FrmTeacher()
        {
            InitializeComponent();
            _ITeacherService = new TeacherService();
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 5;
            dtg_data.Columns[0].Name = "Mã";
            dtg_data.Columns[1].Name = "Tên giảng viên";
            dtg_data.Columns[2].Name = "Số điện thoại";
            dtg_data.Columns[3].Name = "Gmail";
            dtg_data.Columns[4].Name = "Trạng thái";
            dtg_data.Rows.Clear();
            var data = await _ITeacherService.GetAllAsync();
            foreach (var load in data)
            {
                dtg_data.Rows
                    .Add(load.TeacherCode,
                    load.FullNameTeacher,
                    load.PhoneNumber,
                    load.Email,
                    load.Status == 1 ? "Đang làm" : "Đã nghỉ"
                    );
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new TeacherCreateVM
                {
                    TeacherCode = tb_code.Text,
                    FullNameTeacher = tb_name.Text,
                    Email = tb_email.Text,
                    PhoneNumber = Convert.ToInt32(tb_phone.Text),
                    Status = cb_status.Checked ? 1 : 0
                };
                await _ITeacherService.CreateAsync(data);
                MessageBox.Show("Success");
                LoadData();
            }
        }
        private async void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Code = dtg_data.Rows[e.RowIndex].Cells[0].Value.ToString();

                _tcr = await _ITeacherService.GetByIDAsync(Code);

                tb_code.Text = _tcr.TeacherCode;
                tb_name.Text = _tcr.FullNameTeacher;
                tb_phone.Text = Convert.ToInt32(_tcr.PhoneNumber).ToString();
                tb_email.Text = _tcr.Email;
                cb_status.Checked = (_tcr.Status == 1);
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
                    _ITeacherService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _ITeacherService.GetByIDAsync(tb_code.Text);
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
                    var data = new TeacherUpdateVM
                    {
                        TeacherCode = tb_code.Text,
                        FullNameTeacher = tb_name.Text,
                        Email = tb_email.Text,
                        PhoneNumber = Convert.ToInt32(tb_phone.Text),
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _ITeacherService.UpdateAsync(_tcr.TeacherCode, data);
                    MessageBox.Show("Success");
                    LoadData();
                }
            }
        }
    }
}
