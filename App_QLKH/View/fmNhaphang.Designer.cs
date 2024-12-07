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
            this.lblNhaphang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhaphang
            // 
            this.lblNhaphang.AutoSize = true;
            this.lblNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaphang.Location = new System.Drawing.Point(392, 62);
            this.lblNhaphang.Name = "lblNhaphang";
            this.lblNhaphang.Size = new System.Drawing.Size(153, 32);
            this.lblNhaphang.TabIndex = 0;
            this.lblNhaphang.Text = "Nhập hàng";
            // 
            // fmNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 666);
            this.Controls.Add(this.lblNhaphang);
            this.Name = "fmNhaphang";
            this.Text = "fmNhaphang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhaphang;
    }
}