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
    public partial class frmQuanLyNganhHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyNganhHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLyNganhHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        //load data
        private void DataBind()
        {
            ds = db.getNganhHoc();
            dgvquanlynganh.DataSource = ds.Tables[0];
            txtmangnganh.DataBindings.Clear();
            txttennganh.DataBindings.Clear();
            txtmakhoa.DataBindings.Clear();
            txtmangnganh.DataBindings.Add("Text", ds.Tables[0], "MaNganh");
            txttennganh.DataBindings.Add("Text", ds.Tables[0], "TenNganh");
            txtmakhoa.DataBindings.Add("Text", ds.Tables[0], "MaKhoa");
            cbcNganh.Items.Add("Lớp");
            cbcNganh.Items.Add("Sinh viên");
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
            if (!db.insertNganhHoc(ref err,
                txtmangnganh.Text,
                txttennganh.Text,
                txtmakhoa.Text))
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
            if (!db.updateNganhHoc(ref err, txtmangnganh.Text, txttennganh.Text, txtmakhoa.Text))
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
                if (!db.deleteNganhHoc(ref err, txtmangnganh.Text))
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
            frmLopTheoNganh frmLop = new frmLopTheoNganh();
            int r = dgvquanlynganh.CurrentCell.RowIndex;//dòng hiện hành
            frmLop.maNganh = dgvquanlynganh.Rows[r].Cells[0].Value.ToString();
            frmSinhVienTheoNganh frmSinhVien = new frmSinhVienTheoNganh();
            frmSinhVien.maNganh = dgvquanlynganh.Rows[r].Cells[0].Value.ToString();
            frmSinhVien.chon = cbcNganh.Text;
            frmLop.chon = cbcNganh.Text;
            if(frmLop.chon == "Lớp")
                frmLop.ShowDialog();
            if (frmSinhVien.chon == "Sinh viên")
                frmSinhVien.ShowDialog();
        }
    }
}
