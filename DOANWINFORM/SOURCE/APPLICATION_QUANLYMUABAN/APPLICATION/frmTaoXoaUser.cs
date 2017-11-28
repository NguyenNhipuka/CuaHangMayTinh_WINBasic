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
    public partial class frmTaoXoaUser : Form
    {

        
        
        SqlDataAdapter da;
        SqlCommand cmd;
        public frmTaoXoaUser()
        {
            InitializeComponent();


        }
        ///đưa dữ liệu từ CSDL lên combobox User
        public void showDataToCombobox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    string query = "  select MA_NV from TAIKHOAN_NV";
                    cmd = new SqlCommand(query, con);
                    da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    cbbUser.DataSource = table;
                    cbbUser.ValueMember = "MA_NV";
                    cbbUser.DisplayMember = "MA_NV";
                    con.Close();
                }
               
                
            }
            catch { }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void rdbKhoa_Mo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmKhoaUser_Load(object sender, EventArgs e)
        {
            
            cbbUser.Visible = false;
            btnXoa.Enabled = false;
            cbbCV.SelectedItem = cbbCV.Items[0];
            rdbTaoMoi.Checked = true;
            cbbCV.Enabled = false;
        }

        private void rdbTaoMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Text = txtPass.Text = string.Empty;
            if (rdbTaoMoi.Checked == true)
            {
                btnXoa.Enabled = false;
                btnMoi.Enabled = true;
                cbbUser.Visible = false;
                txtUser.Visible = true;
               

            }
            else
            {
                btnMoi.Enabled = false;
                btnXoa.Enabled = true;
            }
        }

        private void rdbXoa_CheckedChanged(object sender, EventArgs e)
        {
            cbbUser.SelectedValue = "NV0001";
            txtUser.Text = txtPass.Text = string.Empty;
            cbbCV.SelectedItem = cbbCV.Items[2];
            if (rdbXoa.Checked == true)
            {
                txtPass.Enabled = false;
                btnMoi.Enabled = false;
                /// an textbox User
                txtUser.Visible = false;
                ///hiện Combobox User để xóa tài khoảng
                cbbUser.Visible = true;
                showDataToCombobox();
            }

            else
            {
                txtPass.Enabled = true;
                btnMoi.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (cbbUser.SelectedValue.ToString().Trim() == "NV0001")
            {
                MessageBox.Show("Đây là tài khoảng admin. Bạn không thể xóa");
                return;
            }
            try
            {
               
                    ///-----------------------------
                    ///---------------------------------
                    DialogResult ok;
                    ok = MessageBox.Show("Bạn có muốn xóa tài khoảng này không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ok == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                        {
                            con.Open();
                            ///-------------------kiểm tra ràng buộc khóa ngoại
                            //// kiem tra khoa ngoai
                            SqlCommand cmd = new SqlCommand(" select COUNT(*)  from HOADON_MUA where MA_NV = '" + cbbUser.SelectedValue.ToString() + "'", con);
                            int x = (int)cmd.ExecuteScalar();
                            if (x != 0)
                            {
                                MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu");
                                return;
                            }
                            cmd = new SqlCommand(" select COUNT(*)  from HOADON_BAN where MA_NV = '" + cbbUser.SelectedValue.ToString() + "'", con);
                            x = (int)cmd.ExecuteScalar();
                            if (x != 0)
                            {
                                MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu", "Thông báo");
                                return;
                            }
                            ///---------------------
                            cmd = new SqlCommand("DELETE FROM TAIKHOAN_NV WHERE MA_NV = '" + cbbUser.SelectedValue.ToString() + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tài khoảng  " + cbbUser.SelectedValue.ToString() + "   đã được xóa thành công khỏi hệ thống");
                            showDataToCombobox();
                            ///-----------------------
                            con.Close();
                            ///-----------------------
                        }
                        ///-----------------
                }
            }
            catch { }
         


        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUser.TextLength < 6)
                {
                    MessageBox.Show("Mã nhân viên không đúng quy định. \nMã nhân viên theo quy định là: ví dụ 'NV0000'");
                    return;
                }
                if (txtPass.TextLength < 3)
                {
                    MessageBox.Show("Mật khẩu phải ít nhất 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ///-----------------------------------

                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    ///-----------------------------------kiểm trâ sự tồn tại của MA_NV trong bảng TAIKHOAN_NV mới cần tạo
                    con.Open();
                    string query_tontai_TK = "SELECT COUNT(*) from TAIKHOAN_NV WHERE MA_NV = '" + txtUser.Text + "'";
                    cmd = new SqlCommand(query_tontai_TK, con);
                    int x = (int)cmd.ExecuteScalar();
                    if (x == 1)
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại", "Thông báo");
                        con.Close();
                        return;
                    }

                    string query_tontai_NHANVIEN = "SELECT COUNT(*) from NHANVIEN WHERE MA_NV = '" + txtUser.Text + "'";
                    cmd = new SqlCommand(query_tontai_NHANVIEN, con);
                    int x2 = (int)cmd.ExecuteScalar();
                    if (x2 == 0)
                    {
                        MessageBox.Show("User của tài khoảng mới này chưa tồn tại mã nhân viên của cửa hàng", "Thông báo");
                        con.Close();
                        return;
                    }
                    con.Close();

                    ///----------------------------------------
                    con.Open();

                    string query = "insert into TAIKHOAN_NV values ('" + txtUser.Text + "','" + txtPass.Text + "',N'" + cbbCV.SelectedItem.ToString() + "')";


                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tài khoảng này đã được tạo thành công");
                    con.Close();
                }
            }
            catch { }
            txtUser.Text = txtPass.Text = string.Empty;
        }

        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionstring))
            {
                conn.Open();
                cmd = new SqlCommand("select CHUCVU from NHANVIEN WHERE MA_NV = '" + cbbUser.SelectedValue.ToString() + "'", conn);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r[0] != null)
                        cbbCV.SelectedItem = r[0].ToString();
                }

                conn.Close();
            }
        }

        private void frmKhoaUser_Click(object sender, EventArgs e)
        {

        }

        private void cbbUser_Click(object sender, EventArgs e)
        {
           

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NV la 6 ky tu
            else
            {
                if (txtUser.TextLength >= 6)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                    MaNV_ChucVu(txtUser.Text);
                }

            }


        }

        public void MaNV_ChucVu(string s)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionstring))
            {
                conn.Open();
                cmd = new SqlCommand("select MA_NV,CHUCVU FROM NHANVIEN", conn);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if(r[0].ToString().Trim()== s)
                    {
                        cbbCV.SelectedItem = r[1].ToString();
                        break;
                    }
                }
                conn.Close();
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// quy dinh do dai cua PASS la 30 ky tu
            if (txtUser.TextLength >= 30)
                e.Handled = true;
            else
                e.Handled = false;

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            MaNV_ChucVu(txtUser.Text);
        }

        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
