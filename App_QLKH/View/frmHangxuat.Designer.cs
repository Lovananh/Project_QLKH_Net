namespace App_QLKH.View
{
	partial class frmHangxuat
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
			this.lblHangnhap = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblHangnhap
			// 
			this.lblHangnhap.AutoSize = true;
			this.lblHangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblHangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHangnhap.Location = new System.Drawing.Point(305, 91);
			this.lblHangnhap.Name = "lblHangnhap";
			this.lblHangnhap.Size = new System.Drawing.Size(119, 24);
			this.lblHangnhap.TabIndex = 1;
			this.lblHangnhap.Text = "Hàng nhập:";
			// 
			// frmHangxuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblHangnhap);
			this.Name = "frmHangxuat";
			this.Text = "frmHangxuat";
			this.Load += new System.EventHandler(this.frmHangxuat_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHangnhap;
	}
}