using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.Semester;
using BUS.Viewmodel.Student;
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

namespace UI.Views.Semester
{
    public partial class FrmSemester : Form
    {
        private string Code;
        private CancellationTokenSource _cts;
        private readonly ISemesterService _ISemesterService;
        private List<SemesterVM> _lstsems;
        private SemesterVM _sems;
        public FrmSemester()
        {
            InitializeComponent();
            _lstsems = new List<SemesterVM>();
            _ISemesterService = new SemesterService();
            LoadData();
            _cts = new CancellationTokenSource();
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 5;
            dtg_data.Columns[0].Name = "Mã";
            dtg_data.Columns[1].Name = "Tên";
            dtg_data.Columns[2].Name = "Lớp";
            dtg_data.Columns[3].Name = "Trạng thái";
            dtg_data.Columns[4].Name = "Ngày tạo";
            dtg_data.Rows.Clear();
            _lstsems = await _ISemesterService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(tb_code.Text))
            {
                _lstsems = _lstsems.Where(s => s.SemesterCode.Equals(tb_code.Text.Trim())).ToList();
            }

            foreach (var student in _lstsems)
            {
                dtg_data.Rows.Add(
                    student.SemesterCode,
                    student.SemesterName,
                    student.SchoolYear,
                    student.Status == 1 ? "Hoạt động" : "Tạm nghỉ",
                    student.CreateDate.ToString("dd/MM/yyyy")
                );
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new SemesterCreateVM
                {
                    SemesterCode = tb_code.Text,
                    SemesterName = tb_name.Text,
                    SchoolYear = dtp_date.Value,
                    Status = rd_check.Checked ? 1 : 0
                };
                await _ISemesterService.CreateAsync(data);
                MessageBox.Show("Success");
                LoadData();
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
                    _ISemesterService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _ISemesterService.GetByIDAsync(tb_code.Text);
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
                    var data = new SemesterUpdateVM
                    {
                        SemesterCode = tb_code.Text,
                        SemesterName = tb_name.Text,
                        SchoolYear = dtp_date.Value,
                        Status = rd_check.Checked ? 1 : 0
                    };
                    await _ISemesterService.UpdateAsync(_sems.SemesterCode, data);
                    MessageBox.Show("Success");
                    LoadData();
                }
            }
        }
    }
}
