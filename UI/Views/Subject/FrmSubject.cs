using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.Student;
using BUS.Viewmodel.Subject;
using BUS.Viewmodel.Teacher;
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

namespace UI.Views.Subject
{
    public partial class FrmSubject : Form
    {
        private readonly ISubjectService _ISubjectService;
        private string Code;
        private SubjectVM _sbj;
        public FrmSubject()
        {
            InitializeComponent();
            _ISubjectService = new SubjectService();
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 4;
            dtg_data.Columns[0].Name = "Mã môn";
            dtg_data.Columns[1].Name = "Tên môn học";
            dtg_data.Columns[2].Name = "Số tín chỉ";
            dtg_data.Columns[3].Name = "Trạng thái";
            dtg_data.Rows.Clear();
            var data = await _ISubjectService.GetAllAsync();
            foreach (var load in data)
            {
                dtg_data.Rows
                    .Add(load.SubjectCode,
                    load.NameSubject,
                    load.NumberofCredits,
                    load.Status == 1 ? "Hoạt động" : "Tạm ngưng"
                    );
            }
        }
        private async void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Code = dtg_data.Rows[e.RowIndex].Cells[0].Value.ToString();

                _sbj = await _ISubjectService.GetByIDAsync(Code);

                tb_code.Text = _sbj.SubjectCode;
                tb_name.Text = _sbj.NameSubject;
                tb_credits.Text = Convert.ToInt32(_sbj.NumberofCredits).ToString();
                cb_status.Checked = (_sbj.Status == 1);
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
                    _ISubjectService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _ISubjectService.GetByIDAsync(tb_code.Text);
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
                    var data = new SubjectUpdateVM
                    {
                        SubjectCode = tb_code.Text,
                        NameSubject = tb_name.Text,
                        NumberofCredits = Convert.ToInt32(tb_credits.Text),
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _ISubjectService.UpdateAsync(_sbj.SubjectCode, data);
                    MessageBox.Show("Success");
                    LoadData();
                }
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new SubjectCreateVM
                {
                    SubjectCode = tb_code.Text,
                    NameSubject = tb_name.Text,
                    NumberofCredits = Convert.ToInt32(tb_credits.Text),
                    Status = cb_status.Checked ? 1 : 0
                };
                await _ISubjectService.CreateAsync(data);
                MessageBox.Show("Success");
                LoadData();
            }
        }
    }
}
