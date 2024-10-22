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
            this.txt_Ma_NhanVien = new System.Windows.Forms.TextBox();
            this.btn_Tim_NhanVien = new System.Windows.Forms.Button();
            this.dgv_Nhan_Vien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhan_Vien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(487, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin Nhân Viên";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập mã nhân viên :";
            // 
            // txt_Ma_NhanVien
            // 
            this.txt_Ma_NhanVien.Location = new System.Drawing.Point(809, 138);
            this.txt_Ma_NhanVien.Name = "txt_Ma_NhanVien";
            this.txt_Ma_NhanVien.Size = new System.Drawing.Size(181, 26);
            this.txt_Ma_NhanVien.TabIndex = 7;
            // 
            // btn_Tim_NhanVien
            // 
            this.btn_Tim_NhanVien.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_NhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_NhanVien.Location = new System.Drawing.Point(1043, 107);
            this.btn_Tim_NhanVien.Name = "btn_Tim_NhanVien";
            this.btn_Tim_NhanVien.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_NhanVien.TabIndex = 11;
            this.btn_Tim_NhanVien.Text = "Tìm";
            this.btn_Tim_NhanVien.UseVisualStyleBackColor = false;
            // 
            // dgv_Nhan_Vien
            // 
            this.dgv_Nhan_Vien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Nhan_Vien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Nhan_Vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nhan_Vien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.SDT,
            this.Email,
            this.Password,
            this.TrangThaiTaiKhoan,
            this.VaiTro});
            this.dgv_Nhan_Vien.GridColor = System.Drawing.Color.White;
            this.dgv_Nhan_Vien.Location = new System.Drawing.Point(45, 236);
            this.dgv_Nhan_Vien.Name = "dgv_Nhan_Vien";
            this.dgv_Nhan_Vien.RowHeadersWidth = 62;
            this.dgv_Nhan_Vien.RowTemplate.Height = 28;
            this.dgv_Nhan_Vien.Size = new System.Drawing.Size(1104, 412);
            this.dgv_Nhan_Vien.TabIndex = 12;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 8;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Họ tên nhân viên";
            this.TenNhanVien.MinimumWidth = 8;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            // 
            // TrangThaiTaiKhoan
            // 
            this.TrangThaiTaiKhoan.HeaderText = "Trạng thái tài khoản";
            this.TrangThaiTaiKhoan.MinimumWidth = 8;
            this.TrangThaiTaiKhoan.Name = "TrangThaiTaiKhoan";
            // 
            // VaiTro
            // 
            this.VaiTro.HeaderText = "Vai Trò";
            this.VaiTro.MinimumWidth = 8;
            this.VaiTro.Name = "VaiTro";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Nhan_Vien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Tim_NhanVien);
            this.panel1.Controls.Add(this.txt_Ma_NhanVien);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 651);
            this.panel1.TabIndex = 20;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1208, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhan_Vien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ma_NhanVien;
        private System.Windows.Forms.Button btn_Tim_NhanVien;
        private System.Windows.Forms.DataGridView dgv_Nhan_Vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.Panel panel1;
    }
}