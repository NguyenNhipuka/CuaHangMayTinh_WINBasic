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
    public partial class frmDangNhap : Form
    {
        public delegate void sendMessage(string message);
        public event sendMessage sendMessageEvent;
        public frmDangNhap()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();

            txtPass.UseSystemPasswordChar = true;//// kí tự nhập vào được mã hóa thành ký tự khác
        }
        private void ChkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkHienPass.Checked == true)
                txtPass.UseSystemPasswordChar = false;//// kí tự nhập vào không mã hóa 
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn phải đăng nhập để sử dụng. Bạn có muốn đăng nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.No)
                this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionstring);
            con.Open();
            string query = "SELECT COUNT(*) FROM TAIKHOAN_NV WHERE MA_NV='" + txtUser.Text + "' AND PASS ='" + txtPass.Text + " ' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            DataTable datatable = new DataTable();
            sqlda.Fill(datatable);
            if (datatable.Rows[0][0].ToString() == "1")
            {
                ///// đăng nhập thành công
                if (sendMessageEvent != null)
                {
                    sendMessageEvent(txtUser.Text);
                    con.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("User hoặc pass đã sai. Vui lòng xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
            return;
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
                }
            }
        }

    }
}