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
    public partial class frmSinhVienTheoKhoaHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maKhoaHoc { set; get; } //mã khóa học
        public string chon { set; get; } //mã khóa học

        public frmSinhVienTheoKhoaHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienTheoKhoaHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            if (chon == "Sinh viên")
            {
                ds = db.getSinhVienTheoKhoaHoc(maKhoaHoc);
                dgvSinhVienTheoKhoaHoc.DataSource = ds.Tables[0];
            }
        }
    }
}
