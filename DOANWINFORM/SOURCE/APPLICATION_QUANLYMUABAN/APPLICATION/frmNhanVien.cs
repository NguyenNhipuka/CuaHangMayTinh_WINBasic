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
    public partial class frmNhanVien : Form
    {
        SqlConnection con;
        public string manv = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    query = "SELECT * FROM NHANVIEN";
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
                dataGridView_DSNhanVien.DataSource = DATASET_DATABASE().Tables[0];
                int x = dataGridView_DSNhanVien.RowCount;
                for (int i = 1; i <= x; i++)
                {
                    dataGridView_DSNhanVien.Rows[i - 1].Cells[0].Value = i;
                }
                
            }
            catch { }


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
            txtMaNV.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cbbCV.Enabled = true;
           
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }



        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //cbbCV.SelectedText = "NHÂN VIÊN";
            cbbCV.SelectedItem = "NHÂN VIÊN";
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
            if(manv != "NV0001")
            {
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            loadToDatagridview();
            
        }



        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NV la 6 ky tu
            else
            {
                if (txtMaNV.TextLength >= 6)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }

            }

        }

        private void txtDThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                if (!char.IsDigit(e.KeyChar) || txtDThoai.TextLength >= 11 || char.IsWhiteSpace(e.KeyChar))/// so diện thoại phải nhỏ hơn 12
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsDigit(e.KeyChar) || txtHoTen.TextLength >= 59) /// không cho nhập số,quy dinh do dai cua họ tên NV lớn nhất  la 29 ky tu
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

        private void chkGTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// kiểm tra xem mã nhân viên có đúng định dạng là "NV0000": true : đúng mã, false : sai mã
        public bool kiemTraMA_NV(string s)
        {
            if (s.Length <6)
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                /// ---------------------------- điều kiện để thực thi
                if (txtMaNV.TextLength == 0 || txtDThoai.TextLength == 0 || txtDiaChi.TextLength == 0 || txtHoTen.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng điền đây đủ thông tin");
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    return;
                }
                if (kiemTraMA_NV(txtMaNV.Text) == false)
                {
                    MessageBox.Show("Mã nhân viên không đúng định dạng");
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
                    query = " select COUNT(*)  from NHANVIEN where MA_NV = '" + txtMaNV.Text + "'";
                    cmd = new SqlCommand(query, con);
                    x = (int)cmd.ExecuteScalar();
                    if (x == 1)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại");
                        return;
                    }
                    ///----------------------
                    if (chkGTinh.Checked == true)
                        query = " insert into NHANVIEN values ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + "NAM" + "',N'" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + "','" + txtDThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + cbbCV.SelectedItem.ToString() + "')";
                    else
                        query = " insert into NHANVIEN values ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + "NỮ" + "',N'" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + "','" + txtDThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + cbbCV.SelectedItem.ToString() + "')";

                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thành công","Thông báo");
                }
                loadToDatagridview();
                txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                txtMaNV.Enabled = false;
            }
            catch { }
           
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                /// ---------------------------- điều kiện để thực thi
                if ( txtDThoai.TextLength == 0 || txtDiaChi.TextLength == 0 || txtHoTen.TextLength == 0)
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
                    
                    if (chkGTinh.Checked == true)
                        query = " UPDATE NHANVIEN SET TEN_NV = N'" + txtHoTen.Text + "',PHAI = N'NAM',NGAYSINH = '" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + " ',DIACHI =N'" + txtDiaChi.Text + "',CHUCVU = N'" + cbbCV.SelectedItem.ToString() + "' ,DIENTHOAI ='"+txtDThoai.Text+"' WHERE MA_NV = '"+txtMaNV.Text+"'";
                    else
                        query = " UPDATE NHANVIEN SET TEN_NV = N'" + txtHoTen.Text + "',PHAI = N'NỮ',NGAYSINH = '" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + " ',DIACHI =N'" + txtDiaChi.Text + "',CHUCVU = N'" + cbbCV.SelectedItem.ToString() + "' ,DIENTHOAI ='" + txtDThoai.Text + "' WHERE MA_NV = '" + txtMaNV.Text + "'";
                    
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    if(txtMaNV.Text != "NV0001")
                    {
                        cmd = new SqlCommand("update TAIKHOAN_NV set CV = N'" + cbbCV.SelectedItem.ToString() + "' WHERE MA_NV = '" + txtMaNV.Text + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    
                    con.Close();
                    MessageBox.Show("Thành công","Thông bao");
                }
                loadToDatagridview();
                txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView_DSNhanVien.SelectedRows)
                {
                    if (dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString().Trim() == "NV0001")
                    {
                        MessageBox.Show("Bạn không thể xóa tài khoản này","Thông báo");
                        return;
                    }
                    DialogResult ok;
                    ok = MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString() + " ra khổi hệ thống không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ok == DialogResult.No)
                        return;
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                    {
                        con.Open();
                        //// kiem tra khoa ngoai
                        SqlCommand cmd = new SqlCommand( " select COUNT(*)  from HOADON_MUA where MA_NV = '" + txtMaNV.Text.ToString().Trim() + "'", con);
                        int x = (int)cmd.ExecuteScalar();
                        if (x != 0)
                        {
                            MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu","Thông báo");
                            return;
                        }
                        cmd = new SqlCommand(" select COUNT(*)  from HOADON_BAN where MA_NV = '" + txtMaNV.Text.ToString().Trim() + "'", con);
                        x = (int)cmd.ExecuteScalar();
                        if (x != 0)
                        {
                            MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu","Thông báo");
                            return;
                        }
                        //// -----------------------------------------
                        cmd = new SqlCommand("DELETE NHANVIEN WHERE MA_NV = '" + dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        dataGridView_DSNhanVien.Rows.RemoveAt(dataGridView_DSNhanVien.CurrentRow.Index);

                        cmd = new SqlCommand("delete TAIKHOAN_NV WHERE MA_NV = '" + txtMaNV.Text.ToString()+ "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Thành Công");
                        loadToDatagridview();

                    }
                }
            }
            catch { }
            
           
        }

        private void dataGridView_DSNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
          
            try
            {
                 foreach (DataGridViewRow row in dataGridView_DSNhanVien.SelectedRows)
                 {
                     
                     txtMaNV.Text = row.Cells[1].Value.ToString();
                     txtHoTen.Text = row.Cells[2].Value.ToString();
                     if (row.Cells[3].Value.ToString() == "NAM")
                         chkGTinh.Checked = true;
                     else
                         chkGTinh.Checked = false;
                     string date = row.Cells[4].Value.ToString();
                     DateTime x = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                     dateTimePicker1Ngaysinh.Value = x;
                     txtDThoai.Text = row.Cells[5].Value.ToString();
                     txtDiaChi.Text = row.Cells[6].Value.ToString();
                     cbbCV.SelectedItem = row.Cells[7].Value.ToString();
                     if (txtMaNV.Text.ToString().Trim() == "NV0001")/// không thể chỉnh sửa chức vụ của nhân viên có mã "NV0001"
                     {
                         cbbCV.Visible = false;
                         txtCV.Visible = true;
                     }
                     else
                     {
                         cbbCV.Visible = true;
                         txtCV.Visible = false;
                     }
                         
                 }
                
           }
            catch { }
        }
        private void dataGridView_DSNhanVien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = dataGridView_DSNhanVien.RowCount;
            for (int i = 1; i <= x; i++)
            {
                dataGridView_DSNhanVien.Rows[i - 1].Cells[0].Value = i;
            }
        }
           
            
        

    }
}
