using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoiKhoaBieu
{
  public partial class frmMonhoc : Form
  {
    public DataBase db = new DataBase();
    private BindingSource bindingSource1 = new BindingSource();
        public static string role;
        //bunifuDataGridView1
        //dataGridView1
        public frmMonhoc()
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
    DataTable dtMonhoc;
    DataView dwMonhoc;
    SqlDataAdapter adapter;
    private void frmMonhoc_Load(object sender, EventArgs e)
    {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
      SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=TKB_v2;Integrated Security=True");
      adapter = new SqlDataAdapter("select * from MonHoc", con);
      dtMonhoc = new DataTable("Monhoc");
      adapter.Fill(dtMonhoc);
      dwMonhoc = new DataView(dtMonhoc);
      LoadGrid();
    }
    private void btnseach_Click(object sender, EventArgs e)
    {
        if(txt_seach.Text=="Nhập môn học..." || txt_seach.Text == "")
            {
                LoadGrid();
            }
            else
            {
                String TenMH = txt_seach.Text;
                dwMonhoc.RowFilter = "Ten like '%" + TenMH + "%'";
                dataGridView1.DataSource = dwMonhoc;
                
            }
    }
    private void frmMonhoc_SizeChanged(object sender, EventArgs e)
    {
      //panel1.Height = this.Height - panel2.Height;
    }

    private void LoadGrid()
    {
      DataTable dt = new DataTable();

            // Set up the DataGridView.
            dataGridView1.DataSource = null;

            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;

      // Set up the data source.
      string sql = "SELECT [IDMon],[Ten],[Khoi6],[SoTietK6],[SoBuoiK6],[Khoi7],[SoTietK7],[SoBuoiK7],[Khoi8],[SoTietK8],[SoBuoiK8],[Khoi9],[SoTietK9],[SoBuoiK9],[Kep] From MonHoc";
      bindingSource1.DataSource = db.GetDataSet("MonHoc", sql).Tables[0];
            dataGridView1.DataSource = bindingSource1;

            // Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode =
          DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.Columns["IDMon"].HeaderText = "Mã số";
            dataGridView1.Columns["Ten"].HeaderText = "Tên môn";
            dataGridView1.Columns["Khoi6"].HeaderText = "Khối 6";
            dataGridView1.Columns["Khoi7"].HeaderText = "Khối 7";
            dataGridView1.Columns["Khoi8"].HeaderText = "Khối 8";
            dataGridView1.Columns["Khoi9"].HeaderText = "Khối 9";
            dataGridView1.Columns["SoTietK6"].HeaderText = "Số tiết khối 6";
            dataGridView1.Columns["SoTietK7"].HeaderText = "Số tiết khối 7";
            dataGridView1.Columns["SoTietK8"].HeaderText = "Số tiết khối 8";
            dataGridView1.Columns["SoTietK9"].HeaderText = "Số tiết khối 9";
            dataGridView1.Columns["SoBuoiK6"].HeaderText = "/buổi";
            dataGridView1.Columns["SoBuoiK7"].HeaderText = "/buổi";
            dataGridView1.Columns["SoBuoiK8"].HeaderText = "/buổi";
            dataGridView1.Columns["SoBuoiK9"].HeaderText = "/buổi";
            dataGridView1.Columns["Kep"].HeaderText = "Tiết kép";
            //dataGridView1.Columns["Phu"].HeaderText = "Tiết phụ";

            dataGridView1.Columns["IDMon"].Width = 57;
            dataGridView1.Columns["Ten"].Width = 100;
            dataGridView1.Columns["Khoi6"].Width = 57;
            dataGridView1.Columns["Khoi7"].Width = 57;
            dataGridView1.Columns["Khoi8"].Width = 57;
            dataGridView1.Columns["Khoi9"].Width = 57;
            dataGridView1.Columns["SoTietK6"].Width = 57;
            dataGridView1.Columns["SoTietK7"].Width = 57;
            dataGridView1.Columns["SoTietK8"].Width = 57;
            dataGridView1.Columns["SoTietK9"].Width = 57;
            dataGridView1.Columns["SoBuoiK6"].Width = 57;
            dataGridView1.Columns["SoBuoiK7"].Width = 57;
            dataGridView1.Columns["SoBuoiK8"].Width = 57;
            dataGridView1.Columns["SoBuoiK9"].Width = 57;
            dataGridView1.Columns["Kep"].Width = 50;
      //dataGridView1.Columns["Phu"].Width = 50;

      foreach (DataGridViewColumn col in dataGridView1.Columns)
      {
        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      }
            dataGridView1.Columns["IDMon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Ten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    }
        //============================
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                db.UpdateDataSet("MonHoc");
                LoadGrid();
                frmAlertForm1 fma = new frmAlertForm1();
                fma.Show();
            }
            else
            {
                frmError frme = new frmError();
                frme.Show();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            rptDSMH frm = new rptDSMH();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa Môn học đang chọn?", "", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sql = "Delete from MonHoc Where IDMon = " + cell.Value.ToString();
                        if (db.RunQuery(sql))
                            dataGridView1.Rows.RemoveAt(cell.RowIndex);
                    }
                }
            }
            else
            {
                frmError frme = new frmError();
                frme.Show();
            }
        }
    }
}


