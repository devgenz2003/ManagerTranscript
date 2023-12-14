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
            tb_code = new TextBox();
            tb_credits = new TextBox();
            tb_attendance = new TextBox();
            tb_conditionpoint = new TextBox();
            tb_testscore = new TextBox();
            cbb_studentcode = new ComboBox();
            cbb_subjectcode = new ComboBox();
            cbb_classcode = new ComboBox();
            cbb_examcode = new ComboBox();
            groupBox1 = new GroupBox();
            btn_data = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cb_status = new CheckBox();
            dtg_data = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // tb_code
            // 
            tb_code.Location = new Point(174, 33);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(474, 27);
            tb_code.TabIndex = 0;
            // 
            // tb_credits
            // 
            tb_credits.Location = new Point(174, 237);
            tb_credits.Name = "tb_credits";
            tb_credits.Size = new Size(474, 27);
            tb_credits.TabIndex = 1;
            // 
            // tb_attendance
            // 
            tb_attendance.Location = new Point(174, 277);
            tb_attendance.Name = "tb_attendance";
            tb_attendance.Size = new Size(474, 27);
            tb_attendance.TabIndex = 2;
            // 
            // tb_conditionpoint
            // 
            tb_conditionpoint.Location = new Point(174, 317);
            tb_conditionpoint.Name = "tb_conditionpoint";
            tb_conditionpoint.Size = new Size(474, 27);
            tb_conditionpoint.TabIndex = 3;
            // 
            // tb_testscore
            // 
            tb_testscore.Location = new Point(174, 357);
            tb_testscore.Name = "tb_testscore";
            tb_testscore.Size = new Size(474, 27);
            tb_testscore.TabIndex = 4;
            // 
            // cbb_studentcode
            // 
            cbb_studentcode.FormattingEnabled = true;
            cbb_studentcode.Location = new Point(174, 73);
            cbb_studentcode.Name = "cbb_studentcode";
            cbb_studentcode.Size = new Size(474, 28);
            cbb_studentcode.TabIndex = 5;
            // 
            // cbb_subjectcode
            // 
            cbb_subjectcode.FormattingEnabled = true;
            cbb_subjectcode.Location = new Point(174, 196);
            cbb_subjectcode.Name = "cbb_subjectcode";
            cbb_subjectcode.Size = new Size(474, 28);
            cbb_subjectcode.TabIndex = 6;
            // 
            // cbb_classcode
            // 
            cbb_classcode.FormattingEnabled = true;
            cbb_classcode.Location = new Point(174, 155);
            cbb_classcode.Name = "cbb_classcode";
            cbb_classcode.Size = new Size(474, 28);
            cbb_classcode.TabIndex = 7;
            // 
            // cbb_examcode
            // 
            cbb_examcode.FormattingEnabled = true;
            cbb_examcode.Location = new Point(174, 114);
            cbb_examcode.Name = "cbb_examcode";
            cbb_examcode.Size = new Size(474, 28);
            cbb_examcode.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(663, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 231);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_data
            // 
            btn_data.Location = new Point(6, 183);
            btn_data.Name = "btn_data";
            btn_data.Size = new Size(238, 29);
            btn_data.TabIndex = 19;
            btn_data.Text = "Danh sách";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 21;
            label1.Text = "Mã bảng điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 22;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 240);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 23;
            label3.Text = "Số tín chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 120);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 24;
            label4.Text = "Mã bài thi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 160);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 25;
            label5.Text = "Mã lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 280);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 26;
            label6.Text = "Điểm chuyên cần";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 200);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 27;
            label7.Text = "Mã môn học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 320);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 28;
            label8.Text = "Điểm điều kiện";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 360);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 29;
            label9.Text = "Điểm thi ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 405);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 31;
            label10.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(174, 404);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(58, 24);
            cb_status.TabIndex = 30;
            cb_status.Text = "Đậu";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(12, 452);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(901, 279);
            dtg_data.TabIndex = 32;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // FrmTranscript
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 743);
            Controls.Add(dtg_data);
            Controls.Add(label10);
            Controls.Add(cb_status);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(cbb_examcode);
            Controls.Add(cbb_classcode);
            Controls.Add(cbb_subjectcode);
            Controls.Add(cbb_studentcode);
            Controls.Add(tb_testscore);
            Controls.Add(tb_conditionpoint);
            Controls.Add(tb_attendance);
            Controls.Add(tb_credits);
            Controls.Add(tb_code);
            Name = "FrmTranscript";
            Text = "FrmTranscript";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_code;
        private TextBox tb_credits;
        private TextBox tb_attendance;
        private TextBox tb_conditionpoint;
        private TextBox tb_testscore;
        private ComboBox cbb_studentcode;
        private ComboBox cbb_subjectcode;
        private ComboBox cbb_classcode;
        private ComboBox cbb_examcode;
        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox cb_status;
        private DataGridView dtg_data;
    }
}