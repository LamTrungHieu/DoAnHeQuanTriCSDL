namespace ShoesStore
{
    partial class HoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tim_Kiem_HoaDon = new System.Windows.Forms.Button();
            this.lab5 = new System.Windows.Forms.Label();
            this.date_Tu = new System.Windows.Forms.DateTimePicker();
            this.date_Den = new System.Windows.Forms.DateTimePicker();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThanhToanHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sua_HoaDon = new System.Windows.Forms.Button();
            this.btn_Them_HoaDon = new System.Windows.Forms.Button();
            this.btn_Xoa_HoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TrangThaiThanhToan_HD = new System.Windows.Forms.TextBox();
            this.txt_PhuongThucThanhToan_HD = new System.Windows.Forms.TextBox();
            this.txt_SoTienThanhToan_HD = new System.Windows.Forms.TextBox();
            this.txt_MaNV_HD = new System.Windows.Forms.TextBox();
            this.txt_MaKH_HD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(394, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin hoá đơn";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Đến :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Tim_Kiem_HoaDon
            // 
            this.btn_Tim_Kiem_HoaDon.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_Kiem_HoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_Kiem_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_Kiem_HoaDon.Location = new System.Drawing.Point(886, 65);
            this.btn_Tim_Kiem_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim_Kiem_HoaDon.Name = "btn_Tim_Kiem_HoaDon";
            this.btn_Tim_Kiem_HoaDon.Size = new System.Drawing.Size(100, 54);
            this.btn_Tim_Kiem_HoaDon.TabIndex = 22;
            this.btn_Tim_Kiem_HoaDon.Text = "Tìm";
            this.btn_Tim_Kiem_HoaDon.UseVisualStyleBackColor = false;
            this.btn_Tim_Kiem_HoaDon.Click += new System.EventHandler(this.btn_Tim_Kiem_HoaDon_Click);
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.Location = new System.Drawing.Point(98, 101);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(37, 18);
            this.lab5.TabIndex = 20;
            this.lab5.Text = "Từ :";
            // 
            // date_Tu
            // 
            this.date_Tu.Location = new System.Drawing.Point(163, 101);
            this.date_Tu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_Tu.Name = "date_Tu";
            this.date_Tu.Size = new System.Drawing.Size(253, 22);
            this.date_Tu.TabIndex = 24;
            // 
            // date_Den
            // 
            this.date_Den.Location = new System.Drawing.Point(546, 101);
            this.date_Den.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_Den.Name = "date_Den";
            this.date_Den.Size = new System.Drawing.Size(253, 22);
            this.date_Den.TabIndex = 25;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayMuaHang,
            this.SoTienThanhToanHoaDon,
            this.PhuongThucThanhToan,
            this.TrangThaiThanhToan});
            this.dgv_HoaDon.GridColor = System.Drawing.Color.White;
            this.dgv_HoaDon.Location = new System.Drawing.Point(7, 201);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 62;
            this.dgv_HoaDon.RowTemplate.Height = 28;
            this.dgv_HoaDon.Size = new System.Drawing.Size(979, 307);
            this.dgv_HoaDon.TabIndex = 26;
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hoá đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // NgayMuaHang
            // 
            this.NgayMuaHang.DataPropertyName = "NgayMuaHang";
            this.NgayMuaHang.HeaderText = "Ngày mua hàng";
            this.NgayMuaHang.MinimumWidth = 8;
            this.NgayMuaHang.Name = "NgayMuaHang";
            // 
            // SoTienThanhToanHoaDon
            // 
            this.SoTienThanhToanHoaDon.DataPropertyName = "SoTienThanhToanHoaDon";
            this.SoTienThanhToanHoaDon.HeaderText = "Số tiền thanh toán";
            this.SoTienThanhToanHoaDon.MinimumWidth = 8;
            this.SoTienThanhToanHoaDon.Name = "SoTienThanhToanHoaDon";
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 8;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            // 
            // TrangThaiThanhToan
            // 
            this.TrangThaiThanhToan.DataPropertyName = "TrangThaiThanhToan";
            this.TrangThaiThanhToan.HeaderText = "Trạng thái thanh toán";
            this.TrangThaiThanhToan.MinimumWidth = 8;
            this.TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 569);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_HoaDon);
            this.tabPage1.Controls.Add(this.lab5);
            this.tabPage1.Controls.Add(this.date_Den);
            this.tabPage1.Controls.Add(this.btn_Tim_Kiem_HoaDon);
            this.tabPage1.Controls.Add(this.date_Tu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tùy chỉnh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sua_HoaDon);
            this.panel1.Controls.Add(this.btn_Them_HoaDon);
            this.panel1.Controls.Add(this.btn_Xoa_HoaDon);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_TrangThaiThanhToan_HD);
            this.panel1.Controls.Add(this.txt_PhuongThucThanhToan_HD);
            this.panel1.Controls.Add(this.txt_SoTienThanhToan_HD);
            this.panel1.Controls.Add(this.txt_MaNV_HD);
            this.panel1.Controls.Add(this.txt_MaKH_HD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_MaHD);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 534);
            this.panel1.TabIndex = 0;
            // 
            // btn_Sua_HoaDon
            // 
            this.btn_Sua_HoaDon.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Sua_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_HoaDon.Location = new System.Drawing.Point(789, 252);
            this.btn_Sua_HoaDon.Name = "btn_Sua_HoaDon";
            this.btn_Sua_HoaDon.Size = new System.Drawing.Size(111, 56);
            this.btn_Sua_HoaDon.TabIndex = 32;
            this.btn_Sua_HoaDon.Text = "Sửa";
            this.btn_Sua_HoaDon.UseVisualStyleBackColor = false;
            this.btn_Sua_HoaDon.Click += new System.EventHandler(this.btn_Sua_HoaDon_Click);
            // 
            // btn_Them_HoaDon
            // 
            this.btn_Them_HoaDon.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Them_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_HoaDon.Location = new System.Drawing.Point(789, 140);
            this.btn_Them_HoaDon.Name = "btn_Them_HoaDon";
            this.btn_Them_HoaDon.Size = new System.Drawing.Size(111, 56);
            this.btn_Them_HoaDon.TabIndex = 31;
            this.btn_Them_HoaDon.Text = "Thêm";
            this.btn_Them_HoaDon.UseVisualStyleBackColor = false;
            this.btn_Them_HoaDon.Click += new System.EventHandler(this.btn_Them_HoaDon_Click);
            // 
            // btn_Xoa_HoaDon
            // 
            this.btn_Xoa_HoaDon.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Xoa_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_HoaDon.Location = new System.Drawing.Point(789, 365);
            this.btn_Xoa_HoaDon.Name = "btn_Xoa_HoaDon";
            this.btn_Xoa_HoaDon.Size = new System.Drawing.Size(111, 56);
            this.btn_Xoa_HoaDon.TabIndex = 30;
            this.btn_Xoa_HoaDon.Text = "Xóa";
            this.btn_Xoa_HoaDon.UseVisualStyleBackColor = false;
            this.btn_Xoa_HoaDon.Click += new System.EventHandler(this.btn_Xoa_HoaDon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Trạng thái thanh toán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phương thức thanh toán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số tiền thanh toán hóa đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // txt_TrangThaiThanhToan_HD
            // 
            this.txt_TrangThaiThanhToan_HD.Location = new System.Drawing.Point(471, 422);
            this.txt_TrangThaiThanhToan_HD.Name = "txt_TrangThaiThanhToan_HD";
            this.txt_TrangThaiThanhToan_HD.Size = new System.Drawing.Size(219, 22);
            this.txt_TrangThaiThanhToan_HD.TabIndex = 21;
            // 
            // txt_PhuongThucThanhToan_HD
            // 
            this.txt_PhuongThucThanhToan_HD.Location = new System.Drawing.Point(471, 365);
            this.txt_PhuongThucThanhToan_HD.Name = "txt_PhuongThucThanhToan_HD";
            this.txt_PhuongThucThanhToan_HD.Size = new System.Drawing.Size(219, 22);
            this.txt_PhuongThucThanhToan_HD.TabIndex = 20;
            // 
            // txt_SoTienThanhToan_HD
            // 
            this.txt_SoTienThanhToan_HD.Location = new System.Drawing.Point(471, 305);
            this.txt_SoTienThanhToan_HD.Name = "txt_SoTienThanhToan_HD";
            this.txt_SoTienThanhToan_HD.Size = new System.Drawing.Size(219, 22);
            this.txt_SoTienThanhToan_HD.TabIndex = 19;
            // 
            // txt_MaNV_HD
            // 
            this.txt_MaNV_HD.Location = new System.Drawing.Point(471, 239);
            this.txt_MaNV_HD.Name = "txt_MaNV_HD";
            this.txt_MaNV_HD.Size = new System.Drawing.Size(219, 22);
            this.txt_MaNV_HD.TabIndex = 18;
            // 
            // txt_MaKH_HD
            // 
            this.txt_MaKH_HD.Location = new System.Drawing.Point(471, 174);
            this.txt_MaKH_HD.Name = "txt_MaKH_HD";
            this.txt_MaKH_HD.Size = new System.Drawing.Size(219, 22);
            this.txt_MaKH_HD.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(368, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tùy chỉnh thông tin hoá đơn";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(471, 117);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(219, 22);
            this.txt_MaHD.TabIndex = 0;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 573);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tim_Kiem_HoaDon;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.DateTimePicker date_Tu;
        private System.Windows.Forms.DateTimePicker date_Den;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThanhToanHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThanhToan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa_HoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TrangThaiThanhToan_HD;
        private System.Windows.Forms.TextBox txt_PhuongThucThanhToan_HD;
        private System.Windows.Forms.TextBox txt_SoTienThanhToan_HD;
        private System.Windows.Forms.TextBox txt_MaNV_HD;
        private System.Windows.Forms.TextBox txt_MaKH_HD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Button btn_Sua_HoaDon;
        private System.Windows.Forms.Button btn_Them_HoaDon;
    }
}