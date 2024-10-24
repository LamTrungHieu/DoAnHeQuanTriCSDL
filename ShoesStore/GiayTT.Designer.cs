namespace ShoesStore
{
    partial class GiayTT
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenGiay = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_KhoiLuong = new System.Windows.Forms.TextBox();
            this.txt_Mau_Sac = new System.Windows.Forms.TextBox();
            this.dgv_Giay_The_Thao = new System.Windows.Forms.DataGridView();
            this.MaGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuaTangKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim_Kiem_Giay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay_The_Thao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(583, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Giày Thể Thao";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên Giày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tên hãng :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập khối lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(698, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập màu sắc :";
            // 
            // txt_TenGiay
            // 
            this.txt_TenGiay.Location = new System.Drawing.Point(198, 169);
            this.txt_TenGiay.Name = "txt_TenGiay";
            this.txt_TenGiay.Size = new System.Drawing.Size(146, 26);
            this.txt_TenGiay.TabIndex = 5;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(361, 169);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(142, 26);
            this.txt_TenHang.TabIndex = 6;
            // 
            // txt_KhoiLuong
            // 
            this.txt_KhoiLuong.Location = new System.Drawing.Point(520, 169);
            this.txt_KhoiLuong.Name = "txt_KhoiLuong";
            this.txt_KhoiLuong.Size = new System.Drawing.Size(163, 26);
            this.txt_KhoiLuong.TabIndex = 7;
            // 
            // txt_Mau_Sac
            // 
            this.txt_Mau_Sac.Location = new System.Drawing.Point(702, 169);
            this.txt_Mau_Sac.Name = "txt_Mau_Sac";
            this.txt_Mau_Sac.Size = new System.Drawing.Size(145, 26);
            this.txt_Mau_Sac.TabIndex = 8;
            // 
            // dgv_Giay_The_Thao
            // 
            this.dgv_Giay_The_Thao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Giay_The_Thao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Giay_The_Thao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Giay_The_Thao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiayTT,
            this.TenGiayTT,
            this.TenHangGiayTT,
            this.KhoiLuong,
            this.HanBaoHanh,
            this.SoLuong,
            this.MauSac,
            this.SizeGiay,
            this.QuaTangKem});
<<<<<<< HEAD
            this.dgv_Giay_The_Thao.GridColor = System.Drawing.Color.White;
=======
            this.dgv_Giay_The_Thao.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
>>>>>>> dev
            this.dgv_Giay_The_Thao.Location = new System.Drawing.Point(213, 318);
            this.dgv_Giay_The_Thao.Name = "dgv_Giay_The_Thao";
            this.dgv_Giay_The_Thao.RowHeadersWidth = 62;
            this.dgv_Giay_The_Thao.RowTemplate.Height = 28;
            this.dgv_Giay_The_Thao.Size = new System.Drawing.Size(1077, 355);
            this.dgv_Giay_The_Thao.TabIndex = 9;
            this.dgv_Giay_The_Thao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.HeaderText = "Mã Giày Thể Thao";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            // 
            // TenGiayTT
            // 
            this.TenGiayTT.HeaderText = "Tên Giày Thể Thao";
            this.TenGiayTT.MinimumWidth = 8;
            this.TenGiayTT.Name = "TenGiayTT";
            // 
            // TenHangGiayTT
            // 
            this.TenHangGiayTT.HeaderText = "Tên Hãng Giày ";
            this.TenHangGiayTT.MinimumWidth = 8;
            this.TenHangGiayTT.Name = "TenHangGiayTT";
            // 
            // KhoiLuong
            // 
            this.KhoiLuong.HeaderText = "Khối Lượng";
            this.KhoiLuong.MinimumWidth = 8;
            this.KhoiLuong.Name = "KhoiLuong";
            // 
            // HanBaoHanh
            // 
            this.HanBaoHanh.HeaderText = "Hạn Bảo Hành";
            this.HanBaoHanh.MinimumWidth = 8;
            this.HanBaoHanh.Name = "HanBaoHanh";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // MauSac
            // 
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 8;
            this.MauSac.Name = "MauSac";
            // 
            // SizeGiay
            // 
            this.SizeGiay.HeaderText = "Size";
            this.SizeGiay.MinimumWidth = 8;
            this.SizeGiay.Name = "SizeGiay";
            // 
            // QuaTangKem
            // 
            this.QuaTangKem.HeaderText = "Quà Tặng Kèm";
            this.QuaTangKem.MinimumWidth = 8;
            this.QuaTangKem.Name = "QuaTangKem";
            // 
            // btn_Tim_Kiem_Giay
            // 
            this.btn_Tim_Kiem_Giay.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_Kiem_Giay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_Kiem_Giay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_Kiem_Giay.Location = new System.Drawing.Point(1097, 128);
            this.btn_Tim_Kiem_Giay.Name = "btn_Tim_Kiem_Giay";
            this.btn_Tim_Kiem_Giay.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_Kiem_Giay.TabIndex = 10;
            this.btn_Tim_Kiem_Giay.Text = "Tìm";
            this.btn_Tim_Kiem_Giay.UseVisualStyleBackColor = false;
            this.btn_Tim_Kiem_Giay.Click += new System.EventHandler(this.btn_Tim_Kiem_Giay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhập Size Giày  :";
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(857, 169);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(145, 26);
            this.txt_Size.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Giay_The_Thao);
            this.panel1.Controls.Add(this.btn_Tim_Kiem_Giay);
            this.panel1.Controls.Add(this.txt_Size);
            this.panel1.Controls.Add(this.txt_KhoiLuong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Mau_Sac);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_TenGiay);
            this.panel1.Controls.Add(this.txt_TenHang);
            this.panel1.Location = new System.Drawing.Point(-59, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 686);
            this.panel1.TabIndex = 20;
            // 
            // GiayTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1498, 684);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiayTT";
            this.Text = "GiayTT";
            this.Load += new System.EventHandler(this.GiayTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay_The_Thao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenGiay;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_KhoiLuong;
        private System.Windows.Forms.TextBox txt_Mau_Sac;
        private System.Windows.Forms.DataGridView dgv_Giay_The_Thao;
        private System.Windows.Forms.Button btn_Tim_Kiem_Giay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuaTangKem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Panel panel1;
    }
}