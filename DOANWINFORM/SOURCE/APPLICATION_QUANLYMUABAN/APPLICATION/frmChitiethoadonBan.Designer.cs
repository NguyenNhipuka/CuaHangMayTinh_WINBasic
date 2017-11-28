namespace APPLICATION
{
    partial class frmChitiethoadonBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongtien_M = new System.Windows.Forms.TextBox();
            this.dataGridView2ChiTietBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc_M = new System.Windows.Forms.Button();
            this.btnHienall_B = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2ChiTietBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongtien_M);
            this.groupBox1.Controls.Add(this.dataGridView2ChiTietBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 356);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các thiết bị trong hóa đơn";
            // 
            // txtTongtien_M
            // 
            this.txtTongtien_M.Enabled = false;
            this.txtTongtien_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongtien_M.Location = new System.Drawing.Point(219, 280);
            this.txtTongtien_M.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien_M.Name = "txtTongtien_M";
            this.txtTongtien_M.Size = new System.Drawing.Size(214, 27);
            this.txtTongtien_M.TabIndex = 13;
            this.txtTongtien_M.Text = "0";
            // 
            // dataGridView2ChiTietBan
            // 
            this.dataGridView2ChiTietBan.AllowUserToAddRows = false;
            this.dataGridView2ChiTietBan.AllowUserToDeleteRows = false;
            this.dataGridView2ChiTietBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2ChiTietBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2ChiTietBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2ChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2ChiTietBan.GridColor = System.Drawing.Color.Navy;
            this.dataGridView2ChiTietBan.Location = new System.Drawing.Point(22, 27);
            this.dataGridView2ChiTietBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2ChiTietBan.Name = "dataGridView2ChiTietBan";
            this.dataGridView2ChiTietBan.ReadOnly = true;
            this.dataGridView2ChiTietBan.RowHeadersVisible = false;
            this.dataGridView2ChiTietBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2ChiTietBan.Size = new System.Drawing.Size(999, 233);
            this.dataGridView2ChiTietBan.TabIndex = 10;
            this.dataGridView2ChiTietBan.DataSourceChanged += new System.EventHandler(this.dataGridView2ChiTietBan_DataSourceChanged);
            this.dataGridView2ChiTietBan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2ChiTietBan_ColumnHeaderMouseClick);
            this.dataGridView2ChiTietBan.Click += new System.EventHandler(this.dataGridView2ChiTietBan_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_TB";
            this.Column2.HeaderText = "Mã thiết bị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TEN_TB";
            this.Column3.HeaderText = "Tên thiết bị";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LOAI";
            this.Column4.HeaderText = "Loại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NSX";
            this.Column5.HeaderText = "NSX";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SOLUONG";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DONGIA";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "THANHTIEN";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MA_HDB";
            this.Column9.HeaderText = "MA_hd";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng tiền của hóa đơn";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaHDB.Location = new System.Drawing.Point(313, 81);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(301, 27);
            this.txtMaHDB.TabIndex = 13;
            this.txtMaHDB.TextChanged += new System.EventHandler(this.txtMaHDB_TextChanged);
            this.txtMaHDB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHDB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã hóa đơn bán đã lập";
            // 
            // btnLoc_M
            // 
            this.btnLoc_M.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLoc_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoc_M.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnLoc_M.Location = new System.Drawing.Point(679, 67);
            this.btnLoc_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc_M.Name = "btnLoc_M";
            this.btnLoc_M.Size = new System.Drawing.Size(109, 58);
            this.btnLoc_M.TabIndex = 14;
            this.btnLoc_M.Text = "Lọc";
            this.btnLoc_M.UseVisualStyleBackColor = false;
            this.btnLoc_M.Click += new System.EventHandler(this.btnLoc_B_Click);
            // 
            // btnHienall_B
            // 
            this.btnHienall_B.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHienall_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienall_B.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienall_B.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnHienall_B.Location = new System.Drawing.Point(828, 65);
            this.btnHienall_B.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienall_B.Name = "btnHienall_B";
            this.btnHienall_B.Size = new System.Drawing.Size(107, 62);
            this.btnHienall_B.TabIndex = 14;
            this.btnHienall_B.Text = "Hiện tất cả";
            this.btnHienall_B.UseVisualStyleBackColor = false;
            this.btnHienall_B.Click += new System.EventHandler(this.btnHienall_B_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 36);
            this.panel1.TabIndex = 17;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1119, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(33, 35);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(507, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN ĐÃ BÁN";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnIn.Location = new System.Drawing.Point(965, 65);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(138, 62);
            this.btnIn.TabIndex = 25;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmChitiethoadonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 576);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHienall_B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoc_M);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 99);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitiethoadonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chi tiết hóa đơn bán";
            this.Load += new System.EventHandler(this.frmChitiethoadonBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2ChiTietBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.TextBox txtTongtien_M;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2ChiTietBan;
        private System.Windows.Forms.Button btnLoc_M;
        private System.Windows.Forms.Button btnHienall_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnIn;
    }
}