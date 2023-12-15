namespace UI.Views.Subject
{
    partial class FrmSubject
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_name = new TextBox();
            tb_credits = new TextBox();
            tb_code = new TextBox();
            label7 = new Label();
            cb_status = new CheckBox();
            dtg_data = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_data);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Location = new Point(538, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 215);
            groupBox1.TabIndex = 36;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 34;
            label3.Text = "Tên môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 33;
            label2.Text = "Số tín chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 32;
            label1.Text = "Mã môn";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(155, 94);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(348, 27);
            tb_name.TabIndex = 30;
            // 
            // tb_credits
            // 
            tb_credits.Location = new Point(155, 153);
            tb_credits.Name = "tb_credits";
            tb_credits.Size = new Size(348, 27);
            tb_credits.TabIndex = 29;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(155, 35);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(348, 27);
            tb_code.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 211);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 39;
            label7.Text = "Trạng thái";
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(155, 207);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(103, 24);
            cb_status.TabIndex = 38;
            cb_status.Text = "Hoạt động";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(12, 261);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(776, 207);
            dtg_data.TabIndex = 37;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // FrmSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Controls.Add(tb_credits);
            Controls.Add(tb_code);
            Controls.Add(label7);
            Controls.Add(cb_status);
            Controls.Add(dtg_data);
            Name = "FrmSubject";
            Text = "FrmSubject.cs";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_data;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_email;
        private TextBox tb_name;
        private TextBox tb_credits;
        private TextBox tb_code;
        private Label label7;
        private CheckBox cb_status;
        private DataGridView dtg_data;
    }
}