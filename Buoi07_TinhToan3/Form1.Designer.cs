﻿namespace Buoi07_TinhToan3
{
    partial class Form1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(172, 218);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(25, 218);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(90, 32);
            this.btnTinh.TabIndex = 18;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phép tính:";
            // 
            // txtKq
            // 
            this.txtKq.Enabled = false;
            this.txtKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(162, 87);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 26);
            this.txtKq.TabIndex = 15;
            this.txtKq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kết quả:";
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(162, 48);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 26);
            this.txtSo2.TabIndex = 13;
            this.txtSo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập số thứ hai:";
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(162, 12);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 26);
            this.txtSo1.TabIndex = 11;
            this.txtSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập số thứ nhất:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChia);
            this.groupBox1.Controls.Add(this.radNhan);
            this.groupBox1.Controls.Add(this.radTru);
            this.groupBox1.Controls.Add(this.radCong);
            this.groupBox1.Location = new System.Drawing.Point(116, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCong.Location = new System.Drawing.Point(15, 21);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(59, 21);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTru.Location = new System.Drawing.Point(15, 44);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(48, 21);
            this.radTru.TabIndex = 1;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhan.Location = new System.Drawing.Point(85, 21);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(60, 21);
            this.radNhan.TabIndex = 2;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChia.Location = new System.Drawing.Point(85, 44);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(54, 21);
            this.radChia.TabIndex = 3;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tinh toan don gian 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radCong;
    }
}

