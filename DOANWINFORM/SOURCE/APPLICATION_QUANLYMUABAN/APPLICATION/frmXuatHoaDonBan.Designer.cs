namespace APPLICATION
{
    partial class frmXuatHoaDonBan
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
            this.crvXuatHoaDonBan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvXuatHoaDonBan
            // 
            this.crvXuatHoaDonBan.ActiveViewIndex = -1;
            this.crvXuatHoaDonBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvXuatHoaDonBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvXuatHoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvXuatHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.crvXuatHoaDonBan.Name = "crvXuatHoaDonBan";
            this.crvXuatHoaDonBan.Size = new System.Drawing.Size(1151, 537);
            this.crvXuatHoaDonBan.TabIndex = 0;
            this.crvXuatHoaDonBan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvXuatHoaDonBan.Load += new System.EventHandler(this.crvXuatHoaDonBan_Load);
            // 
            // frmXuatHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 537);
            this.Controls.Add(this.crvXuatHoaDonBan);
            this.Location = new System.Drawing.Point(165, 99);
            this.Name = "frmXuatHoaDonBan";
            this.Text = "XUẤT HÓA ĐƠN BÁN";
            this.Load += new System.EventHandler(this.frmXuatHoaDonBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvXuatHoaDonBan;
    }
}