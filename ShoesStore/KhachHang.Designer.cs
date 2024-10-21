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
            this.dgv_Khach_Hang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim_Kiem_KH = new System.Windows.Forms.Button();
            this.txt_Ten_Khach_Hang = new System.Windows.Forms.TextBox();
            this.lab5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khach_Hang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Khach_Hang
            // 
            this.dgv_Khach_Hang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Khach_Hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khach_Hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.Email,
            this.TongSoTienGD});
            this.dgv_Khach_Hang.GridColor = System.Drawing.Color.White;
            this.dgv_Khach_Hang.Location = new System.Drawing.Point(12, 223);
            this.dgv_Khach_Hang.Name = "dgv_Khach_Hang";
            this.dgv_Khach_Hang.RowHeadersWidth = 62;
            this.dgv_Khach_Hang.RowTemplate.Height = 28;
            this.dgv_Khach_Hang.Size = new System.Drawing.Size(815, 288);
            this.dgv_Khach_Hang.TabIndex = 17;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Họ tên khách hàng";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // TongSoTienGD
            // 
            this.TongSoTienGD.HeaderText = "Tổng Số Tiền  GD";
            this.TongSoTienGD.MinimumWidth = 8;
            this.TongSoTienGD.Name = "TongSoTienGD";
            this.TongSoTienGD.Width = 150;
            // 
            // btn_Tim_Kiem_KH
            // 
            this.btn_Tim_Kiem_KH.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_Kiem_KH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_Kiem_KH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_Kiem_KH.Location = new System.Drawing.Point(664, 103);
            this.btn_Tim_Kiem_KH.Name = "btn_Tim_Kiem_KH";
            this.btn_Tim_Kiem_KH.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_Kiem_KH.TabIndex = 16;
            this.btn_Tim_Kiem_KH.Text = "Tìm";
            this.btn_Tim_Kiem_KH.UseVisualStyleBackColor = false;
            // 
            // txt_Ten_Khach_Hang
            // 
            this.txt_Ten_Khach_Hang.Location = new System.Drawing.Point(51, 125);
            this.txt_Ten_Khach_Hang.Name = "txt_Ten_Khach_Hang";
            this.txt_Ten_Khach_Hang.Size = new System.Drawing.Size(181, 26);
            this.txt_Ten_Khach_Hang.TabIndex = 15;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.Location = new System.Drawing.Point(38, 81);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(218, 22);
            this.lab5.TabIndex = 14;
            this.lab5.Text = "Nhập tên khách hàng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(328, 125);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(181, 26);
            this.txt_SDT.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập SĐT: ";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Khach_Hang);
            this.Controls.Add(this.btn_Tim_Kiem_KH);
            this.Controls.Add(this.txt_Ten_Khach_Hang);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khach_Hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Khach_Hang;
        private System.Windows.Forms.Button btn_Tim_Kiem_KH;
        private System.Windows.Forms.TextBox txt_Ten_Khach_Hang;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienGD;
    }
}