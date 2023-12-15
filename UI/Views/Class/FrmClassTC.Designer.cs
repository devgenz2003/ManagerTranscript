namespace UI.Views.Class
{
    partial class FrmClassTC
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
            btn_data = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            dtg_data = new DataGridView();
            groupBox2 = new GroupBox();
            label6 = new Label();
            cbb_ses = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            cb_status = new CheckBox();
            tb_quantity = new TextBox();
            cbb_codeteacher = new ComboBox();
            cbb_codesubject = new ComboBox();
            tb_name = new TextBox();
            tb_code = new TextBox();
            label8 = new Label();
            btn_stc = new Button();
            btn_teacher = new Button();
            label9 = new Label();
            cbb_sescheck = new ComboBox();
            cbb_classtc = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 257);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_data
            // 
            btn_data.Location = new Point(6, 178);
            btn_data.Name = "btn_data";
            btn_data.Size = new Size(238, 29);
            btn_data.TabIndex = 19;
            btn_data.Text = "Danh sách";
            btn_data.UseVisualStyleBackColor = true;
            btn_data.Click += btn_data_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(6, 132);
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
            btn_update.Location = new Point(6, 85);
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
            dtg_data.Location = new Point(6, 467);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(776, 187);
            dtg_data.TabIndex = 24;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbb_ses);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cb_status);
            groupBox2.Controls.Add(tb_quantity);
            groupBox2.Controls.Add(cbb_codeteacher);
            groupBox2.Controls.Add(cbb_codesubject);
            groupBox2.Controls.Add(tb_name);
            groupBox2.Controls.Add(tb_code);
            groupBox2.Location = new Point(12, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 338);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 116);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 40;
            label6.Text = "Học kì";
            // 
            // cbb_ses
            // 
            cbb_ses.FormattingEnabled = true;
            cbb_ses.Location = new Point(148, 108);
            cbb_ses.Name = "cbb_ses";
            cbb_ses.Size = new Size(353, 28);
            cbb_ses.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 259);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 38;
            label5.Text = "Sĩ số";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 211);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 37;
            label4.Text = "Mã giảng viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 162);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 36;
            label3.Text = "Mã môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 35;
            label2.Text = "Tên lớp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 34;
            label1.Text = "Mã lớp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 304);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 33;
            label7.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(151, 300);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 32;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(151, 252);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(350, 27);
            tb_quantity.TabIndex = 31;
            // 
            // cbb_codeteacher
            // 
            cbb_codeteacher.FormattingEnabled = true;
            cbb_codeteacher.Location = new Point(148, 203);
            cbb_codeteacher.Name = "cbb_codeteacher";
            cbb_codeteacher.Size = new Size(353, 28);
            cbb_codeteacher.TabIndex = 30;
            // 
            // cbb_codesubject
            // 
            cbb_codesubject.FormattingEnabled = true;
            cbb_codesubject.Location = new Point(148, 154);
            cbb_codesubject.Name = "cbb_codesubject";
            cbb_codesubject.Size = new Size(353, 28);
            cbb_codesubject.TabIndex = 29;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(148, 70);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(353, 27);
            tb_name.TabIndex = 28;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(148, 22);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(353, 27);
            tb_code.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 375);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 41;
            label8.Text = "Mã học kì";
            // 
            // btn_stc
            // 
            btn_stc.Location = new Point(538, 372);
            btn_stc.Name = "btn_stc";
            btn_stc.Size = new Size(250, 29);
            btn_stc.TabIndex = 42;
            btn_stc.Text = "Số tín";
            btn_stc.UseVisualStyleBackColor = true;
            btn_stc.Click += btn_stc_Click;
            // 
            // btn_teacher
            // 
            btn_teacher.Location = new Point(538, 415);
            btn_teacher.Name = "btn_teacher";
            btn_teacher.Size = new Size(250, 29);
            btn_teacher.TabIndex = 44;
            btn_teacher.Text = "Tìm giảng viên";
            btn_teacher.UseVisualStyleBackColor = true;
            btn_teacher.Click += btn_teacher_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 423);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 45;
            label9.Text = "Mã lớp";
            // 
            // cbb_sescheck
            // 
            cbb_sescheck.FormattingEnabled = true;
            cbb_sescheck.Location = new Point(141, 373);
            cbb_sescheck.Name = "cbb_sescheck";
            cbb_sescheck.Size = new Size(372, 28);
            cbb_sescheck.TabIndex = 46;
            // 
            // cbb_classtc
            // 
            cbb_classtc.FormattingEnabled = true;
            cbb_classtc.Location = new Point(141, 415);
            cbb_classtc.Name = "cbb_classtc";
            cbb_classtc.Size = new Size(372, 28);
            cbb_classtc.TabIndex = 47;
            // 
            // FrmClassTC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 666);
            Controls.Add(cbb_classtc);
            Controls.Add(cbb_sescheck);
            Controls.Add(label9);
            Controls.Add(btn_teacher);
            Controls.Add(btn_stc);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(dtg_data);
            Controls.Add(groupBox1);
            Name = "FrmClassTC";
            Text = "FrmClassTC";
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
        private Label label6;
        private ComboBox cbb_ses;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private CheckBox cb_status;
        private TextBox tb_quantity;
        private ComboBox cbb_codeteacher;
        private ComboBox cbb_codesubject;
        private TextBox tb_name;
        private TextBox tb_code;
        private Label label8;
        private Button btn_stc;
        private Button btn_teacher;
        private Label label9;
        private ComboBox cbb_sescheck;
        private ComboBox cbb_classtc;
    }
}