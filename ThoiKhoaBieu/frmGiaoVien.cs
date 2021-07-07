using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoiKhoaBieu
{
  public partial class frmGiaoVien : Form
  {
    private DataBase db = new DataBase();
    private DataSet ds = new DataSet();
    private BindingSource bindingSource1 = new BindingSource();
        public static string role;
    public frmGiaoVien()
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
    DataTable dtGiaovien;
    DataView dwGiaovien;
    SqlDataAdapter adapter;
    private void frmGiaoVien_Load(object sender, EventArgs e)
    {
            // TODO: This line of code loads data into the 'dataSetDSGV.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.dataSetDSGV.GiaoVien);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
      dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
      SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=TKB_v2;Integrated Security=True");
      adapter = new SqlDataAdapter("select * from GiaoVien", con);
      dtGiaovien = new DataTable("GiaoVien");
      adapter.Fill(dtGiaovien);
      dwGiaovien = new DataView(dtGiaovien);
      LoadGrid();
    }
    private void frmGiaoVien_SizeChanged(object sender, EventArgs e)
    {
      panel1.Height = this.Height - panel2.Height;
    }

    private void LoadGrid()
    {
      DataTable dt = new DataTable();

      // Set up the DataGridView.
      dataGridView1.DataSource = null;

      // Automatically generate the DataGridView columns.
      dataGridView1.AutoGenerateColumns = true;

      // Set up the data source.
      string sql = "SELECT [IDGV],[TenGV],[IDMon],[ChuyenKhoi],[SoTiet],[NamSinh],[GioiTinh],[SoDT],[DiaChi] From [vGiaoVien]";
      ds = db.GetDataSet(sql);
      bindingSource1.DataSource = ds.Tables[0];
      dataGridView1.DataSource = bindingSource1;

      // Automatically resize the visible rows.
      dataGridView1.AutoSizeRowsMode =
          DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

      // Set the DataGridView control's border.
      dataGridView1.BorderStyle = BorderStyle.Fixed3D;

      // Put the cells in edit mode when user enters them.
      dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

      dataGridView1.Columns["IDGV"].HeaderText = "Mã số";
      dataGridView1.Columns["TenGV"].HeaderText = "Họ Tên";
      dataGridView1.Columns["ChuyenKhoi"].HeaderText = "Chuyên Khối";
      dataGridView1.Columns["SoTiet"].HeaderText = "Số tiết tối đa / tuần";
      dataGridView1.Columns["NamSinh"].HeaderText = "Ngày sinh";
      dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính (nam)";
      dataGridView1.Columns["SoDT"].HeaderText = "Điện thoại";
      dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";

      dataGridView1.Columns["IDGV"].Width = 50;
      dataGridView1.Columns["TenGV"].Width = 150;
      dataGridView1.Columns["ChuyenKhoi"].Width = 50;
      dataGridView1.Columns["NamSinh"].Width = 80;
      dataGridView1.Columns["GioiTinh"].Width = 66;
      dataGridView1.Columns["SoDT"].Width = 110;
      dataGridView1.Columns["DiaChi"].Width = 200;
      foreach (DataGridViewColumn col in dataGridView1.Columns)
      {
        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      }
      dataGridView1.Columns["IDMon"].Visible = false;
      dataGridView1.Columns["ChuyenKhoi"].Visible = false;
      dataGridView1.Columns["SoTiet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dataGridView1.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

      DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn();
            newColumn.FlatStyle = FlatStyle.Flat;
      newColumn.Name = "MonDay";
      newColumn.HeaderText = "Môn dạy";
      newColumn.DataPropertyName = "IDMon";
      newColumn.ValueMember = "IDMon";
      newColumn.DisplayMember = "Ten";
      newColumn.DataSource = db.GetData("Select IDMon, Ten From MonHoc");
      newColumn.Width = 120;
      dataGridView1.Columns.Insert(3, newColumn);

      //cột khối
      DataTable dtKhoi = new DataTable();
      dtKhoi.Columns.Add("KhoiLop", System.Type.GetType("System.Int32"));
      dtKhoi.Columns.Add("TenKhoi", System.Type.GetType("System.String"));
      dtKhoi.Rows.Add(dtKhoi.NewRow());
      dtKhoi.Rows.Add(dtKhoi.NewRow());
      dtKhoi.Rows.Add(dtKhoi.NewRow());
      dtKhoi.Rows.Add(dtKhoi.NewRow());
      dtKhoi.Rows[0]["KhoiLop"] = 6; dtKhoi.Rows[0]["TenKhoi"] = "Khối 6";
      dtKhoi.Rows[1]["KhoiLop"] = 7; dtKhoi.Rows[1]["TenKhoi"] = "Khối 7";
      dtKhoi.Rows[2]["KhoiLop"] = 8; dtKhoi.Rows[2]["TenKhoi"] = "Khối 8";
      dtKhoi.Rows[3]["KhoiLop"] = 9; dtKhoi.Rows[3]["TenKhoi"] = "Khối 9";

      DataGridViewComboBoxColumn colKhoi = new DataGridViewComboBoxColumn();
            colKhoi.FlatStyle = FlatStyle.Flat;
      colKhoi.Name = "tkbKhoi";
      colKhoi.HeaderText = "Khối";
      colKhoi.DataPropertyName = "ChuyenKhoi";
      colKhoi.ValueMember = "KhoiLop";
      colKhoi.DisplayMember = "TenKhoi";
      colKhoi.DataSource = dtKhoi;
      colKhoi.Width = 80;
      colKhoi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dataGridView1.Columns.Insert(4, colKhoi);
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
        //_____________________________Update UI_________________________
        private void btn_search_Click(object sender, EventArgs e)
        {
            String TenGV = txt_seach.Text;
            dwGiaovien.RowFilter = "TenGV like '%" + TenGV + "%'";
            dataGridView1.DataSource = dwGiaovien;
            
        }
        //+++++++++++++++++++++++++++++++
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                string strQuery;
                DateTime Ngay;
                DataSet dsChanges = ds.GetChanges(DataRowState.Modified);
                if (dsChanges != null)
                {
                    DataTable dtChanges = dsChanges.Tables[0];
                    foreach (DataRow row in dtChanges.Rows)
                    {
                        strQuery = "UPDATE GiaoVien SET ";
                        strQuery += "TenGV = N'" + row["TenGV"].ToString() + "',";
                        if (!string.IsNullOrEmpty(row["IDMon"].ToString()))
                            strQuery += "IDMon = " + row["IDMon"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["ChuyenKhoi"].ToString()))
                            strQuery += "ChuyenKhoi = " + row["ChuyenKhoi"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["SoTiet"].ToString()))
                            strQuery += "SoTiet = " + row["SoTiet"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["NamSinh"].ToString()))
                        {
                            Ngay = (DateTime)row["NamSinh"];
                            strQuery += "NamSinh = '" + Ngay.ToString("MM/dd/yyyy") + "',";
                        }
                        if (!string.IsNullOrEmpty(row["GioiTinh"].ToString()))
                            if (row["GioiTinh"].ToString().Equals("True"))
                                strQuery += "GioiTinh = 1,";
                            else
                                strQuery += "GioiTinh = 0,";
                        strQuery += "SoDT = N'" + row["SoDT"].ToString() + "',";
                        strQuery += "DiaChi = N'" + row["DiaChi"].ToString() + "'";
                        strQuery += " WHERE IDGV = " + row["IDGV"].ToString();
                        db.RunQuery(strQuery);
                    }
                }

                string cols = "", vals = "";
                DataSet dsNew = ds.GetChanges(DataRowState.Added);
                if (dsNew != null)
                {
                    DataTable dtNew = dsNew.Tables[0];
                    foreach (DataRow row in dtNew.Rows)
                    {
                        cols += ",TenGV";
                        vals += ",N'" + row["TenGV"].ToString() + "'";
                        if (!string.IsNullOrEmpty(row["IDMon"].ToString()))
                        {
                            cols += ",IDMon";
                            vals += "," + row["IDMon"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["ChuyenKhoi"].ToString()))
                        {
                            cols += ",ChuyenKhoi";
                            vals += "," + row["ChuyenKhoi"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["SoTiet"].ToString()))
                        {
                            cols += ",SoTiet";
                            vals += "," + row["SoTiet"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["NamSinh"].ToString()))
                        {
                            Ngay = (DateTime)row["NamSinh"];
                            cols += ",NamSinh";
                            vals += ",'" + Ngay.ToString("MM/dd/yyyy") + "'";
                        }
                        if (!string.IsNullOrEmpty(row["GioiTinh"].ToString()))
                        {
                            cols += ",GioiTinh";
                            if (row["GioiTinh"].ToString().Equals("True"))
                                vals += ",1";
                            else
                                vals += ",0";
                        }
                        cols += ",SoDT";
                        vals += ",N'" + row["SoDT"].ToString() + "'";
                        cols += ",DiaChi";
                        vals += ",N'" + row["DiaChi"].ToString() + "'";
                        strQuery = "INSERT INTO GiaoVien(" + cols.Substring(1) + ") Values(" + vals.Substring(1) + ")";
                        db.RunQuery(strQuery);
                    }
                }
                
                LoadGrid();
                frmAlertForm1 frma = new frmAlertForm1();
                frma.Show();
            }
            else
            {
                frmError frme = new frmError();
                frme.Show();
            }
        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            rptDSGV frm = new rptDSGV();
            frm.Show();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa Giáo viên đang chọn?", "", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sql = "Delete from GiaoVien Where IDGV = " + cell.Value.ToString();
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



  

