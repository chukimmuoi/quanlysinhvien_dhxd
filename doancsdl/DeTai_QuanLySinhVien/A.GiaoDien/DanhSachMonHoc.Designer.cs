﻿namespace A.GiaoDien
{
    partial class DanhSachMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachMonHoc));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btInBaoCao = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btThem,
            this.toolStripLabel2,
            this.btSua,
            this.toolStripLabel4,
            this.btXoa,
            this.toolStripLabel5,
            this.lbTimKiem,
            this.txtTimKiem,
            this.btInBaoCao});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(857, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "(F9)>";
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(114, 22);
            this.btThem.Text = "Thêm Môn Học.";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "(F10)>";
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(107, 22);
            this.btSua.Text = "Sửa Thông Tin.";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel4.Text = "(F11)>";
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 22);
            this.btXoa.Text = "Xóa Môn Học.";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel5.Text = "(F12)>";
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(77, 22);
            this.lbTimKiem.Text = "Tìm Kiếm (*):";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 25);
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhiAnTimKiem);
            // 
            // btInBaoCao
            // 
            this.btInBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btInBaoCao.Image")));
            this.btInBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInBaoCao.Name = "btInBaoCao";
            this.btInBaoCao.Size = new System.Drawing.Size(84, 22);
            this.btInBaoCao.Text = "In Báo Cáo";
            this.btInBaoCao.Click += new System.EventHandler(this.btInBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDanhSachMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 560);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Môn Học.";
            // 
            // tbDanhSachMonHoc
            // 
            this.tbDanhSachMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tbDanhSachMonHoc.Location = new System.Drawing.Point(6, 19);
            this.tbDanhSachMonHoc.Name = "tbDanhSachMonHoc";
            this.tbDanhSachMonHoc.Size = new System.Drawing.Size(845, 535);
            this.tbDanhSachMonHoc.TabIndex = 0;
            this.tbDanhSachMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDanhSachMonHoc_CellContentClick);
            this.tbDanhSachMonHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.KichDupChuot);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMonHoc";
            this.Column1.HeaderText = "Mã Môn Học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMonHoc";
            this.Column2.HeaderText = "Tên Môn Học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTinChi";
            this.Column3.HeaderText = "Số Tín Chỉ";
            this.Column3.Name = "Column3";
            // 
            // DanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachMonHoc";
            this.Text = "DanhSachsMonHoc";
            this.Load += new System.EventHandler(this.DanhSachMonHoc_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbDanhSachMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripButton btInBaoCao;
    }
}