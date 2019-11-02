using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBusiness;

namespace DO_AN_HE_QUAN_TRI
{
    public partial class MainForm : Form
    {
        //Khai báo
        DBBusinessLayer db;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
            db = new DBBusinessLayer();
            ds = new DataSet();
        }
        private void lopQuanLyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQuanLyLop frm = new frmQuanLyLop();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không ???",
                "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                Application.Exit();
        }

        private void monHocQuanLyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc frm = new frmQuanLyMonHoc();
            frm.ShowDialog();
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoaHoc frm = new frmQuanLyKhoaHoc();
            frm.ShowDialog();
        }

        private void nganhQuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNganhHoc frm = new frmQuanLyNganhHoc();
            frm.ShowDialog();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyDiem frm = new frmQuanLyDiem();
            frm.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa frm = new frmQuanLyKhoa();
            frm.ShowDialog();
        }

        private void sinhVienQuanLyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frm = new frmQuanLySinhVien();
            frm.ShowDialog();
        }

        private void giaoVienQuanLyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQuanLyGiaoVien frm = new frmQuanLyGiaoVien();
            frm.ShowDialog();
        }
    }
}
