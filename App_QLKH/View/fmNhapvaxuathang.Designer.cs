namespace App_QLKH.View
{
    partial class fmNhaphang
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
			this.lblNhapvaxuathang = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblMakho = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNhapvaxuathang
			// 
			this.lblNhapvaxuathang.AutoSize = true;
			this.lblNhapvaxuathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNhapvaxuathang.Location = new System.Drawing.Point(228, 29);
			this.lblNhapvaxuathang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNhapvaxuathang.Name = "lblNhapvaxuathang";
			this.lblNhapvaxuathang.Size = new System.Drawing.Size(168, 24);
			this.lblNhapvaxuathang.TabIndex = 0;
			this.lblNhapvaxuathang.Text = "Nhập và xuất hàng";
			this.lblNhapvaxuathang.Click += new System.EventHandler(this.lblNhapvaxuathang_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblMakho);
			this.panel1.Controls.Add(this.lblNhapvaxuathang);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(661, 409);
			this.panel1.TabIndex = 1;
			// 
			// lblMakho
			// 
			this.lblMakho.AutoSize = true;
			this.lblMakho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMakho.Location = new System.Drawing.Point(61, 81);
			this.lblMakho.Name = "lblMakho";
			this.lblMakho.Size = new System.Drawing.Size(75, 20);
			this.lblMakho.TabIndex = 2;
			this.lblMakho.Text = "Mã hàng:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// fmNhaphang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 433);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "fmNhaphang";
			this.Text = "fmNhaphang";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhapvaxuathang;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMakho;
	}
}