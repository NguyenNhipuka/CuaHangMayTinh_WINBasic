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
    public partial class frmKhoTB : Form
    {

        public  string Chu_vu = "";
        string query = "";
       SqlCommand cmd;
       public bool chichoxemvabc = false;
        public frmKhoTB()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnKetThuc_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
                    query = "SELECT LOAI,MA_TB,TEN_TB,TEN_NCC,SOLUONG,TG_BAOHANH,DONGIA_MUA,DONGIA_BAN,NSX, THIETBI.MA_NCC FROM THIETBI, NHACUNGCAP WHERE NHACUNGCAP.MA_NCC = THIETBI.MA_NCC";
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
                dataGridView2DSTB.DataSource = DATASET_DATABASE().Tables[0];
            }
            catch { }


        }



   
        private void frmKhoTB_Load(object sender, EventArgs e)
        {
            btnIN.Visible = false;
            btnHienThiALL_Click(sender, e);
            showDataToCombobox();
            txtMaTB.Enabled = false;
            btnLưu.Enabled = false;
            ///// để làm from thống kê hàng tồn kho
            if (chichoxemvabc == true)
            {
                Chu_vu = "NHÂN VIÊN";
                lblTenForm.Text = "TRÌNH TRẠNG THIẾT BỊ TRONG KHO";
            }

            /////////////////////from Thiết bị
            if(Chu_vu == "NHÂN VIÊN")
            {
                groupBox1.Enabled = false;
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char.IsDigit(e.KeyChar) && txtMaTB.TextLength <6) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FrmQuanLyNCC fr = new FrmQuanLyNCC();
            fr.ShowDialog();
        }


        /// kiểm tra tồn tại mã thiết bị
        public bool kiemTraMa_TB(string ma_tb)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
            {
                con.Open();

                int x = 0;
                ///kiem tra mã thiết bị
                query = " SELECT count(*) FROM THIETBI WHERE MA_TB = '"+ma_tb+"'";
                cmd = new SqlCommand(query, con);
                x = (int)cmd.ExecuteScalar();
                con.Close();
                if (x == 1)
                    return true;//  ton tai
                return false;
               
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatbi.TextLength != 6)
            {
                MessageBox.Show("Mã thiết bị không đúng. Vui lòng nhập lại.\nGợi ý: Mã thiết bị là số gồm có 6 chữ số. \n Ví dụ: mã thiết bị: '000001","Thông báo");
                return;
            }
                 using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                 {
                     con.Open();


                     if (kiemTraMa_TB(txtmatbi.Text.Trim()) == false)
                     {
                         MessageBox.Show("Không có mã thiết bị này trong kho");
                         return;
                     }
                     //// xóa toan bộ thông tin trong datagridviewThIETBI
                     int count = dataGridView2DSTB.Rows.Count;
                     for (int i = count - 1; i >= 0; i--)
                     {
                         dataGridView2DSTB.Rows.RemoveAt(i);
                     }
                     ////---------------------------------------
                     //// hiển thị thông tin thiết bị  cần tìm lên datagridview
                     DataSet data = new DataSet();
                     query = "SELECT LOAI,MA_TB,TEN_TB,TEN_NCC,SOLUONG,TG_BAOHANH,DONGIA_MUA,DONGIA_BAN,NSX FROM THIETBI, NHACUNGCAP WHERE MA_TB = '" + txtmatbi.Text.Trim() + "' and NHACUNGCAP.MA_NCC = THIETBI.MA_NCC";
                     SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                     adapter.Fill(data);
                     dataGridView2DSTB.DataSource = data.Tables[0];
                     dataGridView2DSTB_Click(sender, e);
                     con.Close();
                 }
            }
            catch { }
           
            
        }

        public void DanhDauSoLuong()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.White;
            int rc = dataGridView2DSTB.RowCount;
            if (rc == 0)
            {
                richTbTrinhTrangDh.Visible = true;
            }
            else
            {
                for (int i = 0; i < rc; i++)
                {
                    int sluong = int.Parse(dataGridView2DSTB.Rows[i].Cells[4].Value.ToString());
                    if (sluong < 5)
                    {
                        dataGridView2DSTB.Rows[i].DefaultCellStyle = style;
                        richTbTrinhTrangDh.Visible = true;
                    }
                }

            }
        }
        private void btnHienThiALL_Click(object sender, EventArgs e)
        {
            loadToDatagridview();
            DanhDauSoLuong();// tô đỏ các thiết bị có số lượng nhỏ hơn 5
           
        }

         ///đưa dữ liệu từ CSDL lên combobox
        public void showDataToCombobox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    string query = "  SELECT MA_NCC,TEN_NCC FROM NHACUNGCAP";
                    cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter;
                    adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cbbTenNCC.DataSource = table;
                    cbbTenNCC.ValueMember = "MA_NCC";
                    cbbTenNCC.DisplayMember = "TEN_NCC";
                    cbbTenNCC.SelectedItem = cbbTenNCC.Items[0];
                    con.Close();
                }
            }
            catch { }
          


        }

        private void cbbTenNCC_Click(object sender, EventArgs e)
        {
            showDataToCombobox();
        }

        /// chỉ được xóa thiết bị khi trong hóa đơn mua, bán không chứa nó
        public bool KiemTraDieuKienXoa()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
            {
                con.Open();
                string query = "SELECT count(MA_TB) FROM CHITIET_HDB where MA_TB = '"+txtMaTB.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                int TontaiHDB = (int) cmd.ExecuteScalar();

                query = "SELECT count(MA_TB) FROM CHITIET_HDM where MA_TB = '" + txtMaTB.Text + "'";
                cmd = new SqlCommand(query, con);
                int TontaiHDM = (int)cmd.ExecuteScalar();
                con.Close();
                if(TontaiHDB ==0 && TontaiHDM == 0)/// mã thiết bị này không tồn tại trong hóa đon mua hoặc bán
                {
                    return true;/////=> Được xóa
                }

                return false;////=>k  Được xóa
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2DSTB.SelectedRows)
                {
                    DialogResult ok;
                    ok = MessageBox.Show("Bạn có muốn xóa thiết bị có mã " + dataGridView2DSTB.CurrentRow.Cells[1].Value.ToString() + " khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ok == DialogResult.No)
                        return;
                    if(KiemTraDieuKienXoa() == false)
                    {
                        MessageBox.Show("Không thể xóa thiết bị này khỏi hệ thống. Mã thiết bị này chứa thông tin phục vụ thệ thống", "Thông báo");
                        return;
                    }
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                    {
                        con.Open();
                        string query = "DELETE THIETBI WHERE MA_TB = '" + dataGridView2DSTB.CurrentRow.Cells[1].Value.ToString().Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        dataGridView2DSTB.Rows.RemoveAt(dataGridView2DSTB.CurrentRow.Index);
                        con.Close();
                        MessageBox.Show("Xóa thành công","Thông báo");
                        loadToDatagridview();

                    }
                }
            }
            catch { }
        }

        private void btnLưu_Click(object sender, EventArgs e)
        {
            
            try
            {
                /// ---------------------------- điều kiện để thực thi
                if (txtMaTB.TextLength != 6 || txtLoai.TextLength == 0 || txtDonGiaMua.TextLength == 0 || txtDonGiaBan.TextLength == 0  || txtSoluong.TextLength == 0 || txtTenTB.TextLength == 0 || txtThoiGianBH.TextLength == 0 || txtNSX.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng điền đây đủ thông tin","Thông báo");
                    return;
                }
                if (kiemTraMa_TB(txtMaTB.Text) == true)
                {
                    MessageBox.Show("Mã thiết bị đã tồn tại. Vui lòng nhập mã khác","Thông báo");
                    return;
                }
                ////------------------------------------------------end điều kiện
                
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                {
                    con.Open();
                    int x = int.Parse(txtThoiGianBH.Text);
                    double s = double.Parse(txtDonGiaBan.Text);
                    query = " INSERT INTO THIETBI VALUES(N'" + txtLoai.Text.Trim() + "','" + txtMaTB.Text + "',N'" + txtTenTB.Text.Trim() + "','" + cbbTenNCC.SelectedValue.ToString().Trim() + "',"+int.Parse(txtSoluong.Text)+","+int.Parse(txtThoiGianBH.Text)+","+int.Parse(txtDonGiaMua.Text)+","+int.Parse(txtDonGiaBan.Text)+",N'"+txtNSX.Text+"')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    /////=====================
                    con.Close();
                    MessageBox.Show("Thiết bị này đã được thêm với mã là: " + txtMaTB.Text ,"Thông báo");
                }
                loadToDatagridview();
                txtMaTB.Text = txtLoai.Text= txtDonGiaMua.Text = txtDonGiaBan.Text = txtSoluong.Text =txtTenTB.Text=txtThoiGianBH.Text=txtNSX.Text = string.Empty;
            }
            catch { }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            /// chua co thiet bi naoo de sua
            if(dataGridView2DSTB.CurrentRow == null)
            {
                return;

            }

            try
            {
                    /// ---------------------------- điều kiện để thực thi
                    if (txtMaTB.Text ==string.Empty || txtLoai.Text ==""|| txtDonGiaMua.Text ==""|| txtDonGiaBan.Text ==""|| txtSoluong.Text ==""|| txtTenTB.Text == ""||  txtThoiGianBH.Text ==""|| txtNSX.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng điền đây đủ thông tin");
                        return;
                    }
                    ////------------------------------------------------end điều kiện
                    
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
                    {
                        con.Open();
                        string query = "";
                        SqlCommand cmd;

                        ///----------------------

                        query = " UPDATE THIETBI SET TEN_TB = N'" + txtTenTB.Text.Trim() + "',MA_NCC = '" + cbbTenNCC.SelectedValue.ToString() + "',LOAI = N'" + txtLoai.Text + "', TG_BAOHANH = '" + int.Parse(txtThoiGianBH.Text) + "', DONGIA_MUA= '" + double.Parse(txtDonGiaMua.Text) + "',DONGIA_BAN='" + double.Parse(txtDonGiaBan.Text) + "' ,NSX = '" + txtNSX.Text + "'WHERE MA_TB = '" + dataGridView2DSTB.CurrentRow.Cells["Column1"].Value.ToString().Trim() + "'";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    loadToDatagridview();

            }
            catch { }
        }

        private void dataGridView2DSTB_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Hủy thêm mới")
                return;
            if (dataGridView2DSTB.RowCount != 0)
            {
                txtMaTB.Text = dataGridView2DSTB.CurrentRow.Cells["Column1"].Value.ToString();
                txtTenTB.Text = dataGridView2DSTB.CurrentRow.Cells["Column2"].Value.ToString();
                txtLoai.Text = dataGridView2DSTB.CurrentRow.Cells["Column13"].Value.ToString();
                txtSoluong.Text = dataGridView2DSTB.CurrentRow.Cells["Column15"].Value.ToString();
                txtThoiGianBH.Text = dataGridView2DSTB.CurrentRow.Cells["Column16"].Value.ToString();
                txtDonGiaMua.Text = dataGridView2DSTB.CurrentRow.Cells["Column17"].Value.ToString();
                txtDonGiaBan.Text = dataGridView2DSTB.CurrentRow.Cells["Column18"].Value.ToString();
                txtNSX.Text = dataGridView2DSTB.CurrentRow.Cells["Column19"].Value.ToString(); 
                cbbTenNCC.SelectedValue = dataGridView2DSTB.CurrentRow.Cells["Column20"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTB.Text = txtLoai.Text = txtDonGiaMua.Text = txtDonGiaBan.Text = txtSoluong.Text = txtTenTB.Text = txtThoiGianBH.Text = txtNSX.Text = string.Empty;
            if (btnThem.Text == "Thêm mới")
            {
                btnThem.Text = "Hủy thêm mới";
                btnLưu.Enabled = true;
                txtMaTB.Enabled = true;
            }
            else
            {
                btnThem.Text = "Thêm mới";
                btnLưu.Enabled = false;
                txtMaTB.Enabled = false;
                dataGridView2DSTB_Click(sender, e);
            }

        }

        private void txtmatbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) && txtmatbi.TextLength < 6) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtThoiGianBH_KeyDown(object sender, KeyEventArgs e)
        {
            /// khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtThoiGianBH_TextChanged(object sender, EventArgs e)
        {
            if (txtThoiGianBH.Text == "")
                return;
            try
            {
                int x = int.Parse(txtThoiGianBH.Text.ToString());
            }
            catch
            {
                txtThoiGianBH.Text = "";
            }
        }

        private void txtSoluong_KeyDown(object sender, KeyEventArgs e)
        {
            /// khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtDonGiaMua_KeyDown(object sender, KeyEventArgs e)
        {
            /// khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtDonGiaBan_KeyDown(object sender, KeyEventArgs e)
        {
            /// khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtmatbi_KeyDown(object sender, KeyEventArgs e)
        {
            /// khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtMaTB_TextChanged(object sender, EventArgs e)
        {
            if (txtMaTB.Text == "")
                return;
           
            try
            {
                int x = int.Parse(txtMaTB.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtMaTB.Text = "";
            }
        }

      
        private void txtDonGiaMua_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaMua.TextLength == 0)
                return;
            try
            {
                double x = double.Parse(txtDonGiaMua.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtDonGiaMua.Text = "0";
            }
        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaBan.TextLength == 0)
                return;
            try
            {
                double x = double.Parse(txtDonGiaBan.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtDonGiaBan.Text = "0";
            }
        }

        private void txtmatbi_TextChanged(object sender, EventArgs e)
        {
            if (txtmatbi.Text == "")
                return;
          
            try
            {
                int x = int.Parse(txtmatbi.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtmatbi.Text = "";
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtThoiGianBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "")
            {
                return;
            }
            try
            {
                int x = int.Parse(txtSoluong.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtSoluong.Text = "0";
            }
        }

        private void richTbTrinhTrangDh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIN_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2DSTB_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DanhDauSoLuong();
        }

    }
}
