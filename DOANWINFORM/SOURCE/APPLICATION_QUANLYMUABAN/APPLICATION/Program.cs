using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLICATION
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDangNhap());
          Application.Run(new frmMAIN());
            //Application.Run(new frmKhoaUser());
           //Application.Run(new frmDoiMatKhau());
            //Application.Run(new frmNhanVien());
            //Application.Run(new FrmQuanLyNCC());
           //Application.Run(new  frmKhoTB());
           //Application.Run(new FrmHoaDonMuaHang());
          //  Application.Run(new frmHoaDonBanHang());
            //Application.Run(new frmChiTietHoaDon());
           // Application.Run(new frmChitiethoadonBan());
           // Application.Run(new frmChitiethoadonMua());
          // Application.Run(new frmThongKeThuChi());
           // Application.Run(new frmBangBaoGia());
            //Application.Run(new frmXuatHoaDonBan());
        }
    }
}
