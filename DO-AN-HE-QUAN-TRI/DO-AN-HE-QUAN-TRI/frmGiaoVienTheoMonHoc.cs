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
    public partial class frmGiaoVienTheoMonHoc : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maMonHoc { get; set; }
        public string chon { get; set; }
        public frmGiaoVienTheoMonHoc()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoVienTheoMonHoc_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            if (chon == "Giáo viên")
            {
                ds = db.getGiaoVienTheoMonHoc(maMonHoc);
                dgvGiaoVienTheoMonHoc.DataSource = ds.Tables[0];
            }
        }
    }
}
