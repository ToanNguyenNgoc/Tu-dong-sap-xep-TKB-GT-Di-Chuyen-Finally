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
  public partial class frmPhongHoc : Form
  {
    private DataBase db = new DataBase();
    private DataSet ds = new DataSet();
    private BindingSource bindingSource1 = new BindingSource();
        public static string role;

    public frmPhongHoc()
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

    private void frmPhongHoc_Load(object sender, EventArgs e)
    {
      dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
      dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
      LoadGrid();
    }

    private void LoadGrid()
    {
      DataTable dt = new DataTable();

      // Set up the DataGridView.
      dataGridView1.DataSource = null;

      // Automatically generate the DataGridView columns.
      dataGridView1.AutoGenerateColumns = true;

      // Set up the data source.
      string sql = "SELECT [IDPH],[TenPH],[SucChua],[ViTri] FROM [PhongHoc]";
      bindingSource1.DataSource = db.GetDataSet("PhongHoc", sql).Tables[0];
      dataGridView1.DataSource = bindingSource1;

      // Automatically resize the visible rows.
      dataGridView1.AutoSizeRowsMode =
          DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

      // Set the DataGridView control's border.
      dataGridView1.BorderStyle = BorderStyle.Fixed3D;

      // Put the cells in edit mode when user enters them.
      dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

      dataGridView1.Columns["IDPH"].HeaderText = "Mã số";
      dataGridView1.Columns["TenPH"].HeaderText = "Tên phòng";
      dataGridView1.Columns["SucChua"].HeaderText = "Sức chứa";
      dataGridView1.Columns["ViTri"].HeaderText = "Vị trí";

      dataGridView1.Columns["IDPH"].Width = 50;
      dataGridView1.Columns["TenPH"].Width = 200;
      dataGridView1.Columns["SucChua"].Width = 100;
      dataGridView1.Columns["ViTri"].Width = 280;
      foreach (DataGridViewColumn col in dataGridView1.Columns)
      {
        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      }
      dataGridView1.Columns["TenPH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridView1.Columns["ViTri"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    }

    private void frmPhongHoc_Resize(object sender, EventArgs e)
    {
      panel1.Height = this.Height - panel2.Height;
    }
        //========================
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                db.UpdateDataSet("PhongHoc");
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

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            rptDSPH frm = new rptDSPH();
            frm.Show();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa Phòng học đang chọn?", "", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sql = "Delete from PhongHoc Where IDPH = " + cell.Value.ToString();
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
