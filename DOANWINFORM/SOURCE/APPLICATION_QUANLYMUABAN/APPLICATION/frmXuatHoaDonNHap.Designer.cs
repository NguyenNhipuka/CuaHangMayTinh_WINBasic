namespace APPLICATION
{
    partial class frmXuatHoaDonNHap
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
            this.crvXuatHoaDonNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvXuatHoaDonNhap
            // 
            this.crvXuatHoaDonNhap.ActiveViewIndex = -1;
            this.crvXuatHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvXuatHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvXuatHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvXuatHoaDonNhap.Location = new System.Drawing.Point(0, 0);
            this.crvXuatHoaDonNhap.Name = "crvXuatHoaDonNhap";
            this.crvXuatHoaDonNhap.Size = new System.Drawing.Size(1151, 537);
            this.crvXuatHoaDonNhap.TabIndex = 0;
            this.crvXuatHoaDonNhap.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvXuatHoaDonNhap.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmXuatHoaDonNHap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 537);
            this.Controls.Add(this.crvXuatHoaDonNhap);
            this.Location = new System.Drawing.Point(165, 99);
            this.Name = "frmXuatHoaDonNHap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XUẤT HÓA ĐƠN NHẬP";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvXuatHoaDonNhap;

    }
}