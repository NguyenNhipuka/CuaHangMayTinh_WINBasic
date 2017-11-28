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
    public partial class frmChitiethoadonBan : Form
    {
        SqlConnection con;
        DataSet dataset;/// chua toan bo chi tiet cua hoa don 
        DataTable table;/// chua chi tiet cua hoa don theo ma hoa don
        public string mahoadon = "";
        public frmChitiethoadonBan()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
            dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT MA_HDB,CHITIET_HDB.MA_TB,TEN_TB,LOAI,NSX,CHITIET_HDB.SOLUONG,DONGIA,THANHTIEN FROM THIETBI,CHITIET_HDB WHERE CHITIET_HDB.MA_TB = THIETBI.MA_TB", con);
            adapter.Fill(dataset);
            
        }
        public void showToData()
        {
            try
            {
                table = null;
                if (dataset.Tables[0].Rows.Count == 0)
                    return;
                //DataColumn[] pk = new DataColumn[1];
                //pk[0] = dataset.Tables[0].Columns[0];
                //dataset.Tables[0].PrimaryKey = pk;
                if (txtMaHDB.TextLength == 0)
                {
                    table = null;
                    return;
                }
                DataRow[] r = dataset.Tables[0].Select("MA_HDB = '" + txtMaHDB.Text.ToString().Trim() + "'");

                if (r.Count() == 0)
                    return;
                table = r.CopyToDataTable();/// dua du lieu da loc vao table
                dataGridView2ChiTietBan.DataSource = table;
                int rowcount = dataGridView2ChiTietBan.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView2ChiTietBan.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
            
        }

        /// Loc chi tiết hóa đơn theo mã 



        private void btnLoc_B_Click(object sender, EventArgs e)
        {
          
            if(txtMaHDB.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị");
                return;
            }
            showToData();
            try
            {
                int rowcount = dataGridView2ChiTietBan.RowCount;
                double Tongtienban = 0;
                if (rowcount != 0)
                {
                    for (int i = 0; i < rowcount; i++)
                    {
                        Tongtienban += double.Parse(dataGridView2ChiTietBan.Rows[i].Cells[8].Value.ToString());
                    }
                }

                txtTongtien_M.Text = Tongtienban.ToString();
            }
            catch { }
            if(dataGridView2ChiTietBan.RowCount == 0)
            {
                MessageBox.Show("Không có mã hóa đơn này");
                return;
            }
        }

        private void frmChitiethoadonBan_Load(object sender, EventArgs e)
        {
             if(mahoadon != "")
             {
                 txtMaHDB.Text = mahoadon;
                 btnHienall_B.Enabled = false;
                 btnLoc_B_Click(sender, e);
                 txtMaHDB.Enabled = false;
             }
                 
        }

        private void txtMaHDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua mã hóa đơn bán la 11 ky tu
            else
            {
                if (txtMaHDB.TextLength >= 10)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void btnHienall_B_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2ChiTietBan.DataSource = dataset.Tables[0];
                int rowcount = dataGridView2ChiTietBan.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView2ChiTietBan.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
            
        }

        private void dataGridView2ChiTietBan_Click(object sender, EventArgs e)
        {
            int rowcount = dataGridView2ChiTietBan.RowCount;
            for (int i = 1; i <= rowcount; i++)
            {
                dataGridView2ChiTietBan.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void dataGridView2ChiTietBan_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowcount = dataGridView2ChiTietBan.RowCount;
            for (int i = 1; i <= rowcount; i++)
            {
                dataGridView2ChiTietBan.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void dataGridView2ChiTietBan_DataSourceChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaHDB_TextChanged(object sender, EventArgs e)
        {
            dataGridView2ChiTietBan.DataSource = null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dataGridView2ChiTietBan.RowCount !=0 && txtMaHDB.TextLength != 0)
            {
                frmXuatHoaDonBan fr = new frmXuatHoaDonBan();
                fr.Ma_HD = txtMaHDB.Text;
                fr.ShowDialog();
            }
        }

    }
}
