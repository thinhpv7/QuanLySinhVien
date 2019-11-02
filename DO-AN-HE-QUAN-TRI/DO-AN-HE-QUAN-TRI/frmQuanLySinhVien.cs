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
using System.IO;


namespace DO_AN_HE_QUAN_TRI
{
    public partial class frmQuanLySinhVien : Form
    {
        DataSet ds;
        DBBusinessLayer db;

        //địa chỉ của image
        //string imgLoc = "";
        //private byte[] img = null; //image
        //private object txtgioitinh;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getSinhVien();
            dgvquanlysinhvien.DataSource = ds.Tables[0];
            txtmalop.DataBindings.Clear();
            txtmssv.DataBindings.Clear();
            txthoten.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtngaysinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtmalop.DataBindings.Clear();
            txtmssv.DataBindings.Add("text", ds.Tables[0], "mssv");
            txthoten.DataBindings.Add("text", ds.Tables[0], "tensv");
            txtGioiTinh.DataBindings.Add("text", ds.Tables[0], "gioitinh");
            txtngaysinh.DataBindings.Add("text", ds.Tables[0], "ngaysinh");
            txtnoisinh.DataBindings.Add("text", ds.Tables[0], "noisinh");
            txtdiachi.DataBindings.Add("text", ds.Tables[0], "diachi");
            txtsdt.DataBindings.Add("text", ds.Tables[0], "sodienthoai");
            txtmalop.DataBindings.Add("text", ds.Tables[0], "malop");
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string err = "";
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ???",
                "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!db.deleteSinhVien(ref err, Int32.Parse(txtmssv.Text)))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("xóa thành công.");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.updateSinhVien(ref err, Int32.Parse(txtmssv.Text), txthoten.Text, txtGioiTinh.Text, txtngaysinh.Text,
                txtnoisinh.Text, txtdiachi.Text, txtsdt.Text, txtmalop.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Sửa thành công.");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertSinhVien(ref err, Int32.Parse(txtmssv.Text), txthoten.Text, txtGioiTinh.Text, txtngaysinh.Text,
                txtnoisinh.Text, txtdiachi.Text, txtsdt.Text, txtmalop.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Thêm thành công.");
            }
        }
    }
}
