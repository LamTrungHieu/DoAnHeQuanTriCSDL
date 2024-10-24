namespace ShoesStore
{
    partial class PhuKien
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
            this.dgv_GoiPhuKien = new System.Windows.Forms.DataGridView();
            this.MaGoiPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGoiPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem_GoiDichVu = new System.Windows.Forms.Button();
            this.txt_TimKiem_GoiPhuKien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PhiPK = new System.Windows.Forms.TextBox();
            this.txt_TenGoiPK = new System.Windows.Forms.TextBox();
            this.txt_MaGoiPhuKien = new System.Windows.Forms.TextBox();
            this.btn_Sua_GoiPhuKien = new System.Windows.Forms.Button();
            this.btn_Them_GoiPhuKien = new System.Windows.Forms.Button();
            this.btn_Xoa_GoiPhuKien = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TimKiem_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TimKiem_MaNhanVien = new System.Windows.Forms.TextBox();
            this.btn_TimKiem_BanPhuKien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TimKiem_MaGoiPK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_BanPhuKien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGoiPhuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_MaKH_BPK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MaNV_BPK = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_MaGoi_BPK = new System.Windows.Forms.TextBox();
            this.btn_Sua_BPK = new System.Windows.Forms.Button();
            this.btn_Them_BPK = new System.Windows.Forms.Button();
            this.btn_Xoa_BPK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoiPhuKien)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanPhuKien)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_GoiPhuKien
            // 
            this.dgv_GoiPhuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GoiPhuKien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_GoiPhuKien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_GoiPhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GoiPhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGoiPK,
            this.TenGoiPK,
            this.GiaPK});
            this.dgv_GoiPhuKien.GridColor = System.Drawing.Color.White;
            this.dgv_GoiPhuKien.Location = new System.Drawing.Point(109, 226);
            this.dgv_GoiPhuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_GoiPhuKien.Name = "dgv_GoiPhuKien";
            this.dgv_GoiPhuKien.RowHeadersWidth = 62;
            this.dgv_GoiPhuKien.RowTemplate.Height = 28;
            this.dgv_GoiPhuKien.Size = new System.Drawing.Size(746, 200);
            this.dgv_GoiPhuKien.TabIndex = 22;
            this.dgv_GoiPhuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GoiPhuKien_CellContentClick);
            // 
            // MaGoiPK
            // 
            this.MaGoiPK.DataPropertyName = "MaGoiPK";
            this.MaGoiPK.HeaderText = "Mã gói phụ kiện";
            this.MaGoiPK.MinimumWidth = 8;
            this.MaGoiPK.Name = "MaGoiPK";
            // 
            // TenGoiPK
            // 
            this.TenGoiPK.DataPropertyName = "TenGoiPK";
            this.TenGoiPK.HeaderText = "Tên gói phụ kiện";
            this.TenGoiPK.MinimumWidth = 8;
            this.TenGoiPK.Name = "TenGoiPK";
            // 
            // GiaPK
            // 
            this.GiaPK.DataPropertyName = "GiaPK";
            this.GiaPK.HeaderText = "Giá phụ kiện";
            this.GiaPK.MinimumWidth = 8;
            this.GiaPK.Name = "GiaPK";
            // 
            // btn_TimKiem_GoiDichVu
            // 
            this.btn_TimKiem_GoiDichVu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_TimKiem_GoiDichVu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiem_GoiDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem_GoiDichVu.Location = new System.Drawing.Point(771, 97);
            this.btn_TimKiem_GoiDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem_GoiDichVu.Name = "btn_TimKiem_GoiDichVu";
            this.btn_TimKiem_GoiDichVu.Size = new System.Drawing.Size(84, 38);
            this.btn_TimKiem_GoiDichVu.TabIndex = 21;
            this.btn_TimKiem_GoiDichVu.Text = "Tìm";
            this.btn_TimKiem_GoiDichVu.UseVisualStyleBackColor = false;
            this.btn_TimKiem_GoiDichVu.Click += new System.EventHandler(this.btn_TimKiem_GoiDichVu_Click);
            // 
            // txt_TimKiem_GoiPhuKien
            // 
            this.txt_TimKiem_GoiPhuKien.Location = new System.Drawing.Point(551, 126);
            this.txt_TimKiem_GoiPhuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem_GoiPhuKien.Name = "txt_TimKiem_GoiPhuKien";
            this.txt_TimKiem_GoiPhuKien.Size = new System.Drawing.Size(161, 22);
            this.txt_TimKiem_GoiPhuKien.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhập mã gói phụ kiện :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(341, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin Phụ Kiện";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_GoiPhuKien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_TimKiem_GoiDichVu);
            this.panel1.Controls.Add(this.txt_TimKiem_GoiPhuKien);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 522);
            this.panel1.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 555);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin phụ kiện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tùy chỉnh gói phụ kiện";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_PhiPK);
            this.panel3.Controls.Add(this.txt_TenGoiPK);
            this.panel3.Controls.Add(this.txt_MaGoiPhuKien);
            this.panel3.Controls.Add(this.btn_Sua_GoiPhuKien);
            this.panel3.Controls.Add(this.btn_Them_GoiPhuKien);
            this.panel3.Controls.Add(this.btn_Xoa_GoiPhuKien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 523);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Giá bán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tên gói phụ kiện:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Mã gói phụ kiện:";
            // 
            // txt_PhiPK
            // 
            this.txt_PhiPK.Location = new System.Drawing.Point(320, 292);
            this.txt_PhiPK.Name = "txt_PhiPK";
            this.txt_PhiPK.Size = new System.Drawing.Size(219, 22);
            this.txt_PhiPK.TabIndex = 38;
            // 
            // txt_TenGoiPK
            // 
            this.txt_TenGoiPK.Location = new System.Drawing.Point(320, 227);
            this.txt_TenGoiPK.Name = "txt_TenGoiPK";
            this.txt_TenGoiPK.Size = new System.Drawing.Size(219, 22);
            this.txt_TenGoiPK.TabIndex = 37;
            // 
            // txt_MaGoiPhuKien
            // 
            this.txt_MaGoiPhuKien.Location = new System.Drawing.Point(320, 170);
            this.txt_MaGoiPhuKien.Name = "txt_MaGoiPhuKien";
            this.txt_MaGoiPhuKien.Size = new System.Drawing.Size(219, 22);
            this.txt_MaGoiPhuKien.TabIndex = 36;
            // 
            // btn_Sua_GoiPhuKien
            // 
            this.btn_Sua_GoiPhuKien.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Sua_GoiPhuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_GoiPhuKien.Location = new System.Drawing.Point(659, 248);
            this.btn_Sua_GoiPhuKien.Name = "btn_Sua_GoiPhuKien";
            this.btn_Sua_GoiPhuKien.Size = new System.Drawing.Size(111, 56);
            this.btn_Sua_GoiPhuKien.TabIndex = 35;
            this.btn_Sua_GoiPhuKien.Text = "Sửa";
            this.btn_Sua_GoiPhuKien.UseVisualStyleBackColor = false;
            this.btn_Sua_GoiPhuKien.Click += new System.EventHandler(this.btn_Sua_GoiPhuKien_Click);
            // 
            // btn_Them_GoiPhuKien
            // 
            this.btn_Them_GoiPhuKien.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Them_GoiPhuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_GoiPhuKien.Location = new System.Drawing.Point(659, 136);
            this.btn_Them_GoiPhuKien.Name = "btn_Them_GoiPhuKien";
            this.btn_Them_GoiPhuKien.Size = new System.Drawing.Size(111, 56);
            this.btn_Them_GoiPhuKien.TabIndex = 34;
            this.btn_Them_GoiPhuKien.Text = "Thêm";
            this.btn_Them_GoiPhuKien.UseVisualStyleBackColor = false;
            this.btn_Them_GoiPhuKien.Click += new System.EventHandler(this.btn_Them_GoiPhuKien_Click);
            // 
            // btn_Xoa_GoiPhuKien
            // 
            this.btn_Xoa_GoiPhuKien.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Xoa_GoiPhuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_GoiPhuKien.Location = new System.Drawing.Point(659, 361);
            this.btn_Xoa_GoiPhuKien.Name = "btn_Xoa_GoiPhuKien";
            this.btn_Xoa_GoiPhuKien.Size = new System.Drawing.Size(111, 56);
            this.btn_Xoa_GoiPhuKien.TabIndex = 33;
            this.btn_Xoa_GoiPhuKien.Text = "Xóa";
            this.btn_Xoa_GoiPhuKien.UseVisualStyleBackColor = false;
            this.btn_Xoa_GoiPhuKien.Click += new System.EventHandler(this.btn_Xoa_GoiPhuKien_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(320, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tùy chỉnh gói phụ kiện";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin hoạt động bán phụ kiện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_TimKiem_MaKhachHang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_TimKiem_MaNhanVien);
            this.panel2.Controls.Add(this.btn_TimKiem_BanPhuKien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_TimKiem_MaGoiPK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_BanPhuKien);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 522);
            this.panel2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhập mã khách hàng:";
            // 
            // txt_TimKiem_MaKhachHang
            // 
            this.txt_TimKiem_MaKhachHang.Location = new System.Drawing.Point(330, 114);
            this.txt_TimKiem_MaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem_MaKhachHang.Name = "txt_TimKiem_MaKhachHang";
            this.txt_TimKiem_MaKhachHang.Size = new System.Drawing.Size(161, 22);
            this.txt_TimKiem_MaKhachHang.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nhập mã nhân viên:";
            // 
            // txt_TimKiem_MaNhanVien
            // 
            this.txt_TimKiem_MaNhanVien.Location = new System.Drawing.Point(109, 114);
            this.txt_TimKiem_MaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem_MaNhanVien.Name = "txt_TimKiem_MaNhanVien";
            this.txt_TimKiem_MaNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txt_TimKiem_MaNhanVien.TabIndex = 27;
            // 
            // btn_TimKiem_BanPhuKien
            // 
            this.btn_TimKiem_BanPhuKien.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_TimKiem_BanPhuKien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiem_BanPhuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem_BanPhuKien.Location = new System.Drawing.Point(800, 98);
            this.btn_TimKiem_BanPhuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem_BanPhuKien.Name = "btn_TimKiem_BanPhuKien";
            this.btn_TimKiem_BanPhuKien.Size = new System.Drawing.Size(84, 38);
            this.btn_TimKiem_BanPhuKien.TabIndex = 25;
            this.btn_TimKiem_BanPhuKien.Text = "Tìm";
            this.btn_TimKiem_BanPhuKien.UseVisualStyleBackColor = false;
            this.btn_TimKiem_BanPhuKien.Click += new System.EventHandler(this.btn_TimKiem_BanPhuKien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nhập mã gói phụ kiện:";
            // 
            // txt_TimKiem_MaGoiPK
            // 
            this.txt_TimKiem_MaGoiPK.Location = new System.Drawing.Point(552, 115);
            this.txt_TimKiem_MaGoiPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem_MaGoiPK.Name = "txt_TimKiem_MaGoiPK";
            this.txt_TimKiem_MaGoiPK.Size = new System.Drawing.Size(161, 22);
            this.txt_TimKiem_MaGoiPK.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(341, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin Phụ Kiện";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // dgv_BanPhuKien
            // 
            this.dgv_BanPhuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BanPhuKien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_BanPhuKien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_BanPhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BanPhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MaKH,
            this.MaGoiPhuKien});
            this.dgv_BanPhuKien.GridColor = System.Drawing.Color.White;
            this.dgv_BanPhuKien.Location = new System.Drawing.Point(109, 226);
            this.dgv_BanPhuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_BanPhuKien.Name = "dgv_BanPhuKien";
            this.dgv_BanPhuKien.RowHeadersWidth = 62;
            this.dgv_BanPhuKien.RowTemplate.Height = 28;
            this.dgv_BanPhuKien.Size = new System.Drawing.Size(746, 200);
            this.dgv_BanPhuKien.TabIndex = 22;
            this.dgv_BanPhuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BanPhuKien_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            // 
            // MaGoiPhuKien
            // 
            this.MaGoiPhuKien.DataPropertyName = "MaGoiPK";
            this.MaGoiPhuKien.HeaderText = "Mã gói phụ kiện";
            this.MaGoiPhuKien.MinimumWidth = 8;
            this.MaGoiPhuKien.Name = "MaGoiPhuKien";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(924, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tùy chỉnh hoạt động bán phụ kiện";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_MaKH_BPK);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_MaNV_BPK);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt_MaGoi_BPK);
            this.panel4.Controls.Add(this.btn_Sua_BPK);
            this.panel4.Controls.Add(this.btn_Them_BPK);
            this.panel4.Controls.Add(this.btn_Xoa_BPK);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(918, 523);
            this.panel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(125, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Mã khách hàng:";
            // 
            // txt_MaKH_BPK
            // 
            this.txt_MaKH_BPK.Location = new System.Drawing.Point(325, 244);
            this.txt_MaKH_BPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKH_BPK.Name = "txt_MaKH_BPK";
            this.txt_MaKH_BPK.Size = new System.Drawing.Size(161, 22);
            this.txt_MaKH_BPK.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(125, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 38;
            this.label12.Text = "Mã nhân viên:";
            // 
            // txt_MaNV_BPK
            // 
            this.txt_MaNV_BPK.Location = new System.Drawing.Point(325, 173);
            this.txt_MaNV_BPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV_BPK.Name = "txt_MaNV_BPK";
            this.txt_MaNV_BPK.Size = new System.Drawing.Size(161, 22);
            this.txt_MaNV_BPK.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(125, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "Mã gói phụ kiện:";
            // 
            // txt_MaGoi_BPK
            // 
            this.txt_MaGoi_BPK.Location = new System.Drawing.Point(325, 321);
            this.txt_MaGoi_BPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaGoi_BPK.Name = "txt_MaGoi_BPK";
            this.txt_MaGoi_BPK.Size = new System.Drawing.Size(161, 22);
            this.txt_MaGoi_BPK.TabIndex = 37;
            // 
            // btn_Sua_BPK
            // 
            this.btn_Sua_BPK.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Sua_BPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_BPK.Location = new System.Drawing.Point(659, 248);
            this.btn_Sua_BPK.Name = "btn_Sua_BPK";
            this.btn_Sua_BPK.Size = new System.Drawing.Size(111, 56);
            this.btn_Sua_BPK.TabIndex = 35;
            this.btn_Sua_BPK.Text = "Sửa";
            this.btn_Sua_BPK.UseVisualStyleBackColor = false;
            this.btn_Sua_BPK.Click += new System.EventHandler(this.btn_Sua_BPK_Click);
            // 
            // btn_Them_BPK
            // 
            this.btn_Them_BPK.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Them_BPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_BPK.Location = new System.Drawing.Point(659, 136);
            this.btn_Them_BPK.Name = "btn_Them_BPK";
            this.btn_Them_BPK.Size = new System.Drawing.Size(111, 56);
            this.btn_Them_BPK.TabIndex = 34;
            this.btn_Them_BPK.Text = "Thêm";
            this.btn_Them_BPK.UseVisualStyleBackColor = false;
            this.btn_Them_BPK.Click += new System.EventHandler(this.btn_Them_BPK_Click);
            // 
            // btn_Xoa_BPK
            // 
            this.btn_Xoa_BPK.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Xoa_BPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_BPK.Location = new System.Drawing.Point(659, 361);
            this.btn_Xoa_BPK.Name = "btn_Xoa_BPK";
            this.btn_Xoa_BPK.Size = new System.Drawing.Size(111, 56);
            this.btn_Xoa_BPK.TabIndex = 33;
            this.btn_Xoa_BPK.Text = "Xóa";
            this.btn_Xoa_BPK.UseVisualStyleBackColor = false;
            this.btn_Xoa_BPK.Click += new System.EventHandler(this.btn_Xoa_BPK_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(246, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(386, 36);
            this.label14.TabIndex = 19;
            this.label14.Text = "Tùy chỉnh hoạt động bán phụ kiện";
            this.label14.UseCompatibleTextRendering = true;
            // 
            // PhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1218, 926);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhuKien";
            this.Text = "PhuKien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoiPhuKien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanPhuKien)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GoiPhuKien;
        private System.Windows.Forms.Button btn_TimKiem_GoiDichVu;
        private System.Windows.Forms.TextBox txt_TimKiem_GoiPhuKien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_BanPhuKien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TimKiem_MaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TimKiem_MaNhanVien;
        private System.Windows.Forms.Button btn_TimKiem_BanPhuKien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimKiem_MaGoiPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGoiPhuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGoiPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoiPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPK;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Sua_GoiPhuKien;
        private System.Windows.Forms.Button btn_Them_GoiPhuKien;
        private System.Windows.Forms.Button btn_Xoa_GoiPhuKien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PhiPK;
        private System.Windows.Forms.TextBox txt_TenGoiPK;
        private System.Windows.Forms.TextBox txt_MaGoiPhuKien;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_MaKH_BPK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_MaNV_BPK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_MaGoi_BPK;
        private System.Windows.Forms.Button btn_Sua_BPK;
        private System.Windows.Forms.Button btn_Them_BPK;
        private System.Windows.Forms.Button btn_Xoa_BPK;
        private System.Windows.Forms.Label label14;
    }
}