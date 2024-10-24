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

namespace ShoesStore
{
    public partial class PhuKien : Form
    {
        MyConnect myconn = new MyConnect();
        public PhuKien()
        {
            InitializeComponent();
            LoadDataGoiPhuKien();
            LoadDataBanPK();
        }

        private void LoadDataGoiPhuKien()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GoiPhuKien", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_GoiPhuKien.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_TimKiem_GoiDichVu_Click(object sender, EventArgs e)
        {
            myconn.openConnectionAdmin();
            SqlCommand cmd = new SqlCommand("Select * From func_SearchDichVuByID(@MaGoiPK)", myconn.getConnectionAdmin);
            cmd.Parameters.AddWithValue("@MaGoiPK", txt_TimKiem_GoiPhuKien.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_GoiPhuKien.DataSource = dt;
            myconn.closeConnectionAdmin();

        }
        private void LoadDataBanPK()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BanPhuKien", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_BanPhuKien.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_TimKiem_BanPhuKien_Click(object sender, EventArgs e)
        {
            myconn.openConnectionAdmin();
            SqlCommand cmd = new SqlCommand("Select * From func_SearchBanPhuKien(@MaNV, @MaKH, @MaGoiPK)", myconn.getConnectionAdmin);
            cmd.Parameters.AddWithValue("@MaNV", txt_TimKiem_MaNhanVien.Text);
            cmd.Parameters.AddWithValue("@MaKH", txt_TimKiem_MaKhachHang.Text);
            cmd.Parameters.AddWithValue("@MaGoiPK", txt_TimKiem_MaGoiPK.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_BanPhuKien.DataSource = dt;
            myconn.closeConnectionAdmin();

        }

        private void dgv_GoiPhuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGoiPhuKien.Text = dgv_GoiPhuKien.CurrentRow.Cells[0].Value.ToString();
            txt_TenGoiPK.Text = dgv_GoiPhuKien.CurrentRow.Cells[1].Value.ToString();
            txt_PhiPK.Text = dgv_GoiPhuKien.CurrentRow.Cells[2].Value.ToString();
            if (e.RowIndex >= 0)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
            }
        }

        private void ResetGoiPhuKien()
        {
            txt_MaGoiPhuKien.ResetText();
            txt_TenGoiPK.ResetText();
            txt_PhiPK.ResetText();
        }

        private void btn_Them_GoiPhuKien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiPhuKien '{txt_MaGoiPhuKien.Text}', N'{txt_TenGoiPK.Text}', '{txt_PhiPK.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm gói phụ kiện thành công!");
                LoadDataGoiPhuKien();
                ResetGoiPhuKien();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void btn_Sua_GoiPhuKien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiPhuKien'{txt_MaGoiPhuKien.Text}', N'{txt_TenGoiPK.Text}', '{txt_PhiPK.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa gói phụ kiện thành công!");
                LoadDataGoiPhuKien();
                ResetGoiPhuKien();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void btn_Xoa_GoiPhuKien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiPhuKien '{txt_MaGoiPhuKien.Text}', N'{txt_TenGoiPK.Text}', '{txt_PhiPK.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa gói phụ kiện thành công!");
                LoadDataGoiPhuKien();
                ResetGoiPhuKien();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void btn_Them_BPK_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ResiveBanPhuKien'{txt_MaNV_BPK.Text}','{txt_MaKH_BPK.Text}','{txt_MaGoi_BPK.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm bán phụ kiện thành công!");
                LoadDataBanPK();
                ResetBPK();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];

        }

        private void btn_Sua_BPK_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ResiveBanPhuKien '{txt_MaNV_BPK.Text}','{txt_MaKH_BPK.Text}','{txt_MaGoi_BPK.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa bán phụ kiện thành công!");
                LoadDataBanPK();
                ResetBPK();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void btn_Xoa_BPK_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ResiveBanPhuKien'{txt_MaNV_BPK.Text}','{txt_MaKH_BPK.Text}','{txt_MaGoi_BPK.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa bán phụ kiện thành công!");
                LoadDataBanPK();
                ResetBPK();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }
        private void ResetBPK()
        {
            txt_MaNV_BPK.ResetText();
            txt_MaKH_BPK.ResetText();
            txt_MaGoi_BPK.ResetText();
        }

        private void dgv_BanPhuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV_BPK.Text = dgv_BanPhuKien.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_BPK.Text = dgv_BanPhuKien.CurrentRow.Cells[1].Value.ToString();
            txt_MaGoi_BPK.Text = dgv_BanPhuKien.CurrentRow.Cells[2].Value.ToString();
            if (e.RowIndex >= 0)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
            }
        }
    }
}
