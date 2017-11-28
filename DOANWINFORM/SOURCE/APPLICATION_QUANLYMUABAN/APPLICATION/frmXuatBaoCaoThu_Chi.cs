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
    public partial class frmXuatBaoCaoThu_Chi : Form
    {
        SqlConnection con;
        DataTable table;
        SqlDataAdapter adapter;
        public frmXuatBaoCaoThu_Chi()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
        }

        private void crXuatBaoCaoThuChi_Load(object sender, EventArgs e)
        {
            
        }

        private void frmXuatBaoCaoThu_Chi_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT MAPHIEU, NGAYLAP, TRIGIA_HD, TENNV, TONG FROM BAOCAOTHUCHI", con);
            table = new DataTable();
            adapter.Fill(table);
            CrXuatBaoCaoThuChi rp = new CrXuatBaoCaoThuChi();
            rp.SetDataSource(table);
            crvXuatBaoCaoThuChi.ReportSource = rp;
            crvXuatBaoCaoThuChi.Refresh();
        }
    }
}
