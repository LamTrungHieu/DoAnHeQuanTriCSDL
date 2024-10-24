using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormchild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Body.Controls.Add(childForm);
            pn_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            label1.Text = btn_NhanVien.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_GiayTT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiayTT());
             label1.Text = btn_GiayTT.Text;
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap());
            label1.Text = btn_NCC.Text;
        }

        private void btn_Phieunhapkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuNhapKho());
            label1.Text = btn_Phieunhapkho.Text;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon());
            label1.Text = btn_HoaDon.Text;
        }

        private void btn_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiTietHoaDon());
            label1.Text = btn_ChiTietHoaDon.Text;
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            label1.Text = btn_khachhang.Text;
        }

        private void btn_baohanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Baohanh());
            label1.Text = btn_baohanh.Text;
        }

        private void btn_phukien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhuKien());
            label1.Text = btn_phukien.Text;
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HienThiThongKe());
            label1.Text = btn_Thongke.Text;
        }

        private void pn_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
