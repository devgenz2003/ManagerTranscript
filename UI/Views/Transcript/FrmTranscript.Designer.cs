namespace UI.Views.Transcript
{
    partial class FrmTranscript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_avg = new Button();
            btn_data = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            dtg_data = new DataGridView();
            groupBox2 = new GroupBox();
            label10 = new Label();
            cb_status = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbb_examcode = new ComboBox();
            cbb_classcode = new ComboBox();
            cbb_subjectcode = new ComboBox();
            cbb_studentcode = new ComboBox();
            tb_testscore = new TextBox();
            tb_conditionpoint = new TextBox();
            tb_attendance = new TextBox();
            tb_credits = new TextBox();
            tb_code = new TextBox();
            label11 = new Label();
            btn_pointmin = new Button();
            btn_transcript = new Button();
            label12 = new Label();
            cbb_subjectcodecheck = new ComboBox();
            cbb_studentcodecheck = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_avg);
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(663, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 420);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_avg
            // 
            btn_avg.Location = new Point(6, 233);
            btn_avg.Name = "btn_avg";
            btn_avg.Size = new Size(238, 29);
            btn_avg.TabIndex = 20;
            btn_avg.Text = "Điểm trung bình";
            btn_avg.UseVisualStyleBackColor = true;
            btn_avg.Click += btn_avg_Click;
            // 
            // btn_data
            // 
            btn_data.Location = new Point(6, 183);
            btn_data.Name = "btn_data";
            btn_data.Size = new Size(238, 29);
            btn_data.TabIndex = 19;
            btn_data.Text = "Danh sách học lại";
            btn_data.UseVisualStyleBackColor = true;
            btn_data.Click += btn_data_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(6, 134);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(238, 30);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Xoá";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(6, 38);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(238, 29);
            btn_add.TabIndex = 16;
            btn_add.Text = "Tạo mới";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(6, 86);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(238, 29);
            btn_update.TabIndex = 17;
            btn_update.Text = "Chỉnh sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(12, 543);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(901, 188);
            dtg_data.TabIndex = 32;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cb_status);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbb_examcode);
            groupBox2.Controls.Add(cbb_classcode);
            groupBox2.Controls.Add(cbb_subjectcode);
            groupBox2.Controls.Add(cbb_studentcode);
            groupBox2.Controls.Add(tb_testscore);
            groupBox2.Controls.Add(tb_conditionpoint);
            groupBox2.Controls.Add(tb_attendance);
            groupBox2.Controls.Add(tb_credits);
            groupBox2.Controls.Add(tb_code);
            groupBox2.Location = new Point(6, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(651, 441);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 398);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 51;
            label10.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(145, 397);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(58, 24);
            cb_status.TabIndex = 50;
            cb_status.Text = "Đậu";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 353);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 49;
            label9.Text = "Điểm thi ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 313);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 48;
            label8.Text = "Điểm điều kiện";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 193);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 47;
            label7.Text = "Mã môn học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 46;
            label6.Text = "Điểm chuyên cần";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 45;
            label5.Text = "Mã lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 44;
            label4.Text = "Mã bài thi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 43;
            label3.Text = "Số tín chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 42;
            label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 41;
            label1.Text = "Mã bảng điểm";
            // 
            // cbb_examcode
            // 
            cbb_examcode.FormattingEnabled = true;
            cbb_examcode.Location = new Point(145, 107);
            cbb_examcode.Name = "cbb_examcode";
            cbb_examcode.Size = new Size(474, 28);
            cbb_examcode.TabIndex = 40;
            // 
            // cbb_classcode
            // 
            cbb_classcode.FormattingEnabled = true;
            cbb_classcode.Location = new Point(145, 148);
            cbb_classcode.Name = "cbb_classcode";
            cbb_classcode.Size = new Size(474, 28);
            cbb_classcode.TabIndex = 39;
            // 
            // cbb_subjectcode
            // 
            cbb_subjectcode.FormattingEnabled = true;
            cbb_subjectcode.Location = new Point(145, 189);
            cbb_subjectcode.Name = "cbb_subjectcode";
            cbb_subjectcode.Size = new Size(474, 28);
            cbb_subjectcode.TabIndex = 38;
            // 
            // cbb_studentcode
            // 
            cbb_studentcode.FormattingEnabled = true;
            cbb_studentcode.Location = new Point(145, 66);
            cbb_studentcode.Name = "cbb_studentcode";
            cbb_studentcode.Size = new Size(474, 28);
            cbb_studentcode.TabIndex = 37;
            // 
            // tb_testscore
            // 
            tb_testscore.Location = new Point(145, 350);
            tb_testscore.Name = "tb_testscore";
            tb_testscore.Size = new Size(474, 27);
            tb_testscore.TabIndex = 36;
            // 
            // tb_conditionpoint
            // 
            tb_conditionpoint.Location = new Point(145, 310);
            tb_conditionpoint.Name = "tb_conditionpoint";
            tb_conditionpoint.Size = new Size(474, 27);
            tb_conditionpoint.TabIndex = 35;
            // 
            // tb_attendance
            // 
            tb_attendance.Location = new Point(145, 270);
            tb_attendance.Name = "tb_attendance";
            tb_attendance.Size = new Size(474, 27);
            tb_attendance.TabIndex = 34;
            // 
            // tb_credits
            // 
            tb_credits.Location = new Point(145, 230);
            tb_credits.Name = "tb_credits";
            tb_credits.Size = new Size(474, 27);
            tb_credits.TabIndex = 33;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(145, 26);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(474, 27);
            tb_code.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 466);
            label11.Name = "label11";
            label11.Size = new Size(132, 20);
            label11.TabIndex = 52;
            label11.Text = "Nhập mã môn học";
            // 
            // btn_pointmin
            // 
            btn_pointmin.Location = new Point(663, 462);
            btn_pointmin.Name = "btn_pointmin";
            btn_pointmin.Size = new Size(244, 29);
            btn_pointmin.TabIndex = 21;
            btn_pointmin.Text = "Điểm thấp nhất";
            btn_pointmin.UseVisualStyleBackColor = true;
            btn_pointmin.Click += btn_pointmin_Click;
            // 
            // btn_transcript
            // 
            btn_transcript.Location = new Point(663, 496);
            btn_transcript.Name = "btn_transcript";
            btn_transcript.Size = new Size(244, 29);
            btn_transcript.TabIndex = 54;
            btn_transcript.Text = "Bảng điểm";
            btn_transcript.UseVisualStyleBackColor = true;
            btn_transcript.Click += btn_transcript_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 504);
            label12.Name = "label12";
            label12.Size = new Size(131, 20);
            label12.TabIndex = 55;
            label12.Text = "Nhập mã sinh viên";
            // 
            // cbb_subjectcodecheck
            // 
            cbb_subjectcodecheck.FormattingEnabled = true;
            cbb_subjectcodecheck.Location = new Point(151, 458);
            cbb_subjectcodecheck.Name = "cbb_subjectcodecheck";
            cbb_subjectcodecheck.Size = new Size(506, 28);
            cbb_subjectcodecheck.TabIndex = 56;
            // 
            // cbb_studentcodecheck
            // 
            cbb_studentcodecheck.FormattingEnabled = true;
            cbb_studentcodecheck.Location = new Point(151, 497);
            cbb_studentcodecheck.Name = "cbb_studentcodecheck";
            cbb_studentcodecheck.Size = new Size(506, 28);
            cbb_studentcodecheck.TabIndex = 57;
            // 
            // FrmTranscript
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 743);
            Controls.Add(cbb_studentcodecheck);
            Controls.Add(cbb_subjectcodecheck);
            Controls.Add(label12);
            Controls.Add(btn_transcript);
            Controls.Add(btn_pointmin);
            Controls.Add(label11);
            Controls.Add(groupBox2);
            Controls.Add(dtg_data);
            Controls.Add(groupBox1);
            Name = "FrmTranscript";
            Text = "FrmTranscript";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private DataGridView dtg_data;
        private GroupBox groupBox2;
        private Label label10;
        private CheckBox cb_status;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_examcode;
        private ComboBox cbb_classcode;
        private ComboBox cbb_subjectcode;
        private ComboBox cbb_studentcode;
        private TextBox tb_testscore;
        private TextBox tb_conditionpoint;
        private TextBox tb_attendance;
        private TextBox tb_credits;
        private TextBox tb_code;
        private Label label11;
        private Button btn_avg;
        private Button btn_pointmin;
        private Button btn_transcript;
        private Label label12;
        private ComboBox cbb_subjectcodecheck;
        private ComboBox cbb_studentcodecheck;
    }
}