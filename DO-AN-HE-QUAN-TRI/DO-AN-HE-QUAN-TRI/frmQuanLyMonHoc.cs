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
    public partial class frmQuanLyMonHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getMonHoc();
            dgvquanlymonhoc.DataSource = ds.Tables[0];
            txtmamonhoc.DataBindings.Clear();
            txttenmonhoc.DataBindings.Clear();
            txtsotinchi.DataBindings.Clear();
            txtmamonhoc.DataBindings.Add("Text", ds.Tables[0], "MaMonHoc");
            txttenmonhoc.DataBindings.Add("Text", ds.Tables[0], "TenMonHoc");
            txtsotinchi.DataBindings.Add("Text", ds.Tables[0], "SoTinChi");
            cbcMonHoc.Items.Add("Sinh viên");
            cbcMonHoc.Items.Add("Giáo viên");
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertMonHoc(ref err,
                txtmamonhoc.Text,
                txttenmonhoc.Text,
                txtsotinchi.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Thêm thành công.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.updateMonHoc(ref err, 
                txtmamonhoc.Text, 
                txttenmonhoc.Text, 
                txtsotinchi.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Sửa thành công.");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string err = "";
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ???",
                "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!db.deleteMonHoc(ref err, txtmamonhoc.Text))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("xóa thành công.");
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmSinhVienTheoMonHoc frmSinhVien = new frmSinhVienTheoMonHoc();
            int r = dgvquanlymonhoc.CurrentCell.RowIndex;//dòng hiện hành
            frmSinhVien.maMonHoc = dgvquanlymonhoc.Rows[r].Cells[0].Value.ToString();
            frmSinhVien.chon = cbcMonHoc.Text;
            frmGiaoVienTheoMonHoc frmGiaoVien = new frmGiaoVienTheoMonHoc();
            frmGiaoVien.maMonHoc = dgvquanlymonhoc.Rows[r].Cells[0].Value.ToString();
            frmGiaoVien.chon = cbcMonHoc.Text;

            if (frmSinhVien.chon == "Sinh viên")
                frmSinhVien.ShowDialog();
            if (frmGiaoVien.chon == "Giáo viên")
                frmGiaoVien.ShowDialog();
        }
    }
}
