namespace App_QLKH
{
    partial class Trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolNhacungcap = new System.Windows.Forms.ToolStripButton();
            this.toolNhanvien = new System.Windows.Forms.ToolStripButton();
            this.toolKhohang = new System.Windows.Forms.ToolStripButton();
            this.lblTrangchu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHanghoa = new System.Windows.Forms.Label();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.lblHangnhap = new System.Windows.Forms.Label();
            this.lblHangxuat = new System.Windows.Forms.Label();
            this.lblNhacungcap = new System.Windows.Forms.Label();
            this.lblKhohang = new System.Windows.Forms.Label();
            this.lblBaocaosolieu = new System.Windows.Forms.Label();
            this.lblDangxuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBLoc = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNhacungcap,
            this.toolNhanvien,
            this.toolKhohang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.lblTrangchu);
            this.splitContainer1.Panel1.Controls.Add(this.lblHanghoa);
            this.splitContainer1.Panel1.Controls.Add(this.lblHangxuat);
            this.splitContainer1.Panel1.Controls.Add(this.lblNhacungcap);
            this.splitContainer1.Panel1.Controls.Add(this.lblHangnhap);
            this.splitContainer1.Panel1.Controls.Add(this.lblNhanvien);
            this.splitContainer1.Panel1.Controls.Add(this.lblDangxuat);
            this.splitContainer1.Panel1.Controls.Add(this.lblBaocaosolieu);
            this.splitContainer1.Panel1.Controls.Add(this.lblKhohang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1294, 678);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolNhacungcap
            // 
            this.toolNhacungcap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNhacungcap.Image = ((System.Drawing.Image)(resources.GetObject("toolNhacungcap.Image")));
            this.toolNhacungcap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNhacungcap.Name = "toolNhacungcap";
            this.toolNhacungcap.Size = new System.Drawing.Size(34, 33);
            this.toolNhacungcap.Text = "Nhà cung cấp";
            // 
            // toolNhanvien
            // 
            this.toolNhanvien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("toolNhanvien.Image")));
            this.toolNhanvien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNhanvien.Name = "toolNhanvien";
            this.toolNhanvien.Size = new System.Drawing.Size(34, 28);
            this.toolNhanvien.Text = "Nhân viên";
            // 
            // toolKhohang
            // 
            this.toolKhohang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKhohang.Image = ((System.Drawing.Image)(resources.GetObject("toolKhohang.Image")));
            this.toolKhohang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKhohang.Name = "toolKhohang";
            this.toolKhohang.Size = new System.Drawing.Size(34, 28);
            this.toolKhohang.Text = "Kho hàng";
            this.toolKhohang.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // lblTrangchu
            // 
            this.lblTrangchu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangchu.AutoSize = true;
            this.lblTrangchu.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangchu.Location = new System.Drawing.Point(49, 23);
            this.lblTrangchu.Name = "lblTrangchu";
            this.lblTrangchu.Size = new System.Drawing.Size(128, 31);
            this.lblTrangchu.TabIndex = 0;
            this.lblTrangchu.Text = "Trang chủ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.txtBLoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 678);
            this.panel1.TabIndex = 0;
            // 
            // lblHanghoa
            // 
            this.lblHanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHanghoa.AutoSize = true;
            this.lblHanghoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHanghoa.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanghoa.Location = new System.Drawing.Point(49, 81);
            this.lblHanghoa.Name = "lblHanghoa";
            this.lblHanghoa.Size = new System.Drawing.Size(123, 30);
            this.lblHanghoa.TabIndex = 1;
            this.lblHanghoa.Text = "Hàng hóa";
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.Location = new System.Drawing.Point(45, 338);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(128, 30);
            this.lblNhanvien.TabIndex = 2;
            this.lblNhanvien.Text = "Nhân viên";
            // 
            // lblHangnhap
            // 
            this.lblHangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHangnhap.AutoSize = true;
            this.lblHangnhap.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangnhap.Location = new System.Drawing.Point(41, 205);
            this.lblHangnhap.Name = "lblHangnhap";
            this.lblHangnhap.Size = new System.Drawing.Size(138, 30);
            this.lblHangnhap.TabIndex = 3;
            this.lblHangnhap.Text = "Hàng nhập";
            // 
            // lblHangxuat
            // 
            this.lblHangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHangxuat.AutoSize = true;
            this.lblHangxuat.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangxuat.Location = new System.Drawing.Point(44, 271);
            this.lblHangxuat.Name = "lblHangxuat";
            this.lblHangxuat.Size = new System.Drawing.Size(129, 30);
            this.lblHangxuat.TabIndex = 4;
            this.lblHangxuat.Text = "Hàng xuất";
            // 
            // lblNhacungcap
            // 
            this.lblNhacungcap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhacungcap.AutoSize = true;
            this.lblNhacungcap.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhacungcap.Location = new System.Drawing.Point(23, 405);
            this.lblNhacungcap.Name = "lblNhacungcap";
            this.lblNhacungcap.Size = new System.Drawing.Size(169, 30);
            this.lblNhacungcap.TabIndex = 5;
            this.lblNhacungcap.Text = "Nhà cung cấp";
            // 
            // lblKhohang
            // 
            this.lblKhohang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhohang.AutoSize = true;
            this.lblKhohang.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhohang.Location = new System.Drawing.Point(51, 135);
            this.lblKhohang.Name = "lblKhohang";
            this.lblKhohang.Size = new System.Drawing.Size(122, 30);
            this.lblKhohang.TabIndex = 6;
            this.lblKhohang.Text = "Kho hàng";
            // 
            // lblBaocaosolieu
            // 
            this.lblBaocaosolieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaocaosolieu.AutoSize = true;
            this.lblBaocaosolieu.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaocaosolieu.Location = new System.Drawing.Point(12, 480);
            this.lblBaocaosolieu.Name = "lblBaocaosolieu";
            this.lblBaocaosolieu.Size = new System.Drawing.Size(180, 30);
            this.lblBaocaosolieu.TabIndex = 7;
            this.lblBaocaosolieu.Text = "Báo cáo số liệu";
            this.lblBaocaosolieu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDangxuat
            // 
            this.lblDangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDangxuat.AutoSize = true;
            this.lblDangxuat.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangxuat.Location = new System.Drawing.Point(41, 551);
            this.lblDangxuat.Name = "lblDangxuat";
            this.lblDangxuat.Size = new System.Drawing.Size(128, 30);
            this.lblDangxuat.TabIndex = 8;
            this.lblDangxuat.Text = "Đăng xuất";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trang chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBLoc
            // 
            this.txtBLoc.Location = new System.Drawing.Point(96, 113);
            this.txtBLoc.Name = "txtBLoc";
            this.txtBLoc.Size = new System.Drawing.Size(377, 26);
            this.txtBLoc.TabIndex = 10;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(511, 113);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 37);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(96, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 194);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(414, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 194);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(708, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 197);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(884, 220);
            this.dataGridView1.TabIndex = 15;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 716);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Trangchu";
            this.Text = "Trang Chủ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolNhacungcap;
        private System.Windows.Forms.ToolStripButton toolNhanvien;
        private System.Windows.Forms.ToolStripButton toolKhohang;
        private System.Windows.Forms.Label lblTrangchu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHangxuat;
        private System.Windows.Forms.Label lblHangnhap;
        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.Label lblHanghoa;
        private System.Windows.Forms.Label lblBaocaosolieu;
        private System.Windows.Forms.Label lblKhohang;
        private System.Windows.Forms.Label lblNhacungcap;
        private System.Windows.Forms.Label lblDangxuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtBLoc;
        private System.Windows.Forms.Label label1;
    }
}

