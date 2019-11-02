namespace DO_AN_HE_QUAN_TRI
{
    partial class frmLopTheoKhoaHoc
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
            this.dgvLopTheoKhoaHoc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTheoKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopTheoKhoaHoc
            // 
            this.dgvLopTheoKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopTheoKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SiSo,
            this.MaKhoaHoc,
            this.TenKhoaHoc});
            this.dgvLopTheoKhoaHoc.Location = new System.Drawing.Point(1, 1);
            this.dgvLopTheoKhoaHoc.Name = "dgvLopTheoKhoaHoc";
            this.dgvLopTheoKhoaHoc.Size = new System.Drawing.Size(545, 292);
            this.dgvLopTheoKhoaHoc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.FillWeight = 80F;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.FillWeight = 50F;
            this.SiSo.HeaderText = "Sỉ số";
            this.SiSo.Name = "SiSo";
            // 
            // MaKhoaHoc
            // 
            this.MaKhoaHoc.DataPropertyName = "MaKhoaHoc";
            this.MaKhoaHoc.FillWeight = 80F;
            this.MaKhoaHoc.HeaderText = "Mã khóa học";
            this.MaKhoaHoc.Name = "MaKhoaHoc";
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.DataPropertyName = "TenKhoaHoc";
            this.TenKhoaHoc.HeaderText = "Tên khóa học";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // frmLopTheoKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLopTheoKhoaHoc);
            this.Name = "frmLopTheoKhoaHoc";
            this.Text = "Lớp theo khóa học";
            this.Load += new System.EventHandler(this.frmLopTheoKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTheoKhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopTheoKhoaHoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc;
    }
}