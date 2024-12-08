namespace App_QLKH.View
{
    partial class fmDangky
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
			this.btnDangky = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.txtNhapmk = new System.Windows.Forms.TextBox();
			this.txtNhaplaimk = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDangky
			// 
			this.btnDangky.Location = new System.Drawing.Point(137, 292);
			this.btnDangky.Name = "btnDangky";
			this.btnDangky.Size = new System.Drawing.Size(74, 30);
			this.btnDangky.TabIndex = 0;
			this.btnDangky.Text = "Đăng ký";
			this.btnDangky.UseVisualStyleBackColor = true;
			this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(299, 292);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(74, 30);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Text = "Quay lại";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(205, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đăng ký";
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Location = new System.Drawing.Point(156, 101);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(217, 20);
			this.txtTenDangNhap.TabIndex = 3;
			// 
			// txtNhapmk
			// 
			this.txtNhapmk.Location = new System.Drawing.Point(156, 136);
			this.txtNhapmk.Name = "txtNhapmk";
			this.txtNhapmk.Size = new System.Drawing.Size(217, 20);
			this.txtNhapmk.TabIndex = 4;
			// 
			// txtNhaplaimk
			// 
			this.txtNhaplaimk.Location = new System.Drawing.Point(156, 172);
			this.txtNhaplaimk.Name = "txtNhaplaimk";
			this.txtNhaplaimk.Size = new System.Drawing.Size(217, 20);
			this.txtNhaplaimk.TabIndex = 5;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(156, 211);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(217, 20);
			this.txtEmail.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nhập mật khẩu :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Nhập lại mật khẩu :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 218);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Email :";
			// 
			// fmDangky
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(460, 393);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNhaplaimk);
			this.Controls.Add(this.txtNhapmk);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangky);
			this.Name = "fmDangky";
			this.Text = "fmDangky";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnDangky;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.TextBox txtNhapmk;
		private System.Windows.Forms.TextBox txtNhaplaimk;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}