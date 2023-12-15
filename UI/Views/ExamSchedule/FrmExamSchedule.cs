using BUS.Services._1_Interface;
using BUS.Services._2_Implement;
using BUS.Viewmodel.ClassTC;
using BUS.Viewmodel.ExamSchedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.ExamSchedule
{
    public partial class FrmExamSchedule : Form
    {
        private readonly IExamScheduleService _IExamScheduleService;
        private List<ExamScheduleVM> _lstexc;
        private ExamScheduleVM _exc;
        private string Code;
        public FrmExamSchedule()
        {
            InitializeComponent();
            _IExamScheduleService = new ExamScheduleService();
            _lstexc = new List<ExamScheduleVM>();
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                dtg_data.ColumnCount = 4;
                dtg_data.Columns[0].Name = "Mã";
                dtg_data.Columns[1].Name = "Tên thì thi";
                dtg_data.Columns[2].Name = "Thời gian";
                dtg_data.Columns[3].Name = "Trạng thái";
                dtg_data.Rows.Clear();

                _lstexc = await _IExamScheduleService.GetAllAsync();
                if (!string.IsNullOrWhiteSpace(tb_code.Text))
                {
                    _lstexc = _lstexc.Where(c => c.ExamScheduleCode.Equals(tb_code.Text.Trim())).ToList();
                }

                foreach (var load in _lstexc)
                {
                    dtg_data.Rows.Add(load.ExamScheduleCode,
                                      load.NameSubject,
                                      load.ExamTime,
                                      load.Status == 1 ? "Hoạt động" : "Tạm ngưng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dialog = MessageBox.Show("Xác nhận thêm mới?", "Thêm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var data = new ExamScheduleCreateVM
                {
                    ExamScheduleCode = tb_code.Text,
                    NameSubject = tb_name.Text,
                    ExamTime = dtp_year.Value,
                    Status = cb_status.Checked ? 1 : 0
                };
                await _IExamScheduleService.CreateAsync(data);
                MessageBox.Show("Success");
                LoadData();
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
                    _IExamScheduleService.RemoveAsync(Code);
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var check = await _IExamScheduleService.GetByIDAsync(tb_code.Text);
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
                    var data = new ExamScheduleUpdateVM
                    {
                        ExamScheduleCode = tb_code.Text,
                        NameSubject = tb_name.Text,
                        ExamTime = dtp_year.Value,
                        Status = cb_status.Checked ? 1 : 0
                    };
                    await _IExamScheduleService.UpdateAsync(_exc.ExamScheduleCode, data);
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

                _exc = await _IExamScheduleService.GetByIDAsync(Code);

                tb_code.Text = _exc.ExamScheduleCode;
                tb_name.Text = _exc.NameSubject;
                dtp_year.Value = _exc.ExamTime;
                cb_status.Checked = (_exc.Status == 1);
            }
        }
    }
}
