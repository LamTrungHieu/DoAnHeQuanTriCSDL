﻿using System;
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
    public partial class HoaDon : Form
    {
        MyConnect myconn = new MyConnect();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_HoaDon.DataSource = dataTable;
            Reset();
            myconn.closeConnection();
        }
        private void btn_Tim_Kiem_HoaDon_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from fn_SearchOrderByPeroid(@FromDate, @ToDate)", myconn.getConnectionAdmin);
            cmd.Parameters.AddWithValue("@FromDate", date_Tu.Value);
            cmd.Parameters.AddWithValue("@ToDate", date_Den.Value);
            DataTable dt = new DataTable();
            myconn.openConnectionAdmin();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_HoaDon.DataSource = dt;
            myconn.closeConnectionAdmin();

        }

        private void Reset()
        {
            txt_MaHD.ResetText();
            txt_MaKH_HD.ResetText();
            txt_MaNV_HD.ResetText();
            txt_SoTienThanhToan_HD.ResetText();
            txt_PhuongThucThanhToan_HD.ResetText();
            txt_TrangThaiThanhToan_HD.ResetText();
        }

        private void btn_Them_HoaDon_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_MaNV_HD.Text}', {txt_SoTienThanhToan_HD.Text}, N'{txt_PhuongThucThanhToan_HD.Text}', N'{txt_TrangThaiThanhToan_HD.Text}', 'INSERT' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];

        }

        private void btn_Sua_HoaDon_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_MaNV_HD.Text}', {txt_SoTienThanhToan_HD.Text}, N'{txt_PhuongThucThanhToan_HD.Text}', N'{txt_TrangThaiThanhToan_HD.Text}', 'UPDATE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void btn_Xoa_HoaDon_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_MaNV_HD.Text}', {txt_SoTienThanhToan_HD.Text}, N'{txt_PhuongThucThanhToan_HD.Text}', N'{txt_TrangThaiThanhToan_HD.Text}', 'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void btn_Show_HoaDon__Click(object sender, EventArgs e)
        {
          
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHD.Text = dgv_HoaDon.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_HoaDon.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV_HD.Text = dgv_HoaDon.CurrentRow.Cells[2].Value.ToString();
            txt_SoTienThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[4].Value.ToString();
            txt_PhuongThucThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[5].Value.ToString();
            txt_TrangThaiThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[6].Value.ToString();
            if (e.RowIndex >= 0)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
            }
        }
    }
}
