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
            this.dgv_Hoa_Don = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(472, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phiếu Nhập Kho";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dgv_Hoa_Don
            // 
            this.dgv_Hoa_Don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hoa_Don.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoa_Don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhapkho,
            this.MaNCC,
            this.Manhanvien,
            this.Ngaynhapkho,
            this.Sotienthanhtoan,
            this.phuongthucthanhtoan,
            this.Trangthaithanhtoan});
            this.dgv_Hoa_Don.GridColor = System.Drawing.Color.White;
            this.dgv_Hoa_Don.Location = new System.Drawing.Point(33, 342);
            this.dgv_Hoa_Don.Name = "dgv_Hoa_Don";
            this.dgv_Hoa_Don.RowHeadersWidth = 62;
            this.dgv_Hoa_Don.RowTemplate.Height = 28;
            this.dgv_Hoa_Don.Size = new System.Drawing.Size(1093, 358);
            this.dgv_Hoa_Don.TabIndex = 30;
            // 
            // Manhapkho
            // 
            this.Manhapkho.HeaderText = "Mã nhập kho";
            this.Manhapkho.MinimumWidth = 8;
            this.Manhapkho.Name = "Manhapkho";
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // Manhanvien
            // 
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.MinimumWidth = 8;
            this.Manhanvien.Name = "Manhanvien";
            // 
            // Ngaynhapkho
            // 
            this.Ngaynhapkho.HeaderText = "Ngày nhập kho";
            this.Ngaynhapkho.MinimumWidth = 8;
            this.Ngaynhapkho.Name = "Ngaynhapkho";
            // 
            // Sotienthanhtoan
            // 
            this.Sotienthanhtoan.HeaderText = "Số tiền thanh toán";
            this.Sotienthanhtoan.MinimumWidth = 8;
            this.Sotienthanhtoan.Name = "Sotienthanhtoan";
            // 
            // phuongthucthanhtoan
            // 
            this.phuongthucthanhtoan.HeaderText = "Phương thức thanh toán";
            this.phuongthucthanhtoan.MinimumWidth = 8;
            this.phuongthucthanhtoan.Name = "phuongthucthanhtoan";
            // 
            // Trangthaithanhtoan
            // 
            this.Trangthaithanhtoan.HeaderText = "Trạng thái thanh toán";
            this.Trangthaithanhtoan.MinimumWidth = 8;
            this.Trangthaithanhtoan.Name = "Trangthaithanhtoan";
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.Location = new System.Drawing.Point(635, 141);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(284, 26);
            this.date_ngaynhap.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập ngày nhập kho :";
            // 
            // btn_Tim_nhapkho
            // 
            this.btn_Tim_nhapkho.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_nhapkho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_nhapkho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_nhapkho.Location = new System.Drawing.Point(1031, 105);
            this.btn_Tim_nhapkho.Name = "btn_Tim_nhapkho";
            this.btn_Tim_nhapkho.Size = new System.Drawing.Size(95, 73);
            this.btn_Tim_nhapkho.TabIndex = 27;
            this.btn_Tim_nhapkho.Text = "Tìm";
            this.btn_Tim_nhapkho.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Hoa_Don);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Tim_nhapkho);
            this.panel1.Controls.Add(this.date_ngaynhap);
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 716);
            this.panel1.TabIndex = 31;
            // 
            // PhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1221, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuNhapKho";
            this.Text = "PhieuNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Hoa_Don;
        private System.Windows.Forms.DateTimePicker date_ngaynhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tim_nhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotienthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongthucthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaithanhtoan;
        private System.Windows.Forms.Panel panel1;
    }
}