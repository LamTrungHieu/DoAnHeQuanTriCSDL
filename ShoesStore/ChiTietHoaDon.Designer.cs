namespace ShoesStore
{
    partial class ChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Chi_Tiet_Hoa_Don = new System.Windows.Forms.DataGridView();
            this.MaGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanTungSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi_Tiet_Hoa_Don)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(427, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Tiết Hoá Đơn";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dgv_Chi_Tiet_Hoa_Don
            // 
            this.dgv_Chi_Tiet_Hoa_Don.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Chi_Tiet_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chi_Tiet_Hoa_Don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiayTT,
            this.MaHoaDon,
            this.SoLuongSanPham,
            this.GiaBanTungSanPham,
            this.ThueVAT,
            this.KhuyenMai,
            this.ThanhTienSanPham});
            this.dgv_Chi_Tiet_Hoa_Don.GridColor = System.Drawing.Color.White;
            this.dgv_Chi_Tiet_Hoa_Don.Location = new System.Drawing.Point(30, 138);
            this.dgv_Chi_Tiet_Hoa_Don.Name = "dgv_Chi_Tiet_Hoa_Don";
            this.dgv_Chi_Tiet_Hoa_Don.RowHeadersWidth = 62;
            this.dgv_Chi_Tiet_Hoa_Don.RowTemplate.Height = 28;
            this.dgv_Chi_Tiet_Hoa_Don.Size = new System.Drawing.Size(1093, 428);
            this.dgv_Chi_Tiet_Hoa_Don.TabIndex = 18;
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.HeaderText = "Mã Giày TT";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            this.MaGiayTT.Width = 150;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hoá đơn";
            this.MaHoaDon.MinimumWidth = 8;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 150;
            // 
            // SoLuongSanPham
            // 
            this.SoLuongSanPham.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSanPham.MinimumWidth = 8;
            this.SoLuongSanPham.Name = "SoLuongSanPham";
            this.SoLuongSanPham.Width = 150;
            // 
            // GiaBanTungSanPham
            // 
            this.GiaBanTungSanPham.HeaderText = "Giá bán từng sản phẩm";
            this.GiaBanTungSanPham.MinimumWidth = 8;
            this.GiaBanTungSanPham.Name = "GiaBanTungSanPham";
            this.GiaBanTungSanPham.Width = 150;
            // 
            // ThueVAT
            // 
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 8;
            this.ThueVAT.Name = "ThueVAT";
            this.ThueVAT.Width = 150;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 8;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.Width = 150;
            // 
            // ThanhTienSanPham
            // 
            this.ThanhTienSanPham.HeaderText = "Thành tiền từng sản phẩm";
            this.ThanhTienSanPham.MinimumWidth = 8;
            this.ThanhTienSanPham.Name = "ThanhTienSanPham";
            this.ThanhTienSanPham.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Chi_Tiet_Hoa_Don);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 592);
            this.panel1.TabIndex = 19;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1152, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi_Tiet_Hoa_Don)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Chi_Tiet_Hoa_Don;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanTungSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienSanPham;
        private System.Windows.Forms.Panel panel1;
    }
}