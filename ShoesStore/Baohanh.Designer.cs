﻿namespace ShoesStore
{
    partial class Baohanh
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
            this.dgv_Baohanh = new System.Windows.Forms.DataGridView();
            this.btn_Tim_baohanh = new System.Windows.Forms.Button();
            this.txt_Ma_baohanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Magoibaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengoibaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Baohanh
            // 
            this.dgv_Baohanh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Baohanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Baohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Baohanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Magoibaohanh,
            this.Tengoibaohanh,
            this.MotaChiTiet});
            this.dgv_Baohanh.GridColor = System.Drawing.Color.White;
            this.dgv_Baohanh.Location = new System.Drawing.Point(122, 308);
            this.dgv_Baohanh.Name = "dgv_Baohanh";
            this.dgv_Baohanh.RowHeadersWidth = 62;
            this.dgv_Baohanh.RowTemplate.Height = 28;
            this.dgv_Baohanh.Size = new System.Drawing.Size(520, 198);
            this.dgv_Baohanh.TabIndex = 17;
            // 
            // btn_Tim_baohanh
            // 
            this.btn_Tim_baohanh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_baohanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_baohanh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_baohanh.Location = new System.Drawing.Point(936, 84);
            this.btn_Tim_baohanh.Name = "btn_Tim_baohanh";
            this.btn_Tim_baohanh.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_baohanh.TabIndex = 16;
            this.btn_Tim_baohanh.Text = "Tìm";
            this.btn_Tim_baohanh.UseVisualStyleBackColor = false;
            // 
            // txt_Ma_baohanh
            // 
            this.txt_Ma_baohanh.Location = new System.Drawing.Point(657, 106);
            this.txt_Ma_baohanh.Name = "txt_Ma_baohanh";
            this.txt_Ma_baohanh.Size = new System.Drawing.Size(181, 26);
            this.txt_Ma_baohanh.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập mã gói bảo hành :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thông tin Bảo Hành";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Magoibaohanh
            // 
            this.Magoibaohanh.HeaderText = "Mã gói bảo hành";
            this.Magoibaohanh.MinimumWidth = 8;
            this.Magoibaohanh.Name = "Magoibaohanh";
            this.Magoibaohanh.Width = 150;
            // 
            // Tengoibaohanh
            // 
            this.Tengoibaohanh.HeaderText = "Tên gói bảo hành";
            this.Tengoibaohanh.MinimumWidth = 8;
            this.Tengoibaohanh.Name = "Tengoibaohanh";
            this.Tengoibaohanh.Width = 150;
            // 
            // MotaChiTiet
            // 
            this.MotaChiTiet.HeaderText = "Mô Tả Chi Tiết";
            this.MotaChiTiet.MinimumWidth = 8;
            this.MotaChiTiet.Name = "MotaChiTiet";
            this.MotaChiTiet.Width = 150;
            // 
            // Baohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1172, 649);
            this.Controls.Add(this.dgv_Baohanh);
            this.Controls.Add(this.btn_Tim_baohanh);
            this.Controls.Add(this.txt_Ma_baohanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Baohanh";
            this.Text = "Baohanh";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baohanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Baohanh;
        private System.Windows.Forms.Button btn_Tim_baohanh;
        private System.Windows.Forms.TextBox txt_Ma_baohanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magoibaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengoibaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotaChiTiet;
    }
}