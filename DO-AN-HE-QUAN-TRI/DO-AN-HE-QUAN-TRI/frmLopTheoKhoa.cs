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
    public partial class frmLopTheoKhoa : Form
    {
        DataSet ds;
        DBBusinessLayer db;
        public string maKhoa { get; set; }
        public string chon { get; set; }
        public frmLopTheoKhoa()
        {
            InitializeComponent();
            ds = new DataSet();
            db = new DBBusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLopTheoKhoa_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            if (chon == "Lớp")
            {
                ds = db.getLopTheoKhoa(maKhoa);
                dgvLopTheoKhoa.DataSource = ds.Tables[0];
            }
        }
    }
}
