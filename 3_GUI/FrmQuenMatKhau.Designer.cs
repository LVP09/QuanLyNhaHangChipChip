﻿
namespace _3_GUI
{
    partial class FrmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuenMatKhau));
            this.lbFrmKhachHang = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_SendtoEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_XacNhan = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFrmKhachHang
            // 
            this.lbFrmKhachHang.AutoSize = true;
            this.lbFrmKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrmKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbFrmKhachHang.Location = new System.Drawing.Point(111, 21);
            this.lbFrmKhachHang.Name = "lbFrmKhachHang";
            this.lbFrmKhachHang.Size = new System.Drawing.Size(220, 38);
            this.lbFrmKhachHang.TabIndex = 101;
            this.lbFrmKhachHang.Text = "Quên mật khẩu";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_XacNhan.Location = new System.Drawing.Point(270, 255);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.btn_XacNhan.TabIndex = 107;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_SendtoEmail
            // 
            this.btn_SendtoEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_SendtoEmail.Location = new System.Drawing.Point(74, 255);
            this.btn_SendtoEmail.Name = "btn_SendtoEmail";
            this.btn_SendtoEmail.Size = new System.Drawing.Size(94, 29);
            this.btn_SendtoEmail.TabIndex = 106;
            this.btn_SendtoEmail.Text = "Gửi";
            this.btn_SendtoEmail.UseVisualStyleBackColor = true;
            this.btn_SendtoEmail.Click += new System.EventHandler(this.btn_SendtoEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(32, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Xác nhận Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(74, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Email";
            // 
            // Txt_XacNhan
            // 
            this.Txt_XacNhan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Txt_XacNhan.Location = new System.Drawing.Point(169, 194);
            this.Txt_XacNhan.Name = "Txt_XacNhan";
            this.Txt_XacNhan.Size = new System.Drawing.Size(195, 27);
            this.Txt_XacNhan.TabIndex = 103;
            // 
            // txt_Email
            // 
            this.txt_Email.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Email.Location = new System.Drawing.Point(168, 111);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(195, 27);
            this.txt_Email.TabIndex = 102;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.Color.Maroon;
            this.btnQuaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaylai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuaylai.ForeColor = System.Drawing.Color.White;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(338, 335);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(80, 37);
            this.btnQuaylai.TabIndex = 108;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 386);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_SendtoEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_XacNhan);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbFrmKhachHang);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quên Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFrmKhachHang;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_SendtoEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_XacNhan;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btnQuaylai;
    }
}