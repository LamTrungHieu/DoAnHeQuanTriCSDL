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
            this.txt_TimTenGiay = new System.Windows.Forms.TextBox();
            this.txt_TimTenHang = new System.Windows.Forms.TextBox();
            this.txt_TimKhoiLuong = new System.Windows.Forms.TextBox();
            this.txt_TimMauSac = new System.Windows.Forms.TextBox();
            this.dgv_Giay_The_Thao = new System.Windows.Forms.DataGridView();
            this.btn_Tim_Kiem_Giay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TimSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaGiayTT = new System.Windows.Forms.TextBox();
            this.txt_TenGiayTT = new System.Windows.Forms.TextBox();
            this.txt_TenHangGiay = new System.Windows.Forms.TextBox();
            this.txt_CSKhoiluong = new System.Windows.Forms.TextBox();
            this.txt_hanBaoHanh = new System.Windows.Forms.TextBox();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.txt_MauSac = new System.Windows.Forms.TextBox();
            this.txt_CSSizeGiay = new System.Windows.Forms.TextBox();
            this.txt_QuatangKem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_HienThongTin = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Chatlieugiay = new System.Windows.Forms.TextBox();
            this.txt_GiaGiay = new System.Windows.Forms.TextBox();
            this.MaGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangGiayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieuGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuaTangKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay_The_Thao)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(448, 12);
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
            this.label2.Location = new System.Drawing.Point(87, 116);
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
            this.label3.Location = new System.Drawing.Point(250, 116);
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
            this.label4.Location = new System.Drawing.Point(409, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập khối lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập màu sắc :";
            // 
            // txt_TimTenGiay
            // 
            this.txt_TimTenGiay.Location = new System.Drawing.Point(91, 157);
            this.txt_TimTenGiay.Name = "txt_TimTenGiay";
            this.txt_TimTenGiay.Size = new System.Drawing.Size(146, 26);
            this.txt_TimTenGiay.TabIndex = 5;
            // 
            // txt_TimTenHang
            // 
            this.txt_TimTenHang.Location = new System.Drawing.Point(254, 157);
            this.txt_TimTenHang.Name = "txt_TimTenHang";
            this.txt_TimTenHang.Size = new System.Drawing.Size(142, 26);
            this.txt_TimTenHang.TabIndex = 6;
            // 
            // txt_TimKhoiLuong
            // 
            this.txt_TimKhoiLuong.Location = new System.Drawing.Point(413, 157);
            this.txt_TimKhoiLuong.Name = "txt_TimKhoiLuong";
            this.txt_TimKhoiLuong.Size = new System.Drawing.Size(163, 26);
            this.txt_TimKhoiLuong.TabIndex = 7;
            // 
            // txt_TimMauSac
            // 
            this.txt_TimMauSac.Location = new System.Drawing.Point(595, 157);
            this.txt_TimMauSac.Name = "txt_TimMauSac";
            this.txt_TimMauSac.Size = new System.Drawing.Size(145, 26);
            this.txt_TimMauSac.TabIndex = 8;
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
            this.SizeGiay,
            this.MauSac,
            this.ChatLieuGiay,
            this.Gia,
            this.QuaTangKem});
            this.dgv_Giay_The_Thao.GridColor = System.Drawing.Color.White;
            this.dgv_Giay_The_Thao.Location = new System.Drawing.Point(15, 248);
            this.dgv_Giay_The_Thao.Name = "dgv_Giay_The_Thao";
            this.dgv_Giay_The_Thao.RowHeadersWidth = 62;
            this.dgv_Giay_The_Thao.RowTemplate.Height = 28;
            this.dgv_Giay_The_Thao.Size = new System.Drawing.Size(1165, 405);
            this.dgv_Giay_The_Thao.TabIndex = 9;
            this.dgv_Giay_The_Thao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Tim_Kiem_Giay
            // 
            this.btn_Tim_Kiem_Giay.BackColor = System.Drawing.Color.Tomato;
            this.btn_Tim_Kiem_Giay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tim_Kiem_Giay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim_Kiem_Giay.Location = new System.Drawing.Point(1001, 157);
            this.btn_Tim_Kiem_Giay.Name = "btn_Tim_Kiem_Giay";
            this.btn_Tim_Kiem_Giay.Size = new System.Drawing.Size(179, 48);
            this.btn_Tim_Kiem_Giay.TabIndex = 10;
            this.btn_Tim_Kiem_Giay.Text = "Tìm";
            this.btn_Tim_Kiem_Giay.UseVisualStyleBackColor = false;
            this.btn_Tim_Kiem_Giay.Click += new System.EventHandler(this.btn_Tim_Kiem_Giay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhập Size Giày  :";
            // 
            // txt_TimSize
            // 
            this.txt_TimSize.Location = new System.Drawing.Point(750, 157);
            this.txt_TimSize.Name = "txt_TimSize";
            this.txt_TimSize.Size = new System.Drawing.Size(145, 26);
            this.txt_TimSize.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_HienThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Giay_The_Thao);
            this.panel1.Controls.Add(this.btn_Tim_Kiem_Giay);
            this.panel1.Controls.Add(this.txt_TimSize);
            this.panel1.Controls.Add(this.txt_TimKhoiLuong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_TimMauSac);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_TimTenGiay);
            this.panel1.Controls.Add(this.txt_TimTenHang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 668);
            this.panel1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1462, 720);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1454, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infor ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txt_Chatlieugiay);
            this.tabPage2.Controls.Add(this.txt_GiaGiay);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Xoa);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Controls.Add(this.btn_Them);
            this.tabPage2.Controls.Add(this.txt_QuatangKem);
            this.tabPage2.Controls.Add(this.txt_CSSizeGiay);
            this.tabPage2.Controls.Add(this.txt_MauSac);
            this.tabPage2.Controls.Add(this.txt_Soluong);
            this.tabPage2.Controls.Add(this.txt_hanBaoHanh);
            this.tabPage2.Controls.Add(this.txt_CSKhoiluong);
            this.tabPage2.Controls.Add(this.txt_TenHangGiay);
            this.tabPage2.Controls.Add(this.txt_TenGiayTT);
            this.tabPage2.Controls.Add(this.txt_MaGiayTT);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1454, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(433, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 43);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chỉnh Sửa Thông Tin Giày Thể Thao";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã giày thể thao :";
            // 
            // txt_MaGiayTT
            // 
            this.txt_MaGiayTT.Location = new System.Drawing.Point(467, 81);
            this.txt_MaGiayTT.Name = "txt_MaGiayTT";
            this.txt_MaGiayTT.Size = new System.Drawing.Size(395, 26);
            this.txt_MaGiayTT.TabIndex = 11;
            // 
            // txt_TenGiayTT
            // 
            this.txt_TenGiayTT.Location = new System.Drawing.Point(467, 123);
            this.txt_TenGiayTT.Name = "txt_TenGiayTT";
            this.txt_TenGiayTT.Size = new System.Drawing.Size(395, 26);
            this.txt_TenGiayTT.TabIndex = 12;
            // 
            // txt_TenHangGiay
            // 
            this.txt_TenHangGiay.Location = new System.Drawing.Point(467, 166);
            this.txt_TenHangGiay.Name = "txt_TenHangGiay";
            this.txt_TenHangGiay.Size = new System.Drawing.Size(395, 26);
            this.txt_TenHangGiay.TabIndex = 13;
            // 
            // txt_CSKhoiluong
            // 
            this.txt_CSKhoiluong.Location = new System.Drawing.Point(467, 207);
            this.txt_CSKhoiluong.Name = "txt_CSKhoiluong";
            this.txt_CSKhoiluong.Size = new System.Drawing.Size(395, 26);
            this.txt_CSKhoiluong.TabIndex = 14;
            // 
            // txt_hanBaoHanh
            // 
            this.txt_hanBaoHanh.Location = new System.Drawing.Point(467, 250);
            this.txt_hanBaoHanh.Name = "txt_hanBaoHanh";
            this.txt_hanBaoHanh.Size = new System.Drawing.Size(395, 26);
            this.txt_hanBaoHanh.TabIndex = 15;
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Location = new System.Drawing.Point(467, 287);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(395, 26);
            this.txt_Soluong.TabIndex = 16;
            // 
            // txt_MauSac
            // 
            this.txt_MauSac.Location = new System.Drawing.Point(467, 330);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.Size = new System.Drawing.Size(395, 26);
            this.txt_MauSac.TabIndex = 17;
            // 
            // txt_CSSizeGiay
            // 
            this.txt_CSSizeGiay.Location = new System.Drawing.Point(467, 445);
            this.txt_CSSizeGiay.Name = "txt_CSSizeGiay";
            this.txt_CSSizeGiay.Size = new System.Drawing.Size(395, 26);
            this.txt_CSSizeGiay.TabIndex = 18;
            // 
            // txt_QuatangKem
            // 
            this.txt_QuatangKem.Location = new System.Drawing.Point(467, 481);
            this.txt_QuatangKem.Name = "txt_QuatangKem";
            this.txt_QuatangKem.Size = new System.Drawing.Size(395, 26);
            this.txt_QuatangKem.TabIndex = 19;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Tomato;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.Location = new System.Drawing.Point(239, 572);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 56);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(496, 572);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(207, 56);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(767, 572);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(179, 56);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tên giày thể thao :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tên hãng giày :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Khối lượng :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Hạn bảo hành :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(205, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 26);
            this.label13.TabIndex = 27;
            this.label13.Text = "Số lượng :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(205, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "Màu sắc :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(205, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 26);
            this.label15.TabIndex = 29;
            this.label15.Text = "Size giày :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(205, 481);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 26);
            this.label16.TabIndex = 30;
            this.label16.Text = "Quà tặng kèm :";
            // 
            // btn_HienThongTin
            // 
            this.btn_HienThongTin.BackColor = System.Drawing.Color.DarkRed;
            this.btn_HienThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HienThongTin.Location = new System.Drawing.Point(1001, 82);
            this.btn_HienThongTin.Name = "btn_HienThongTin";
            this.btn_HienThongTin.Size = new System.Drawing.Size(179, 56);
            this.btn_HienThongTin.TabIndex = 13;
            this.btn_HienThongTin.Text = "Hiện Thông Tin";
            this.btn_HienThongTin.UseVisualStyleBackColor = false;
            this.btn_HienThongTin.Click += new System.EventHandler(this.btn_HienThongTin_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(205, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 26);
            this.label17.TabIndex = 34;
            this.label17.Text = "Chất liệu giày :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(205, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 26);
            this.label18.TabIndex = 33;
            this.label18.Text = "Giá :";
            // 
            // txt_Chatlieugiay
            // 
            this.txt_Chatlieugiay.Location = new System.Drawing.Point(467, 413);
            this.txt_Chatlieugiay.Name = "txt_Chatlieugiay";
            this.txt_Chatlieugiay.Size = new System.Drawing.Size(395, 26);
            this.txt_Chatlieugiay.TabIndex = 32;
            // 
            // txt_GiaGiay
            // 
            this.txt_GiaGiay.Location = new System.Drawing.Point(467, 372);
            this.txt_GiaGiay.Name = "txt_GiaGiay";
            this.txt_GiaGiay.Size = new System.Drawing.Size(395, 26);
            this.txt_GiaGiay.TabIndex = 31;
            // 
            // MaGiayTT
            // 
            this.MaGiayTT.DataPropertyName = "MaGiayTT";
            this.MaGiayTT.HeaderText = "Mã Giày Thể Thao";
            this.MaGiayTT.MinimumWidth = 8;
            this.MaGiayTT.Name = "MaGiayTT";
            // 
            // TenGiayTT
            // 
            this.TenGiayTT.DataPropertyName = "TenGiayTT";
            this.TenGiayTT.HeaderText = "Tên Giày Thể Thao";
            this.TenGiayTT.MinimumWidth = 8;
            this.TenGiayTT.Name = "TenGiayTT";
            // 
            // TenHangGiayTT
            // 
            this.TenHangGiayTT.DataPropertyName = "TenhangGiayTT";
            this.TenHangGiayTT.HeaderText = "Tên Hãng Giày ";
            this.TenHangGiayTT.MinimumWidth = 8;
            this.TenHangGiayTT.Name = "TenHangGiayTT";
            // 
            // KhoiLuong
            // 
            this.KhoiLuong.DataPropertyName = "Khoiluong";
            this.KhoiLuong.HeaderText = "Khối Lượng";
            this.KhoiLuong.MinimumWidth = 8;
            this.KhoiLuong.Name = "KhoiLuong";
            // 
            // HanBaoHanh
            // 
            this.HanBaoHanh.DataPropertyName = "HanBaoHang";
            this.HanBaoHanh.HeaderText = "Hạn Bảo Hành";
            this.HanBaoHanh.MinimumWidth = 8;
            this.HanBaoHanh.Name = "HanBaoHanh";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // SizeGiay
            // 
            this.SizeGiay.DataPropertyName = "SizeGiay";
            this.SizeGiay.HeaderText = "Size";
            this.SizeGiay.MinimumWidth = 8;
            this.SizeGiay.Name = "SizeGiay";
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 8;
            this.MauSac.Name = "MauSac";
            // 
            // ChatLieuGiay
            // 
            this.ChatLieuGiay.DataPropertyName = "ChatLieuGiay";
            this.ChatLieuGiay.HeaderText = "Chất liệu giày";
            this.ChatLieuGiay.MinimumWidth = 8;
            this.ChatLieuGiay.Name = "ChatLieuGiay";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GiaGiay";
            this.Gia.HeaderText = "Giá ";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // QuaTangKem
            // 
            this.QuaTangKem.DataPropertyName = "QuaTangKem";
            this.QuaTangKem.HeaderText = "Quà Tặng Kèm";
            this.QuaTangKem.MinimumWidth = 8;
            this.QuaTangKem.Name = "QuaTangKem";
            // 
            // GiayTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1520, 800);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiayTT";
            this.Text = "GiayTT";
            this.Load += new System.EventHandler(this.GiayTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay_The_Thao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TimTenGiay;
        private System.Windows.Forms.TextBox txt_TimTenHang;
        private System.Windows.Forms.TextBox txt_TimKhoiLuong;
        private System.Windows.Forms.TextBox txt_TimMauSac;
        private System.Windows.Forms.DataGridView dgv_Giay_The_Thao;
        private System.Windows.Forms.Button btn_Tim_Kiem_Giay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TimSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_QuatangKem;
        private System.Windows.Forms.TextBox txt_CSSizeGiay;
        private System.Windows.Forms.TextBox txt_MauSac;
        private System.Windows.Forms.TextBox txt_Soluong;
        private System.Windows.Forms.TextBox txt_hanBaoHanh;
        private System.Windows.Forms.TextBox txt_CSKhoiluong;
        private System.Windows.Forms.TextBox txt_TenHangGiay;
        private System.Windows.Forms.TextBox txt_TenGiayTT;
        private System.Windows.Forms.TextBox txt_MaGiayTT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_HienThongTin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Chatlieugiay;
        private System.Windows.Forms.TextBox txt_GiaGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangGiayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieuGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuaTangKem;
    }
}