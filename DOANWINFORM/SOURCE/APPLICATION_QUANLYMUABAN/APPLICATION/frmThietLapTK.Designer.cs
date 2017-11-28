namespace APPLICATION
{
    partial class frmDoiMatKhau
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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtPassHientai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhaplaiPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHienPass = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(237, 114);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(280, 26);
            this.txt_User.TabIndex = 0;
            this.txt_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnexit.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnexit.Location = new System.Drawing.Point(392, 334);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 63);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtPassHientai
            // 
            this.txtPassHientai.Location = new System.Drawing.Point(237, 184);
            this.txtPassHientai.Name = "txtPassHientai";
            this.txtPassHientai.Size = new System.Drawing.Size(280, 26);
            this.txtPassHientai.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password hiện tại";
            // 
            // txtPassmoi
            // 
            this.txtPassmoi.Location = new System.Drawing.Point(237, 240);
            this.txtPassmoi.Name = "txtPassmoi";
            this.txtPassmoi.Size = new System.Drawing.Size(280, 26);
            this.txtPassmoi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password mới";
            // 
            // txtNhaplaiPass
            // 
            this.txtNhaplaiPass.Location = new System.Drawing.Point(237, 286);
            this.txtNhaplaiPass.Name = "txtNhaplaiPass";
            this.txtNhaplaiPass.Size = new System.Drawing.Size(280, 26);
            this.txtNhaplaiPass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập lại Password mới";
            // 
            // chkHienPass
            // 
            this.chkHienPass.AutoSize = true;
            this.chkHienPass.Location = new System.Drawing.Point(237, 146);
            this.chkHienPass.Name = "chkHienPass";
            this.chkHienPass.Size = new System.Drawing.Size(161, 22);
            this.chkHienPass.TabIndex = 3;
            this.chkHienPass.Text = "Hiển thị password";
            this.chkHienPass.UseVisualStyleBackColor = true;
            this.chkHienPass.CheckedChanged += new System.EventHandler(this.chkHienPass_CheckedChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDongY.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnDongY.Location = new System.Drawing.Point(248, 334);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(105, 63);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 43);
            this.panel1.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1119, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(33, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font(".VnMysticalH", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(1477, 4);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(59, 38);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(250, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkHienPass);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhaplaiPass);
            this.Controls.Add(this.txtPassmoi);
            this.Controls.Add(this.txtPassHientai);
            this.Controls.Add(this.txt_User);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 106);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtPassHientai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaplaiPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHienPass;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label5;
    }
}