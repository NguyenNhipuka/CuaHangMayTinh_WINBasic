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
    public partial class frmXuatHoaDonNHap : Form
    {
        SqlConnection con;
        DataTable table;
        SqlDataAdapter adapter;
        public string Ma_HD = "";
        public frmXuatHoaDonNHap()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString.connectionstring);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT CHITIET_HDM.MA_HDM, CHITIET_HDM.MA_TB, CHITIET_HDM.SOLUONG, CHITIET_HDM.DONNGIA_MUA, CHITIET_HDM.THANHTIEN, HOADON_MUA.NGAYLAP, HOADON_MUA.TRIGIA_HDM,  HOADON_MUA.MA_NV, NHACUNGCAP.TEN_NCC, THIETBI.TEN_TB FROM CHITIET_HDM INNER JOIN HOADON_MUA ON CHITIET_HDM.MA_HDM = HOADON_MUA.MA_HDM INNER JOIN NHACUNGCAP ON HOADON_MUA.MA_NCC = NHACUNGCAP.MA_NCC INNER JOIN THIETBI ON CHITIET_HDM.MA_TB = THIETBI.MA_TB AND NHACUNGCAP.MA_NCC = THIETBI.MA_NCC WHERE CHITIET_HDM.MA_HDM = '"+Ma_HD+"'", con);
            table = new DataTable();
            adapter.Fill(table);
            CrXuatHoaDonNhap rp = new CrXuatHoaDonNhap();
            rp.SetDataSource(table);
            crvXuatHoaDonNhap.ReportSource = rp;
            crvXuatHoaDonNhap.Refresh();
        }
    }
}
