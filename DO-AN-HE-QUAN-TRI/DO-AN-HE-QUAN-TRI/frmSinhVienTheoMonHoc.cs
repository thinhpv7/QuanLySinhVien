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
    public partial class frmSinhVienTheoMonHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maMonHoc { get; set; }
        public string chon { get; set; }
        public frmSinhVienTheoMonHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienTheoMonHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            if (chon == "Sinh viên")
            {
                ds = db.getSinhVienTheoMonHoc(maMonHoc);
                dgvSinhVienTheoMonHoc.DataSource = ds.Tables[0];
            }
        }
    }
}
