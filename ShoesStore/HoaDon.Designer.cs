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
            this.dgv_Hoa_Don = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymuahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotienthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuongthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthaithanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(531, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin hoá đơn";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Đến :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Tim_Kiem_HoaDon
            // 
            this.btn_Tim_Kiem_HoaDon.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_Kiem_HoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_Kiem_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_Kiem_HoaDon.Location = new System.Drawing.Point(1084, 130);
            this.btn_Tim_Kiem_HoaDon.Name = "btn_Tim_Kiem_HoaDon";
            this.btn_Tim_Kiem_HoaDon.Size = new System.Drawing.Size(113, 67);
            this.btn_Tim_Kiem_HoaDon.TabIndex = 22;
            this.btn_Tim_Kiem_HoaDon.Text = "Tìm";
            this.btn_Tim_Kiem_HoaDon.UseVisualStyleBackColor = false;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.Location = new System.Drawing.Point(194, 152);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(46, 22);
            this.lab5.TabIndex = 20;
            this.lab5.Text = "Từ :";
            // 
            // date_Tu
            // 
            this.date_Tu.Location = new System.Drawing.Point(271, 148);
            this.date_Tu.Name = "date_Tu";
            this.date_Tu.Size = new System.Drawing.Size(284, 26);
            this.date_Tu.TabIndex = 24;
            // 
            // date_Den
            // 
            this.date_Den.Location = new System.Drawing.Point(701, 148);
            this.date_Den.Name = "date_Den";
            this.date_Den.Size = new System.Drawing.Size(284, 26);
            this.date_Den.TabIndex = 25;
            // 
            // dgv_Hoa_Don
            // 
            this.dgv_Hoa_Don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hoa_Don.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Hoa_Don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoa_Don.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.Makhachhang,
            this.Manhanvien,
            this.Ngaymuahang,
            this.Sotienthanhtoan,
            this.phuongthucthanhtoan,
            this.Trangthaithanhtoan});
            this.dgv_Hoa_Don.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Hoa_Don.Location = new System.Drawing.Point(126, 280);
            this.dgv_Hoa_Don.Name = "dgv_Hoa_Don";
            this.dgv_Hoa_Don.RowHeadersWidth = 62;
            this.dgv_Hoa_Don.RowTemplate.Height = 28;
            this.dgv_Hoa_Don.Size = new System.Drawing.Size(1101, 384);
            this.dgv_Hoa_Don.TabIndex = 26;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hoá đơn";
            this.MaHoaDon.MinimumWidth = 8;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // Makhachhang
            // 
            this.Makhachhang.HeaderText = "Mã khách hàng";
            this.Makhachhang.MinimumWidth = 8;
            this.Makhachhang.Name = "Makhachhang";
            // 
            // Manhanvien
            // 
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.MinimumWidth = 8;
            this.Manhanvien.Name = "Manhanvien";
            // 
            // Ngaymuahang
            // 
            this.Ngaymuahang.HeaderText = "Ngày mua hàng";
            this.Ngaymuahang.MinimumWidth = 8;
            this.Ngaymuahang.Name = "Ngaymuahang";
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
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1311, 720);
            this.Controls.Add(this.dgv_Hoa_Don);
            this.Controls.Add(this.date_Den);
            this.Controls.Add(this.date_Tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Tim_Kiem_HoaDon);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoa_Don)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tim_Kiem_HoaDon;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.DateTimePicker date_Tu;
        private System.Windows.Forms.DateTimePicker date_Den;
        private System.Windows.Forms.DataGridView dgv_Hoa_Don;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymuahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotienthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongthucthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaithanhtoan;
    }
}