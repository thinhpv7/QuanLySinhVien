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
    public partial class frmQuanLyDiem : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyDiem()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            ds = db.getDiem();
            dgvquanlydiem.DataSource = ds.Tables[0];
            txtMaSinhVien.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Clear();
            txtHocKi.DataBindings.Clear();
            txtDiemLan1.DataBindings.Clear();
            txtDiemLan2.DataBindings.Clear();
            txtDiemThi.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", ds.Tables[0], "MSSV");
            txtMaMonHoc.DataBindings.Add("Text", ds.Tables[0], "MaMonHoc");
            txtHocKi.DataBindings.Add("Text", ds.Tables[0], "HocKi");
            txtDiemLan1.DataBindings.Add("Text", ds.Tables[0], "Diemlan1");
            txtDiemLan2.DataBindings.Add("Text", ds.Tables[0], "Diemlan2");
            txtDiemThi.DataBindings.Add("Text", ds.Tables[0], "DiemThi");
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
            if (!db.insertDiem(ref err,
                txtMaSinhVien.Text,
                txtMaMonHoc.Text,
                txtHocKi.Text,
                txtDiemLan1.Text,
                txtDiemLan2.Text,
                txtDiemThi.Text))
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
            if (!db.updateDiem(ref err, txtMaSinhVien.Text, txtMaMonHoc.Text, txtHocKi.Text, txtDiemLan1.Text, txtDiemLan2.Text, txtDiemThi.Text))
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
                if (!db.deleteDiem(ref err, txtMaSinhVien.Text, txtMaMonHoc.Text))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("xóa thành công.");
                }
            }
        }
    }
}
