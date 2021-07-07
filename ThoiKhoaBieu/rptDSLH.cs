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
    public partial class rptDSLH : Form
    {
        public rptDSLH()
        {
            InitializeComponent();
        }

        private void rptDSLH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDSLH.LopHoc' table. You can move, or remove it, as needed.
            this.LopHocTableAdapter.Fill(this.DataSetDSLH.LopHoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
