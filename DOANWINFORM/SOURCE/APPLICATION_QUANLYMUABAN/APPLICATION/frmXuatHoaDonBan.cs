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
    public partial class frmXuatHoaDonBan : Form
    {
        SqlConnection con;
        DataTable table;
        SqlDataAdapter adapter;
        public string Ma_HD = "";
        public frmXuatHoaDonBan()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
           
     
        }

        private void frmXuatHoaDonBan_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT  CHITIET_HDB.MA_TB, CHITIET_HDB.DONGIA, CHITIET_HDB.THANHTIEN, HOADON_BAN.MA_HDB, HOADON_BAN.TEN_KH, HOADON_BAN.SDT, HOADON_BAN.MA_NV, THIETBI.TEN_TB,CHITIET_HDB.SOLUONG,  HOADON_BAN.NGAYLAP FROM CHITIET_HDB INNER JOIN HOADON_BAN ON CHITIET_HDB.MA_HDB = HOADON_BAN.MA_HDB INNER JOIN  THIETBI ON CHITIET_HDB.MA_TB = THIETBI.MA_TB where HOADON_BAN.MA_HDB = '" + Ma_HD + "'", con);
            table = new DataTable();
            adapter.Fill(table);
            CrXuatPhieuBan rp = new CrXuatPhieuBan();
            rp.SetDataSource(table);
            
            crvXuatHoaDonBan.ReportSource = rp;
            crvXuatHoaDonBan.Refresh();


        }

        private void crvXuatHoaDonBan_Load(object sender, EventArgs e)
        {

        }
    }
}
