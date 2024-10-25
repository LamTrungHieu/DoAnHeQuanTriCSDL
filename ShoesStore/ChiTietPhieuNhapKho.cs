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
    
    public partial class ChiTietPhieuNhapKho : Form
    {
        MyConnect myconn = new MyConnect();
        public ChiTietPhieuNhapKho()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AJ47GCA\MAY1;Initial Catalog=QLYShoesStore;User ID=sa;Password=12345")) 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap", conn);
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
            txt_MaGiayTT.ResetText();
            txt_MaNK.ResetText();
            txt_SoluongSP.ResetText();
            txt_GiaTungSP.ResetText();
            txt_ThueVAT.ResetText();
            txt_ThanhTienTungSP.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_PhieuNhapKho.DataSource = dataTable;
            myconn.closeConnection();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaGiayTT.Text}', '{txt_MaNK.Text}', '{txt_SoluongSP.Text}', {txt_GiaTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Insert' ", myconn.getConnection);
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

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaGiayTT.Text}', '{txt_MaNK.Text}', '{txt_SoluongSP.Text}', {txt_GiaTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Update' ", myconn.getConnection);
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

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaGiayTT.Text}', '{txt_MaNK.Text}', '{txt_SoluongSP.Text}', {txt_GiaTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Delete' ", myconn.getConnection);
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

        private void dgv_PhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGiayTT.Text = dgv_PhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_SoluongSP.Text = dgv_PhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_GiaTungSP.Text = dgv_PhieuNhapKho.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_PhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_PhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
        
        }
    }
}
