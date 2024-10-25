namespace ShoesStore
{
    partial class PhieuNhapKho
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
            this.dgv_PhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.Manhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotienthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuongthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthaithanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tim_nhapkho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HienThongTin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_trangthaithanhtoan = new System.Windows.Forms.TextBox();
            this.txt_Phuongthucthanhtoan = new System.Windows.Forms.TextBox();
            this.txt_TienNhapKho = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.txt_MaNK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(408, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phiếu Nhập Kho";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_PhieuNhapKho
            // 
            this.dgv_PhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhapKho.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_PhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhapkho,
            this.MaNCC,
            this.Manhanvien,
            this.Ngaynhapkho,
            this.Sotienthanhtoan,
            this.phuongthucthanhtoan,
            this.Trangthaithanhtoan});
            this.dgv_PhieuNhapKho.GridColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.Location = new System.Drawing.Point(18, 249);
            this.dgv_PhieuNhapKho.Name = "dgv_PhieuNhapKho";
            this.dgv_PhieuNhapKho.RowHeadersWidth = 62;
            this.dgv_PhieuNhapKho.RowTemplate.Height = 28;
            this.dgv_PhieuNhapKho.Size = new System.Drawing.Size(1093, 389);
            this.dgv_PhieuNhapKho.TabIndex = 30;
            this.dgv_PhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hoa_Don_CellContentClick);
            // 
            // Manhapkho
            // 
            this.Manhapkho.DataPropertyName = "MaNK";
            this.Manhapkho.HeaderText = "Mã nhập kho";
            this.Manhapkho.MinimumWidth = 8;
            this.Manhapkho.Name = "Manhapkho";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // Manhanvien
            // 
            this.Manhanvien.DataPropertyName = "MaNV";
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.MinimumWidth = 8;
            this.Manhanvien.Name = "Manhanvien";
            // 
            // Ngaynhapkho
            // 
            this.Ngaynhapkho.DataPropertyName = "NgayNhapKho";
            this.Ngaynhapkho.HeaderText = "Ngày nhập kho";
            this.Ngaynhapkho.MinimumWidth = 8;
            this.Ngaynhapkho.Name = "Ngaynhapkho";
            // 
            // Sotienthanhtoan
            // 
            this.Sotienthanhtoan.DataPropertyName = "SoTienThanhToanNhapKho";
            this.Sotienthanhtoan.HeaderText = "Số tiền thanh toán";
            this.Sotienthanhtoan.MinimumWidth = 8;
            this.Sotienthanhtoan.Name = "Sotienthanhtoan";
            // 
            // phuongthucthanhtoan
            // 
            this.phuongthucthanhtoan.DataPropertyName = "PhuongThucThanhToan";
            this.phuongthucthanhtoan.HeaderText = "Phương thức thanh toán";
            this.phuongthucthanhtoan.MinimumWidth = 8;
            this.phuongthucthanhtoan.Name = "phuongthucthanhtoan";
            // 
            // Trangthaithanhtoan
            // 
            this.Trangthaithanhtoan.DataPropertyName = "TrangThaiThanhToan";
            this.Trangthaithanhtoan.HeaderText = "Trạng thái thanh toán";
            this.Trangthaithanhtoan.MinimumWidth = 8;
            this.Trangthaithanhtoan.Name = "Trangthaithanhtoan";
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.Location = new System.Drawing.Point(581, 125);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(284, 26);
            this.date_ngaynhap.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập ngày nhập kho :";
            // 
            // btn_Tim_nhapkho
            // 
            this.btn_Tim_nhapkho.BackColor = System.Drawing.Color.Tomato;
            this.btn_Tim_nhapkho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_nhapkho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_nhapkho.Location = new System.Drawing.Point(979, 143);
            this.btn_Tim_nhapkho.Name = "btn_Tim_nhapkho";
            this.btn_Tim_nhapkho.Size = new System.Drawing.Size(119, 60);
            this.btn_Tim_nhapkho.TabIndex = 27;
            this.btn_Tim_nhapkho.Text = "Tìm";
            this.btn_Tim_nhapkho.UseVisualStyleBackColor = false;
            this.btn_Tim_nhapkho.Click += new System.EventHandler(this.btn_Tim_nhapkho_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_HienThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_PhieuNhapKho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Tim_nhapkho);
            this.panel1.Controls.Add(this.date_ngaynhap);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 652);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_HienThongTin
            // 
            this.btn_HienThongTin.BackColor = System.Drawing.Color.Brown;
            this.btn_HienThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HienThongTin.Location = new System.Drawing.Point(979, 76);
            this.btn_HienThongTin.Name = "btn_HienThongTin";
            this.btn_HienThongTin.Size = new System.Drawing.Size(119, 61);
            this.btn_HienThongTin.TabIndex = 31;
            this.btn_HienThongTin.Text = "Hiện Thông Tin";
            this.btn_HienThongTin.UseVisualStyleBackColor = false;
            this.btn_HienThongTin.Click += new System.EventHandler(this.btn_HienThongTin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 706);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1204, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infor ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Xoa);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Controls.Add(this.btn_Them);
            this.tabPage2.Controls.Add(this.txt_trangthaithanhtoan);
            this.tabPage2.Controls.Add(this.txt_Phuongthucthanhtoan);
            this.tabPage2.Controls.Add(this.txt_TienNhapKho);
            this.tabPage2.Controls.Add(this.txt_MaNV);
            this.tabPage2.Controls.Add(this.txt_MaNCC);
            this.tabPage2.Controls.Add(this.txt_MaNK);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 26);
            this.label13.TabIndex = 53;
            this.label13.Text = "Trạng thái thanh toán :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 26);
            this.label12.TabIndex = 52;
            this.label12.Text = "Phương thức thanh toán :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 26);
            this.label11.TabIndex = 51;
            this.label11.Text = "Số tiền thanh toán nhập kho :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 26);
            this.label10.TabIndex = 50;
            this.label10.Text = "Mã nhân viên :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 26);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã nhà cung cấp :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(769, 478);
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
            this.btn_Sua.Location = new System.Drawing.Point(450, 478);
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
            this.btn_Them.Location = new System.Drawing.Point(122, 478);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 56);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_trangthaithanhtoan
            // 
            this.txt_trangthaithanhtoan.Location = new System.Drawing.Point(485, 389);
            this.txt_trangthaithanhtoan.Name = "txt_trangthaithanhtoan";
            this.txt_trangthaithanhtoan.Size = new System.Drawing.Size(395, 26);
            this.txt_trangthaithanhtoan.TabIndex = 42;
            // 
            // txt_Phuongthucthanhtoan
            // 
            this.txt_Phuongthucthanhtoan.Location = new System.Drawing.Point(485, 326);
            this.txt_Phuongthucthanhtoan.Name = "txt_Phuongthucthanhtoan";
            this.txt_Phuongthucthanhtoan.Size = new System.Drawing.Size(395, 26);
            this.txt_Phuongthucthanhtoan.TabIndex = 41;
            // 
            // txt_TienNhapKho
            // 
            this.txt_TienNhapKho.Location = new System.Drawing.Point(485, 270);
            this.txt_TienNhapKho.Name = "txt_TienNhapKho";
            this.txt_TienNhapKho.Size = new System.Drawing.Size(395, 26);
            this.txt_TienNhapKho.TabIndex = 40;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(488, 208);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(395, 26);
            this.txt_MaNV.TabIndex = 39;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(488, 153);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(395, 26);
            this.txt_MaNCC.TabIndex = 38;
            // 
            // txt_MaNK
            // 
            this.txt_MaNK.Location = new System.Drawing.Point(488, 98);
            this.txt_MaNK.Name = "txt_MaNK";
            this.txt_MaNK.Size = new System.Drawing.Size(395, 26);
            this.txt_MaNK.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã nhập kho :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(296, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(527, 43);
            this.label7.TabIndex = 35;
            this.label7.Text = "Chỉnh Sửa Thông Tin Phiếu Nhập Kho";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // PhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1221, 729);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuNhapKho";
            this.Text = "PhieuNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PhieuNhapKho;
        private System.Windows.Forms.DateTimePicker date_ngaynhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tim_nhapkho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_trangthaithanhtoan;
        private System.Windows.Forms.TextBox txt_Phuongthucthanhtoan;
        private System.Windows.Forms.TextBox txt_TienNhapKho;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.TextBox txt_MaNK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_HienThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotienthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongthucthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaithanhtoan;
    }
}