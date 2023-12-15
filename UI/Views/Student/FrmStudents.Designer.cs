namespace UI.Views.Student
{
    partial class FrmStudents
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
            tb_name = new TextBox();
            tb_class = new TextBox();
            tb_hometown = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtp_birthday = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            cb_status = new CheckBox();
            label7 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox1 = new GroupBox();
            btn_data = new Button();
            dtg_data = new DataGridView();
            tb_gender = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // tb_code
            // 
            tb_code.Location = new Point(187, 54);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(350, 27);
            tb_code.TabIndex = 0;
            tb_code.TextChanged += tb_code_TextChanged;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(187, 105);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(494, 27);
            tb_name.TabIndex = 1;
            // 
            // tb_class
            // 
            tb_class.Location = new Point(187, 156);
            tb_class.Name = "tb_class";
            tb_class.Size = new Size(494, 27);
            tb_class.TabIndex = 2;
            // 
            // tb_hometown
            // 
            tb_hometown.Location = new Point(187, 207);
            tb_hometown.Name = "tb_hometown";
            tb_hometown.Size = new Size(494, 27);
            tb_hometown.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 112);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 7;
            label3.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 214);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Quê quán";
            // 
            // dtp_birthday
            // 
            dtp_birthday.Location = new Point(187, 300);
            dtp_birthday.Name = "dtp_birthday";
            dtp_birthday.Size = new Size(494, 27);
            dtp_birthday.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 264);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 307);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 13;
            label6.Text = "Năm sinh";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(187, 356);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 14;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 357);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 15;
            label7.Text = "Trạng thái";
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
            btn_update.Location = new Point(6, 81);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(238, 29);
            btn_update.TabIndex = 17;
            btn_update.Text = "Chỉnh sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(6, 124);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(238, 30);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Xoá";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(687, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 273);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_data
            // 
            btn_data.Location = new Point(6, 168);
            btn_data.Name = "btn_data";
            btn_data.Size = new Size(238, 29);
            btn_data.TabIndex = 19;
            btn_data.Text = "Danh sách";
            btn_data.UseVisualStyleBackColor = true;
            btn_data.Click += btn_data_Click;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(12, 402);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(919, 307);
            dtg_data.TabIndex = 19;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // tb_gender
            // 
            tb_gender.Location = new Point(187, 257);
            tb_gender.Name = "tb_gender";
            tb_gender.Size = new Size(494, 27);
            tb_gender.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 61);
            label8.Name = "label8";
            label8.Size = new Size(122, 20);
            label8.TabIndex = 21;
            label8.Text = "(có thể tìm kiếm)";
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 721);
            Controls.Add(label8);
            Controls.Add(tb_gender);
            Controls.Add(dtg_data);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(cb_status);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtp_birthday);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_hometown);
            Controls.Add(tb_class);
            Controls.Add(tb_name);
            Controls.Add(tb_code);
            Name = "FrmStudents";
            Text = "FrmStudents";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox cb_status;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dtp_birthday;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_code;
        private TextBox tb_name;
        private TextBox tb_class;
        private TextBox tb_hometown;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox1;
        private DataGridView dtg_data;
        private TextBox tb_gender;
        private Button btn_data;
        private Label label8;
    }
}