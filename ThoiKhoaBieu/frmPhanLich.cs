using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ThoiKhoaBieu
{
  public partial class frmPhanLich : Form
  {
    NhiemSacThe nst;
    DataTable dtTheHe;
    DataBase db = new DataBase();
    int sec = 0;
    bool Running = false;
    
    public frmPhanLich()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      this.ControlBox = false;
      this.WindowState = FormWindowState.Maximized;
      this.BringToFront();
    }

    private void FrmPhanLich_SizeChanged(object sender, EventArgs e)
    {
      //chart1.Width = this.Width - 24;
      tableLayoutPanel1.Height = this.Height - panel1.Height;
    }

    private void FrmPhanLich_Load(object sender, EventArgs e)
    {
      dtTheHe = new DataTable();
      dtTheHe.Columns.Add("TheHe", System.Type.GetType("System.Int32"));
      dtTheHe.Columns.Add("SoTietHopLe", System.Type.GetType("System.Int32"));
      dtTheHe.Columns.Add("SoTietViPham", System.Type.GetType("System.Int32"));
      dtTheHe.Columns.Add("DoThichNghi", System.Type.GetType("System.String"));
      dataGridView1.DataSource = dtTheHe;
      dataGridView1.Columns["TheHe"].HeaderText = "Thế hệ";
      dataGridView1.Columns["SoTietHopLe"].HeaderText = "Số tiết hợp lệ";
      dataGridView1.Columns["SoTietViPham"].HeaderText = "Số tiết v.phạm";
      dataGridView1.Columns["DoThichNghi"].HeaderText = "Hệ số Th.Nghi";
      dataGridView1.Columns["TheHe"].Width = 50;
      dataGridView1.Columns["SoTietHopLe"].Width = 60;
      dataGridView1.Columns["SoTietViPham"].Width = 60;
      dataGridView1.Columns["DoThichNghi"].Width = 50;
      LoadNST();
    }

    private void AddChartColumn()
    {
      float dothichnghi = nst.HeSoThichNghi * 100;
      int thehe = nst.TheHe;
      DataPoint col = new DataPoint(thehe, dothichnghi);
      //col.Label = dothichnghi.ToString("0.0");
      chart1.Series[0].Points.Add(col);

      DataRow row = dtTheHe.NewRow();
      row["TheHe"] = thehe;
      row["DoThichNghi"] = dothichnghi.ToString("0.00");
      row["SoTietHopLe"] = nst.TongTietHopLe;
      row["SoTietViPham"] = nst.TongTietViPham;
      dtTheHe.Rows.Add(row);
    }

    private void ForcusLastRow(){
      int nRowIndex = dataGridView1.Rows.Count - 1;
      int nColumnIndex = 3;

      dataGridView1.Rows[nRowIndex].Selected = true;
      dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

      //In case if you want to scroll down as well.
      dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
    }

    private void LoadNST()
    {
      nst = new NhiemSacThe();
      Program.nst = nst;
      DataTable dsLop = new DataTable();
      DataTable dsPhong = new DataTable();
      DataTable dsGV = new DataTable();
      DataTable dsMon = new DataTable();
      
      if (!db.GetData(dsLop, "Select * From vLopHoc"))
        MessageBox.Show("Không có dữ liệu Lớp học");
      else if (!db.GetData(dsPhong, "Select * From PhongHoc"))
        MessageBox.Show("Không có dữ liệu Phòng học");
      else if (!db.GetData(dsGV, "Select GiaoVien.*, MonHoc.Ten As TenMon From GiaoVien Left Join MonHoc On GiaoVien.IDMon = MonHoc.IDMon"))
        MessageBox.Show("Không có dữ liệu Giáo viên");
      else if (!db.GetData(dsMon, "Select * From MonHoc Where Phu = 0  Or Phu IS NULL"))
        MessageBox.Show("Không có dữ liệu Môn học");
      else
      {
        nst.ListLopHoc(dsLop);
        nst.ListPhongHoc(dsPhong);
        nst.ListGiaoVien(dsGV);
        nst.ListMonHoc(dsMon);

        nst.PhanLichMonHoc();
        nst.PhanGiaoVien();
        nst.TinhDoThichNghi();
        AddChartColumn();
      }
    }
    private void Timer1_Tick(object sender, EventArgs e)
    {
      sec += 1;
      //lblTime.Text = (sec / 60).ToString() + ":" + (sec % 60).ToString("00");
      timer2.Interval= (sec / 60) + (sec % 60);
        }
        //++++++++++++++++++++++++++++++++++++++++++++
        private void btn_tienHoa_Click(object sender, EventArgs e)
        {
            nst.TienHoa();
            AddChartColumn();
            ForcusLastRow();
        }

        private void btn_tienHoa100_Click(object sender, EventArgs e)
        {
            btn_tienHoa.Enabled = false;
            btn_tienHoa100.Enabled = false;
            btn_tienHoaAll.Enabled = false;
            //++++++++++++++++++++++++++
            
            for (int i = 0; i < 100; i++)
            {
                nst.TienHoa();
                AddChartColumn();
                Application.DoEvents();
            }
            btn_tienHoa.Enabled = true;
            btn_tienHoa100.Enabled = true;
            btn_tienHoaAll.Enabled = true;
            //+++++++++++++
            
            ForcusLastRow();
        }

        private void btn_tienHoaAll_Click(object sender, EventArgs e)
        {
            frmLoading frmL = new frmLoading();
            frmL.Show();
            btn_tienHoa.Enabled = false;
            btn_tienHoa100.Enabled = false;
            btn_tienHoaAll.Enabled = false;
            btn_dung.Enabled = true;
            sec = 0;
            Running = true;
            timer1.Enabled = true;
            do
            {
                nst.TienHoa();
                Application.DoEvents();
            } while (nst.HeSoThichNghi != 1 && Running);
            Running = false;
            timer1.Enabled = false;
            AddChartColumn();
            ForcusLastRow();
            frmL.Close();
            frmSuccesses frms = new frmSuccesses();
            frms.Show();
            btn_tienHoa.Enabled = true;
            btn_tienHoa100.Enabled = true;
            btn_tienHoaAll.Enabled = true;
            btn_dung.Enabled = false;
            this.lb_success.Visible = false;
            //this.lb_success.Text = "Tiến hóa thành công! Có thể xem Thời khóa biểu";
            this.lb_success.Text="Thời gian phân lịch : "+ (sec / 60).ToString() + ":" + (sec % 60).ToString("00");
            this.lb_success.ForeColor = Color.Lime;
        }

        private void btn_dung_Click(object sender, EventArgs e)
        {
            frmSuccesses frmsu = new frmSuccesses();
            frmsu.Close();
            Running = false;
            this.lb_success.Text="";
        }

        private void btn_tkb_Click(object sender, EventArgs e)
        {
            frmMain fMain = (frmMain)this.MdiParent;
            if (fMain != null)
                fMain.ShowTKB();
        }

        private void btn_tkbGV_Click(object sender, EventArgs e)
        {
            frmMain fmain = (frmMain)this.MdiParent;
            if (fmain != null)
                fmain.ShowTKBGV();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lb_success.Visible = true;
        }
    }
}
