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
    public partial class frmLopTheoKhoaHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmLopTheoKhoaHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }
        public string maKhoaHoc { set; get; } //mã khóa học
        public string chon { set; get; } //mã khóa học

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLopTheoKhoaHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            if(chon == "Lớp")
            {
                ds = db.getLopTheoKhoaHoc(maKhoaHoc);
                dgvLopTheoKhoaHoc.DataSource = ds.Tables[0];
            }  
        }
    }
}
