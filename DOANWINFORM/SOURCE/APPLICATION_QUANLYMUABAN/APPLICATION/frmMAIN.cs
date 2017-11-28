using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APPLICATION
{
    public partial class frmMAIN : Form
    {


        /// lấy tham số truyền vào

        public static string s = string.Empty;
        string Chuc_vu = "";
        SqlConnection con;
        public List<Button> bt()
        {
            List<Button> l = new List<Button>();
            l.Add(btn_QuanLyNCC);
            l.Add(btnBanHang);
            l.Add(btnBangBaoGia);
            l.Add(btnMuaHang);
            l.Add(btnQLNhanVien);
            l.Add(btnThoatX);
            return l;
        }
        public frmMAIN()
        {
            InitializeComponent();
            
            
        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {
            try
            {
                List<Button> ds = bt();
                foreach (Button b in ds)
                    b.Enabled = false;
                qToolStripMenuItem.Enabled = false;
                tHIẾTBỊToolStripMenuItem.Enabled = false;
                tHỐNGKÊToolStripMenuItem.Enabled = false;
                tRACỨUToolStripMenuItem.Enabled = false;
            }
            catch { }

        }


        public string  KiemTraChucVuCuaNV()
        {
            string nv = "";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    string query = "select CV  from TAIKHOAN_NV WHERE MA_NV = '" + lblMaNV.Text.ToString().Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    nv = ds.Tables[0].Rows[0][0].ToString();
                    con.Close();
                }
            }
            catch { }
            return nv;
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                this.Close();
        }

        private void btnThoatX_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                this.Close();
        }

        private void frmMAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                FrmHoaDonMuaHang fr = new FrmHoaDonMuaHang();
                fr.ma_nv = lblMaNV.Text;
                fr.ShowDialog();
            }
            catch { }
           
        }

        private void btn_QuanLyNCC_Click(object sender, EventArgs e)
        {
            FrmQuanLyNCC fr = new FrmQuanLyNCC();
            if (KiemTraChucVuCuaNV() == "NHÂN VIÊN")
                fr.chichoxem = true;
            fr.ShowDialog();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien fr = new frmNhanVien();
            fr.manv = lblMaNV.Text;
            fr.ShowDialog();
        }

        private void btnBangBaoGia_Click(object sender, EventArgs e)
        {
           frmBangBaoGia fr = new frmBangBaoGia();
           fr.ShowDialog();
        }

        private void tHIẾTBỊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoTB fr = new frmKhoTB();
            fr.Chu_vu = Chuc_vu;
            fr.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang fr = new frmHoaDonBanHang();
            fr.ma_nv = lblMaNV.Text;
            fr.ShowDialog();
           
        }

        private void tRACỨUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    btnDangNhap.Enabled = true;
                    lblMaNV.Text = string.Empty;
                    Chuc_vu = string.Empty;
                    btnDangNhap_Click(sender, e);

                    //// ---------------- người dùng không đăng nhập thì thoát chương trình luôn
                    if (lblMaNV.Text == string.Empty)
                        this.Close();
                }
            }
            catch { }
           

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frdn = new frmDangNhap();
            frdn.sendMessageEvent +=fr_sendMessageEvent;
            frdn.ShowDialog();
            frdn.Close();
            if(lblMaNV.Text.Length != 0)
            {
                /// mở các chức năng sau khi đã đăng nhập
                List<Button> ds = bt();
                foreach (Button b in ds)
                    b.Enabled = true;
                qToolStripMenuItem.Enabled = true;
                tHIẾTBỊToolStripMenuItem.Enabled = true;
                tHỐNGKÊToolStripMenuItem.Enabled = true;
                tRACỨUToolStripMenuItem.Enabled = true;
                ////////////Kiểm tra phân quyền theo chức vụ: chỉ Thủ kho  mới nhập hàng, nhân viên bán hàng, admin: all
                Chuc_vu = KiemTraChucVuCuaNV();
                if (Chuc_vu == "NHÂN VIÊN")
                {
                    btnMuaHang.Enabled = false;
                }
                else
                    if (Chuc_vu == "THỦ KHO")
                    {
                        btnBanHang.Enabled = false;
                    }
                /// khóa chức năng đang nhập, khi nào đăng xuất thì chức năng này mới mở trở lại
                btnDangNhap.Enabled = false;
                
            }
        }
        public void fr_sendMessageEvent(string messaege)
        {
            lblMaNV.Text = messaege;
        }

        private void TaoKhoaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoXoaUser fr = new frmTaoXoaUser();
            fr.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                this.Close();
        }

        private void thiếtLậpTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fr = new frmDoiMatKhau();
            fr.Ma_NV_DangThaoTac = lblMaNV.Text;
            fr.Show();
            
        }

       private void qToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (lblMaNV.Text == "NV0001")
               TaoKhoaAdminToolStripMenuItem.Enabled = true;
           else
               TaoKhoaAdminToolStripMenuItem.Enabled = false;
       }

       private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           
       }

       private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmChitiethoadonMua fr = new frmChitiethoadonMua();
           fr.ShowDialog();
       }

       private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmChitiethoadonBan fr = new frmChitiethoadonBan();
           fr.ShowDialog();
       }

       private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmThongKeThuChi fr = new frmThongKeThuChi();
           fr.ShowDialog();
       }

       private void bảngBáoGiáToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmBangBaoGia fr = new frmBangBaoGia();
           fr.ShowDialog();
       }

       private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmKhoTB fr = new frmKhoTB();
           fr.chichoxemvabc = true;
           fr.ShowDialog();
       }

       private void label2_Click(object sender, EventArgs e)
       {

       }
    }

}
