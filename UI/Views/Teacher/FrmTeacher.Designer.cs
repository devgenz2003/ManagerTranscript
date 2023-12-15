namespace UI.Views.Teacher
{
    partial class FrmTeacher
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
            tb_phone = new TextBox();
            tb_name = new TextBox();
            tb_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btn_data = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            dtg_data = new DataGridView();
            label7 = new Label();
            cb_status = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // tb_code
            // 
            tb_code.Location = new Point(155, 58);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(348, 27);
            tb_code.TabIndex = 0;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(155, 176);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(348, 27);
            tb_phone.TabIndex = 1;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(155, 117);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(348, 27);
            tb_name.TabIndex = 2;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(155, 235);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(348, 27);
            tb_email.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 65);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã giảng viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 183);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên giảng viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 242);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 215);
            groupBox1.TabIndex = 24;
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
            dtg_data.Location = new Point(12, 325);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(776, 207);
            dtg_data.TabIndex = 25;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 290);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 27;
            label7.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(155, 286);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 26;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // FrmTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(label7);
            Controls.Add(cb_status);
            Controls.Add(dtg_data);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_email);
            Controls.Add(tb_name);
            Controls.Add(tb_phone);
            Controls.Add(tb_code);
            Name = "FrmTeacher";
            Text = "FrmTeacher";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_code;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private DataGridView dtg_data;
        private Label label7;
        private CheckBox cb_status;
    }
}