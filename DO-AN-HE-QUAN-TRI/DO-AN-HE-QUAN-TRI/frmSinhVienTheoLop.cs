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
    public partial class frmSinhVienTheoLop : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public frmSinhVienTheoLop()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }
        public string maLop { set; get; } //mã khóa học
        public string chon { set; get; } //mã khóa học
        private void frmSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            if (chon == "Sinh viên")
            {
                ds = db.getSinhVienTheoLop(maLop);
                dgvSinhVienLop.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
