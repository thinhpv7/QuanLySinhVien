namespace DO_AN_HE_QUAN_TRI
{
    partial class frmQuanLyDiem
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
            this.btntrove = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemLan2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemLan1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvquanlydiem = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemlan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemlan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlydiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btntrove
            // 
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.Location = new System.Drawing.Point(515, 367);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 40);
            this.btntrove.TabIndex = 37;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(515, 283);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(75, 40);
            this.btnreload.TabIndex = 36;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(515, 189);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 40);
            this.btnxoa.TabIndex = 35;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(515, 112);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 40);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(515, 29);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 40);
            this.btnthem.TabIndex = 33;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiemThi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDiemLan2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDiemLan1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHocKi);
            this.panel1.Controls.Add(this.txtMaMonHoc);
            this.panel1.Controls.Add(this.txtMaSinhVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labrl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 220);
            this.panel1.TabIndex = 32;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.Location = new System.Drawing.Point(191, 165);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(234, 23);
            this.txtDiemThi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điểm thi";
            // 
            // txtDiemLan2
            // 
            this.txtDiemLan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLan2.Location = new System.Drawing.Point(191, 136);
            this.txtDiemLan2.Name = "txtDiemLan2";
            this.txtDiemLan2.Size = new System.Drawing.Size(234, 23);
            this.txtDiemLan2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điển lần 2";
            // 
            // txtDiemLan1
            // 
            this.txtDiemLan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLan1.Location = new System.Drawing.Point(191, 107);
            this.txtDiemLan1.Name = "txtDiemLan1";
            this.txtDiemLan1.Size = new System.Drawing.Size(234, 23);
            this.txtDiemLan1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm lần 1";
            // 
            // txtHocKi
            // 
            this.txtHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKi.Location = new System.Drawing.Point(191, 78);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(234, 23);
            this.txtHocKi.TabIndex = 5;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(191, 49);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(234, 23);
            this.txtMaMonHoc.TabIndex = 4;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(191, 17);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(234, 23);
            this.txtMaSinhVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kì";
            // 
            // labrl
            // 
            this.labrl.AutoSize = true;
            this.labrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrl.Location = new System.Drawing.Point(27, 55);
            this.labrl.Name = "labrl";
            this.labrl.Size = new System.Drawing.Size(85, 17);
            this.labrl.TabIndex = 1;
            this.labrl.Text = "Mã môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // dgvquanlydiem
            // 
            this.dgvquanlydiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlydiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.MaMonHoc,
            this.HocKi,
            this.Diemlan1,
            this.Diemlan2,
            this.DiemThi});
            this.dgvquanlydiem.Location = new System.Drawing.Point(12, 12);
            this.dgvquanlydiem.Name = "dgvquanlydiem";
            this.dgvquanlydiem.Size = new System.Drawing.Size(465, 217);
            this.dgvquanlydiem.TabIndex = 31;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã SV";
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 80;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã môn học";
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 80;
            // 
            // HocKi
            // 
            this.HocKi.DataPropertyName = "HocKi";
            this.HocKi.HeaderText = "Học  kì";
            this.HocKi.Name = "HocKi";
            this.HocKi.Width = 50;
            // 
            // Diemlan1
            // 
            this.Diemlan1.DataPropertyName = "Diemlan1";
            this.Diemlan1.HeaderText = "Điểm lần 1";
            this.Diemlan1.Name = "Diemlan1";
            this.Diemlan1.Width = 70;
            // 
            // Diemlan2
            // 
            this.Diemlan2.DataPropertyName = "Diemlan2";
            this.Diemlan2.HeaderText = "Điểm lần 2";
            this.Diemlan2.Name = "Diemlan2";
            this.Diemlan2.Width = 70;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm thi";
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 70;
            // 
            // frmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 498);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvquanlydiem);
            this.Name = "frmQuanLyDiem";
            this.Text = "frmQuanLyDiem";
            this.Load += new System.EventHandler(this.frmQuanLyDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlydiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemLan2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemLan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHocKi;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvquanlydiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemlan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemlan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
    }
}