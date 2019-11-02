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
    public partial class frmSinhVienTheoKhoa : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maKhoa { get; set; }
        public string chon { get; set; }
        public frmSinhVienTheoKhoa()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienTheoKhoa_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            if (chon == "Sinh viên")
            {
                ds = db.getSinhVienTheoKhoa(maKhoa);
                dgvSinhVienTheoKhoa.DataSource = ds.Tables[0];
            }
        }
    }
}
