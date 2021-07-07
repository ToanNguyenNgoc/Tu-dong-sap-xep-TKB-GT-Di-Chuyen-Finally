using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoiKhoaBieu
{
    //bunifuDataGridView1
    //dataGridView1

    public partial class frmLop : Form
  {
    private DataBase db = new DataBase();
    private DataSet ds = new DataSet();
    private BindingSource bindingSource1 = new BindingSource();
        public static string role;
    public frmLop()
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
    DataTable dtLop;
    DataView dwLop;
    SqlDataAdapter adapter;
    private void frmLop_Load(object sender, EventArgs e)
    {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
      SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=TKB_v2;Integrated Security=True");
      
      adapter = new SqlDataAdapter("select * from LopHoc", con);
      dtLop = new DataTable("LopHoc");
      adapter.Fill(dtLop);
      dwLop = new DataView(dtLop);
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
      string sql = "SELECT [IDLop],[TenLop],[IDGV],[SiSo],[Nam],";
      sql += "[Khoi],[BuoiHoc],[IDPH] FROM [vLopHoc] ORDER BY [Khoi], [TenLop]";
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

            dataGridView1.Columns["IDLop"].HeaderText = "Mã số";
            dataGridView1.Columns["TenLop"].HeaderText = "Lớp";
            dataGridView1.Columns["IDGV"].HeaderText = "Môn Dạy";
            dataGridView1.Columns["SiSo"].HeaderText = "Sĩ số";
            dataGridView1.Columns["Nam"].HeaderText = "Năm học";
            dataGridView1.Columns["Khoi"].HeaderText = "Khối";
            dataGridView1.Columns["BuoiHoc"].HeaderText = "Buổi học";

            dataGridView1.Columns["IDLop"].Width = 55;
            dataGridView1.Columns["TenLop"].Width = 130;
            dataGridView1.Columns["IDGV"].Width = 130;
            dataGridView1.Columns["IDPH"].Width = 130;
            dataGridView1.Columns["SiSo"].Width = 130;
            dataGridView1.Columns["Nam"].Width = 130;
            dataGridView1.Columns["Khoi"].Width = 130;
            dataGridView1.Columns["BuoiHoc"].Width = 130;
      foreach (DataGridViewColumn col in dataGridView1.Columns)
      {
        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      }
            dataGridView1.Columns["TenLop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["IDGV"].Visible = false;
            dataGridView1.Columns["IDPH"].Visible = false;
            dataGridView1.Columns["Khoi"].Visible = false;
            dataGridView1.Columns["BuoiHoc"].Visible = false;

      //Cột Giáo viên chủ nhiệm
      DataGridViewComboBoxColumn colGV = new DataGridViewComboBoxColumn();
            colGV.FlatStyle = FlatStyle.Flat;
           
      colGV.Name = "GVCN";
      colGV.HeaderText = "GVCN";
      colGV.DataPropertyName = "IDGV";
      colGV.ValueMember = "ID";
      colGV.DisplayMember = "TenGV";
      colGV.DataSource = db.GetData("Select IDGV As ID, TenGV From GiaoVien");
      colGV.Width = 180;
            colGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns.Insert(3, colGV);

      //cột buổi
      DataTable dtBuoi = new DataTable();
      dtBuoi.Columns.Add("Buoi", System.Type.GetType("System.Int32"));
      dtBuoi.Columns.Add("TenBuoi", System.Type.GetType("System.String"));
      dtBuoi.Rows.Add(dtBuoi.NewRow());
      dtBuoi.Rows.Add(dtBuoi.NewRow());
      dtBuoi.Rows[0]["Buoi"] = 1; dtBuoi.Rows[0]["TenBuoi"] = "Sáng";
      dtBuoi.Rows[1]["Buoi"] = 2; dtBuoi.Rows[1]["TenBuoi"] = "Chiều";

      DataGridViewComboBoxColumn colBuoi = new DataGridViewComboBoxColumn();
            colBuoi.FlatStyle = FlatStyle.Flat;
      colBuoi.Name = "tkbBuoi";
      colBuoi.HeaderText = "Buổi học";
      colBuoi.DataPropertyName = "BuoiHoc";
      colBuoi.ValueMember = "Buoi";
      colBuoi.DisplayMember = "TenBuoi";
      colBuoi.DataSource = dtBuoi;
      colBuoi.Width = 80;
      colBuoi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Insert(7, colBuoi);

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
      colKhoi.DataPropertyName = "Khoi";
      colKhoi.ValueMember = "KhoiLop";
      colKhoi.DisplayMember = "TenKhoi";
      colKhoi.DataSource = dtKhoi;
      colKhoi.Width = 80;
      colKhoi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Insert(6, colKhoi);

      //Cột phòng học
      DataGridViewComboBoxColumn colPH = new DataGridViewComboBoxColumn();
            colPH.FlatStyle = FlatStyle.Flat;
            
            colPH.Name = "Phong";
      colPH.HeaderText = "Phòng";
      colPH.DataPropertyName = "IDPH";
      colPH.ValueMember = "IDP";
      colPH.DisplayMember = "TenPH";
      colPH.DataSource = db.GetData("Select IDPH As IDP, TenPH From PhongHoc");
      colPH.Width = 80;
      colPH.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns.Insert(9, colPH);
    }

    private void frmLop_SizeChanged(object sender, EventArgs e)
    {
      panel1.Height = this.Height - panel2.Height;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        rptDSLH frm = new rptDSLH();
        frm.Show();
    }
        //__________________Update UI__________________________________
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            String TenLop = txt_seach.Text;
            dwLop.RowFilter = "TenLop like '%" + TenLop + "%'";
            dataGridView1.DataSource = dwLop;
        }
        //-------------------------------------------------------

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                string strQuery;
                DataSet dsChanges = ds.GetChanges(DataRowState.Modified);
                if (dsChanges != null)
                {
                    DataTable dtChanges = dsChanges.Tables[0];
                    foreach (DataRow row in dtChanges.Rows)
                    {
                        strQuery = "UPDATE LopHoc SET ";
                        if (!string.IsNullOrEmpty(row["IDGV"].ToString()))
                            strQuery += "IDGV = " + row["IDGV"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["SiSo"].ToString()))
                            strQuery += "SiSo = " + row["SiSo"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["Nam"].ToString()))
                            strQuery += "Nam = " + row["Nam"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["Khoi"].ToString()))
                            strQuery += "Khoi = " + row["Khoi"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["BuoiHoc"].ToString()))
                            strQuery += "BuoiHoc = " + row["BuoiHoc"].ToString() + ",";
                        if (!string.IsNullOrEmpty(row["IDPH"].ToString()))
                            strQuery += "IDPH = " + row["IDPH"].ToString() + ",";
                        strQuery += "TenLop = N'" + row["TenLop"].ToString() + "'";
                        strQuery += " WHERE IDLop = " + row["IDLop"].ToString();
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
                        cols += ",TenLop";
                        vals += ",N'" + row["TenLop"].ToString() + "'";
                        if (!string.IsNullOrEmpty(row["IDGV"].ToString()))
                        {
                            cols += ",IDGV";
                            vals += "," + row["IDGV"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["SiSo"].ToString()))
                        {
                            cols += ",SiSo";
                            vals += "," + row["SiSo"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["Nam"].ToString()))
                        {
                            cols += ",Nam";
                            vals += "," + row["Nam"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["Khoi"].ToString()))
                        {
                            cols += ",Khoi";
                            vals += "," + row["Khoi"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["BuoiHoc"].ToString()))
                        {
                            cols += ",BuoiHoc";
                            vals += "," + row["BuoiHoc"].ToString();
                        }
                        if (!string.IsNullOrEmpty(row["IDPH"].ToString()))
                        {
                            cols += ",IDPH";
                            vals += "," + row["IDPH"].ToString();
                        }
                        strQuery = "INSERT INTO LopHoc(" + cols.Substring(1) + ") Values(" + vals.Substring(1) + ")";
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
            rptDSLH frm = new rptDSLH();
            frm.Show();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                if (cell != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn xóa Lớp đang chọn?", "", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sql = "Delete from LopHoc Where IDLop = " + cell.Value.ToString();
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
