namespace DO_AN_HE_QUAN_TRI
{
    partial class frmQuanLyKhoaHoc
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
            this.txtTenKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtMaKhoaHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyKhoaHoc = new System.Windows.Forms.DataGridView();
            this.MaKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbcKhoaHoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btntrove
            // 
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.Location = new System.Drawing.Point(298, 211);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 40);
            this.btntrove.TabIndex = 39;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(298, 150);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(75, 40);
            this.btnreload.TabIndex = 38;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(298, 104);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 40);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(298, 58);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 40);
            this.btnsua.TabIndex = 36;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(298, 12);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 40);
            this.btnthem.TabIndex = 35;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenKhoaHoc);
            this.panel1.Controls.Add(this.txtMaKhoaHoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 83);
            this.panel1.TabIndex = 34;
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(110, 40);
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(135, 23);
            this.txtTenKhoaHoc.TabIndex = 4;
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(110, 5);
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(135, 23);
            this.txtMaKhoaHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khóa học";
            // 
            // dgvQuanLyKhoaHoc
            // 
            this.dgvQuanLyKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaHoc,
            this.TenKhoaHoc});
            this.dgvQuanLyKhoaHoc.Location = new System.Drawing.Point(12, 12);
            this.dgvQuanLyKhoaHoc.Name = "dgvQuanLyKhoaHoc";
            this.dgvQuanLyKhoaHoc.Size = new System.Drawing.Size(245, 239);
            this.dgvQuanLyKhoaHoc.TabIndex = 33;
            // 
            // MaKhoaHoc
            // 
            this.MaKhoaHoc.DataPropertyName = "MaKhoaHoc";
            this.MaKhoaHoc.HeaderText = "Mã khóa học";
            this.MaKhoaHoc.Name = "MaKhoaHoc";
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.DataPropertyName = "TenKhoaHoc";
            this.TenKhoaHoc.HeaderText = "Tên khóa học";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "Xem ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbcKhoaHoc
            // 
            this.cbcKhoaHoc.BackColor = System.Drawing.SystemColors.Menu;
            this.cbcKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcKhoaHoc.FormattingEnabled = true;
            this.cbcKhoaHoc.Location = new System.Drawing.Point(275, 275);
            this.cbcKhoaHoc.Name = "cbcKhoaHoc";
            this.cbcKhoaHoc.Size = new System.Drawing.Size(121, 28);
            this.cbcKhoaHoc.TabIndex = 41;
            this.cbcKhoaHoc.Text = "Lớp";
            // 
            // frmQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 414);
            this.Controls.Add(this.cbcKhoaHoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuanLyKhoaHoc);
            this.Name = "frmQuanLyKhoaHoc";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.frmQuanLyKhoaHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenKhoaHoc;
        private System.Windows.Forms.TextBox txtMaKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLyKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbcKhoaHoc;
    }
}