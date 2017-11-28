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
    public partial class FrmHoaDonMuaHang : Form
    {
        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlConnection conn;
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        SqlDataAdapter da;
        SqlDataAdapter adapter;
        public string ma_nv = "";
        int dd = 0;
        int ddd = 0;
        public FrmHoaDonMuaHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.connectionstring);
            /// Dua NCC len

            da = new SqlDataAdapter("select * from NHACUNGCAP", conn);
            da.Fill(ds, "NHACUNGCAP");
            cbbTenNCC.DataSource = ds.Tables[0];


            cbbTenNCC.DisplayMember = "TEN_NCC";
            cbbTenNCC.ValueMember = "MA_NCC";
            if (ds.Tables[0].Rows.Count != 0)
                cbbTenNCC.SelectedItem = cbbTenNCC.Items[0];
                
            //// Dua thiet bi len

            SqlDataAdapter da2 = new SqlDataAdapter("select * from THIETBI", conn);
            da2.Fill(ds2,"THIETBI");
            // tao khoa chinh
            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds2.Tables["THIETBI"].Columns[1];
            ds2.Tables["THIETBI"].PrimaryKey = pk;

           
        }



        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHoaDonMuaHang_Load(object sender, EventArgs e)
        {
            txbMaNVHDMH.Text = ma_nv;
            txbMaHD.Text = TaoMaHDTuDong();
            showDataToCombobox_MA_TB();
            txtTongHD.Text = TONGTIENHD().ToString();
            
        }

        public string TaoMaHDTuDong()
        {
            
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionstring))
            {
                con.Open();
                string query = "SELECT MAX(MA_HDM) FROM  HOADON_MUA";
                cmd = new SqlCommand(query, con);
                adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable table = dataset.Tables[0];
                ///// stringmax chua ma hoa don mua lon nhat trong HOADON_MUA  
                string stringMax = table.Rows[0][0].ToString();
                if (stringMax == "")
                {
                    con.Close();
                    return "M000000000";
                }
                  
                ///// taoj ma ke tiep
                //// cat lay so, bo 'M'
                string x= (int.Parse( stringMax.Substring(1))+1).ToString();
                stringMax = "M";
                for (int i = 1; i <=9- x.Length; i++ )
                {
                    stringMax += '0';
                }
                stringMax += x;
                    con.Close();
                return stringMax;

            }
        }

       

        public void showDataToCombobox_MA_TB()
        {
            try
            {
                cbbMaTB.DataSource = null;
                if (cbbTenNCC.Items.Count != 0)
                {
                    string dieukienloc = "MA_NCC = '" + cbbTenNCC.SelectedValue + "'";
                    DataRow[] rows = ds2.Tables["THIETBI"].Select(dieukienloc);
                    table = null;
                    if (rows.Count() == 0)
                        return;
                    table = rows.CopyToDataTable();
                    cbbMaTB.DataSource = table;
                    cbbMaTB.DisplayMember = "MA_TB";
                    cbbMaTB.ValueMember = "MA_TB";
                    if (cbbMaTB.Items.Count != 0)
                    {
                        cbbMaTB.SelectedItem = cbbMaTB.Items[0];
                    }

                }
            }
            catch { }
           
        }


        
        private void cbbMaTB_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbMaTB.Items.Count == 0 || cbbMaTB.Items == null || ddd < 2)
                {
                    ddd++;

                    return;
                }
                if (cbbMaTB.SelectedItem == null)
                {
                    txtTenTB.Text = "";
                    txtLoai.Text = "";
                    txtTGBH.Text = "";
                    txtDonGiaMua.Text = "";
                    txtDGban.Text = "";
                }
                DataColumn[] pk = new DataColumn[1];
                pk[0] = table.Columns[1];
                table.PrimaryKey = pk;
                if (cbbMaTB.SelectedItem == null)
                    return;
                DataRow r = ds2.Tables["THIETBI"].Rows.Find(cbbMaTB.SelectedValue.ToString());
                if (r == null)
                    MessageBox.Show("k");
                // MessageBox.Show(r[1].ToString());
                txtTenTB.Text = r[2].ToString();
                txtLoai.Text = r[0].ToString();
                txtTGBH.Text = r[5].ToString();
                txtDonGiaMua.Text = r[6].ToString();
                txtDGban.Text = r[7].ToString();
            }
            catch { }
           
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                FrmQuanLyNCC fr = new FrmQuanLyNCC();
                fr.ShowDialog();
                da = new SqlDataAdapter("select * from NHACUNGCAP", conn);
                ds.Tables[0].Clear();
                da.Fill(ds, "NHACUNGCAP");
                cbbTenNCC.DataSource = ds.Tables[0];
                cbbTenNCC.DisplayMember = "TEN_NCC";
                cbbTenNCC.ValueMember = "MA_NCC";
                if (ds.Tables[0].Rows.Count != 0)
                    cbbTenNCC.SelectedItem = cbbTenNCC.Items[0];
                showDataToCombobox_MA_TB();
            }
            catch { }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaTB_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThemTenTB_Click(object sender, EventArgs e)
        {
            try
            {
                frmKhoTB fr = new frmKhoTB();
                fr.ShowDialog();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter da3 = new SqlDataAdapter("select * from THIETBI", conn);
                ds2.Tables["THIETBI"].Clear();
                da3.Fill(ds2, "THIETBI");

                // tao khoa chinh
                DataColumn[] pk = new DataColumn[1];
                pk[0] = ds2.Tables["THIETBI"].Columns[1];
                ds2.Tables["THIETBI"].PrimaryKey = pk;
                conn.Close();
                showDataToCombobox_MA_TB();
                //// cap nhat gia cho nhung thiet bi da duoc them

                int rowcount = dataGridView1.RowCount;
                if (cbbMaTB.Items.Count == 0)
                    dataGridView1.Rows.Clear();
                else
                {
                    //// kiem tra xem ma thiet bi nay co ton tai o nha cung cap nauy khong
                    for (int i = 0; i < rowcount; i++)
                    {
                        //MessageBox.Show((table.Rows.Contains(dataGridView1.Rows[0].Cells[0].Value.ToString()).ToString()));

                        if (table.Rows.Contains(dataGridView1.Rows[i].Cells[0].Value.ToString()) == false)
                        {
                            /// xoa hang da them
                            dataGridView1.Rows.RemoveAt(i);
                            rowcount--;
                            i--;
                        }

                    }

                }

                if (rowcount != 0)
                {
                    for (int i = 0; i < rowcount; i++)
                    {

                        DataRow r = ds2.Tables["THIETBI"].Rows.Find(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        if (r == null)
                            return;
                        double x = double.Parse(r[6].ToString());
                        dataGridView1.Rows[i].Cells[4].Value = x;
                        x = double.Parse(r[7].ToString());
                        dataGridView1.Rows[i].Cells[5].Value = x;
                        dataGridView1.Rows[i].Cells[3].Value = int.Parse(r[5].ToString());
                        dataGridView1.Rows[i].Cells[1].Value = r[2].ToString();
                    }
                }
            }
            catch { }
            

        }

        private void btnThemHDMH_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbMaTB.Items.Count == 0)
                {
                    MessageBox.Show("Nhà cung cấp chưa cung cấp thiết bị nào.Bạn hãy thêm thiết bị và sau đó lập hóa đơn mua");
                    return;
                }
                if (txtSoLuong.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa điền số lượng thiết bị trong hóa đơn");
                    return;
                }
                else
                {
                    if (int.Parse(txtSoLuong.Text) == 0)
                    {
                        MessageBox.Show("Số lượng thiết bị trong đơn hàng phải lớn hơn 0. Vui Lòng sửa lại");
                        return;
                    }
                }
                if (cbbMaTB.SelectedItem == null)
                {
                    MessageBox.Show("Mã thiết bị không thuộc nhà cung cấp này");
                    return;
                }
                if (cbbTenNCC.SelectedItem == null)
                {
                    MessageBox.Show("Không có nhà cung cấp này");
                    return;
                }
                int rowcount = dataGridView1.Rows.Count;
                if (rowcount != 0)
                {
                    for (int i = 0; i < rowcount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cbbMaTB.SelectedValue.ToString())
                        {
                            MessageBox.Show("Thiết bị đã được thêm. Vui lòng chọn thiết bị khác hoặc sửa lại hóa đơn đã nhập");
                            return;
                        }
                    }
                }
                double thanhtien = int.Parse(txtSoLuong.Text) * double.Parse(txtDonGiaMua.Text);
                dataGridView1.Rows.Add(cbbMaTB.SelectedValue.ToString(), txtTenTB.Text, int.Parse(txtSoLuong.Text), int.Parse(txtTGBH.Text), double.Parse(txtDonGiaMua.Text), double.Parse(txtDGban.Text), thanhtien);
                txtTongHD.Text = TONGTIENHD().ToString();
            }
            catch { }  
        }

        private void cbbTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            // bo qua 2 lan cbbTenNCC khi khoi tao
            if (dd == 0 || dd==1)
            {
                dd++;
                return;
            }
            else
            {
                
                showDataToCombobox_MA_TB();
                
            }
            
            /////
            if(dataGridView1.Rows.Count !=0)
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn có muốn lưu thiết bị đã nhập không", "SAVE", MessageBoxButtons.YesNo);
                if(ok == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }

        public double TONGTIENHD()
        {
            int rowcount = dataGridView1.Rows.Count;
            if (rowcount == 0)
                return 0;
            double tong = 0;
            for (int i = 0; i < rowcount; i++)
            {
                tong += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            return tong;
        }

        private void cbbTenNCC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaHDMH_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbMaTB.Items.Count.ToString());
            int rowcount = dataGridView1.RowCount;
            if (rowcount  ==0)
            {
                MessageBox.Show("Chưa chọn dữ liệu hoặc đơn hàng trống.");
                return;
            }
            if (dataGridView1.SelectedRows != null)
            {
                for(int i=0 ;i<rowcount;i++ )
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cbbMaTB.SelectedValue.ToString() )
                    {
                        dataGridView1.Rows[i].Cells[2].Value = int.Parse(txtSoLuong.Text.ToString());
                    }
                }
            }

        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Hoá đơn chưa có thiết bị");
                    return;
                }
                
                string query = "SET DATEFORMAT DMY INSERT INTO HOADON_MUA VALUES ('" + txbMaHD.Text.ToString() + "','" + cbbTenNCC.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "'," + double.Parse(txtTongHD.Text.ToString()) + ",'" + txbMaNVHDMH.Text.ToString() + "') ";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                int rowcount = dataGridView1.RowCount;
                for (int i = 0; i < rowcount; i++)
                {
                    query = "insert into CHITIET_HDM values ('" + txbMaHD.Text.ToString().Trim() + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'," + dataGridView1.Rows[i].Cells[2].Value.ToString() + "," + dataGridView1.Rows[i].Cells[4].Value.ToString() + "," + dataGridView1.Rows[i].Cells[6].Value.ToString() + ")";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    query = "UPDATE THIETBI SET  SOLUONG += " + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + " where MA_TB = '" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }


                conn.Close();
                DialogResult ok;
                ok = MessageBox.Show("Thành công. Bạn có muốn in không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    frmXuatHoaDonNHap fr = new frmXuatHoaDonNHap();
                    fr.Ma_HD = txbMaHD.Text.ToString().Trim();
                    fr.ShowDialog();
                }
                dataGridView1.Rows.Clear();
                txtTongHD.Text = "0";
                txbMaHD.Text = TaoMaHDTuDong();
            }
            catch { }
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {

            btnThemTenTB_Click(sender, e);
            //// cap nhat gia cho nhung thiet bi da duoc them
            int rowcount = dataGridView1.RowCount;
            if(rowcount != 0)
            {
                for(int i=0; i<rowcount; i++)
                {
                     DataRow r = ds2.Tables["THIETBI"].Rows.Find(dataGridView1.Rows[i].Cells[0].Value.ToString());
                      if (r == null)
                             return;
                    double x =double.Parse( r[6].ToString());
                    dataGridView1.Rows[i].Cells[4].Value = x;
                    x=double.Parse( r[7].ToString());
                    dataGridView1.Rows[i].Cells[5].Value = x;
                    dataGridView1.Rows[i].Cells[3].Value = int.Parse(r[5].ToString());
                    dataGridView1.Rows[i].Cells[1].Value = r[2].ToString();
                }
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                return;
            }
            try
            {
                int x = int.Parse(txtSoLuong.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtSoLuong.Text = "0";
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                return;

            cbbMaTB.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value;
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void cbbMaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaHDMH_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

        }
    }
}
