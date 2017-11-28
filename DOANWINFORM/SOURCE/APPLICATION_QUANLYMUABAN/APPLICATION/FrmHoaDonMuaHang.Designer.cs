namespace APPLICATION
{
    partial class FrmHoaDonMuaHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.txtDonGiaMua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemTenTB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongHD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbMaNVHDMH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemHDMH = new System.Windows.Forms.Button();
            this.btnSuaHDMH = new System.Windows.Forms.Button();
            this.btnXoaHDMH = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCapNhatGia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDGban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaTB = new System.Windows.Forms.ComboBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTGBH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 38);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.Location = new System.Drawing.Point(1116, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 32);
            this.button8.TabIndex = 4;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(483, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn mua hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // txbMaHD
            // 
            this.txbMaHD.Enabled = false;
            this.txbMaHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMaHD.Location = new System.Drawing.Point(117, 46);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(176, 27);
            this.txbMaHD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(323, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên NCC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(323, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Lập";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.Lime;
            this.btnThemNCC.Location = new System.Drawing.Point(938, 44);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(83, 43);
            this.btnThemNCC.TabIndex = 14;
            this.btnThemNCC.Text = "Thêm Nhà Cung Cấp";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTenNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(416, 46);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(504, 27);
            this.cbbTenNCC.TabIndex = 15;
            this.cbbTenNCC.SelectedValueChanged += new System.EventHandler(this.cbbTenNCC_SelectedValueChanged);
            // 
            // txtDonGiaMua
            // 
            this.txtDonGiaMua.BackColor = System.Drawing.Color.Aqua;
            this.txtDonGiaMua.Enabled = false;
            this.txtDonGiaMua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGiaMua.Location = new System.Drawing.Point(493, 50);
            this.txtDonGiaMua.Name = "txtDonGiaMua";
            this.txtDonGiaMua.Size = new System.Drawing.Size(161, 27);
            this.txtDonGiaMua.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(400, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Đơn giá mua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tên Thiết Bị";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(493, 10);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(68, 27);
            this.txtSoLuong.TabIndex = 24;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(400, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Số lượng";
            // 
            // btnThemTenTB
            // 
            this.btnThemTenTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnThemTenTB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemTenTB.ForeColor = System.Drawing.Color.Lime;
            this.btnThemTenTB.Location = new System.Drawing.Point(253, 15);
            this.btnThemTenTB.Name = "btnThemTenTB";
            this.btnThemTenTB.Size = new System.Drawing.Size(88, 42);
            this.btnThemTenTB.TabIndex = 25;
            this.btnThemTenTB.Text = "Thêm mã TB";
            this.btnThemTenTB.UseVisualStyleBackColor = false;
            this.btnThemTenTB.Click += new System.EventHandler(this.btnThemTenTB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(45, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 255);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn mua hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(26, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 229);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thiết bị";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên thiết bị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TGBH (Tháng)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn giá mua (VNĐ)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá bán (VNĐ)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Thành tiền (VNĐ)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtTongHD
            // 
            this.txtTongHD.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtTongHD.Location = new System.Drawing.Point(925, 517);
            this.txtTongHD.Name = "txtTongHD";
            this.txtTongHD.Size = new System.Drawing.Size(207, 30);
            this.txtTongHD.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(682, 522);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tổng trị giá hóa đơn (VNĐ)";
            // 
            // txbMaNVHDMH
            // 
            this.txbMaNVHDMH.Location = new System.Drawing.Point(134, 527);
            this.txbMaNVHDMH.Name = "txbMaNVHDMH";
            this.txbMaNVHDMH.Size = new System.Drawing.Size(131, 20);
            this.txbMaNVHDMH.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(31, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Mã Nhân Viên";
            // 
            // btnThemHDMH
            // 
            this.btnThemHDMH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnThemHDMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemHDMH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemHDMH.ForeColor = System.Drawing.Color.Lime;
            this.btnThemHDMH.Location = new System.Drawing.Point(906, 106);
            this.btnThemHDMH.Name = "btnThemHDMH";
            this.btnThemHDMH.Size = new System.Drawing.Size(88, 61);
            this.btnThemHDMH.TabIndex = 27;
            this.btnThemHDMH.Text = "Thêm";
            this.btnThemHDMH.UseVisualStyleBackColor = false;
            this.btnThemHDMH.Click += new System.EventHandler(this.btnThemHDMH_Click);
            // 
            // btnSuaHDMH
            // 
            this.btnSuaHDMH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSuaHDMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaHDMH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaHDMH.ForeColor = System.Drawing.Color.Lime;
            this.btnSuaHDMH.Location = new System.Drawing.Point(906, 173);
            this.btnSuaHDMH.Name = "btnSuaHDMH";
            this.btnSuaHDMH.Size = new System.Drawing.Size(88, 61);
            this.btnSuaHDMH.TabIndex = 29;
            this.btnSuaHDMH.Text = "Sửa";
            this.btnSuaHDMH.UseVisualStyleBackColor = false;
            this.btnSuaHDMH.Click += new System.EventHandler(this.btnSuaHDMH_Click);
            // 
            // btnXoaHDMH
            // 
            this.btnXoaHDMH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnXoaHDMH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaHDMH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHDMH.ForeColor = System.Drawing.Color.Lime;
            this.btnXoaHDMH.Location = new System.Drawing.Point(1010, 173);
            this.btnXoaHDMH.Name = "btnXoaHDMH";
            this.btnXoaHDMH.Size = new System.Drawing.Size(88, 61);
            this.btnXoaHDMH.TabIndex = 30;
            this.btnXoaHDMH.Text = "Xóa";
            this.btnXoaHDMH.UseVisualStyleBackColor = false;
            this.btnXoaHDMH.Click += new System.EventHandler(this.btnXoaHDMH_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Lime;
            this.btnLuu.Location = new System.Drawing.Point(1010, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 60);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(416, 79);
            this.dateTimePicker1.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // btnCapNhatGia
            // 
            this.btnCapNhatGia.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCapNhatGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatGia.ForeColor = System.Drawing.Color.Lime;
            this.btnCapNhatGia.Location = new System.Drawing.Point(581, 13);
            this.btnCapNhatGia.Name = "btnCapNhatGia";
            this.btnCapNhatGia.Size = new System.Drawing.Size(101, 34);
            this.btnCapNhatGia.TabIndex = 25;
            this.btnCapNhatGia.Text = "Cập nhật giá";
            this.btnCapNhatGia.UseVisualStyleBackColor = false;
            this.btnCapNhatGia.Click += new System.EventHandler(this.btnCapNhatGia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(400, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Đơn giá bán";
            // 
            // txtDGban
            // 
            this.txtDGban.BackColor = System.Drawing.Color.Aqua;
            this.txtDGban.Enabled = false;
            this.txtDGban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDGban.Location = new System.Drawing.Point(493, 91);
            this.txtDGban.Name = "txtDGban";
            this.txtDGban.Size = new System.Drawing.Size(161, 27);
            this.txtDGban.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã thiết bị";
            // 
            // cbbMaTB
            // 
            this.cbbMaTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaTB.FormattingEnabled = true;
            this.cbbMaTB.ItemHeight = 19;
            this.cbbMaTB.Location = new System.Drawing.Point(100, 15);
            this.cbbMaTB.Name = "cbbMaTB";
            this.cbbMaTB.Size = new System.Drawing.Size(147, 27);
            this.cbbMaTB.TabIndex = 17;
            this.cbbMaTB.SelectedValueChanged += new System.EventHandler(this.cbbMaTB_SelectedValueChanged);
            // 
            // txtTenTB
            // 
            this.txtTenTB.BackColor = System.Drawing.Color.Aqua;
            this.txtTenTB.Enabled = false;
            this.txtTenTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTB.Location = new System.Drawing.Point(102, 60);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTenTB.Size = new System.Drawing.Size(292, 27);
            this.txtTenTB.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(16, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Loại TB";
            // 
            // txtLoai
            // 
            this.txtLoai.BackColor = System.Drawing.Color.Aqua;
            this.txtLoai.Enabled = false;
            this.txtLoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoai.Location = new System.Drawing.Point(100, 108);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(110, 27);
            this.txtLoai.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenTB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTGBH);
            this.groupBox2.Controls.Add(this.txtLoai);
            this.groupBox2.Controls.Add(this.cbbMaTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnThemTenTB);
            this.groupBox2.Controls.Add(this.txtDGban);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDonGiaMua);
            this.groupBox2.Controls.Add(this.btnCapNhatGia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(45, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 141);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(233, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "TG Bảo hành";
            // 
            // txtTGBH
            // 
            this.txtTGBH.BackColor = System.Drawing.Color.Aqua;
            this.txtTGBH.Enabled = false;
            this.txtTGBH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTGBH.Location = new System.Drawing.Point(329, 108);
            this.txtTGBH.Name = "txtTGBH";
            this.txtTGBH.Size = new System.Drawing.Size(68, 27);
            this.txtTGBH.TabIndex = 24;
            // 
            // FrmHoaDonMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTongHD);
            this.Controls.Add(this.txbMaNVHDMH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnXoaHDMH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaHDMH);
            this.Controls.Add(this.btnThemHDMH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTenNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 99);
            this.Name = "FrmHoaDonMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmHoaDonMuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.ComboBox cbbTenNCC;
        private System.Windows.Forms.TextBox txtDonGiaMua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemTenTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemHDMH;
        private System.Windows.Forms.Button btnSuaHDMH;
        private System.Windows.Forms.TextBox txtTongHD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbMaNVHDMH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXoaHDMH;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnCapNhatGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDGban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTGBH;
    }
}