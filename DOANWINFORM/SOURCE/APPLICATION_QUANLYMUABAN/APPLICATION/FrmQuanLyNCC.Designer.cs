namespace APPLICATION
{
    partial class FrmQuanLyNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemQLNCC = new System.Windows.Forms.Button();
            this.btnSuaQLNCC = new System.Windows.Forms.Button();
            this.XoaQLNCC = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1DS_NCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DS_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnThoat.Location = new System.Drawing.Point(1118, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(34, 27);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(225, 104);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(229, 26);
            this.txtTenNCC.TabIndex = 3;
            this.txtTenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNCC_KeyPress);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNCC.Location = new System.Drawing.Point(228, 56);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(136, 26);
            this.txtMaNCC.TabIndex = 5;
            this.txtMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNCC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(587, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(201, 26);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(472, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(587, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(473, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(472, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email-Fax";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(924, 104);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(136, 26);
            this.txtSoDienThoai.TabIndex = 11;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(791, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số Điện Thoại";
            // 
            // btnThemQLNCC
            // 
            this.btnThemQLNCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnThemQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemQLNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemQLNCC.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnThemQLNCC.Location = new System.Drawing.Point(251, 156);
            this.btnThemQLNCC.Name = "btnThemQLNCC";
            this.btnThemQLNCC.Size = new System.Drawing.Size(148, 43);
            this.btnThemQLNCC.TabIndex = 12;
            this.btnThemQLNCC.Text = "Tạo mới";
            this.btnThemQLNCC.UseVisualStyleBackColor = false;
            this.btnThemQLNCC.Click += new System.EventHandler(this.btnThemQLNCC_Click);
            // 
            // btnSuaQLNCC
            // 
            this.btnSuaQLNCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSuaQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaQLNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaQLNCC.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnSuaQLNCC.Location = new System.Drawing.Point(669, 156);
            this.btnSuaQLNCC.Name = "btnSuaQLNCC";
            this.btnSuaQLNCC.Size = new System.Drawing.Size(109, 43);
            this.btnSuaQLNCC.TabIndex = 13;
            this.btnSuaQLNCC.Text = "Sửa";
            this.btnSuaQLNCC.UseVisualStyleBackColor = false;
            this.btnSuaQLNCC.Click += new System.EventHandler(this.btnSuaQLNCC_Click);
            // 
            // XoaQLNCC
            // 
            this.XoaQLNCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.XoaQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XoaQLNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.XoaQLNCC.ForeColor = System.Drawing.Color.LawnGreen;
            this.XoaQLNCC.Location = new System.Drawing.Point(857, 156);
            this.XoaQLNCC.Name = "XoaQLNCC";
            this.XoaQLNCC.Size = new System.Drawing.Size(109, 43);
            this.XoaQLNCC.TabIndex = 14;
            this.XoaQLNCC.Text = "Xóa";
            this.XoaQLNCC.UseVisualStyleBackColor = false;
            this.XoaQLNCC.Click += new System.EventHandler(this.XoaQLNCC_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnLuu.Location = new System.Drawing.Point(465, 156);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 43);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1DS_NCC
            // 
            this.dataGridView1DS_NCC.AllowUserToAddRows = false;
            this.dataGridView1DS_NCC.AllowUserToDeleteRows = false;
            this.dataGridView1DS_NCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1DS_NCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1DS_NCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1DS_NCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1DS_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1DS_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1DS_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1DS_NCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1DS_NCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1DS_NCC.Location = new System.Drawing.Point(73, 255);
            this.dataGridView1DS_NCC.MultiSelect = false;
            this.dataGridView1DS_NCC.Name = "dataGridView1DS_NCC";
            this.dataGridView1DS_NCC.ReadOnly = true;
            this.dataGridView1DS_NCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1DS_NCC.Size = new System.Drawing.Size(1003, 284);
            this.dataGridView1DS_NCC.TabIndex = 15;
            this.dataGridView1DS_NCC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1DS_NCC_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MA_NCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_NCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 322;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EMAIL";
            this.Column3.HeaderText = "Email-fax";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DIENTHOAI";
            this.Column4.HeaderText = "Điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "DIACHI";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(73, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 20);
            this.panel2.TabIndex = 16;
            // 
            // FrmQuanLyNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1DS_NCC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.XoaQLNCC);
            this.Controls.Add(this.btnSuaQLNCC);
            this.Controls.Add(this.btnThemQLNCC);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 99);
            this.Name = "FrmQuanLyNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmQuanLyNCCcs";
            this.Load += new System.EventHandler(this.FrmQuanLyNCC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DS_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemQLNCC;
        private System.Windows.Forms.Button btnSuaQLNCC;
        private System.Windows.Forms.Button XoaQLNCC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1DS_NCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}