﻿namespace A.GiaoDien
{
    partial class DoiMatKhau
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
            this.txtMatKhauCu = new System.Windows.Forms.MaskedTextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.MaskedTextBox();
            this.btThucHien = new System.Windows.Forms.Button();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(168, 66);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(150, 20);
            this.txtMatKhauCu.TabIndex = 1;
            this.txtMatKhauCu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhiAnOMatKhauCu);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(168, 107);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(150, 20);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhiAnOMatKhauMoi);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đổi Mật Khẩu";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập Lại Mật Khẩu Mới:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(168, 142);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(150, 20);
            this.txtNhapLaiMatKhauMoi.TabIndex = 2;
            this.txtNhapLaiMatKhauMoi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhiAnONhapLai);
            // 
            // btThucHien
            // 
            this.btThucHien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThucHien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btThucHien.Image = global::A.GiaoDien.Properties.Resources.camera_test;
            this.btThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThucHien.Location = new System.Drawing.Point(77, 181);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(108, 40);
            this.btThucHien.TabIndex = 4;
            this.btThucHien.Text = "Thực Hiện";
            this.btThucHien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // btHuyBo
            // 
            this.btHuyBo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btHuyBo.Image = global::A.GiaoDien.Properties.Resources.deletered32;
            this.btHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuyBo.Location = new System.Drawing.Point(214, 181);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(104, 40);
            this.btHuyBo.TabIndex = 5;
            this.btHuyBo.Text = "Hủy Bỏ";
            this.btHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuyBo.UseVisualStyleBackColor = true;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 249);
            this.Controls.Add(this.btHuyBo);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMatKhauCu;
        private System.Windows.Forms.MaskedTextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.Button btHuyBo;
    }
}