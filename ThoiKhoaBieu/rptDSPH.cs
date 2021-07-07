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
    public partial class rptDSPH : Form
    {
        public rptDSPH()
        {
            InitializeComponent();
        }

        private void rptDSPH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDSPH.PhongHoc' table. You can move, or remove it, as needed.
            this.PhongHocTableAdapter.Fill(this.DataSetDSPH.PhongHoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
