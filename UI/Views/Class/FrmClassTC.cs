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
        private string Code { get; set; }
        private ClassTCVM _cltc;
        public FrmClassTC()
        {
            InitializeComponent();
            _IClassTCService = new ClassTCService();
            _ISubjectService = new SubjectService();
            _ITeacherService = new TeacherService();
            LoadSubject();
            LoadTeacher();
        }
        private async void LoadData()
        {
            dtg_data.ColumnCount = 6;
            dtg_data.Columns[0].Name = "Mã";
            dtg_data.Columns[1].Name = "Tên lớp";
            dtg_data.Columns[2].Name = "Mã môn học";
            dtg_data.Columns[3].Name = "Mã giảng viên";
            dtg_data.Columns[4].Name = "Số lượng";
            dtg_data.Columns[5].Name = "Trạng thái";
            dtg_data.Rows.Clear();
            var data = await _IClassTCService.GetAllAsync();
            foreach (var load in data)
            {
                dtg_data.Rows
                    .Add(load.ClassCode,
                    load.ClassName,
                    load.CodeSubject,
                    load.TeacherCode,
                    load.QuantityStudent,
                    load.Status == 1 ? "Còn" : "Ngưng"
                    );
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
        private async void LoadSubject()
        {
            foreach (var data in await _ISubjectService.GetAllAsync())
            {
                cbb_codesubject.Items.Add(data.SubjectCode);
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
    }
}
