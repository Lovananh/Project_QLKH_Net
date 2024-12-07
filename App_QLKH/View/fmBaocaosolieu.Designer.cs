namespace App_QLKH.View
{
    partial class fmBaocaosolieu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.lblTungay = new System.Windows.Forms.Label();
            this.dateTimePickerTungay = new System.Windows.Forms.DateTimePicker();
            this.lblDenngay = new System.Windows.Forms.Label();
            this.dateTimePickerDenngay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo số liệu";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App_QLKH.ReportBaocaohanghoa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(56, 318);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 336);
            this.reportViewer1.TabIndex = 1;
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(449, 252);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(101, 41);
            this.BtnBaocao.TabIndex = 2;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // lblTungay
            // 
            this.lblTungay.AutoSize = true;
            this.lblTungay.Location = new System.Drawing.Point(100, 176);
            this.lblTungay.Name = "lblTungay";
            this.lblTungay.Size = new System.Drawing.Size(73, 20);
            this.lblTungay.TabIndex = 3;
            this.lblTungay.Text = "Từ ngày :";
            // 
            // dateTimePickerTungay
            // 
            this.dateTimePickerTungay.Location = new System.Drawing.Point(206, 170);
            this.dateTimePickerTungay.Name = "dateTimePickerTungay";
            this.dateTimePickerTungay.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerTungay.TabIndex = 4;
            this.dateTimePickerTungay.Value = new System.DateTime(2015, 12, 7, 17, 1, 0, 0);
            // 
            // lblDenngay
            // 
            this.lblDenngay.AutoSize = true;
            this.lblDenngay.Location = new System.Drawing.Point(499, 175);
            this.lblDenngay.Name = "lblDenngay";
            this.lblDenngay.Size = new System.Drawing.Size(85, 20);
            this.lblDenngay.TabIndex = 5;
            this.lblDenngay.Text = "Đến ngày :";
            // 
            // dateTimePickerDenngay
            // 
            this.dateTimePickerDenngay.Location = new System.Drawing.Point(614, 170);
            this.dateTimePickerDenngay.Name = "dateTimePickerDenngay";
            this.dateTimePickerDenngay.Size = new System.Drawing.Size(222, 26);
            this.dateTimePickerDenngay.TabIndex = 6;
            // 
            // fmBaocaosolieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 666);
            this.Controls.Add(this.dateTimePickerDenngay);
            this.Controls.Add(this.lblDenngay);
            this.Controls.Add(this.dateTimePickerTungay);
            this.Controls.Add(this.lblTungay);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "fmBaocaosolieu";
            this.Text = "fmBaocaosolieu";
            this.Load += new System.EventHandler(this.fmBaocaosolieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button BtnBaocao;
        private System.Windows.Forms.Label lblTungay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTungay;
        private System.Windows.Forms.Label lblDenngay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenngay;
    }
}