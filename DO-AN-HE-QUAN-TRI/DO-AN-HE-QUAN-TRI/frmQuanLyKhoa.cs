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
    public partial class frmQuanLyKhoa : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyKhoa()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getKhoa();
            dgvQuanLyKhoa.DataSource = ds.Tables[0];
            txtMaKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", ds.Tables[0], "MaKhoa");
            txtTenKhoa.DataBindings.Add("Text", ds.Tables[0], "TenKhoa");
            cbcKhoa.Items.Add("Lớp");
            cbcKhoa.Items.Add("Sinh viên");
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
            if (!db.insertKhoa(ref err,
                txtMaKhoa.Text,
                txtTenKhoa.Text))
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
            if (!db.updateKhoa(ref err, txtMaKhoa.Text, txtTenKhoa.Text))
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
                if (!db.deleteKhoa(ref err, txtMaKhoa.Text))
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

            frmLopTheoKhoa frmLop = new frmLopTheoKhoa();
            int r = dgvQuanLyKhoa.CurrentCell.RowIndex;//dòng hiện hành
            frmLop.maKhoa = dgvQuanLyKhoa.Rows[r].Cells[0].Value.ToString();
            frmLop.chon = cbcKhoa.Text;
            frmSinhVienTheoKhoa frmSinhVien = new frmSinhVienTheoKhoa();
            frmSinhVien.maKhoa = dgvQuanLyKhoa.Rows[r].Cells[0].Value.ToString();
            frmSinhVien.chon = cbcKhoa.Text;
            if(frmLop.chon == "Lớp")
                frmLop.ShowDialog();
            if (frmSinhVien.chon == "Sinh viên")
                frmSinhVien.ShowDialog();
        }
    }
}
