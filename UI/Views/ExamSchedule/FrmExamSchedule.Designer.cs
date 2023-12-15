namespace UI.Views.ExamSchedule
{
    partial class FrmExamSchedule
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
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cb_status = new CheckBox();
            dtp_year = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_code = new TextBox();
            tb_name = new TextBox();
            dtg_data = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 257);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cb_status);
            groupBox2.Controls.Add(dtp_year);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tb_code);
            groupBox2.Controls.Add(tb_name);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 257);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 198);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 35;
            label7.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(90, 198);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 34;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // dtp_year
            // 
            dtp_year.Location = new Point(90, 135);
            dtp_year.Name = "dtp_year";
            dtp_year.Size = new Size(424, 27);
            dtp_year.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 139);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 94);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên kì thi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã kì thi";
            // 
            // tb_code
            // 
            tb_code.Location = new Point(90, 85);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(424, 27);
            tb_code.TabIndex = 2;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(90, 38);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(424, 27);
            tb_name.TabIndex = 0;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(18, 286);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(764, 152);
            dtg_data.TabIndex = 26;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // FrmExamSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtg_data);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmExamSchedule";
            Text = "FrmExamSchedule";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private GroupBox groupBox2;
        private DateTimePicker dtp_year;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_code;
        private TextBox tb_name;
        private Label label7;
        private CheckBox cb_status;
        private DataGridView dtg_data;
    }
}