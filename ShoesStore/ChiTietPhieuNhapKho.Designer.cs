namespace ShoesStore
{
    partial class ChiTietPhieuNhapKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_PhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.MaGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatungsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtiensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_ThanhTienTungSP = new System.Windows.Forms.TextBox();
            this.txt_ThueVAT = new System.Windows.Forms.TextBox();
            this.txt_GiaTungSP = new System.Windows.Forms.TextBox();
            this.txt_SoluongSP = new System.Windows.Forms.TextBox();
            this.txt_MaNK = new System.Windows.Forms.TextBox();
            this.txt_MaGiayTT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(462, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Tiết Phiếu Nhập Kho";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_PhieuNhapKho
            // 
            this.dgv_PhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhapKho.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiayTT,
            this.Manhapkho,
            this.SoLuongSanPham,
            this.Giatungsanpham,
            this.ThueVAT,
            this.thanhtiensanpham});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PhieuNhapKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PhieuNhapKho.GridColor = System.Drawing.Color.Black;
            this.dgv_PhieuNhapKho.Location = new System.Drawing.Point(101, 177);
            this.dgv_PhieuNhapKho.Name = "dgv_PhieuNhapKho";
            this.dgv_PhieuNhapKho.RowHeadersWidth = 62;
            this.dgv_PhieuNhapKho.RowTemplate.Height = 28;
            this.dgv_PhieuNhapKho.Size = new System.Drawing.Size(1037, 448);
            this.dgv_PhieuNhapKho.TabIndex = 27;
            this.dgv_PhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhapKho_CellContentClick);
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.DataPropertyName = "MaGiayTT";
            this.MaGiayTT.HeaderText = "Mã Giày Thể Thao";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            // 
            // Manhapkho
            // 
            this.Manhapkho.DataPropertyName = "MaNK";
            this.Manhapkho.HeaderText = "Mã nhập kho";
            this.Manhapkho.MinimumWidth = 8;
            this.Manhapkho.Name = "Manhapkho";
            // 
            // SoLuongSanPham
            // 
            this.SoLuongSanPham.DataPropertyName = "SoLuongSP";
            this.SoLuongSanPham.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSanPham.MinimumWidth = 8;
            this.SoLuongSanPham.Name = "SoLuongSanPham";
            // 
            // Giatungsanpham
            // 
            this.Giatungsanpham.DataPropertyName = "GiaNhapTungSP";
            this.Giatungsanpham.HeaderText = "Giá nhập từng sản phẩm";
            this.Giatungsanpham.MinimumWidth = 8;
            this.Giatungsanpham.Name = "Giatungsanpham";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 8;
            this.ThueVAT.Name = "ThueVAT";
            // 
            // thanhtiensanpham
            // 
            this.thanhtiensanpham.DataPropertyName = "ThanhTienTungSP";
            this.thanhtiensanpham.HeaderText = "Thành tiền từng sản phẩm";
            this.thanhtiensanpham.MinimumWidth = 8;
            this.thanhtiensanpham.Name = "thanhtiensanpham";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 732);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_PhieuNhapKho);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1239, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infor ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Xoa);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Controls.Add(this.btn_Them);
            this.tabPage2.Controls.Add(this.txt_ThanhTienTungSP);
            this.tabPage2.Controls.Add(this.txt_ThueVAT);
            this.tabPage2.Controls.Add(this.txt_GiaTungSP);
            this.tabPage2.Controls.Add(this.txt_SoluongSP);
            this.tabPage2.Controls.Add(this.txt_MaNK);
            this.tabPage2.Controls.Add(this.txt_MaGiayTT);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1239, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(210, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 26);
            this.label14.TabIndex = 72;
            this.label14.Text = "Thành tiền :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(210, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 26);
            this.label12.TabIndex = 70;
            this.label12.Text = "Thuế VAT :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(210, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 26);
            this.label11.TabIndex = 69;
            this.label11.Text = "Giá nhập từng sản phẩm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(210, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 26);
            this.label10.TabIndex = 68;
            this.label10.Text = "Số lượng sản phẩm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mã nhập kho :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(850, 581);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(179, 56);
            this.btn_Xoa.TabIndex = 66;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(579, 581);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(207, 56);
            this.btn_Sua.TabIndex = 65;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Tomato;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.Location = new System.Drawing.Point(322, 581);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 56);
            this.btn_Them.TabIndex = 64;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // txt_ThanhTienTungSP
            // 
            this.txt_ThanhTienTungSP.Location = new System.Drawing.Point(566, 423);
            this.txt_ThanhTienTungSP.Name = "txt_ThanhTienTungSP";
            this.txt_ThanhTienTungSP.Size = new System.Drawing.Size(395, 26);
            this.txt_ThanhTienTungSP.TabIndex = 63;
            // 
            // txt_ThueVAT
            // 
            this.txt_ThueVAT.Location = new System.Drawing.Point(566, 365);
            this.txt_ThueVAT.Name = "txt_ThueVAT";
            this.txt_ThueVAT.Size = new System.Drawing.Size(395, 26);
            this.txt_ThueVAT.TabIndex = 61;
            // 
            // txt_GiaTungSP
            // 
            this.txt_GiaTungSP.Location = new System.Drawing.Point(566, 312);
            this.txt_GiaTungSP.Name = "txt_GiaTungSP";
            this.txt_GiaTungSP.Size = new System.Drawing.Size(395, 26);
            this.txt_GiaTungSP.TabIndex = 60;
            // 
            // txt_SoluongSP
            // 
            this.txt_SoluongSP.Location = new System.Drawing.Point(566, 253);
            this.txt_SoluongSP.Name = "txt_SoluongSP";
            this.txt_SoluongSP.Size = new System.Drawing.Size(395, 26);
            this.txt_SoluongSP.TabIndex = 59;
            // 
            // txt_MaNK
            // 
            this.txt_MaNK.Location = new System.Drawing.Point(566, 193);
            this.txt_MaNK.Name = "txt_MaNK";
            this.txt_MaNK.Size = new System.Drawing.Size(395, 26);
            this.txt_MaNK.TabIndex = 58;
            // 
            // txt_MaGiayTT
            // 
            this.txt_MaGiayTT.Location = new System.Drawing.Point(566, 137);
            this.txt_MaGiayTT.Name = "txt_MaGiayTT";
            this.txt_MaGiayTT.Size = new System.Drawing.Size(395, 26);
            this.txt_MaGiayTT.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã Giày Thể Thao :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(422, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 43);
            this.label7.TabIndex = 55;
            this.label7.Text = "Chỉnh Sửa Chi Tiết Hoá Đơn";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // ChiTietPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1244, 736);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietPhieuNhapKho";
            this.Text = "ChiTietPhieuNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PhieuNhapKho;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_ThanhTienTungSP;
        private System.Windows.Forms.TextBox txt_ThueVAT;
        private System.Windows.Forms.TextBox txt_GiaTungSP;
        private System.Windows.Forms.TextBox txt_SoluongSP;
        private System.Windows.Forms.TextBox txt_MaNK;
        private System.Windows.Forms.TextBox txt_MaGiayTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatungsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensanpham;
    }
}