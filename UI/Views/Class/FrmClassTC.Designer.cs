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
            tb_code = new TextBox();
            tb_name = new TextBox();
            cbb_codesubject = new ComboBox();
            cbb_codeteacher = new ComboBox();
            tb_quantity = new TextBox();
            label7 = new Label();
            cb_status = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btn_data = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            dtg_data = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // tb_code
            // 
            tb_code.Location = new Point(158, 37);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(353, 27);
            tb_code.TabIndex = 0;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(158, 85);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(353, 27);
            tb_name.TabIndex = 1;
            // 
            // cbb_codesubject
            // 
            cbb_codesubject.FormattingEnabled = true;
            cbb_codesubject.Location = new Point(158, 133);
            cbb_codesubject.Name = "cbb_codesubject";
            cbb_codesubject.Size = new Size(353, 28);
            cbb_codesubject.TabIndex = 2;
            // 
            // cbb_codeteacher
            // 
            cbb_codeteacher.FormattingEnabled = true;
            cbb_codeteacher.Location = new Point(158, 182);
            cbb_codeteacher.Name = "cbb_codeteacher";
            cbb_codeteacher.Size = new Size(353, 28);
            cbb_codeteacher.TabIndex = 3;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(161, 231);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(350, 27);
            tb_quantity.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 283);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 17;
            label7.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(161, 279);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 16;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 18;
            label1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 92);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 19;
            label2.Text = "Tên lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 141);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 20;
            label3.Text = "Mã môn học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 190);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 21;
            label4.Text = "Mã giảng viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 238);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 22;
            label5.Text = "Sĩ số";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 273);
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
            dtg_data.Location = new Point(12, 316);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(776, 247);
            dtg_data.TabIndex = 24;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // FrmClassTC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(dtg_data);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(cb_status);
            Controls.Add(tb_quantity);
            Controls.Add(cbb_codeteacher);
            Controls.Add(cbb_codesubject);
            Controls.Add(tb_name);
            Controls.Add(tb_code);
            Name = "FrmClassTC";
            Text = "FrmClassTC";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_code;
        private TextBox tb_name;
        private ComboBox cbb_codesubject;
        private ComboBox cbb_codeteacher;
        private TextBox tb_quantity;
        private Label label7;
        private CheckBox cb_status;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private DataGridView dtg_data;
    }
}