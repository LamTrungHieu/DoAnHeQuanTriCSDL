namespace ShoesStore
{
    partial class HienThiThongKe
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
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doanh Thu";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tháng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Năm :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng doanh thu :";
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(61, 226);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(100, 26);
            this.txt_Ngay.TabIndex = 19;
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(195, 226);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(100, 26);
            this.txt_Thang.TabIndex = 20;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(362, 226);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(100, 26);
            this.txt_Nam.TabIndex = 21;
            // 
            // txt_Tong
            // 
            this.txt_Tong.Location = new System.Drawing.Point(240, 455);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(278, 26);
            this.txt_Tong.TabIndex = 22;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xuat.Location = new System.Drawing.Point(534, 189);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(112, 63);
            this.btn_Xuat.TabIndex = 23;
            this.btn_Xuat.Text = "Xuất";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            // 
            // HienThiThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 605);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.txt_Tong);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.txt_Thang);
            this.Controls.Add(this.txt_Ngay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HienThiThongKe";
            this.Text = "HienThiThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ngay;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.TextBox txt_Tong;
        private System.Windows.Forms.Button btn_Xuat;
    }
}