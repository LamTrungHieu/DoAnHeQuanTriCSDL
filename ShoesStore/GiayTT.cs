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
            txt_SizeGiay.ResetText();   
            txt_QuatangKem.ResetText();
            txt_TenGiayTT.ResetText();
            txt_MauSac.ResetText();
            txt_Khoiluong.ResetText();
            txt_TenHangGiay.ResetText();
            txt_HanBaoHanh.ResetText();
            txt_Soluong.ResetText();
            txt_Chatlieugiay.ResetText();
            txt_GiaGiay.ResetText();
           
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
                txt_MaGiayTT.Text = dgv_Giay_The_Thao.CurrentRow.Cells[0].Value.ToString();
                txt_TenGiayTT.Text = dgv_Giay_The_Thao.CurrentRow.Cells[1].Value.ToString();
                txt_TenHangGiay.Text = dgv_Giay_The_Thao.CurrentRow.Cells[2].Value.ToString();
                txt_SizeGiay.Text = dgv_Giay_The_Thao.CurrentRow.Cells[3].Value.ToString();
                txt_MauSac.Text = dgv_Giay_The_Thao.CurrentRow.Cells[4].Value.ToString();
                txt_Soluong.Text = dgv_Giay_The_Thao.CurrentRow.Cells[5].Value.ToString();
                txt_GiaGiay.Text = dgv_Giay_The_Thao.CurrentRow.Cells[6].Value.ToString();
                txt_HanBaoHanh.Text = dgv_Giay_The_Thao.CurrentRow.Cells[7].Value.ToString();
                txt_Chatlieugiay.Text = dgv_Giay_The_Thao.CurrentRow.Cells[8].Value.ToString();
                txt_QuatangKem.Text = dgv_Giay_The_Thao.CurrentRow.Cells[9].Value.ToString();
                txt_Khoiluong.Text = dgv_Giay_The_Thao.CurrentRow.Cells[10].Value.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Kiem_Giay_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemGiayTheThao(@TenGTT,@KhoiLuong, @TenHangGTT, @MauSac, @SizeGiay)", conn);
                cmd.Parameters.AddWithValue("@TenGTT", txt_TimTenGiay.Text);
                cmd.Parameters.AddWithValue("@KhoiLuong", txt_TimKhoiLuong.Text);
                cmd.Parameters.AddWithValue("@TenHangGTT", txt_TimTenHang.Text);
                cmd.Parameters.AddWithValue("@MauSac", txt_TimMauSac.Text);
                cmd.Parameters.AddWithValue("@SizeGiay", txt_TimSize.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Giay_The_Thao.DataSource = dt;
                conn.Close();
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_HienThongTin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC dbo.sp_ReviseGiayTT '{txt_MaGiayTT.Text}', N'{txt_TenGiayTT.Text}', N'{txt_TenHangGiay.Text}', {txt_SizeGiay.Text}, N'{txt_MauSac.Text}', {txt_Soluong.Text}, {txt_GiaGiay.Text}, {txt_HanBaoHanh.Text}, N'{txt_Chatlieugiay.Text}', N'{txt_QuatangKem.Text}',N'{txt_Khoiluong.Text}',  'INSERT' ", myconn.getConnection);

                MessageBox.Show("Thêm Giày thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC dbo.sp_ReviseGiayTT '{txt_MaGiayTT.Text}', N'{txt_TenGiayTT.Text}', N'{txt_TenHangGiay.Text}', {txt_SizeGiay.Text}, N'{txt_MauSac.Text}', {txt_Soluong.Text}, {txt_GiaGiay.Text}, {txt_HanBaoHanh.Text}, N'{txt_Chatlieugiay.Text}', N'{txt_QuatangKem.Text}',N'{txt_Khoiluong.Text}', 'UPDATE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Giày thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC dbo.sp_ReviseGiayTT '{txt_MaGiayTT.Text}', N'{txt_TenGiayTT.Text}', N'{txt_TenHangGiay.Text}', {txt_SizeGiay.Text}, N'{txt_MauSac.Text}', {txt_Soluong.Text}, {txt_GiaGiay.Text}, {txt_HanBaoHanh.Text}, N'{txt_Chatlieugiay.Text}', N'{txt_QuatangKem.Text}',N'{txt_Khoiluong.Text}',  'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Giày thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();

        }
    }
}
