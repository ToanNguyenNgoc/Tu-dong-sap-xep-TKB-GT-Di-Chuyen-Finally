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
    public partial class frmLoading : Form
    {
        int sec = 0;
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec += 1;
            lb_time.Text  = (sec / 60).ToString() + ":" + (sec % 60).ToString("00");
        }
    }
}
