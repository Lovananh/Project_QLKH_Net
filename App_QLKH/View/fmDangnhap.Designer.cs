namespace App_QLKH.View
{
    partial class fmDangnhap
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
			this.txtTendangnhap = new System.Windows.Forms.TextBox();
			this.txtMatkhau = new System.Windows.Forms.TextBox();
			this.txtchuacotaikhoan = new System.Windows.Forms.LinkLabel();
			this.btndangnhap = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(181, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(115, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đăng nhập :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(115, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật khẩu :";
			// 
			// txtTendangnhap
			// 
			this.txtTendangnhap.Location = new System.Drawing.Point(231, 136);
			this.txtTendangnhap.Name = "txtTendangnhap";
			this.txtTendangnhap.Size = new System.Drawing.Size(166, 20);
			this.txtTendangnhap.TabIndex = 3;
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(231, 177);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.Size = new System.Drawing.Size(166, 20);
			this.txtMatkhau.TabIndex = 4;
			// 
			// txtchuacotaikhoan
			// 
			this.txtchuacotaikhoan.AutoSize = true;
			this.txtchuacotaikhoan.Location = new System.Drawing.Point(127, 220);
			this.txtchuacotaikhoan.Name = "txtchuacotaikhoan";
			this.txtchuacotaikhoan.Size = new System.Drawing.Size(103, 13);
			this.txtchuacotaikhoan.TabIndex = 5;
			this.txtchuacotaikhoan.TabStop = true;
			this.txtchuacotaikhoan.Text = "Chưa có tài khoản ?";
			// 
			// btndangnhap
			// 
			this.btndangnhap.Location = new System.Drawing.Point(218, 259);
			this.btndangnhap.Name = "btndangnhap";
			this.btndangnhap.Size = new System.Drawing.Size(77, 33);
			this.btndangnhap.TabIndex = 6;
			this.btndangnhap.Text = "Đăng nhập";
			this.btndangnhap.UseVisualStyleBackColor = true;
			this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(310, 259);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(77, 33);
			this.btnthoat.TabIndex = 7;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// fmDangnhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(521, 408);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btndangnhap);
			this.Controls.Add(this.txtchuacotaikhoan);
			this.Controls.Add(this.txtMatkhau);
			this.Controls.Add(this.txtTendangnhap);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "fmDangnhap";
			this.Text = "fmDangnhap";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTendangnhap;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.LinkLabel txtchuacotaikhoan;
		private System.Windows.Forms.Button btndangnhap;
		private System.Windows.Forms.Button btnthoat;
	}
}