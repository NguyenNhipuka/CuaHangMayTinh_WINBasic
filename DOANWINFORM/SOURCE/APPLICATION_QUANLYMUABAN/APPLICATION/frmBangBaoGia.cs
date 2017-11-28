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
    public partial class frmBangBaoGia : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        DataSet ds;
        string query;
        public DataTable table;
        public frmBangBaoGia()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
            query = "SELECT  MA_TB,TEN_TB,TEN_NCC,LOAI,TG_BAOHANH,DONGIA_BAN,NSX FROM THIETBI,NHACUNGCAP WHERE THIETBI.MA_NCC = NHACUNGCAP.MA_NCC";
            adapter = new SqlDataAdapter(query, con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2DSthietbitrongkho.DataSource = ds.Tables[0];
            
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBangBaoGia_Load(object sender, EventArgs e)
        {
           
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2DSthietbitrongkho.RowCount == 0)
                {
                    MessageBox.Show("Kho chưa có thiết bị");
                    return;
                }

                foreach (DataGridViewRow r in dataGridView2DSthietbitrongkho.SelectedRows)
                {
                    int x = dataGridView1bangbaogia.Rows.Count;
                    for (int i = 0; i < x; i++)
                    {
                        if (dataGridView1bangbaogia.Rows[i].Cells[2].Value.ToString() == r.Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Thiết bị đã được thêm trước đó");
                            return;
                        }
                    }
                    dataGridView1bangbaogia.Rows.Add(dataGridView1bangbaogia.Rows.Count + 1, r.Cells[1].Value.ToString(), r.Cells[0].Value.ToString(), r.Cells["Column9"].Value.ToString(), 1, r.Cells["Column13"].Value.ToString(), r.Cells["Column12"].Value.ToString(), r.Cells["Column11"].Value.ToString());

                }
            }
            catch { }
          
        }

        public void TaoSoThuTu()
        {
            try
            {
                int rowcount = dataGridView1bangbaogia.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    dataGridView1bangbaogia.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch { }
           
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1bangbaogia.RowCount.ToString());

            try
            {
                if (dataGridView1bangbaogia.RowCount == 0)
                {
                    return;
                }

                foreach (DataGridViewRow r in dataGridView1bangbaogia.SelectedRows)
                {
                    int x = dataGridView1bangbaogia.Rows.Count;
                    for (int i = 0; i < x; i++)
                    {
                        if (dataGridView1bangbaogia.Rows[i].Cells[2].Value.ToString() == r.Cells[2].Value.ToString())
                        {
                            dataGridView1bangbaogia.Rows.RemoveAt(i);
                            break;
                        }
                    }
                    TaoSoThuTu();
                }
            }
            catch { }
           
        }

        private void btnXuatBBG_Click(object sender, EventArgs e)
        {
            if (dataGridView1bangbaogia.RowCount == 0)
                return;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionstring))
            {
                conn.Open();
                SqlCommand cmd;
                query = "delete BANGBAOGIA";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dataGridView1bangbaogia.RowCount; i++ )
                {
                    query = "INSERT INTO BANGBAOGIA VALUES (N'"+dataGridView1bangbaogia.Rows[i].Cells[3].Value.ToString()+"','"+dataGridView1bangbaogia.Rows[i].Cells[2].Value.ToString()+"',N'"+dataGridView1bangbaogia.Rows[i].Cells[1].Value.ToString()+"',1,"+int.Parse(dataGridView1bangbaogia.Rows[i].Cells[6].Value.ToString())+","+double.Parse(dataGridView1bangbaogia.Rows[i].Cells[5].Value.ToString())+",N'"+dataGridView1bangbaogia.Rows[i].Cells[7].Value.ToString()+"')";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                frmXuatBangbaoGia fr = new frmXuatBangbaoGia();
                fr.ShowDialog();
                //// GIAI PHONG BANG TRONG CSDL
                query = "DELETE BANGBAOGIA";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                    conn.Close();
            }


           
        }
    }
}
