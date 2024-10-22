namespace ShoesStore
{
    partial class PhuKien
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
            this.dgv_PhuKien = new System.Windows.Forms.DataGridView();
            this.Magoiphukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengoiphukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim_PhuKien = new System.Windows.Forms.Button();
            this.txt_Ma_pk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuKien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PhuKien
            // 
            this.dgv_PhuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhuKien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_PhuKien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Magoiphukien,
            this.Tengoiphukien,
            this.MotaChiTiet});
            this.dgv_PhuKien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_PhuKien.Location = new System.Drawing.Point(123, 283);
            this.dgv_PhuKien.Name = "dgv_PhuKien";
            this.dgv_PhuKien.RowHeadersWidth = 62;
            this.dgv_PhuKien.RowTemplate.Height = 28;
            this.dgv_PhuKien.Size = new System.Drawing.Size(839, 250);
            this.dgv_PhuKien.TabIndex = 22;
            this.dgv_PhuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhuKien_CellContentClick);
            // 
            // Magoiphukien
            // 
            this.Magoiphukien.HeaderText = "Mã gói phụ kiện";
            this.Magoiphukien.MinimumWidth = 8;
            this.Magoiphukien.Name = "Magoiphukien";
            // 
            // Tengoiphukien
            // 
            this.Tengoiphukien.HeaderText = "Tên gói phụ kiện";
            this.Tengoiphukien.MinimumWidth = 8;
            this.Tengoiphukien.Name = "Tengoiphukien";
            // 
            // MotaChiTiet
            // 
            this.MotaChiTiet.HeaderText = "Mô Tả Chi Tiết";
            this.MotaChiTiet.MinimumWidth = 8;
            this.MotaChiTiet.Name = "MotaChiTiet";
            // 
            // btn_Tim_PhuKien
            // 
            this.btn_Tim_PhuKien.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tim_PhuKien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_PhuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_PhuKien.Location = new System.Drawing.Point(867, 121);
            this.btn_Tim_PhuKien.Name = "btn_Tim_PhuKien";
            this.btn_Tim_PhuKien.Size = new System.Drawing.Size(95, 48);
            this.btn_Tim_PhuKien.TabIndex = 21;
            this.btn_Tim_PhuKien.Text = "Tìm";
            this.btn_Tim_PhuKien.UseVisualStyleBackColor = false;
            // 
            // txt_Ma_pk
            // 
            this.txt_Ma_pk.Location = new System.Drawing.Point(620, 157);
            this.txt_Ma_pk.Name = "txt_Ma_pk";
            this.txt_Ma_pk.Size = new System.Drawing.Size(181, 26);
            this.txt_Ma_pk.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhập mã gói phụ kiện :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin Phụ Kiện";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_PhuKien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Tim_PhuKien);
            this.panel1.Controls.Add(this.txt_Ma_pk);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 652);
            this.panel1.TabIndex = 23;
            // 
            // PhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhuKien";
            this.Text = "PhuKien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuKien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhuKien;
        private System.Windows.Forms.Button btn_Tim_PhuKien;
        private System.Windows.Forms.TextBox txt_Ma_pk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magoiphukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengoiphukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotaChiTiet;
        private System.Windows.Forms.Panel panel1;
    }
}