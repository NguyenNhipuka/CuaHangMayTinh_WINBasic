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
    public partial class frmThongKeThuChi : Form
    {
        SqlConnection con;
        SqlDataAdapter da1,da2;
        DataSet ds;
        DataTable tablethu,tableao_thu,tablechi,tableao_chi;
        string query = "";
        int khoitao = 0;
        public frmThongKeThuChi()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
            try
            {
                ///LOAD CSDL HÓA ĐƠN BÁN LÊN
                query = "SET DATEFORMAT dmy SELECT  MA_HDB,NGAYLAP, TEN_NV,TRIGIA_HDB FROM HOADON_BAN,NHANVIEN WHERE HOADON_BAN.MA_NV = NHANVIEN.MA_NV";
                da1 = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da1.Fill(ds);

                tablethu = new DataTable();//// table loc theo dieu kien
                tablethu = ds.Tables[0];

                tableao_thu = new DataTable();/// table hien trong datagirdview
                tableao_thu = tablethu.Copy();

                ////// load CSDL HÓA ĐƠN MUA lên
                query = "SET DATEFORMAT dmy SELECT  MA_HDM,NGAYLAP, TEN_NV,TRIGIA_HDM FROM HOADON_MUA,NHANVIEN WHERE HOADON_MUA.MA_NV = NHANVIEN.MA_NV";
                da2 = new SqlDataAdapter(query, con);
                da2.Fill(ds, "CHI");

                tablechi = new DataTable();//// table loc theo dieu kien
                tablechi = ds.Tables["CHI"];

                tableao_chi = new DataTable();////table hien trong datagirdview
                tableao_chi = tablechi.Copy();
            }
            catch { }
           

            
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Thống kê thu ////////////////////////////////////
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTrongNgay1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbTrongNgay1.Checked == true)
                {
                    Delete_rowin_datagridviewDSThu();
                    dateTimePicker1TuNgay1_1.Enabled = true;
                    cbbThang1.Enabled = false;
                    TextBox2Nam1.Enabled = false;
                    dateTimePicker2DenNgay1_2.Enabled = false;
                    txtChiPhi.Text = "0";

                }
            }
            catch { }
           
            
        }

        private void rdbTrongThang1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbTrongThang1.Checked == true)
                {
                    dateTimePicker2DenNgay1_2.Enabled = dateTimePicker1TuNgay1_1.Enabled = false;
                    TextBox2Nam1.Enabled = true;
                    cbbThang1.Enabled = true;
                    txtChiPhi.Text = "0";
                }
            }
            catch { }
           
            
        }

        private void rdbTrongNam1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbTrongNam1.Checked == true)
                {
                    Delete_rowin_datagridviewDSThu();
                    dateTimePicker2DenNgay1_2.Enabled = dateTimePicker1TuNgay1_1.Enabled = false;
                    TextBox2Nam1.Enabled = true;
                    cbbThang1.Enabled = false;
                    txtChiPhi.Text = "0";
                }
            }
            catch { }
         
           
        }

        private void rdbKhoangTg1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbKhoangTg1.Checked == true)
                {
                    Delete_rowin_datagridviewDSThu();
                    dateTimePicker2DenNgay1_2.Enabled = dateTimePicker1TuNgay1_1.Enabled = true;
                    TextBox2Nam1.Enabled = false;
                    cbbThang1.Enabled = false;
                    txtChiPhi.Text = "0";
                }
            }
            catch { }
         
        }

        private void frmThongKeThuChi_Load(object sender, EventArgs e)
        {
            try
            {
                rdbTatca.Checked = true;
                cbbThang1.SelectedItem = cbbThang1.Items[0];
                TaoSTT_DS1();

                rdbTatCa2.Checked = true;
                cbbThang2.SelectedItem = cbbThang2.Items[0];
                TaoSTT_DS2();
            }
            catch { }
           
        }

        private void rdbTatca_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbTatca.Checked == true)
                {

                    dateTimePicker1TuNgay1_1.Enabled = dateTimePicker2DenNgay1_2.Enabled = TextBox2Nam1.Enabled = false;
                    cbbThang1.Enabled = false;
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Chưa có phiếu bán hàng nào");
                        return;
                    }
                    
                    Delete_rowin_datagridviewDSThu();
                    tableao_thu = ds.Tables[0].Copy();
                    dataGridView1DSDSThu.DataSource = tableao_thu;
                    TaoSTT_DS1();

                }
                else
                {
                    Delete_rowin_datagridviewDSThu();
                }
            }
            catch { }
           
        }


        public void LoadToDataGridViewThu(DataTable datatable)
        {
            dataGridView1DSDSThu.DataSource = datatable;
            TaoSTT_DS1();
        }
        public void Delete_rowin_datagridviewDSThu()
        {
            try
            {
                txtChiPhi.Text = "0";
                for (int i = 0; i < tableao_thu.Rows.Count; i++)
                {
                    tableao_thu.Rows.RemoveAt(i);
                    i--;
                }
            }
            catch { }
          
        }
       
        public void TaoSTT_DS1()
        {
            try
            {
                double tongtien = 0;
                int rowcount = dataGridView1DSDSThu.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    dataGridView1DSDSThu.Rows[i].Cells[0].Value = i + 1;

                    double x = double.Parse(dataGridView1DSDSThu.Rows[i].Cells[4].Value.ToString());
                    tongtien += x;
                }
                txtChiPhi.Text = tongtien.ToString();
            }
            catch { }
            
        }

        private void dataGridView1DS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaoSTT_DS1();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
           //try
           //{
               if (dataGridView1DSDSThu.RowCount == 0)
                   return;
               using (SqlConnection conn = new SqlConnection(ConnectionString.connectionstring))
               {
                   conn.Open();
                   SqlCommand cmd;
                   query = "DELETE BAOCAOTHUCHI";
                   cmd = new SqlCommand(query, conn);
                   cmd.ExecuteNonQuery();
                   for (int i = 0; i < dataGridView1DSDSThu.RowCount; i++)
                   {
                       DateTime t = DateTime.Parse(dataGridView1DSDSThu.Rows[0].Cells[2].Value.ToString());
                       query = "SET DATEFORMAT DMY INSERT INTO BAOCAOTHUCHI VALUES ('" + dataGridView1DSDSThu.Rows[i].Cells[1].Value.ToString() + "','" + t.ToShortDateString() + "'," + double.Parse(dataGridView1DSDSThu.Rows[i].Cells[4].Value.ToString()) + ",N'" + dataGridView1DSDSThu.Rows[i].Cells[3].Value.ToString() + "','" + double.Parse(txtChiPhi.Text) + "')";
                       cmd = new SqlCommand(query, conn);
                       cmd.ExecuteNonQuery();
                   }

                   frmXuatBaoCaoThu_Chi fr = new frmXuatBaoCaoThu_Chi();
                   fr.ShowDialog();
                   query = "DELETE BAOCAOTHUCHI";
                   cmd = new SqlCommand(query, conn);
                   cmd.ExecuteNonQuery();
                   con.Close();
               }
           //}
           //catch { }
            
           
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbTatca.Checked == true)
                    return;
                if (rdbTrongNgay1.Checked == true)
                {
                    #region Ngay
                    DateTime d = new DateTime();
                    d = dateTimePicker1TuNgay1_1.Value;
                    string qe = "NGAYLAP = '" + d + "'";
                    DataRow[] r = ds.Tables[0].Select(qe);
                    if (r.Count() == 0)
                    {
                        MessageBox.Show("Không có phiếu thu vào ngày này");
                        return;
                    }
                    tablethu = r.CopyToDataTable();
                    tableao_thu = tablethu.Copy();
                    LoadToDataGridViewThu(tableao_thu);
                    #endregion
                }
                else
                {
                    if (rdbTrongThang1.Checked == true)
                    {

                        #region Tháng
                        int thang = int.Parse(cbbThang1.SelectedItem.ToString());
                        int nam = int.Parse(TextBox2Nam1.Text);
                        if (nam < 2010)
                        {
                            MessageBox.Show("Năm phải lớn hon năm 2009");
                            return;
                        }
                        DateTime t = new DateTime(nam, thang, 1);
                        DateTime t2;
                        if (thang != 12)
                            t2 = new DateTime(nam, (thang + 1), 1);
                        else
                            t2 = new DateTime(nam + 1, 1, 1);
                        string qe = "NGAYLAP >= '" + t + "'" + "and NGAYLAP <'" + t2 + "'";
                        DataRow[] r = ds.Tables[0].Select(qe);
                        if (r.Count() == 0)
                        {
                            MessageBox.Show("Không có phiếu thu vào ngày này");
                            return;
                        }
                        tablethu = r.CopyToDataTable();
                        tableao_thu = tablethu.Copy();
                        LoadToDataGridViewThu(tableao_thu);
                        #endregion
                    }
                    else
                    {
                        if (rdbTrongNam1.Checked == true)
                        {
                            #region Năm
                            int nam = int.Parse(TextBox2Nam1.Text);
                            if (nam < 2010)
                            {
                                MessageBox.Show("Năm phải lớn hon năm 2009");
                                return;
                            }
                            DateTime t1 = new DateTime(nam, 1, 1);
                            DateTime t2 = new DateTime(nam + 1, 1, 1);
                            string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <'" + t2 + "'";
                            DataRow[] r = ds.Tables[0].Select(qe);
                            if (r.Count() == 0)
                            {
                                MessageBox.Show("Không có phiếu thu vào ngày này");
                                return;
                            }
                            tablethu = r.CopyToDataTable();
                            tableao_thu = tablethu.Copy();
                            LoadToDataGridViewThu(tableao_thu);
                            #endregion
                        }
                        else
                        {
                            #region Thời Gian
                            DateTime t1 = dateTimePicker1TuNgay1_1.Value;
                            DateTime t2 = dateTimePicker2DenNgay1_2.Value;
                            string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <='" + t2 + "'";
                            DataRow[] r = ds.Tables[0].Select(qe);
                            if (r.Count() == 0)
                            {
                                MessageBox.Show("Không có phiếu thu vào ngày này");
                                return;
                            }
                            tablethu = r.CopyToDataTable();
                            tableao_thu = tablethu.Copy();
                            LoadToDataGridViewThu(tableao_thu);
                            #endregion
                        }
                    }
                }
                TaoSTT_DS1();
            }
            catch { }
           
        }

        private void tabPage1Thu_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2Nam1_KeyDown(object sender, KeyEventArgs e)
        {
            // khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void TextBox2Nam1_TextChanged(object sender, EventArgs e)
        {
            Delete_rowin_datagridviewDSThu();
            if (TextBox2Nam1.Text == "")
                return;

            try
            {
                int x = int.Parse(TextBox2Nam1.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                TextBox2Nam1.Text = "";
            }
        }

        private void TextBox2Nam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) && TextBox2Nam1.TextLength < 4) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        ///////////Thống kê chi/////
        private void rdbTatCa2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbTatCa2.Checked == true)
                {

                    dateTimePicker2Ngay21.Enabled = dateTimePicker1Ngay22.Enabled = txtNam2.Enabled = false;
                    cbbThang2.Enabled = false;
                    if (ds.Tables["CHI"].Rows.Count == 0)
                    {
                        MessageBox.Show("Chưa có phiếu mua hàng nào");
                        return;
                    }
                    //tableao_chi = null;
                    Delete_rowin_datagridviewDSChi();
                    tableao_chi = ds.Tables["CHI"].Copy();
                    dataGridView1DS2.DataSource = tableao_chi;
                    TaoSTT_DS2();
                }
                else
                {
                    Delete_rowin_datagridviewDSThu();
                }
            }
            catch { }
           
        }

        private void txtNam2_KeyDown(object sender, KeyEventArgs e)
        {
            // khong cho Ctr+v
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtNam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) && txtNam2.TextLength < 4) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNam2_TextChanged(object sender, EventArgs e)
        {
            Delete_rowin_datagridviewDSChi();
            if (txtNam2.Text == "")
                return;

            try
            {
                int x = int.Parse(txtNam2.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtNam2.Text = "";
            }
        }


        public void Delete_rowin_datagridviewDSChi()
        {
            txtCP.Text = "0";
            for (int i = 0; i < tableao_chi.Rows.Count; i++)
            {
                tableao_chi.Rows.RemoveAt(i);
                i--;
            }
        }
        private void rdbNgay2_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbNgay2_2.Checked == true)
                {
                    Delete_rowin_datagridviewDSChi();
                    dateTimePicker2Ngay21.Enabled = true;
                    cbbThang2.Enabled = false;
                    txtNam2.Enabled = false;
                    dateTimePicker1Ngay22.Enabled = false;
                    txtCP.Text = "0";
                }
            }
            catch { }
          
        }

        private void rdbThang_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbThang_2.Checked == true)
                {
                    Delete_rowin_datagridviewDSChi();
                    dateTimePicker2Ngay21.Enabled = dateTimePicker1Ngay22.Enabled = false;
                    txtNam2.Enabled = true;
                    cbbThang2.Enabled = true;
                    txtCP.Text = "0";
                }
            }
            catch { }
          
        }

        private void rdbNam22_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbNam22.Checked == true)
                {
                    Delete_rowin_datagridviewDSChi();
                    dateTimePicker2Ngay21.Enabled = dateTimePicker1Ngay22.Enabled = false;
                    txtNam2.Enabled = true;
                    cbbThang2.Enabled = false;
                    txtCP.Text = "0";
                }
            }
            catch { }
           
        }

        private void rdbKhoanTG22_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbKhoanTG22.Checked == true)
                {
                    Delete_rowin_datagridviewDSChi();
                    dateTimePicker2Ngay21.Enabled = dateTimePicker1Ngay22.Enabled = true;
                    txtNam2.Enabled = false;
                    cbbThang2.Enabled = false;
                    txtCP.Text = "0";
                }
            }
            catch { }
            
        }

        public void LoadToDataGridViewChi(DataTable datatable)
        {

            dataGridView1DS2.DataSource = datatable;
            TaoSTT_DS2();
        }
        public void TaoSTT_DS2()
        {
            try
            {
                double tongtien = 0;
                int rowcount = dataGridView1DS2.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    dataGridView1DS2.Rows[i].Cells[0].Value = i + 1;
                    double x = double.Parse(dataGridView1DS2.Rows[i].Cells[4].Value.ToString());
                    tongtien += x;
                }
                txtCP.Text = tongtien.ToString();
            }
            catch { }
            
        }

        private void dataGridView1DS2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaoSTT_DS2();
        }

        private void tabControl1Chi_Click(object sender, EventArgs e)
        {
            rdbTatca_CheckedChanged(sender, e);
            rdbTatCa2_CheckedChanged(sender, e);
            TaoSTT_DS2();
            TaoSTT_DS1();
        }

        private void btnTK2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbTatCa2.Checked == true)
                    return;
                if (rdbNgay2_2.Checked == true)
                {
                    #region Ngay
                    DateTime d = new DateTime();
                    d = dateTimePicker2Ngay21.Value;
                    string qe = "NGAYLAP = '" + d + "'";
                    DataRow[] r = ds.Tables["CHI"].Select(qe);
                    if (r.Count() == 0)
                    {
                        MessageBox.Show("Không có phiếu chi vào ngày này");
                        return;
                    }
                    tablechi = r.CopyToDataTable();
                    tableao_chi = tablechi.Copy();
                    LoadToDataGridViewChi(tableao_chi);
                    #endregion
                }
                else
                {
                    if (rdbThang_2.Checked == true)
                    {

                        #region Tháng
                        int thang = int.Parse(cbbThang2.SelectedItem.ToString());
                        int nam = int.Parse(txtNam2.Text);
                        if (nam < 2010)
                        {
                            MessageBox.Show("Năm phải lớn hon năm 2009");
                            return;
                        }
                        DateTime t = new DateTime(nam, thang, 1);
                        DateTime t2;
                        if (thang != 12)
                            t2 = new DateTime(nam, (thang + 1), 1);
                        else
                            t2 = new DateTime(nam + 1, 1, 1);
                        string qe = "NGAYLAP >= '" + t + "'" + "and NGAYLAP <'" + t2 + "'";
                        DataRow[] r = ds.Tables["CHI"].Select(qe);
                        if (r.Count() == 0)
                        {
                            MessageBox.Show("Không có phiếu chi vào tháng này");
                            return;
                        }
                        tablechi = r.CopyToDataTable();
                        tableao_chi = tablechi.Copy();
                        LoadToDataGridViewChi(tableao_chi);
                        #endregion
                    }
                    else
                    {
                        if (rdbNam22.Checked == true)
                        {
                            #region Năm
                            int nam = int.Parse(txtNam2.Text);
                            if (nam < 2010)
                            {
                                MessageBox.Show("Năm phải lớn hơn năm 2009");
                                return;
                            }
                            DateTime t1 = new DateTime(nam, 1, 1);
                            DateTime t2 = new DateTime(nam + 1, 1, 1);
                            string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <'" + t2 + "'";
                            DataRow[] r = ds.Tables["CHI"].Select(qe);
                            if (r.Count() == 0)
                            {
                                MessageBox.Show("Không có phiếu chi vào tháng này");
                                return;
                            }
                            tablechi = r.CopyToDataTable();
                            tableao_chi = tablechi.Copy();
                            LoadToDataGridViewChi(tableao_chi);
                            #endregion
                        }
                        else
                        {
                            #region Thời Gian
                            DateTime t1 = dateTimePicker2Ngay21.Value;
                            DateTime t2 = dateTimePicker1Ngay22.Value;

                            string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <='" + t2 + "'";
                            DataRow[] r = ds.Tables["CHI"].Select(qe);
                            if (r.Count() == 0)
                            {
                                MessageBox.Show("Không có phiếu chi vào khoảng thời gian  này");
                                return;
                            }
                            tablechi = r.CopyToDataTable();
                            tableao_chi = tablechi.Copy();
                            LoadToDataGridViewChi(tableao_chi);
                            #endregion
                        }
                    }
                }
                TaoSTT_DS1();
            }
            catch { }
            if (rdbTatCa2.Checked == true)
                return;
            if (rdbNgay2_2.Checked == true)
            {
                #region Ngay
                DateTime d = new DateTime();
                d = dateTimePicker2Ngay21.Value;
                string qe = "NGAYLAP = '" + d + "'";
                DataRow[] r = ds.Tables["CHI"].Select(qe);
                if (r.Count() == 0)
                {
                    MessageBox.Show("Không có phiếu chi vào ngày này");
                    return;
                }
                tablechi = r.CopyToDataTable();
                tableao_chi = tablechi.Copy();
                LoadToDataGridViewChi(tableao_chi);
                #endregion
            }
            else
            {
                if (rdbThang_2.Checked == true)
                {

                    #region Tháng
                    int thang = int.Parse(cbbThang2.SelectedItem.ToString());
                    int nam = int.Parse(txtNam2.Text);
                    if (nam < 2010)
                    {
                        MessageBox.Show("Năm phải lớn hon năm 2009");
                        return;
                    }
                    DateTime t = new DateTime(nam, thang, 1);
                    DateTime t2;
                    if(thang !=12)
                        t2= new DateTime(nam, (thang + 1), 1);
                    else
                        t2 = new DateTime(nam+1,1, 1);
                    string qe = "NGAYLAP >= '" + t + "'" + "and NGAYLAP <'" + t2 + "'";
                    DataRow[] r = ds.Tables["CHI"].Select(qe);
                    if (r.Count() == 0)
                    {
                        MessageBox.Show("Không có phiếu chi vào tháng này");
                        return;
                    }
                    tablechi = r.CopyToDataTable();
                    tableao_chi = tablechi.Copy();
                    LoadToDataGridViewChi(tableao_chi);
                    #endregion
                }
                else
                {
                    if (rdbNam22.Checked == true)
                    {
                        #region Năm
                        int nam = int.Parse(txtNam2.Text);
                        if (nam < 2010)
                        {
                            MessageBox.Show("Năm phải lớn hơn năm 2009");
                            return;
                        }
                        DateTime t1 = new DateTime(nam, 1, 1);
                        DateTime t2 = new DateTime(nam + 1, 1, 1);
                        string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <'" + t2 + "'";
                        DataRow[] r = ds.Tables["CHI"].Select(qe);
                        if (r.Count() == 0)
                        {
                            MessageBox.Show("Không có phiếu chi vào tháng này");
                            return;
                        }
                        tablechi = r.CopyToDataTable();
                        tableao_chi = tablechi.Copy();
                        LoadToDataGridViewChi(tableao_chi);
                        #endregion
                    }
                    else
                    {
                        #region Thời Gian
                        DateTime t1 = dateTimePicker2Ngay21.Value;
                        DateTime t2 = dateTimePicker1Ngay22.Value;
                      
                        string qe = "NGAYLAP >= '" + t1 + "'" + "and NGAYLAP <='" + t2 + "'";
                        DataRow[] r = ds.Tables["CHI"].Select(qe);
                        if (r.Count() == 0)
                        {
                            MessageBox.Show("Không có phiếu chi vào khoảng thời gian  này");
                            return;
                        }
                        tablechi = r.CopyToDataTable();
                        tableao_chi = tablechi.Copy();
                        LoadToDataGridViewChi(tableao_chi);
                        #endregion
                    }
                }
            }
            TaoSTT_DS1();
        }

        private void dateTimePicker2Ngay21_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbThang2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete_rowin_datagridviewDSChi();
        }

        private void cbbThang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete_rowin_datagridviewDSThu();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            frmChitiethoadonBan fr = new frmChitiethoadonBan();
            fr.mahoadon = dataGridView1DSDSThu.CurrentRow.Cells[1].Value.ToString();
            fr.ShowDialog();
        }

        private void contextMenuStrip2_Click(object sender, EventArgs e)
        {
            frmChitiethoadonMua fr = new frmChitiethoadonMua();
            fr.mahoadon = dataGridView1DS2.CurrentRow.Cells[1].Value.ToString();
            fr.ShowDialog();
            
        }

        private void dataGridView1DS2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            //try
            //{

                if (dataGridView1DS2.RowCount == 0)
                    return;
                using (SqlConnection conn = new SqlConnection(ConnectionString.connectionstring))
                {
                    conn.Open();
                    SqlCommand cmd;
                    query = "DELETE BAOCAOTHUCHI";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dataGridView1DS2.RowCount; i++)
                    {
                        DateTime t = DateTime.Parse(dataGridView1DS2.Rows[0].Cells[2].Value.ToString());
                        query = "SET DATEFORMAT DMY INSERT INTO BAOCAOTHUCHI VALUES ('" + dataGridView1DS2.Rows[i].Cells[1].Value.ToString() + "','" + t.ToShortDateString() + "'," + double.Parse(dataGridView1DS2.Rows[i].Cells[4].Value.ToString()) + ",N'" + dataGridView1DS2.Rows[i].Cells[3].Value.ToString() + "',"+double.Parse(txtCP.Text)+")";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }

                    frmXuatBaoCaoThu_Chi fr = new frmXuatBaoCaoThu_Chi();
                    fr.ShowDialog();
                    query = "DELETE BAOCAOTHUCHI";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            //}
            //catch { }
        }

        private void dataGridView1DSDSThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
