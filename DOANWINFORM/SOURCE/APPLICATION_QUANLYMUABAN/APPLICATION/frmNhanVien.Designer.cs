namespace APPLICATION
{
    partial class frmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView_DSNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDThoai = new System.Windows.Forms.TextBox();
            this.chkGTinh = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(255, 53);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(289, 26);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnThem.Location = new System.Drawing.Point(189, 200);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 52);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView_DSNhanVien
            // 
            this.dataGridView_DSNhanVien.AllowUserToAddRows = false;
            this.dataGridView_DSNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_DSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column6,
            this.Column5,
            this.Column4,
            this.Column8});
            this.dataGridView_DSNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView_DSNhanVien.Location = new System.Drawing.Point(55, 293);
            this.dataGridView_DSNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_DSNhanVien.MultiSelect = false;
            this.dataGridView_DSNhanVien.Name = "dataGridView_DSNhanVien";
            this.dataGridView_DSNhanVien.ReadOnly = true;
            this.dataGridView_DSNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_DSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DSNhanVien.ShowEditingIcon = false;
            this.dataGridView_DSNhanVien.Size = new System.Drawing.Size(1035, 239);
            this.dataGridView_DSNhanVien.TabIndex = 3;
            this.dataGridView_DSNhanVien.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_DSNhanVien_ColumnHeaderMouseClick);
            this.dataGridView_DSNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_DSNhanVien_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_NV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TEN_NV";
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PHAI";
            this.Column7.HeaderText = "Giới tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYSINH";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DIENTHOAI";
            this.Column5.HeaderText = "Điện thoại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DIACHI";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CHUCVU";
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(255, 101);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(289, 26);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(667, 44);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(314, 26);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Navy;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnXoa.Location = new System.Drawing.Point(497, 200);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 52);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnSua.Location = new System.Drawing.Point(650, 200);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 52);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.BackColor = System.Drawing.Color.Navy;
            this.btnThoát.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoát.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnThoát.Location = new System.Drawing.Point(822, 200);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(134, 52);
            this.btnThoát.TabIndex = 2;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = false;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại";
            // 
            // txtDThoai
            // 
            this.txtDThoai.Location = new System.Drawing.Point(667, 92);
            this.txtDThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDThoai.Name = "txtDThoai";
            this.txtDThoai.Size = new System.Drawing.Size(191, 26);
            this.txtDThoai.TabIndex = 1;
            this.txtDThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDThoai_KeyPress);
            // 
            // chkGTinh
            // 
            this.chkGTinh.AutoSize = true;
            this.chkGTinh.Location = new System.Drawing.Point(194, 153);
            this.chkGTinh.Margin = new System.Windows.Forms.Padding(4);
            this.chkGTinh.Name = "chkGTinh";
            this.chkGTinh.Size = new System.Drawing.Size(61, 22);
            this.chkGTinh.TabIndex = 4;
            this.chkGTinh.Text = "Nam";
            this.chkGTinh.UseVisualStyleBackColor = true;
            this.chkGTinh.CheckedChanged += new System.EventHandler(this.chkGTinh_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 36);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LawnGreen;
            this.label8.Location = new System.Drawing.Point(477, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(1108, 1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(38, 34);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chức vụ";
            // 
            // cbbCV
            // 
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Items.AddRange(new object[] {
            "NHÂN VIÊN",
            "THỦ KHO"});
            this.cbbCV.Location = new System.Drawing.Point(357, 149);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(187, 26);
            this.cbbCV.TabIndex = 6;
            // 
            // dateTimePicker1Ngaysinh
            // 
            this.dateTimePicker1Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1Ngaysinh.Location = new System.Drawing.Point(667, 140);
            this.dateTimePicker1Ngaysinh.MaxDate = new System.DateTime(2999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1Ngaysinh.Name = "dateTimePicker1Ngaysinh";
            this.dateTimePicker1Ngaysinh.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1Ngaysinh.TabIndex = 7;
            this.dateTimePicker1Ngaysinh.Value = new System.DateTime(2016, 11, 7, 0, 15, 36, 0);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnLuu.Location = new System.Drawing.Point(343, 200);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(134, 52);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(55, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 15);
            this.panel2.TabIndex = 8;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(357, 150);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(187, 26);
            this.txtCV.TabIndex = 9;
            this.txtCV.Text = "GIÁM ĐỐC";
            this.txtCV.Visible = false;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 576);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1Ngaysinh);
            this.Controls.Add(this.cbbCV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkGTinh);
            this.Controls.Add(this.dataGridView_DSNhanVien);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDThoai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 99);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView_DSNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDThoai;
        private System.Windows.Forms.CheckBox chkGTinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCV;
    }
}