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
    public partial class frmQuanLyLop : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmQuanLyLop()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertLop(ref err,
                txtmalop.Text, 
                txttenlop.Text, 
                txtsiso.Text, 
                txtmakhoahoc.Text, 
                txtmanganh.Text))
                MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Thêm thành công.");
            }
            //DataBind();
        }
        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getLop();
            dgvquanlylop.DataSource = ds.Tables[0];
            txtmalop.DataBindings.Clear();
            txttenlop.DataBindings.Clear();
            txtsiso.DataBindings.Clear();
            txtmakhoahoc.DataBindings.Clear();
            txtmanganh.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", ds.Tables[0], "MaLop");
            txttenlop.DataBindings.Add("Text", ds.Tables[0], "TenLop");
            txtsiso.DataBindings.Add("Text", ds.Tables[0], "SiSo");
            txtmakhoahoc.DataBindings.Add("Text", ds.Tables[0], "MaKhoaHoc");
            txtmanganh.DataBindings.Add("Text", ds.Tables[0], "MaNganh");
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
            if(result == DialogResult.Yes)
            {
                if (!db.deleteLop(ref err, txtmalop.Text))
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
            if (!db.updateLop(ref err, txtmalop.Text, txttenlop.Text, txtsiso.Text, txtmakhoahoc.Text, txtmanganh.Text))
                    MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Sửa thành công.");
            }
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmSinhVienTheoLop frm = new frmSinhVienTheoLop();
            int r = dgvquanlylop.CurrentCell.RowIndex;//dòng hiện hành
            frm.maLop = dgvquanlylop.Rows[r].Cells[0].Value.ToString();
            frm.chon = cbcLop.Text;
            frm.ShowDialog();
        }
    }
}
