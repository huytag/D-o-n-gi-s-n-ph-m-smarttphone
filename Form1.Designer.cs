namespace DuBaoGiaDT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.gridSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCPU = new System.Windows.Forms.ComboBox();
            this.cboRam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKTMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDLPin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.cbohang = new System.Windows.Forms.ComboBox();
            this.txtKhoiLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboLoaiMH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(527, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "BẢNG THÔNG TIN GIÁ SẢN PHẨM";
            // 
            // gridSP
            // 
            this.gridSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSP.Location = new System.Drawing.Point(12, 34);
            this.gridSP.Name = "gridSP";
            this.gridSP.RowTemplate.Height = 24;
            this.gridSP.Size = new System.Drawing.Size(1340, 351);
            this.gridSP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // cboCPU
            // 
            this.cboCPU.FormattingEnabled = true;
            this.cboCPU.Location = new System.Drawing.Point(72, 424);
            this.cboCPU.Name = "cboCPU";
            this.cboCPU.Size = new System.Drawing.Size(201, 30);
            this.cboCPU.TabIndex = 1;
            // 
            // cboRam
            // 
            this.cboRam.FormattingEnabled = true;
            this.cboRam.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6",
            "8",
            "12"});
            this.cboRam.Location = new System.Drawing.Point(72, 477);
            this.cboRam.Name = "cboRam";
            this.cboRam.Size = new System.Drawing.Size(201, 30);
            this.cboRam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "RAM";
            // 
            // cboRom
            // 
            this.cboRom.FormattingEnabled = true;
            this.cboRom.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.cboRom.Location = new System.Drawing.Point(72, 534);
            this.cboRom.Name = "cboRom";
            this.cboRom.Size = new System.Drawing.Size(201, 30);
            this.cboRom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "ROM";
            // 
            // txtKTMH
            // 
            this.txtKTMH.Location = new System.Drawing.Point(459, 425);
            this.txtKTMH.Name = "txtKTMH";
            this.txtKTMH.Size = new System.Drawing.Size(226, 30);
            this.txtKTMH.TabIndex = 7;
            this.txtKTMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKTMH_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kích thước MH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dung lượng PIN";
            // 
            // txtDLPin
            // 
            this.txtDLPin.Location = new System.Drawing.Point(459, 538);
            this.txtDLPin.Name = "txtDLPin";
            this.txtDLPin.Size = new System.Drawing.Size(226, 30);
            this.txtDLPin.TabIndex = 10;
            this.txtDLPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDLPin_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loại màn hình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(724, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hãng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chiều dài";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(826, 483);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(226, 30);
            this.txtDai.TabIndex = 15;
            this.txtDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDai_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(716, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Chiều rộng";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(826, 543);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(226, 30);
            this.txtRong.TabIndex = 17;
            this.txtRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRong_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(84, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 34);
            this.label11.TabIndex = 19;
            this.label11.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(216, 605);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(342, 39);
            this.txtKetQua.TabIndex = 20;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.Lavender;
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Red;
            this.btnNhap.Location = new System.Drawing.Point(1149, 507);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(134, 52);
            this.btnNhap.TabIndex = 21;
            this.btnNhap.Text = "Dự Báo";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // cbohang
            // 
            this.cbohang.FormattingEnabled = true;
            this.cbohang.Location = new System.Drawing.Point(826, 430);
            this.cbohang.Name = "cbohang";
            this.cbohang.Size = new System.Drawing.Size(226, 30);
            this.cbohang.TabIndex = 22;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Location = new System.Drawing.Point(1126, 430);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Size = new System.Drawing.Size(226, 30);
            this.txtKhoiLuong.TabIndex = 24;
            this.txtKhoiLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoiLuong_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1085, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "KL";
            // 
            // cboLoaiMH
            // 
            this.cboLoaiMH.FormattingEnabled = true;
            this.cboLoaiMH.Location = new System.Drawing.Point(459, 478);
            this.cboLoaiMH.Name = "cboLoaiMH";
            this.cboLoaiMH.Size = new System.Drawing.Size(226, 30);
            this.cboLoaiMH.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1365, 668);
            this.Controls.Add(this.cboLoaiMH);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbohang);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDLPin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKTMH);
            this.Controls.Add(this.cboRom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSP);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dự báo giá điện thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCPU;
        private System.Windows.Forms.ComboBox cboRam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKTMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDLPin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ComboBox cbohang;
        private System.Windows.Forms.TextBox txtKhoiLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboLoaiMH;
    }
}

