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
    public partial class ChiTietHoaDon : Form
    {
        MyConnect myconn = new MyConnect();
        public ChiTietHoaDon()
        {
            InitializeComponent();
            hienThongTin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void hienThongTin()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Chi_Tiet_Hoa_Don.DataSource = dt;
                conn.Close();
            }
        }

        private void btn_HienThongTin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Chi_Tiet_Hoa_Don.DataSource = dt;
                conn.Close();
            }
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_Chi_Tiet_Hoa_Don.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void Reset()
        {
            txt_MaGiayTT.ResetText();
            txt_MaHD.ResetText();
            txt_SoluongSP.ResetText();
            txt_ThanhTienTungSP.ResetText();
            txt_KhuyenMai.ResetText();
            txt_ThueVAT.ResetText();
            txt_GiabanTungSP.ResetText();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaGiayTT.Text}', '{txt_MaHD.Text}', '{txt_SoluongSP.Text}', {txt_GiabanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Insert' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

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
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaGiayTT.Text}', '{txt_MaHD.Text}', '{txt_SoluongSP.Text}', {txt_GiabanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Update' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

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
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaGiayTT.Text}', '{txt_MaHD.Text}', '{txt_SoluongSP.Text}', {txt_GiabanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Delete' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void dgv_Chi_Tiet_Hoa_Don_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGiayTT.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[0].Value.ToString();
            txt_MaHD.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[1].Value.ToString();
            txt_SoluongSP.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[2].Value.ToString();
            txt_GiabanTungSP.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[4].Value.ToString();
            txt_KhuyenMai.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[5].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_Chi_Tiet_Hoa_Don.CurrentRow.Cells[6].Value.ToString();
    }
    }
}
