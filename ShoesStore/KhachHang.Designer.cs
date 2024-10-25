namespace ShoesStore
{
    partial class KhachHang
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
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienDaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem_KhachHang = new System.Windows.Forms.Button();
            this.txt_TimKiemKH_HoTenKH = new System.Windows.Forms.TextBox();
            this.lab5 = new System.Windows.Forms.Label();
            this.txt_TimKiemKH_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Xoa_KhacHang = new System.Windows.Forms.Button();
            this.btn_Sua_KhacHang = new System.Windows.Forms.Button();
            this.btn_Them_KhacHang = new System.Windows.Forms.Button();
            this.txt_LoaiKH = new System.Windows.Forms.TextBox();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.txt_TongSoTienDaGiaoDich = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTenKH,
            this.LoaiKH,
            this.SDT,
            this.Email,
            this.TongSoTienDaGD});
            this.dgv_KhachHang.GridColor = System.Drawing.Color.White;
            this.dgv_KhachHang.Location = new System.Drawing.Point(80, 228);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 62;
            this.dgv_KhachHang.RowTemplate.Height = 28;
            this.dgv_KhachHang.Size = new System.Drawing.Size(960, 349);
            this.dgv_KhachHang.TabIndex = 17;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên khách hàng";
            this.HoTenKH.MinimumWidth = 8;
            this.HoTenKH.Name = "HoTenKH";
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "LoaiKH";
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 6;
            this.LoaiKH.Name = "LoaiKH";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // TongSoTienDaGD
            // 
            this.TongSoTienDaGD.DataPropertyName = "TongSoTienDaGD";
            this.TongSoTienDaGD.HeaderText = "Tổng Số Tiền  GD";
            this.TongSoTienDaGD.MinimumWidth = 8;
            this.TongSoTienDaGD.Name = "TongSoTienDaGD";
            // 
            // btn_TimKiem_KhachHang
            // 
            this.btn_TimKiem_KhachHang.BackColor = System.Drawing.Color.Peru;
            this.btn_TimKiem_KhachHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiem_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem_KhachHang.Location = new System.Drawing.Point(983, 141);
            this.btn_TimKiem_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem_KhachHang.Name = "btn_TimKiem_KhachHang";
            this.btn_TimKiem_KhachHang.Size = new System.Drawing.Size(101, 52);
            this.btn_TimKiem_KhachHang.TabIndex = 16;
            this.btn_TimKiem_KhachHang.Text = "Tìm";
            this.btn_TimKiem_KhachHang.UseVisualStyleBackColor = false;
            this.btn_TimKiem_KhachHang.Click += new System.EventHandler(this.btn_TimKiem_KhachHang_Click);
            // 
            // txt_TimKiemKH_HoTenKH
            // 
            this.txt_TimKiemKH_HoTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiemKH_HoTenKH.Location = new System.Drawing.Point(273, 156);
            this.txt_TimKiemKH_HoTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiemKH_HoTenKH.Name = "txt_TimKiemKH_HoTenKH";
            this.txt_TimKiemKH_HoTenKH.Size = new System.Drawing.Size(232, 22);
            this.txt_TimKiemKH_HoTenKH.TabIndex = 15;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.Location = new System.Drawing.Point(65, 156);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(187, 22);
            this.lab5.TabIndex = 14;
            this.lab5.Text = "Nhập tên khách hàng : ";
            // 
            // txt_TimKiemKH_SDT
            // 
            this.txt_TimKiemKH_SDT.Location = new System.Drawing.Point(706, 156);
            this.txt_TimKiemKH_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiemKH_SDT.Name = "txt_TimKiemKH_SDT";
            this.txt_TimKiemKH_SDT.Size = new System.Drawing.Size(232, 22);
            this.txt_TimKiemKH_SDT.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập SĐT: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_KhachHang);
            this.panel1.Controls.Add(this.txt_TimKiemKH_SDT);
            this.panel1.Controls.Add(this.btn_TimKiem_KhachHang);
            this.panel1.Controls.Add(this.lab5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_TimKiemKH_HoTenKH);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 610);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(384, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 664);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin khách hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Xoa_KhacHang);
            this.tabPage2.Controls.Add(this.btn_Sua_KhacHang);
            this.tabPage2.Controls.Add(this.btn_Them_KhacHang);
            this.tabPage2.Controls.Add(this.txt_LoaiKH);
            this.tabPage2.Controls.Add(this.txt_HoTenKH);
            this.tabPage2.Controls.Add(this.txt_TongSoTienDaGiaoDich);
            this.tabPage2.Controls.Add(this.txt_SDT);
            this.tabPage2.Controls.Add(this.txt_Email);
            this.tabPage2.Controls.Add(this.txt_MaKH);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tùy chỉnh thông tin khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_Xoa_KhacHang
            // 
            this.btn_Xoa_KhacHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Xoa_KhacHang.Location = new System.Drawing.Point(733, 485);
            this.btn_Xoa_KhacHang.Name = "btn_Xoa_KhacHang";
            this.btn_Xoa_KhacHang.Size = new System.Drawing.Size(157, 60);
            this.btn_Xoa_KhacHang.TabIndex = 14;
            this.btn_Xoa_KhacHang.Text = "Xóa";
            this.btn_Xoa_KhacHang.UseVisualStyleBackColor = false;
            this.btn_Xoa_KhacHang.Click += new System.EventHandler(this.btn_Xoa_KhacHang_Click);
            // 
            // btn_Sua_KhacHang
            // 
            this.btn_Sua_KhacHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Sua_KhacHang.Location = new System.Drawing.Point(478, 485);
            this.btn_Sua_KhacHang.Name = "btn_Sua_KhacHang";
            this.btn_Sua_KhacHang.Size = new System.Drawing.Size(165, 60);
            this.btn_Sua_KhacHang.TabIndex = 13;
            this.btn_Sua_KhacHang.Text = "Sửa";
            this.btn_Sua_KhacHang.UseVisualStyleBackColor = false;
            this.btn_Sua_KhacHang.Click += new System.EventHandler(this.btn_Sua_KhacHang_Click);
            // 
            // btn_Them_KhacHang
            // 
            this.btn_Them_KhacHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Them_KhacHang.Location = new System.Drawing.Point(204, 485);
            this.btn_Them_KhacHang.Name = "btn_Them_KhacHang";
            this.btn_Them_KhacHang.Size = new System.Drawing.Size(149, 60);
            this.btn_Them_KhacHang.TabIndex = 12;
            this.btn_Them_KhacHang.Text = "Thêm";
            this.btn_Them_KhacHang.UseVisualStyleBackColor = false;
            this.btn_Them_KhacHang.Click += new System.EventHandler(this.btn_Them_KhacHang_Click);
            // 
            // txt_LoaiKH
            // 
            this.txt_LoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiKH.Location = new System.Drawing.Point(509, 178);
            this.txt_LoaiKH.Name = "txt_LoaiKH";
            this.txt_LoaiKH.Size = new System.Drawing.Size(337, 27);
            this.txt_LoaiKH.TabIndex = 11;
            this.txt_LoaiKH.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenKH.Location = new System.Drawing.Point(509, 226);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(337, 27);
            this.txt_HoTenKH.TabIndex = 10;
            this.txt_HoTenKH.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_TongSoTienDaGiaoDich
            // 
            this.txt_TongSoTienDaGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSoTienDaGiaoDich.Location = new System.Drawing.Point(509, 387);
            this.txt_TongSoTienDaGiaoDich.Name = "txt_TongSoTienDaGiaoDich";
            this.txt_TongSoTienDaGiaoDich.Size = new System.Drawing.Size(337, 27);
            this.txt_TongSoTienDaGiaoDich.TabIndex = 9;
            this.txt_TongSoTienDaGiaoDich.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(509, 280);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(337, 27);
            this.txt_SDT.TabIndex = 9;
            this.txt_SDT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(509, 333);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(337, 27);
            this.txt_Email.TabIndex = 8;
            this.txt_Email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(509, 124);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(337, 27);
            this.txt_MaKH.TabIndex = 6;
            this.txt_MaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng số tiền đã giao dịch:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Họ và tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(367, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tùy chỉnh thông tin khách hàng";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1133, 657);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Button btn_TimKiem_KhachHang;
        private System.Windows.Forms.TextBox txt_TimKiemKH_HoTenKH;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.TextBox txt_TimKiemKH_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LoaiKH;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Button btn_Xoa_KhacHang;
        private System.Windows.Forms.Button btn_Sua_KhacHang;
        private System.Windows.Forms.Button btn_Them_KhacHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienDaGD;
        private System.Windows.Forms.TextBox txt_TongSoTienDaGiaoDich;
        private System.Windows.Forms.Label label9;
    }
}