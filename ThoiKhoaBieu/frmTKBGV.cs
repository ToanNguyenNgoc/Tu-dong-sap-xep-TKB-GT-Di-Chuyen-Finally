using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ThoiKhoaBieu
{
  public partial class frmTKBGV : Form
  {
    private NhiemSacThe nst;
    private DataTable dtGV;
        DataView dwGiaovien;
        private bool Loading = false;
    
        public NhiemSacThe NST
    {
      get { return nst; }
      set
      {
        nst = value;
        BuildBlankTKB();

        dtGV = new DataTable();
        dtGV.Columns.Add("IDGV", System.Type.GetType("System.Int32"));
        dtGV.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
        dtGV.Columns.Add("MonHoc", System.Type.GetType("System.String"));
                dgGV.DataSource = dtGV;

                dgGV.Columns["IDGV"].HeaderText = "ID";
                dgGV.Columns["GiaoVien"].HeaderText = "Giáo viên";
                dgGV.Columns["MonHoc"].HeaderText = "Môn dạy";
                dgGV.Columns["IDGV"].Width = 40;
                dgGV.Columns["GiaoVien"].Width = 280;
                dgGV.Columns["MonHoc"].Width = 280;
                dgGV.Columns["IDGV"].Visible = false;

        foreach (GiaoVien gv in nst.DSGiaoVien.GetDanhSach())
        {
          DataRow row = dtGV.NewRow();
          row["IDGV"] = gv.IDGV;
          row["GiaoVien"] = gv.TenGV;
          row["MonHoc"] = gv.TenMon;
          dtGV.Rows.Add(row);
        }
      }
    }
    
    public frmTKBGV()
    {
      InitializeComponent();
        }

    public frmTKBGV(NhiemSacThe n)
    {
      InitializeComponent();
      NST = n;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      this.ControlBox = false;
      this.WindowState = FormWindowState.Maximized;
      this.BringToFront();
    }

    private void frmTKBGV_Load(object sender, EventArgs e)
    {
      BuildBlankTKB();
    }

    private void BuildBlankTKB()
    {
      listBox1.Items.Clear();
      listBox2.Items.Clear();
      listBox3.Items.Clear();
      listBox4.Items.Clear();
      listBox5.Items.Clear();
      listBox6.Items.Clear();

      listBox7.Items.Clear();
      listBox8.Items.Clear();
      listBox9.Items.Clear();
      listBox10.Items.Clear();
      listBox11.Items.Clear();
      listBox12.Items.Clear();
      for (int i = 0; i < 5; i++)
      {
        listBox1.Items.Add("--");
        listBox2.Items.Add("--");
        listBox3.Items.Add("--");
        listBox4.Items.Add("--");
        listBox5.Items.Add("--");
        listBox6.Items.Add("--");

        listBox7.Items.Add("--");
        listBox8.Items.Add("--");
        listBox9.Items.Add("--");
        listBox10.Items.Add("--");
        listBox11.Items.Add("--");
        listBox12.Items.Add("--");
      }
    }

    private void LoadData(int rowIndex)
    {
      if (Loading)
      {
        MessageBox.Show("Đang tải dữ liệu, vui lòng thử lại trong vài giây");
      }
      else if (rowIndex >= 0)
      {
                dwGiaovien = new DataView(dtGV);
        Loading = true;
        DataGridViewCell cell = (DataGridViewCell)dgGV.Rows[rowIndex].Cells[0];
        
        AppConstant c = new AppConstant();
        int IDGV = 0;
        string text;
        if (int.TryParse(cell.Value.ToString(), out IDGV))
        {
          BuildBlankTKB();
          foreach (LopHoc lop in nst.DSLop.GetDanhSach())
            foreach (Thu thu in lop.Thu)
              foreach (Tiet tiet in thu.Tiet)
                if (tiet.IDGV == IDGV)
                  if (lop.BuoiHoc == c.BuoiSang)
                  {
                    text = lop.TenLop + " - " + lop.TenPhongHoc;
                    if (thu.Index == c.Thu2) listBox1.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu3) listBox2.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu4) listBox3.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu5) listBox4.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu6) listBox5.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu7) listBox6.Items[tiet.Index] = text;
                  }
                  else
                  {
                    text = lop.TenLop + " - " + lop.TenPhongHoc;
                    if (thu.Index == c.Thu2) listBox7.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu3) listBox8.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu4) listBox9.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu5) listBox10.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu6) listBox11.Items[tiet.Index] = text;
                    if (thu.Index == c.Thu7) listBox12.Items[tiet.Index] = text;
                  }
        }
        Loading = false;
      }
    }
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xls)|*.xls",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    DataGridViewCell cell_2 = dgGV.SelectedCells[1];
                    DataGridViewCell cell_3 = dgGV.SelectedCells[2];

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }
                    int count = 0;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Rows["6"].Font.Color = Color.Green;
                    xlWorkSheet.Rows["7"].Font.Color = Color.Green;
                    xlWorkSheet.Cells[6, 4] = "Tên giáo viên : " + cell_2.Value.ToString();
                    xlWorkSheet.Cells[7, 4] = "Môn dạy : " + cell_3.Value.ToString();

                    xlWorkSheet.Cells[10, 4] = "TIẾT";
                    xlWorkSheet.Cells[10, 5] = "THỨ HAI";
                    xlWorkSheet.Cells[10, 6] = "THỨ BA";
                    xlWorkSheet.Cells[10, 7] = "THỨ TƯ";
                    xlWorkSheet.Cells[10, 8] = "THỨ NĂM";
                    xlWorkSheet.Cells[10, 9] = "THỨ SÁU";
                    xlWorkSheet.Cells[10, 10] = "THỨ BẢY";

                    //tiet
                    for (int i = 1; i < 6; i++)
                    {
                        xlWorkSheet.Cells[10 + i, 4] = i.ToString();
                    }
                    //thu 2
                    foreach (var item in listBox1.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 5] = item;
                        count++;
                    }
                    // thứ 3
                    count = 0;
                    foreach (var item in listBox2.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 6] = item;
                        count++;
                    }
                    // thứ 4
                    count = 0;
                    foreach (var item in listBox3.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 7] = item;
                        count++;
                    }
                    // thứ 5
                    count = 0;
                    foreach (var item in listBox4.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 8] = item;
                        count++;
                    }
                    // thứ 6
                    count = 0;
                    foreach (var item in listBox5.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 9] = item;
                        count++;
                    }
                    // thứ 7
                    count = 0;
                    foreach (var item in listBox6.Items)
                    {
                        xlWorkSheet.Cells[11 + count, 10] = item;
                        count++;
                    }
                    //Chieu
                    for (int i = 1; i < 6; i++)
                    {
                        xlWorkSheet.Cells[18 + i, 4] = i.ToString();
                    }
                    xlWorkSheet.Cells[17, 4] = "CHIỀU";
                    //thu 2
                    foreach (var item in listBox7.Items)
                    {
                        xlWorkSheet.Cells[14 + count, 5] = item;
                        count++;
                    }
                    // thứ 3
                    count = 0;
                    foreach (var item in listBox8.Items)
                    {
                        xlWorkSheet.Cells[19 + count, 6] = item;
                        count++;
                    }
                    // thứ 4
                    count = 0;
                    foreach (var item in listBox9.Items)
                    {
                        xlWorkSheet.Cells[19 + count, 7] = item;
                        count++;
                    }
                    // thứ 5
                    count = 0;
                    foreach (var item in listBox10.Items)
                    {
                        xlWorkSheet.Cells[19 + count, 8] = item;
                        count++;
                    }
                    // thứ 6
                    count = 0;
                    foreach (var item in listBox11.Items)
                    {
                        xlWorkSheet.Cells[19 + count, 9] = item;
                        count++;
                    }
                    // thứ 7
                    count = 0;
                    foreach (var item in listBox12.Items)
                    {
                        xlWorkSheet.Cells[19 + count, 10] = item;
                        count++;
                    }
                    //End_________________________________

                    Microsoft.Office.Interop.Excel.Range chartRange = xlWorkSheet.get_Range("D10", "J23");
                    chartRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    chartRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                    xlWorkBook.SaveAs(path,
                                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                                    misValue, misValue, misValue, misValue,
                                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                                    misValue, misValue, misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                    MessageBox.Show("Xuất dữ liệu thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgGV_SelectionChanged(object sender, EventArgs e)
        {
            LoadData(dgGV.CurrentRow.Index);
            
        }
    }
}
