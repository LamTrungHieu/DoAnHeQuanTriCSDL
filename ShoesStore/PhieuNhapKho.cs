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
    public partial class PhieuNhapKho : Form
    {
        MyConnect myconn = new MyConnect();
        public PhieuNhapKho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Hoa_Don_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNCC.Text = dgv_PhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV.Text = dgv_PhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_TienNhapKho.Text = dgv_PhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_Phuongthucthanhtoan.Text = dgv_PhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
            txt_trangthaithanhtoan.Text = dgv_PhieuNhapKho.CurrentRow.Cells[6].Value.ToString();
        
    }

        private void btn_Tim_nhapkho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemPhieuNhapKho(@NgayNhapKho)", conn);
                cmd.Parameters.AddWithValue("@NgayNhapKho", date_ngaynhap.Value);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_HienThongTin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhapKho", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }
        private void Reset()
        {
            txt_MaNK.ResetText();
            txt_MaNCC.ResetText();
            txt_MaNV.ResetText();
            txt_TienNhapKho.ResetText();
            txt_trangthaithanhtoan.ResetText();
            txt_Phuongthucthanhtoan.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhapKho", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_PhieuNhapKho.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC.Text}', '{txt_MaNV.Text}', {txt_TienNhapKho.Text}, N'{txt_Phuongthucthanhtoan.Text}', N'{txt_trangthaithanhtoan.Text}', 'INSERT' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC.Text}', '{txt_MaNV.Text}', {txt_TienNhapKho.Text}, N'{txt_Phuongthucthanhtoan.Text}', N'{txt_trangthaithanhtoan.Text}', 'UPDATE' ", myconn.getConnection);
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
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC.Text}', '{txt_MaNV.Text}', {txt_TienNhapKho.Text}, N'{txt_Phuongthucthanhtoan.Text}', N'{txt_trangthaithanhtoan.Text}', 'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
