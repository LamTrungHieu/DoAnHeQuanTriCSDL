namespace ShoesStore
{
    partial class NhaCungCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiHopTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Ma_ncc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Tim_NCC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thông tin Nhà Cung Cấp";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_NCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Email,
            this.DiaChi,
            this.SDT,
            this.TrangThaiHopTac});
            this.dgv_NCC.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_NCC.Location = new System.Drawing.Point(22, 256);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.RowHeadersWidth = 62;
            this.dgv_NCC.RowTemplate.Height = 28;
            this.dgv_NCC.Size = new System.Drawing.Size(970, 356);
            this.dgv_NCC.TabIndex = 25;
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // TrangThaiHopTac
            // 
            this.TrangThaiHopTac.HeaderText = "Trạng thái hợp tác";
            this.TrangThaiHopTac.MinimumWidth = 8;
            this.TrangThaiHopTac.Name = "TrangThaiHopTac";
            this.TrangThaiHopTac.Width = 150;
            // 
            // txt_Ma_ncc
            // 
            this.txt_Ma_ncc.Location = new System.Drawing.Point(654, 160);
            this.txt_Ma_ncc.Name = "txt_Ma_ncc";
            this.txt_Ma_ncc.Size = new System.Drawing.Size(181, 26);
            this.txt_Ma_ncc.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nhập mã nhà cung cấp";
            // 
            // btn_Tim_NCC
            // 
            this.btn_Tim_NCC.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_NCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_NCC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_NCC.Location = new System.Drawing.Point(883, 125);
            this.btn_Tim_NCC.Name = "btn_Tim_NCC";
            this.btn_Tim_NCC.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_NCC.TabIndex = 26;
            this.btn_Tim_NCC.Text = "Tìm";
            this.btn_Tim_NCC.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_NCC);
            this.panel1.Controls.Add(this.btn_Tim_NCC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Ma_ncc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 627);
            this.panel1.TabIndex = 27;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1027, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.TextBox txt_Ma_ncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiHopTac;
        private System.Windows.Forms.Button btn_Tim_NCC;
        private System.Windows.Forms.Panel panel1;
    }
}