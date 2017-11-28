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
    public partial class FrmQuanLyNCC : Form
    {
        public bool chichoxem = false;
        public FrmQuanLyNCC()
        {
            InitializeComponent();
        }

        /// đưa CSDL vào dataset
        DataSet DATASET_DATABASE()
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();

                    string query;
                    query = "SELECT * FROM NHACUNGCAP";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(data);
                    con.Close();
                }
            }
            catch { }

            return data;
        }
        /// Đưa DATASET_DATABASE vào datagridview
        public void loadToDatagridview()
        {
            try
            {
                dataGridView1DS_NCC.DataSource = DATASET_DATABASE().Tables[0];
            }
            catch { }


        }


        private void btnThemQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThemQLNCC.Text == "Tạo mới")
                {
                    txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                    btnThemQLNCC.Text = "Hủy thêm mới";
                    btnLuu.Enabled = true;
                    txtMaNCC.Enabled = true;
                }
                else
                {
                    txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                    btnThemQLNCC.Text = "Tạo mới";
                    btnLuu.Enabled = false;
                    txtMaNCC.Enabled = false;

                }
            }
            catch { }
        }

        private void FrmQuanLyNCC_Load(object sender, EventArgs e)
        {
            if(chichoxem == true)
            {
                btnSuaQLNCC.Enabled = btnThemQLNCC.Enabled = XoaQLNCC.Enabled = false;
            }
            loadToDatagridview();
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///------------------------------
        /// kiểm tra xem mã NCC có đúng định dạng là "NC0000": true : đúng mã, false : sai mã
        public bool kiemTraMA_NCC(string s)
        {
            if (s.Length < 6)
                return false;
            if (s[0] == 'N' && s[1] == 'C')
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
        /////-------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                /// ---------------------------- điều kiện để thực thi

                if (txtMaNCC.TextLength == 0 || txtEmail.TextLength == 0 || txtDiaChi.TextLength == 0 || txtTenNCC.TextLength == 0 || txtSoDienThoai.TextLength <= 9)
                {
                    MessageBox.Show("Vui lòng điền đây đủ thông tin");
                    return;
                }
                if (kiemTraMA_NCC(txtMaNCC.Text) == false)
                {
                    MessageBox.Show("Mã nhà cung cấp không đúng định dạng. Mã  nhà cung cấp có định dạng là : 'NC0000' ");
                    return;
                }
                ////------------------------------------------------end điều kiện
                //try
                //{
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    string query = "";
                    SqlCommand cmd;
                    int x = 0;
                    ///kiem tra trung mã nhan viên
                    query = " select COUNT(*)  from NHACUNGCAP where MA_NCC = '" + txtMaNCC.Text + "'";
                    cmd = new SqlCommand(query, con);
                    x = (int)cmd.ExecuteScalar();
                    if (x == 1)
                    {
                        MessageBox.Show("Mã nhà cung cấp này đã tồn tại");
                        return;
                    }
                    ///----------------------
                    query = " insert into NHACUNGCAP values ('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "','" + txtSoDienThoai.Text + "',N'" + txtEmail.Text + "')";

                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Nhà cung cấp này đã được thêm với mã là: " + txtMaNCC.Text);
                }
                loadToDatagridview();
                txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                btnLuu.Enabled = false;
                btnThemQLNCC.Enabled = true;
            }
            catch { }
        }

        private void btnSuaQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1DS_NCC.SelectedRows)
                {
                    /// ---------------------------- điều kiện để thực thi
                    if (txtEmail.TextLength == 0 || txtDiaChi.TextLength == 0 || txtTenNCC.TextLength == 0 || txtSoDienThoai.TextLength == 0)
                    {
                        MessageBox.Show("Vui lòng điền đây đủ thông tin");
                        return;
                    }
                    ////------------------------------------------------end điều kiện
                    //try
                    //{
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                    {
                        con.Open();
                        string query = "";
                        SqlCommand cmd;

                        ///----------------------
                        query = " UPDATE NHACUNGCAP SET TEN_NCC = N'" + txtTenNCC.Text + "',EMAIL = '" + txtEmail.Text + "',DIENTHOAI = '" + txtSoDienThoai.Text + "', DIACHI = N'" + txtDiaChi.Text + "' WHERE MA_NCC = '"+row.Cells[0].Value.ToString().Trim()+"'";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    loadToDatagridview();
                    txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                }
            }
            catch { }
        }

        private void dataGridView1DS_NCC_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnThemQLNCC.Text == "Hủy thêm mới")
                return;
            try
            {
                foreach (DataGridViewRow row in dataGridView1DS_NCC.SelectedRows)
                {
                    txtMaNCC.Text = row.Cells[0].Value.ToString();
                    txtTenNCC.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[4].Value.ToString();
                    txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                    txtDiaChi.Text = row.Cells[2].Value.ToString();
                }
            }
            catch { }
        }


        //public bool KiemTraDieuKienXoa()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
        //        {
        //            con.Open();
        //            string query = "SELECT COUNT(MA_NCC) FROM HOADON_MUA where MA_TB = '" + txtMaNCC.Text.ToString().ToString() + "'";
        //            SqlCommand cmd = new SqlCommand(query, con);
        //            int TontaiHDB = (int)cmd.ExecuteScalar();

        //            //query = "SELECT count(MA_TB) FROM CHITIET_HDB where MA_TB = '" +  + "'";
        //            cmd = new SqlCommand(query, con);
        //            int TontaiHDM = (int)cmd.ExecuteScalar();
        //            con.Close();
        //            if (TontaiHDB == 0 || TontaiHDM == 0)/// mã thiết bị này tồn tại trong hóa đon mua hoặc bán
        //            {
        //                return true;/////=> Được xóa
        //            }

        //            return true;////=>k  Được xóa
        //        }
        //    }
        //    catch { }
        //    return true;////=>k  Được xóa
        //}
        public bool KiemTraDieuKienXoa()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
            {
                con.Open();
                string query = "SELECT count(MA_NCC) FROM THIETBI where MA_NCC = '" + txtMaNCC.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int TontaiMANCC = (int)cmd.ExecuteScalar();
                con.Close();
                if (TontaiMANCC == 0)/// mã nhà cung cấp này chưa cung cấp thiết bị nào
                {
                    return true;/////=> Được xóa
                }

                return false;////=>k  Được xóa
            }
        }
        private void XoaQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1DS_NCC.SelectedRows)
                {
                    DialogResult ok;
                    ok = MessageBox.Show("Bạn có muốn xóa nhà cung cấp có mã " + dataGridView1DS_NCC.CurrentRow.Cells[0].Value.ToString() + " khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ok == DialogResult.No)
                        return;
                    
                    if (KiemTraDieuKienXoa() == false)
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp này khỏi hệ thống. \n Mã nhà cung này chứa thông tin phục vụ thệ thống", "Thông báo");
                        return;
                    }
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                    {
                        con.Open();
                        string query = "DELETE NHACUNGCAP WHERE MA_NCC = '" + dataGridView1DS_NCC.CurrentRow.Cells[0].Value.ToString().Trim()+ "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        
                        dataGridView1DS_NCC.Rows.RemoveAt(dataGridView1DS_NCC.CurrentRow.Index);
                        con.Close();
                        MessageBox.Show("Xóa thành công","Thông báo");
                        loadToDatagridview();

                    }
                }
            }
            catch { }
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NCC la 6 ky tu
            else
            {
                if (txtMaNCC.TextLength >= 6)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }

        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsDigit(e.KeyChar) || txtTenNCC.TextLength >= 99) /// không cho nhập số,quy dinh do dai cua tên NCC lớn nhất  la 99 ky tu
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiaChi.TextLength >= 99 && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                if (!char.IsDigit(e.KeyChar) || txtSoDienThoai.TextLength>= 11 || char.IsWhiteSpace(e.KeyChar))/// so diện thoại phải nhỏ hơn 12
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        
        }
    }
    }
