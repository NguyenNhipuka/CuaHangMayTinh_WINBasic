namespace APPLICATION
{
    partial class frmTaoXoaUser
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.rdbTaoMoi = new System.Windows.Forms.RadioButton();
            this.rdbXoa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnMoi = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Navy;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.ForeColor = System.Drawing.Color.Lime;
            this.btnXoa.Location = new System.Drawing.Point(234, 283);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 63);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Navy;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.ForeColor = System.Drawing.Color.Lime;
            this.btnThoat.Location = new System.Drawing.Point(361, 283);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 63);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbUser
            // 
            this.cbbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUser.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(186, 112);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(241, 32);
            this.cbbUser.TabIndex = 3;
            this.cbbUser.SelectedIndexChanged += new System.EventHandler(this.cbbUser_SelectedIndexChanged);
            // 
            // rdbTaoMoi
            // 
            this.rdbTaoMoi.AutoSize = true;
            this.rdbTaoMoi.Checked = true;
            this.rdbTaoMoi.Location = new System.Drawing.Point(186, 60);
            this.rdbTaoMoi.Name = "rdbTaoMoi";
            this.rdbTaoMoi.Size = new System.Drawing.Size(93, 23);
            this.rdbTaoMoi.TabIndex = 4;
            this.rdbTaoMoi.TabStop = true;
            this.rdbTaoMoi.Text = "Tạo mới";
            this.rdbTaoMoi.UseVisualStyleBackColor = true;
            this.rdbTaoMoi.CheckedChanged += new System.EventHandler(this.rdbTaoMoi_CheckedChanged);
            // 
            // rdbXoa
            // 
            this.rdbXoa.AutoSize = true;
            this.rdbXoa.Location = new System.Drawing.Point(306, 60);
            this.rdbXoa.Name = "rdbXoa";
            this.rdbXoa.Size = new System.Drawing.Size(58, 23);
            this.rdbXoa.TabIndex = 4;
            this.rdbXoa.Text = "Xóa";
            this.rdbXoa.UseVisualStyleBackColor = true;
            this.rdbXoa.CheckedChanged += new System.EventHandler(this.rdbXoa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(186, 166);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(241, 27);
            this.txtPass.TabIndex = 6;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.Navy;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoi.ForeColor = System.Drawing.Color.Lime;
            this.btnMoi.Location = new System.Drawing.Point(98, 283);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(98, 63);
            this.btnMoi.TabIndex = 0;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(186, 112);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 27);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // cbbCV
            // 
            this.cbbCV.AutoCompleteCustomSource.AddRange(new string[] {
            "NV"});
            this.cbbCV.DisplayMember = "NV";
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Items.AddRange(new object[] {
            "NHÂN VIÊN",
            "THỦ KHO",
            "GIÁM ĐỐC"});
            this.cbbCV.Location = new System.Drawing.Point(187, 209);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(240, 27);
            this.cbbCV.TabIndex = 8;
            this.cbbCV.SelectedIndexChanged += new System.EventHandler(this.cbbCV_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phân quyền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 38);
            this.panel1.TabIndex = 9;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(193, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mở/Xóa User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 38);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(1116, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmTaoXoaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(612, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbCV);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbXoa);
            this.Controls.Add(this.rdbTaoMoi);
            this.Controls.Add(this.cbbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 106);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTaoXoaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Khóa/ Mở User";
            this.Load += new System.EventHandler(this.frmKhoaUser_Load);
            this.Click += new System.EventHandler(this.frmKhoaUser_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.RadioButton rdbTaoMoi;
        private System.Windows.Forms.RadioButton rdbXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}