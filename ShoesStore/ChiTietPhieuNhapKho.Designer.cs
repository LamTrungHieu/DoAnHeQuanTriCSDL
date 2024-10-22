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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(386, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Tiết Phiếu Nhập Kho";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_PhieuNhapKho
            // 
            this.dgv_PhieuNhapKho.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
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
            this.dgv_PhieuNhapKho.Location = new System.Drawing.Point(90, 132);
            this.dgv_PhieuNhapKho.Name = "dgv_PhieuNhapKho";
            this.dgv_PhieuNhapKho.RowHeadersWidth = 62;
            this.dgv_PhieuNhapKho.RowTemplate.Height = 28;
            this.dgv_PhieuNhapKho.Size = new System.Drawing.Size(973, 525);
            this.dgv_PhieuNhapKho.TabIndex = 27;
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.HeaderText = "Mã Giày Thể Thao";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            this.MaGiayTT.Width = 150;
            // 
            // Manhapkho
            // 
            this.Manhapkho.HeaderText = "Mã nhập kho";
            this.Manhapkho.MinimumWidth = 8;
            this.Manhapkho.Name = "Manhapkho";
            this.Manhapkho.Width = 150;
            // 
            // SoLuongSanPham
            // 
            this.SoLuongSanPham.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSanPham.MinimumWidth = 8;
            this.SoLuongSanPham.Name = "SoLuongSanPham";
            this.SoLuongSanPham.Width = 150;
            // 
            // Giatungsanpham
            // 
            this.Giatungsanpham.HeaderText = "Giá nhập từng sản phẩm";
            this.Giatungsanpham.MinimumWidth = 8;
            this.Giatungsanpham.Name = "Giatungsanpham";
            this.Giatungsanpham.Width = 150;
            // 
            // ThueVAT
            // 
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 8;
            this.ThueVAT.Name = "ThueVAT";
            this.ThueVAT.Width = 150;
            // 
            // thanhtiensanpham
            // 
            this.thanhtiensanpham.HeaderText = "Thành tiền từng sản phẩm";
            this.thanhtiensanpham.MinimumWidth = 8;
            this.thanhtiensanpham.Name = "thanhtiensanpham";
            this.thanhtiensanpham.Width = 150;
            // 
            // ChiTietPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1161, 669);
            this.Controls.Add(this.dgv_PhieuNhapKho);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietPhieuNhapKho";
            this.Text = "ChiTietPhieuNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PhieuNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatungsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensanpham;
    }
}