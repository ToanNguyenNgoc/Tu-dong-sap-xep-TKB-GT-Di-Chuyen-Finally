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
    public partial class rptDSMH : Form
    {
        public rptDSMH()
        {
            InitializeComponent();
        }

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDSMH.MonHoc' table. You can move, or remove it, as needed.
            this.MonHocTableAdapter.Fill(this.DataSetDSMH.MonHoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
