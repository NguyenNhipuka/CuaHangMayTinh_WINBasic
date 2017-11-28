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
    public partial class frmXuatBangbaoGia : Form
    {
        SqlConnection con;
        DataTable table;
        SqlDataAdapter adapter;
        public frmXuatBangbaoGia()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
        }

        private void frmXuatBangbaoGia_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT        MA_TB, TEN_TB, LOAI, SOLUONG, DONGIA_BAN, TG_BAOHANH, NSX FROM BANGBAOGIA", con);
            table = new DataTable();
            adapter.Fill(table);
            CrBangBaoGia rp = new CrBangBaoGia();
            rp.SetDataSource(table);
            crvBangBaoGia.ReportSource = rp;
            crvBangBaoGia.Refresh();
           
        }



        private void crvBangBaoGia_Load(object sender, EventArgs e)
        {

        }
    }
}
