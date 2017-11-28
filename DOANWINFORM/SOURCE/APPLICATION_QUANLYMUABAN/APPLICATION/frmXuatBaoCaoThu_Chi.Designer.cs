namespace APPLICATION
{
    partial class frmXuatBaoCaoThu_Chi
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
            this.crvXuatBaoCaoThuChi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvXuatBaoCaoThuChi
            // 
            this.crvXuatBaoCaoThuChi.ActiveViewIndex = -1;
            this.crvXuatBaoCaoThuChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvXuatBaoCaoThuChi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvXuatBaoCaoThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvXuatBaoCaoThuChi.Location = new System.Drawing.Point(0, 0);
            this.crvXuatBaoCaoThuChi.Name = "crvXuatBaoCaoThuChi";
            this.crvXuatBaoCaoThuChi.Size = new System.Drawing.Size(1151, 537);
            this.crvXuatBaoCaoThuChi.TabIndex = 0;
            this.crvXuatBaoCaoThuChi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvXuatBaoCaoThuChi.Load += new System.EventHandler(this.crXuatBaoCaoThuChi_Load);
            // 
            // frmXuatBaoCaoThu_Chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 537);
            this.Controls.Add(this.crvXuatBaoCaoThuChi);
            this.Location = new System.Drawing.Point(165, 99);
            this.Name = "frmXuatBaoCaoThu_Chi";
            this.Text = "XUẤT BÁO CÁO THU CHI";
            this.Load += new System.EventHandler(this.frmXuatBaoCaoThu_Chi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvXuatBaoCaoThuChi;
    }
}