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
    public partial class frmChitiethoadonMua : Form
    {
        SqlConnection con;
        DataSet dataset;/// chua toan bo chi tiet cua hoa don 
        DataTable table;/// chua chi tiet cua hoa don theo ma hoa don
        public string mahoadon = "";
        public frmChitiethoadonMua()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
            dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT MA_HDM,CHITIET_HDM.MA_TB,TEN_TB,NSX,LOAI,CHITIET_HDM.SOLUONG,CHITIET_HDM.DONNGIA_MUA,THANHTIEN FROM THIETBI,CHITIET_HDM,NHACUNGCAP WHERE CHITIET_HDM.MA_TB = THIETBI.MA_TB", con);
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
                if (txtmahdM.TextLength == 0)
                {
                    table = null;
                    return;
                }
                DataRow[] r = dataset.Tables[0].Select("MA_HDM = '" + txtmahdM.Text.ToString().Trim() + "'");

                if (r.Count() == 0)
                    return;
                table = r.CopyToDataTable();/// dua du lieu da loc vao table
                dataGridView1DSCHITIET_HDM.DataSource = table;
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienall_B_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1DSCHITIET_HDM.DataSource = dataset.Tables[0];
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
        }

        private void frmChitiethoadonMua_Load(object sender, EventArgs e)
        {
            if (mahoadon != "")
            {
                txtmahdM.Text = mahoadon;
                btnLoc_M_Click(sender, e);
                btnHienall_M.Enabled = false;
                txtmahdM.Enabled = false;
                
            }
        }

        private void txtmahdM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua mã hóa đơn bán la 10 ky tu
            else
            {
                if (txtmahdM.TextLength >= 10)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void btnLoc_M_Click(object sender, EventArgs e)
        {

            
            if (txtmahdM.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị");
                return;
            }
            showToData();
            if (dataGridView1DSCHITIET_HDM.RowCount == 0)
            {
                MessageBox.Show("Không có mã hóa đơn này");
                return;
            }
        }

        private void dataGridView1DSCHITIET_HDM_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
           
        }

        private void dataGridView1DSCHITIET_HDM_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                double Tongtienban = 0;
                for (int i = 0; i < rowcount; i++)
                {
                    Tongtienban += double.Parse(dataGridView1DSCHITIET_HDM.Rows[i].Cells[8].Value.ToString());
                }
                txtTongtien_M.Text = Tongtienban.ToString();
            }
            catch { }
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dataGridView1DSCHITIET_HDM.RowCount !=0 && txtmahdM.TextLength != 0 )
            {
                frmXuatHoaDonNHap fr = new frmXuatHoaDonNHap();
                fr.Ma_HD = txtmahdM.Text.ToString();
                fr.ShowDialog();
            }
            
        }
    }
}
