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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HienThongTin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Chi_Tiet_Hoa_Don = new System.Windows.Forms.DataGridView();
            this.MaGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanTungSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_ThanhTienTungSP = new System.Windows.Forms.TextBox();
            this.txt_KhuyenMai = new System.Windows.Forms.TextBox();
            this.txt_ThueVAT = new System.Windows.Forms.TextBox();
            this.txt_GiabanTungSP = new System.Windows.Forms.TextBox();
            this.txt_SoluongSP = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_MaGiayTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi_Tiet_Hoa_Don)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 632);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infor ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_HienThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Chi_Tiet_Hoa_Don);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 530);
            this.panel1.TabIndex = 20;
            // 
            // btn_HienThongTin
            // 
            this.btn_HienThongTin.BackColor = System.Drawing.Color.IndianRed;
            this.btn_HienThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HienThongTin.Location = new System.Drawing.Point(896, 94);
            this.btn_HienThongTin.Name = "btn_HienThongTin";
            this.btn_HienThongTin.Size = new System.Drawing.Size(145, 56);
            this.btn_HienThongTin.TabIndex = 19;
            this.btn_HienThongTin.Text = "Hiện Thông Tin";
            this.btn_HienThongTin.UseVisualStyleBackColor = false;
            this.btn_HienThongTin.Click += new System.EventHandler(this.btn_HienThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(395, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Tiết Hoá Đơn";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_Chi_Tiet_Hoa_Don
            // 
            this.dgv_Chi_Tiet_Hoa_Don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Chi_Tiet_Hoa_Don.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Chi_Tiet_Hoa_Don.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Chi_Tiet_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chi_Tiet_Hoa_Don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiayTT,
            this.MaHoaDon,
            this.SoLuongSanPham,
            this.GiaBanTungSanPham,
            this.ThueVAT,
            this.KhuyenMai,
            this.ThanhTienSanPham});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Chi_Tiet_Hoa_Don.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Chi_Tiet_Hoa_Don.GridColor = System.Drawing.Color.White;
            this.dgv_Chi_Tiet_Hoa_Don.Location = new System.Drawing.Point(25, 173);
            this.dgv_Chi_Tiet_Hoa_Don.Name = "dgv_Chi_Tiet_Hoa_Don";
            this.dgv_Chi_Tiet_Hoa_Don.RowHeadersWidth = 62;
            this.dgv_Chi_Tiet_Hoa_Don.RowTemplate.Height = 28;
            this.dgv_Chi_Tiet_Hoa_Don.Size = new System.Drawing.Size(1070, 357);
            this.dgv_Chi_Tiet_Hoa_Don.TabIndex = 18;
            this.dgv_Chi_Tiet_Hoa_Don.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Chi_Tiet_Hoa_Don_CellContentClick);
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.DataPropertyName = "MaGiayTT";
            this.MaGiayTT.HeaderText = "Mã Giày TT";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHD";
            this.MaHoaDon.HeaderText = "Mã hoá đơn";
            this.MaHoaDon.MinimumWidth = 8;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // SoLuongSanPham
            // 
            this.SoLuongSanPham.DataPropertyName = "SoLuongSP";
            this.SoLuongSanPham.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSanPham.MinimumWidth = 8;
            this.SoLuongSanPham.Name = "SoLuongSanPham";
            // 
            // GiaBanTungSanPham
            // 
            this.GiaBanTungSanPham.DataPropertyName = "GiaBanTungSP";
            this.GiaBanTungSanPham.HeaderText = "Giá bán từng sản phẩm";
            this.GiaBanTungSanPham.MinimumWidth = 8;
            this.GiaBanTungSanPham.Name = "GiaBanTungSanPham";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 8;
            this.ThueVAT.Name = "ThueVAT";
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 8;
            this.KhuyenMai.Name = "KhuyenMai";
            // 
            // ThanhTienSanPham
            // 
            this.ThanhTienSanPham.DataPropertyName = "ThanhTienTungSP";
            this.ThanhTienSanPham.HeaderText = "Thành tiền từng sản phẩm";
            this.ThanhTienSanPham.MinimumWidth = 8;
            this.ThanhTienSanPham.Name = "ThanhTienSanPham";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Xoa);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Controls.Add(this.btn_Them);
            this.tabPage2.Controls.Add(this.txt_ThanhTienTungSP);
            this.tabPage2.Controls.Add(this.txt_KhuyenMai);
            this.tabPage2.Controls.Add(this.txt_ThueVAT);
            this.tabPage2.Controls.Add(this.txt_GiabanTungSP);
            this.tabPage2.Controls.Add(this.txt_SoluongSP);
            this.tabPage2.Controls.Add(this.txt_MaHD);
            this.tabPage2.Controls.Add(this.txt_MaGiayTT);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 26);
            this.label14.TabIndex = 54;
            this.label14.Text = "Thành tiền :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(119, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 26);
            this.label13.TabIndex = 53;
            this.label13.Text = "Khuyến mãi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 26);
            this.label12.TabIndex = 52;
            this.label12.Text = "Thuế VAT :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 26);
            this.label11.TabIndex = 51;
            this.label11.Text = "Giá nhập từng sản phẩm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 26);
            this.label10.TabIndex = 50;
            this.label10.Text = "Số lượng sản phẩm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 26);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã hoá đơn :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(759, 522);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(179, 56);
            this.btn_Xoa.TabIndex = 48;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(488, 522);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(207, 56);
            this.btn_Sua.TabIndex = 47;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Tomato;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.Location = new System.Drawing.Point(231, 522);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 56);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_ThanhTienTungSP
            // 
            this.txt_ThanhTienTungSP.Location = new System.Drawing.Point(475, 408);
            this.txt_ThanhTienTungSP.Name = "txt_ThanhTienTungSP";
            this.txt_ThanhTienTungSP.Size = new System.Drawing.Size(395, 26);
            this.txt_ThanhTienTungSP.TabIndex = 43;
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.Location = new System.Drawing.Point(475, 355);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.Size = new System.Drawing.Size(395, 26);
            this.txt_KhuyenMai.TabIndex = 42;
            // 
            // txt_ThueVAT
            // 
            this.txt_ThueVAT.Location = new System.Drawing.Point(475, 306);
            this.txt_ThueVAT.Name = "txt_ThueVAT";
            this.txt_ThueVAT.Size = new System.Drawing.Size(395, 26);
            this.txt_ThueVAT.TabIndex = 41;
            // 
            // txt_GiabanTungSP
            // 
            this.txt_GiabanTungSP.Location = new System.Drawing.Point(475, 253);
            this.txt_GiabanTungSP.Name = "txt_GiabanTungSP";
            this.txt_GiabanTungSP.Size = new System.Drawing.Size(395, 26);
            this.txt_GiabanTungSP.TabIndex = 40;
            // 
            // txt_SoluongSP
            // 
            this.txt_SoluongSP.Location = new System.Drawing.Point(475, 194);
            this.txt_SoluongSP.Name = "txt_SoluongSP";
            this.txt_SoluongSP.Size = new System.Drawing.Size(395, 26);
            this.txt_SoluongSP.TabIndex = 39;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(475, 134);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(395, 26);
            this.txt_MaHD.TabIndex = 38;
            // 
            // txt_MaGiayTT
            // 
            this.txt_MaGiayTT.Location = new System.Drawing.Point(475, 78);
            this.txt_MaGiayTT.Name = "txt_MaGiayTT";
            this.txt_MaGiayTT.Size = new System.Drawing.Size(395, 26);
            this.txt_MaGiayTT.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã Giày Thể Thao :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(352, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 43);
            this.label7.TabIndex = 35;
            this.label7.Text = "Chỉnh Sửa Chi Tiết Hoá Đơn";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1271, 667);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi_Tiet_Hoa_Don)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Chi_Tiet_Hoa_Don;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_ThanhTienTungSP;
        private System.Windows.Forms.TextBox txt_KhuyenMai;
        private System.Windows.Forms.TextBox txt_ThueVAT;
        private System.Windows.Forms.TextBox txt_GiabanTungSP;
        private System.Windows.Forms.TextBox txt_SoluongSP;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.TextBox txt_MaGiayTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanTungSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienSanPham;
        private System.Windows.Forms.Button btn_HienThongTin;
    }
}