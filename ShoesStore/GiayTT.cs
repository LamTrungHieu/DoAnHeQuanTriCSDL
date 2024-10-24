using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStore
{
    public partial class GiayTT : Form
    {
        MyConnect myconn = new MyConnect();
        private void Reset()
        {
            txt_MaGiayTT.ResetText();
            txt_CSSizeGiay.ResetText();   
            txt_QuatangKem.ResetText();
            txt_TenGiayTT.ResetText();
            txt_TimMauSac.ResetText();
            txt_CSKhoiluong.ResetText();
            txt_TenHangGiay.ResetText();
            txt_hanBaoHanh.ResetText();
            txt_Soluong.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiayTheThao", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_Giay_The_Thao.DataSource = dataTable;
            myconn.closeConnection();
        }
        public GiayTT()
        {
            InitializeComponent();
        }

        private void GiayTT_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Kiem_Giay_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_HienThongTin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore; User Id=" + DangNhap.username + ";Password=" +
            DangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM GiayTheThao", conn);

                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Giay_The_Thao.DataSource = dt;
                conn.Close();
            }
        }
    }
}
