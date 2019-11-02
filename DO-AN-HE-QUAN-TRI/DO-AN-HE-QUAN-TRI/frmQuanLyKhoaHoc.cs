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
    public partial class frmQuanLyKhoaHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyKhoaHoc()
        {
            ds = new DataSet();
            db = new DBBusinessLayer();
            InitializeComponent();
        }

        private void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getKhoaHoc();
            dgvQuanLyKhoaHoc.DataSource = ds.Tables[0];
            txtMaKhoaHoc.DataBindings.Clear();
            txtTenKhoaHoc.DataBindings.Clear();
            txtMaKhoaHoc.DataBindings.Add("Text", ds.Tables[0], "MaKhoaHoc");
            txtTenKhoaHoc.DataBindings.Add("Text", ds.Tables[0], "TenKhoaHoc");
            cbcKhoaHoc.Items.Add("Lớp");
            cbcKhoaHoc.Items.Add("Sinh viên");
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertKhoaHoc(ref err,
                txtMaKhoaHoc.Text,
                txtTenKhoaHoc.Text))
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
            if (!db.updateKhoaHoc(ref err, txtMaKhoaHoc.Text, txtTenKhoaHoc.Text))
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
                if (!db.deleteKhoaHoc(ref err, txtMaKhoaHoc.Text))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("xóa thành công.");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            //lấy lớp theo khóa học
            frmLopTheoKhoaHoc frmLop = new frmLopTheoKhoaHoc();
            int r = dgvQuanLyKhoaHoc.CurrentCell.RowIndex;//dòng hi{ện hành
            frmLop.maKhoaHoc = dgvQuanLyKhoaHoc.Rows[r].Cells[0].Value.ToString();
            //lấy sinh viên theo khóa học
            frmSinhVienTheoKhoaHoc frmSinhVien = new frmSinhVienTheoKhoaHoc();
            frmSinhVien.maKhoaHoc = dgvQuanLyKhoaHoc.Rows[r].Cells[0].Value.ToString();
            //lấy giá trị trên combobox
            frmLop.chon = cbcKhoaHoc.Text;
            frmSinhVien.chon = cbcKhoaHoc.Text;
            if (frmLop.chon == "Lớp")
                frmLop.ShowDialog();
            if (frmSinhVien.chon == "Sinh viên")
                frmSinhVien.ShowDialog();
        }
    }
}
