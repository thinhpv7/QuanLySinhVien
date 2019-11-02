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
    public partial class frmQuanLyGiaoVien : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyGiaoVien()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getGiaoVien();
            dgvquanlygiaovien.DataSource = ds.Tables[0];
            txtmagiagvien.DataBindings.Clear();
            txttengiangvien.DataBindings.Clear();
            txtmakhoa.DataBindings.Clear();
            txtmagiagvien.DataBindings.Add("text", ds.Tables[0], "MaGV");
            txttengiangvien.DataBindings.Add("text", ds.Tables[0], "TenGV");
            txtmakhoa.DataBindings.Add("text", ds.Tables[0], "MaKhoa");
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string err = "";
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ???",
                "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!db.deleteGiaoVien(ref err, txtmagiagvien.Text))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("xóa thành công.");
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertGiaoVien(ref err, txtmagiagvien.Text, txttengiangvien.Text, txtmakhoa.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Thêm giáo viên thành công.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.updateGiaoVien(ref err, txtmagiagvien.Text, txttengiangvien.Text, txtmakhoa.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Sủa giáo viên thành công.");
            }
        }
    }
}
