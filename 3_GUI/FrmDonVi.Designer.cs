﻿
namespace _3_GUI
{
    partial class FrmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi));
            this.rbtn_KHDCachchebien = new System.Windows.Forms.RadioButton();
            this.rbtn_HDCachchebien = new System.Windows.Forms.RadioButton();
            this.btnXoaCongThuc = new System.Windows.Forms.Button();
            this.dgvCachNau = new System.Windows.Forms.DataGridView();
            this.btnThemCongThuc = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTimKiemCongthucCB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_MethName = new System.Windows.Forms.TextBox();
            this.txt_MethID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachNau)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_KHDCachchebien
            // 
            this.rbtn_KHDCachchebien.AutoSize = true;
            this.rbtn_KHDCachchebien.Location = new System.Drawing.Point(483, 164);
            this.rbtn_KHDCachchebien.Name = "rbtn_KHDCachchebien";
            this.rbtn_KHDCachchebien.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KHDCachchebien.TabIndex = 62;
            this.rbtn_KHDCachchebien.TabStop = true;
            this.rbtn_KHDCachchebien.Text = "Không hoạt động";
            this.rbtn_KHDCachchebien.UseVisualStyleBackColor = true;
            // 
            // rbtn_HDCachchebien
            // 
            this.rbtn_HDCachchebien.AutoSize = true;
            this.rbtn_HDCachchebien.Location = new System.Drawing.Point(359, 164);
            this.rbtn_HDCachchebien.Name = "rbtn_HDCachchebien";
            this.rbtn_HDCachchebien.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HDCachchebien.TabIndex = 63;
            this.rbtn_HDCachchebien.TabStop = true;
            this.rbtn_HDCachchebien.Text = "Hoạt động";
            this.rbtn_HDCachchebien.UseVisualStyleBackColor = true;
            // 
            // btnXoaCongThuc
            // 
            this.btnXoaCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCongThuc.Image")));
            this.btnXoaCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCongThuc.Location = new System.Drawing.Point(522, 225);
            this.btnXoaCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaCongThuc.Name = "btnXoaCongThuc";
            this.btnXoaCongThuc.Size = new System.Drawing.Size(125, 49);
            this.btnXoaCongThuc.TabIndex = 60;
            this.btnXoaCongThuc.Text = "Xóa";
            this.btnXoaCongThuc.UseVisualStyleBackColor = true;
            this.btnXoaCongThuc.Click += new System.EventHandler(this.btnXoaCongThuc_Click);
            // 
            // dgvCachNau
            // 
            this.dgvCachNau.AllowUserToResizeRows = false;
            this.dgvCachNau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCachNau.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCachNau.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCachNau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCachNau.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCachNau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachNau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCachNau.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCachNau.Location = new System.Drawing.Point(232, 341);
            this.dgvCachNau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCachNau.MultiSelect = false;
            this.dgvCachNau.Name = "dgvCachNau";
            this.dgvCachNau.ReadOnly = true;
            this.dgvCachNau.RowHeadersVisible = false;
            this.dgvCachNau.RowHeadersWidth = 40;
            this.dgvCachNau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCachNau.Size = new System.Drawing.Size(423, 574);
            this.dgvCachNau.TabIndex = 61;
            this.dgvCachNau.TabStop = false;
            this.dgvCachNau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCachNau_CellClick);
            // 
            // btnThemCongThuc
            // 
            this.btnThemCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCongThuc.Image")));
            this.btnThemCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCongThuc.Location = new System.Drawing.Point(232, 225);
            this.btnThemCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemCongThuc.Name = "btnThemCongThuc";
            this.btnThemCongThuc.Size = new System.Drawing.Size(125, 49);
            this.btnThemCongThuc.TabIndex = 59;
            this.btnThemCongThuc.Text = "Thêm";
            this.btnThemCongThuc.UseVisualStyleBackColor = true;
            this.btnThemCongThuc.Click += new System.EventHandler(this.btnThemCongThuc_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(225, 163);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Trạng thái :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(359, 307);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 55;
            this.label20.Text = "Tìm kiếm :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(222, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tên Đơn Vị";
            // 
            // txtTimKiemCongthucCB
            // 
            this.txtTimKiemCongthucCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemCongthucCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiemCongthucCB.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemCongthucCB.Location = new System.Drawing.Point(454, 304);
            this.txtTimKiemCongthucCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemCongthucCB.Name = "txtTimKiemCongthucCB";
            this.txtTimKiemCongthucCB.Size = new System.Drawing.Size(201, 26);
            this.txtTimKiemCongthucCB.TabIndex = 50;
            this.txtTimKiemCongthucCB.TextChanged += new System.EventHandler(this.txtTimKiemCongthucCB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(222, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Mã Đơn Vị";
            // 
            // txt_MethName
            // 
            this.txt_MethName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MethName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MethName.ForeColor = System.Drawing.Color.Black;
            this.txt_MethName.Location = new System.Drawing.Point(350, 114);
            this.txt_MethName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MethName.Name = "txt_MethName";
            this.txt_MethName.Size = new System.Drawing.Size(256, 26);
            this.txt_MethName.TabIndex = 51;
            // 
            // txt_MethID
            // 
            this.txt_MethID.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_MethID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MethID.ForeColor = System.Drawing.Color.Black;
            this.txt_MethID.Location = new System.Drawing.Point(350, 66);
            this.txt_MethID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MethID.Name = "txt_MethID";
            this.txt_MethID.ReadOnly = true;
            this.txt_MethID.Size = new System.Drawing.Size(256, 26);
            this.txt_MethID.TabIndex = 57;
            this.txt_MethID.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(383, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 52;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(222, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "ĐƠN VỊ";
            // 
            // FrmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 926);
            this.Controls.Add(this.rbtn_KHDCachchebien);
            this.Controls.Add(this.rbtn_HDCachchebien);
            this.Controls.Add(this.btnXoaCongThuc);
            this.Controls.Add(this.dgvCachNau);
            this.Controls.Add(this.btnThemCongThuc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTimKiemCongthucCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_MethName);
            this.Controls.Add(this.txt_MethID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "FrmDonVi";
            this.Text = "FrmDonVi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachNau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_KHDCachchebien;
        private System.Windows.Forms.RadioButton rbtn_HDCachchebien;
        private System.Windows.Forms.Button btnXoaCongThuc;
        private System.Windows.Forms.DataGridView dgvCachNau;
        private System.Windows.Forms.Button btnThemCongThuc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTimKiemCongthucCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_MethName;
        private System.Windows.Forms.TextBox txt_MethID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}