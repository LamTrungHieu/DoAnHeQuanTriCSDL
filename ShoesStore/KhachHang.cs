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
    public partial class KhachHang : Form
    {
        MyConnect myconn = new MyConnect();
        public KhachHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_KhachHang.DataSource = dataTable;
            myconn.closeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            txt_MaKH.ResetText();
            txt_LoaiKH.ResetText();
            txt_HoTenKH.ResetText();
            txt_SDT.ResetText();
            txt_TongSoTienDaGiaoDich.ResetText();
            txt_Email.ResetText();

        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_MaKH.Text = dgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
            txt_LoaiKH.Text = dgv_KhachHang.CurrentRow.Cells[1].Value.ToString();
            txt_HoTenKH.Text = dgv_KhachHang.CurrentRow.Cells[2].Value.ToString();
            txt_SDT.Text = dgv_KhachHang.CurrentRow.Cells[3].Value.ToString();
            txt_TongSoTienDaGiaoDich.Text = dgv_KhachHang.CurrentRow.Cells[4].Value.ToString();
            txt_Email.Text = dgv_KhachHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Them_KhacHang_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseKhachHang '{txt_MaKH.Text}', '{txt_LoaiKH.Text}', N'{txt_HoTenKH.Text}', '{txt_SDT.Text}', '{txt_Email.Text}','{txt_TongSoTienDaGiaoDich.Text}','Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Sua_KhacHang_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseKhachHang '{txt_MaKH.Text}', '{txt_LoaiKH.Text}', N'{txt_HoTenKH.Text}', '{txt_SDT.Text}', '{txt_Email.Text}', '{txt_TongSoTienDaGiaoDich.Text}','Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa khách hàng thành công!");
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Xoa_KhacHang_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseKhachHang '{txt_MaKH.Text}', '{txt_LoaiKH.Text}', N'{txt_HoTenKH.Text}', '{txt_SDT.Text}', '{txt_Email.Text}','{txt_TongSoTienDaGiaoDich.Text}','Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_TimKiem_KhachHang_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemKhachHang(@HoTenKH, @SDT)", conn);
                cmd.Parameters.AddWithValue("@HoTenKH", txt_TimKiemKH_HoTenKH.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_TimKiemKH_SDT.Text);

                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_KhachHang.DataSource = dt;
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
