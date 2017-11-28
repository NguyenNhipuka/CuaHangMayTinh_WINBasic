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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public string Ma_NV_DangThaoTac;

        private void txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NV la 6 ky tu
            else
            {
                if (txt_User.TextLength >= 6)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            try
            {
                /// An pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = true;
                if (Ma_NV_DangThaoTac == "NV0001")
                {
                    txt_User.Enabled = true;
                    txtPassHientai.Enabled = false;
                }
                else
                {
                    txt_User.Enabled = false;
                    txtPassHientai.Enabled = true;
                }
            }
            catch { }  
        }

        private void chkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienPass.Checked == true)
            {
                /// Hiện pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = false;
            }
            else
            {
                /// Ẩn pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = true;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassmoi.TextLength == 0 || txtNhaplaiPass.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin đầy đủ");
                    return;

                }
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    string query;
                    ////-----------------quyen admin
                    
                    if (Ma_NV_DangThaoTac == "NV0001")
                    {
                        if (txt_User.TextLength == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập thông tin đầy đủ");
                            return;
                        }
                        //// cau lệnh kiểm tra su tồn tại của user trong csdl TAIKHOAN
                        if(kiemTraMA_NV(txt_User.Text) == false)
                        {
                            MessageBox.Show("Định dạng mã nhân viên không đúng.\nMã nhân viên phải bắt đầu 'NV' + 4 chữ số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        query = " SELECT COUNT(*) from TAIKHOAN_NV WHERE MA_NV = '" + txt_User.Text + "'";
                        SqlCommand cmd;
                        cmd = new SqlCommand(query, con);
                        int tontai = (int)cmd.ExecuteScalar();
                        if (tontai == 1)/// co ton tại tài khoản này => có thể thay đổi pass
                        {

                            /// kiểm tra 2 lần nhập mã
                            if (txtPassmoi.Text != txtNhaplaiPass.Text)
                            {
                                MessageBox.Show("Hai mật khẩu không trùng nhau. Vui lòng kiểm tra lại");
                                return;
                            }
                            /// ---------------------------------------------------- update
                            query = "  UPDATE TAIKHOAN_NV SET PASS = '" + txtPassmoi.Text + " ' WHERE MA_NV = '" + txt_User.Text + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản này không tồn tại");
                        }
                    }
                    else
                    {
                        //////--------------------quyen nhan vien

                        if (txtPassmoi.TextLength == 0 || txtNhaplaiPass.TextLength == 0 || txtPassHientai.TextLength == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập thông tin đầy đủ");
                            return;

                        }
                        query = " SELECT COUNT(*) from TAIKHOAN_NV WHERE MA_NV = '" + Ma_NV_DangThaoTac + "' and PASS= '" + txtPassHientai.Text + "'";
                        SqlCommand cmd;
                        cmd = new SqlCommand(query, con);
                        int tontai = (int)cmd.ExecuteScalar();
                        if (tontai == 1)///đúng mã
                        {

                            /// kiểm tra 2 lần nhập mã
                            if (txtPassmoi.Text != txtNhaplaiPass.Text)
                            {
                                MessageBox.Show("Hai mật khẩu không trùng nhau. Vui lòng kiểm tra lại");
                                return;
                            }
                            /// /// update
                            query = "  UPDATE TAIKHOAN_NV SET PASS = '" + txtPassmoi.Text + " ' WHERE MA_NV = '" + Ma_NV_DangThaoTac + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                    }
                    /// kiểm tra xem nếu kết nối còn mở thì đóng kết nối đi
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                    txt_User.Text = txtNhaplaiPass.Text = txtPassHientai.Text = txtPassmoi.Text = "";
                }
            }
            catch { }
            
        }


        /// kiểm tra xem mã nhân viên có đúng định dạng là "NV0000": true : đúng mã, false : sai mã
        public bool kiemTraMA_NV(string s)
        {
            if (s.Length < 6)
                return false;
            if (s[0] == 'N' && s[1] == 'V')
            {
                try
                {
                    int x = int.Parse(s.Substring(2)); // / kiểm tra xem 4 kí tự sau có phải là số không
                }
                catch
                {
                    /// có lỗi=> không phải là số
                    return false;
                }
                /// không lỗi=> đúng định dạng
                return true;
            }

            return false;

        }

    }
}
