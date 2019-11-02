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
    public partial class frmSinhVienTheoNganh : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maNganh { get; set; }
        public string chon { get; set; }
        public frmSinhVienTheoNganh()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienTheoNganh_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            if (chon == "Sinh viên")
            {
                ds = db.getSinhVienTheoNganh(maNganh);
                dgvSinhVienTheoNganh.DataSource = ds.Tables[0];
            }
        }
    }
}
