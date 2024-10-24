namespace ShoesStore
{
    partial class NhanVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TimKiem_NhanVien = new System.Windows.Forms.TextBox();
            this.btn_TimKiemNhanVien = new System.Windows.Forms.Button();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radiobtn_Admin = new System.Windows.Forms.CheckBox();
            this.btn_Xoa_NhanVien = new System.Windows.Forms.Button();
            this.btn_Sua_NhanVien = new System.Windows.Forms.Button();
            this.btn_Them_NhanVien = new System.Windows.Forms.Button();
            this.txt_HoTenNV = new System.Windows.Forms.TextBox();
            this.txt_SDTNV = new System.Windows.Forms.TextBox();
            this.txt_EmailNV = new System.Windows.Forms.TextBox();
            this.txt_PasswordNV = new System.Windows.Forms.TextBox();
            this.txt_TrangThaiTaiKhoanNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(404, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin Nhân Viên";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập mã nhân viên :";
            // 
            // txt_TimKiem_NhanVien
            // 
            this.txt_TimKiem_NhanVien.Location = new System.Drawing.Point(636, 118);
            this.txt_TimKiem_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem_NhanVien.Name = "txt_TimKiem_NhanVien";
            this.txt_TimKiem_NhanVien.Size = new System.Drawing.Size(244, 22);
            this.txt_TimKiem_NhanVien.TabIndex = 7;
            this.txt_TimKiem_NhanVien.TextChanged += new System.EventHandler(this.txt_TimKiem_NhanVien_TextChanged);
            // 
            // btn_TimKiemNhanVien
            // 
            this.btn_TimKiemNhanVien.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_TimKiemNhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TimKiemNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiemNhanVien.Location = new System.Drawing.Point(899, 110);
            this.btn_TimKiemNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiemNhanVien.Name = "btn_TimKiemNhanVien";
            this.btn_TimKiemNhanVien.Size = new System.Drawing.Size(84, 38);
            this.btn_TimKiemNhanVien.TabIndex = 11;
            this.btn_TimKiemNhanVien.Text = "Tìm";
            this.btn_TimKiemNhanVien.UseVisualStyleBackColor = false;
            this.btn_TimKiemNhanVien.Click += new System.EventHandler(this.btn_TimKiemNhanVien_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.SDT,
            this.Email,
            this.Passwd,
            this.TrangThaiTaiKhoan,
            this.VaiTro});
            this.dgv_NhanVien.GridColor = System.Drawing.Color.White;
            this.dgv_NhanVien.Location = new System.Drawing.Point(40, 171);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 62;
            this.dgv_NhanVien.RowTemplate.Height = 28;
            this.dgv_NhanVien.Size = new System.Drawing.Size(981, 330);
            this.dgv_NhanVien.TabIndex = 12;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên nhân viên";
            this.HoTenNV.MinimumWidth = 8;
            this.HoTenNV.Name = "HoTenNV";
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
            // Passwd
            // 
            this.Passwd.DataPropertyName = "Passwd";
            this.Passwd.HeaderText = "Password";
            this.Passwd.MinimumWidth = 8;
            this.Passwd.Name = "Passwd";
            // 
            // TrangThaiTaiKhoan
            // 
            this.TrangThaiTaiKhoan.DataPropertyName = "TrangThaiTaiKhoan";
            this.TrangThaiTaiKhoan.HeaderText = "Trạng thái tài khoản";
            this.TrangThaiTaiKhoan.MinimumWidth = 8;
            this.TrangThaiTaiKhoan.Name = "TrangThaiTaiKhoan";
            // 
            // VaiTro
            // 
            this.VaiTro.DataPropertyName = "VaiTro";
            this.VaiTro.HeaderText = "Vai Trò";
            this.VaiTro.MinimumWidth = 8;
            this.VaiTro.Name = "VaiTro";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_NhanVien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_TimKiemNhanVien);
            this.panel1.Controls.Add(this.txt_TimKiem_NhanVien);
            this.panel1.Location = new System.Drawing.Point(20, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 521);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 659);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm kiếm nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radiobtn_Admin);
            this.tabPage2.Controls.Add(this.btn_Xoa_NhanVien);
            this.tabPage2.Controls.Add(this.btn_Sua_NhanVien);
            this.tabPage2.Controls.Add(this.btn_Them_NhanVien);
            this.tabPage2.Controls.Add(this.txt_HoTenNV);
            this.tabPage2.Controls.Add(this.txt_SDTNV);
            this.tabPage2.Controls.Add(this.txt_EmailNV);
            this.tabPage2.Controls.Add(this.txt_PasswordNV);
            this.tabPage2.Controls.Add(this.txt_TrangThaiTaiKhoanNV);
            this.tabPage2.Controls.Add(this.txt_MaNV);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // radiobtn_Admin
            // 
            this.radiobtn_Admin.AutoSize = true;
            this.radiobtn_Admin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_Admin.Location = new System.Drawing.Point(486, 105);
            this.radiobtn_Admin.Name = "radiobtn_Admin";
            this.radiobtn_Admin.Size = new System.Drawing.Size(98, 30);
            this.radiobtn_Admin.TabIndex = 39;
            this.radiobtn_Admin.Text = "Admin";
            this.radiobtn_Admin.UseVisualStyleBackColor = true;
            this.radiobtn_Admin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Xoa_NhanVien
            // 
            this.btn_Xoa_NhanVien.BackColor = System.Drawing.Color.Salmon;
            this.btn_Xoa_NhanVien.Location = new System.Drawing.Point(749, 461);
            this.btn_Xoa_NhanVien.Name = "btn_Xoa_NhanVien";
            this.btn_Xoa_NhanVien.Size = new System.Drawing.Size(165, 69);
            this.btn_Xoa_NhanVien.TabIndex = 38;
            this.btn_Xoa_NhanVien.Text = "Xóa";
            this.btn_Xoa_NhanVien.UseVisualStyleBackColor = false;
            this.btn_Xoa_NhanVien.Click += new System.EventHandler(this.btn_Xoa_NhanVien_Click);
            // 
            // btn_Sua_NhanVien
            // 
            this.btn_Sua_NhanVien.BackColor = System.Drawing.Color.Salmon;
            this.btn_Sua_NhanVien.Location = new System.Drawing.Point(501, 461);
            this.btn_Sua_NhanVien.Name = "btn_Sua_NhanVien";
            this.btn_Sua_NhanVien.Size = new System.Drawing.Size(165, 69);
            this.btn_Sua_NhanVien.TabIndex = 37;
            this.btn_Sua_NhanVien.Text = "Sửa";
            this.btn_Sua_NhanVien.UseVisualStyleBackColor = false;
            this.btn_Sua_NhanVien.Click += new System.EventHandler(this.btn_Sua_NhanVien_Click);
            // 
            // btn_Them_NhanVien
            // 
            this.btn_Them_NhanVien.BackColor = System.Drawing.Color.Salmon;
            this.btn_Them_NhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them_NhanVien.Location = new System.Drawing.Point(227, 460);
            this.btn_Them_NhanVien.Name = "btn_Them_NhanVien";
            this.btn_Them_NhanVien.Size = new System.Drawing.Size(165, 69);
            this.btn_Them_NhanVien.TabIndex = 36;
            this.btn_Them_NhanVien.Text = "Thêm";
            this.btn_Them_NhanVien.UseVisualStyleBackColor = false;
            this.btn_Them_NhanVien.Click += new System.EventHandler(this.btn_Them_NhanVien_Click);
            // 
            // txt_HoTenNV
            // 
            this.txt_HoTenNV.Location = new System.Drawing.Point(486, 201);
            this.txt_HoTenNV.Name = "txt_HoTenNV";
            this.txt_HoTenNV.Size = new System.Drawing.Size(371, 27);
            this.txt_HoTenNV.TabIndex = 35;
            // 
            // txt_SDTNV
            // 
            this.txt_SDTNV.Location = new System.Drawing.Point(486, 243);
            this.txt_SDTNV.Name = "txt_SDTNV";
            this.txt_SDTNV.Size = new System.Drawing.Size(371, 27);
            this.txt_SDTNV.TabIndex = 34;
            // 
            // txt_EmailNV
            // 
            this.txt_EmailNV.Location = new System.Drawing.Point(486, 289);
            this.txt_EmailNV.Name = "txt_EmailNV";
            this.txt_EmailNV.Size = new System.Drawing.Size(371, 27);
            this.txt_EmailNV.TabIndex = 33;
            // 
            // txt_PasswordNV
            // 
            this.txt_PasswordNV.Location = new System.Drawing.Point(486, 336);
            this.txt_PasswordNV.Name = "txt_PasswordNV";
            this.txt_PasswordNV.Size = new System.Drawing.Size(371, 27);
            this.txt_PasswordNV.TabIndex = 32;
            // 
            // txt_TrangThaiTaiKhoanNV
            // 
            this.txt_TrangThaiTaiKhoanNV.Location = new System.Drawing.Point(486, 385);
            this.txt_TrangThaiTaiKhoanNV.Name = "txt_TrangThaiTaiKhoanNV";
            this.txt_TrangThaiTaiKhoanNV.Size = new System.Drawing.Size(371, 27);
            this.txt_TrangThaiTaiKhoanNV.TabIndex = 31;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(486, 151);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(371, 27);
            this.txt_MaNV.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "SĐT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Password:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Trang thái tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Họ tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã nhân viên:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vai trò:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(367, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tùy chỉnh thông tin nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TimKiem_NhanVien;
        private System.Windows.Forms.Button btn_TimKiemNhanVien;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_HoTenNV;
        private System.Windows.Forms.TextBox txt_SDTNV;
        private System.Windows.Forms.TextBox txt_EmailNV;
        private System.Windows.Forms.TextBox txt_PasswordNV;
        private System.Windows.Forms.TextBox txt_TrangThaiTaiKhoanNV;
        private System.Windows.Forms.Button btn_Xoa_NhanVien;
        private System.Windows.Forms.Button btn_Sua_NhanVien;
        private System.Windows.Forms.Button btn_Them_NhanVien;
        private System.Windows.Forms.CheckBox radiobtn_Admin;
    }
}