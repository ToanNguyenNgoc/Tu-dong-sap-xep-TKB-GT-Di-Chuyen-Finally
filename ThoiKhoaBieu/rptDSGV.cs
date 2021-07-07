using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ThoiKhoaBieu
{
    public partial class rptDSGV : Form
    {
        public rptDSGV()
        {
            InitializeComponent();
        }

        private void rptDSGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDSGV.GiaoVien' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Fill(this.DataSetDSGV.GiaoVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
