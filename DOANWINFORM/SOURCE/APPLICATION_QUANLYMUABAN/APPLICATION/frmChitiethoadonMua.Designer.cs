namespace APPLICATION
{
    partial class frmChitiethoadonMua
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
            this.btthoat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1DSCHITIET_HDM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmahdM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienall_M = new System.Windows.Forms.Button();
            this.btnLoc_M = new System.Windows.Forms.Button();
            this.txtTongtien_M = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DSCHITIET_HDM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 50);
            this.panel1.TabIndex = 18;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthoat.Location = new System.Drawing.Point(1128, 12);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(33, 35);
            this.btthoat.TabIndex = 11;
            this.btthoat.Text = "X";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1678, 1);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 48);
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
            this.label2.Location = new System.Drawing.Point(383, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN NHẬP THIẾT BỊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1DSCHITIET_HDM);
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1106, 355);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các thiết bị trong hóa đơn";
            // 
            // dataGridView1DSCHITIET_HDM
            // 
            this.dataGridView1DSCHITIET_HDM.AllowUserToAddRows = false;
            this.dataGridView1DSCHITIET_HDM.AllowUserToDeleteRows = false;
            this.dataGridView1DSCHITIET_HDM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1DSCHITIET_HDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1DSCHITIET_HDM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1DSCHITIET_HDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1DSCHITIET_HDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8});
            this.dataGridView1DSCHITIET_HDM.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1DSCHITIET_HDM.Location = new System.Drawing.Point(27, 51);
            this.dataGridView1DSCHITIET_HDM.MultiSelect = false;
            this.dataGridView1DSCHITIET_HDM.Name = "dataGridView1DSCHITIET_HDM";
            this.dataGridView1DSCHITIET_HDM.ReadOnly = true;
            this.dataGridView1DSCHITIET_HDM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1DSCHITIET_HDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1DSCHITIET_HDM.Size = new System.Drawing.Size(1060, 264);
            this.dataGridView1DSCHITIET_HDM.TabIndex = 21;
            this.dataGridView1DSCHITIET_HDM.DataSourceChanged += new System.EventHandler(this.dataGridView1DSCHITIET_HDM_DataSourceChanged);
            this.dataGridView1DSCHITIET_HDM.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1DSCHITIET_HDM_ColumnHeaderMouseClick);
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
            this.Column3.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LOAI";
            this.Column5.HeaderText = "Loại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NSX";
            this.Column4.HeaderText = "NSX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.Column7.DataPropertyName = "DONNGIA_MUA";
            this.Column7.HeaderText = "Đơn giá mua";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "THANHTIEN";
            this.Column10.HeaderText = "Thành tiền";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MA_HDM";
            this.Column8.HeaderText = "MA_HD";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // txtmahdM
            // 
            this.txtmahdM.Location = new System.Drawing.Point(172, 94);
            this.txtmahdM.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahdM.Name = "txtmahdM";
            this.txtmahdM.Size = new System.Drawing.Size(240, 26);
            this.txtmahdM.TabIndex = 18;
            this.txtmahdM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmahdM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnHienall_M
            // 
            this.btnHienall_M.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHienall_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienall_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienall_M.ForeColor = System.Drawing.Color.Lime;
            this.btnHienall_M.Location = new System.Drawing.Point(630, 58);
            this.btnHienall_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienall_M.Name = "btnHienall_M";
            this.btnHienall_M.Size = new System.Drawing.Size(107, 62);
            this.btnHienall_M.TabIndex = 19;
            this.btnHienall_M.Text = "Hiện tất cả";
            this.btnHienall_M.UseVisualStyleBackColor = false;
            this.btnHienall_M.Click += new System.EventHandler(this.btnHienall_B_Click);
            // 
            // btnLoc_M
            // 
            this.btnLoc_M.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLoc_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoc_M.ForeColor = System.Drawing.Color.Lime;
            this.btnLoc_M.Location = new System.Drawing.Point(463, 58);
            this.btnLoc_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc_M.Name = "btnLoc_M";
            this.btnLoc_M.Size = new System.Drawing.Size(109, 58);
            this.btnLoc_M.TabIndex = 20;
            this.btnLoc_M.Text = "Lọc";
            this.btnLoc_M.UseVisualStyleBackColor = false;
            this.btnLoc_M.Click += new System.EventHandler(this.btnLoc_M_Click);
            // 
            // txtTongtien_M
            // 
            this.txtTongtien_M.Enabled = false;
            this.txtTongtien_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongtien_M.Location = new System.Drawing.Point(358, 509);
            this.txtTongtien_M.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien_M.Name = "txtTongtien_M";
            this.txtTongtien_M.Size = new System.Drawing.Size(214, 27);
            this.txtTongtien_M.TabIndex = 23;
            this.txtTongtien_M.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 513);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tổng tiền của hóa đơn";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.ForeColor = System.Drawing.Color.Lime;
            this.btnIn.Location = new System.Drawing.Point(757, 58);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(138, 62);
            this.btnIn.TabIndex = 24;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmChitiethoadonMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 576);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTongtien_M);
            this.Controls.Add(this.btnHienall_M);
            this.Controls.Add(this.btnLoc_M);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmahdM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 99);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitiethoadonMua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmChitiethoadonMua";
            this.Load += new System.EventHandler(this.frmChitiethoadonMua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DSCHITIET_HDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmahdM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienall_M;
        private System.Windows.Forms.Button btnLoc_M;
        private System.Windows.Forms.DataGridView dataGridView1DSCHITIET_HDM;
        private System.Windows.Forms.TextBox txtTongtien_M;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnIn;
    }
}