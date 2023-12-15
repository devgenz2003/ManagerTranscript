namespace UI.Views.Semester
{
    partial class FrmSemester
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
            groupBox2 = new GroupBox();
            label4 = new Label();
            rd_check = new CheckBox();
            dtp_date = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_name = new TextBox();
            tb_code = new TextBox();
            dtg_data = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 273);
            groupBox1.TabIndex = 20;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(rd_check);
            groupBox2.Controls.Add(dtp_date);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tb_name);
            groupBox2.Controls.Add(tb_code);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 219);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 42);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "(Có thể tìm kiếm)";
            // 
            // rd_check
            // 
            rd_check.AutoSize = true;
            rd_check.Location = new Point(109, 188);
            rd_check.Name = "rd_check";
            rd_check.Size = new Size(103, 24);
            rd_check.TabIndex = 7;
            rd_check.Text = "Hoạt động";
            rd_check.UseVisualStyleBackColor = true;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(109, 138);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(396, 27);
            dtp_date.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Năm học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên học kì";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã học kì";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(109, 88);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(396, 27);
            tb_name.TabIndex = 2;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(109, 38);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(260, 27);
            tb_code.TabIndex = 0;
            tb_code.TextChanged += tb_code_TextChanged;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(12, 291);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(776, 260);
            dtg_data.TabIndex = 22;
            // 
            // FrmSemester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(dtg_data);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSemester";
            Text = "Semester";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private GroupBox groupBox2;
        private CheckBox rd_check;
        private DateTimePicker dtp_date;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_code;
        private DataGridView dtg_data;
        private Label label4;
    }
}