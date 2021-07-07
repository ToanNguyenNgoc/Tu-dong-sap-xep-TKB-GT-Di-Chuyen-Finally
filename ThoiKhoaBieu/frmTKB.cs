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
using ThoiKhoaBieu;
using System.IO;
using System.Runtime.InteropServices;

namespace ThoiKhoaBieu
{
  public partial class frmTKB1 : Form
  {
    private NhiemSacThe nst;
    DataTable dtGVs, dtGVLop;
    public string tenGVCN, BUOIHOC,TONGTIET;
    public NhiemSacThe NST
    {
      get { return nst; }
      set
      {
        nst = value;
        cmbLophoc.Items.Clear();
        foreach (LopHoc lop in nst.DSLop.GetDanhSach())
        {
          Item p = new Item("Lớp " + lop.TenLop, lop.IDLop.ToString());
          cmbLophoc.Items.Add(p);
        }
        ShowDSGV();
      }
    }

    public frmTKB1()
    {
      InitializeComponent();
    }

    public frmTKB1(NhiemSacThe n)
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

    private class Item
    {
      public string Name;
      public string Value;
      public Item(string name, string value)
      {
        Name = name; Value = value;
      }
      public override string ToString()
      {
        // Generates the text shown in the combo box
        return Name;
      }
    }

    private void Formtkb_Load(object sender, EventArgs e)
    {
        btn_continue.Enabled = false;
        lblkytu.Visible = false;
    }

    private void LoadTKB(string sIDLop)
    {
            int.TryParse(sIDLop, out int idLop);
            AppConstant c = new AppConstant();

      if (idLop > 0)
      {
        listBox1.Items.Clear();
        listBox2.Items.Clear();
        listBox3.Items.Clear();
        listBox4.Items.Clear();
        listBox5.Items.Clear();
        listBox6.Items.Clear();
        listErr1.Items.Clear();
        listErr2.Items.Clear();
        listErr3.Items.Clear();
        listErr4.Items.Clear();
        listErr5.Items.Clear(); 
        listErr6.Items.Clear();

        foreach (LopHoc lop in nst.DSLop.GetDanhSach())
        {
            TONGTIET = lop.TongTiet.ToString();
            tenGVCN = lop.TenGVCN;
          if (lop.IDLop == idLop)
          {
            if (lop.BuoiHoc == c.BuoiSang)
                 BUOIHOC = "Sáng";
            else
                BUOIHOC = "Chiều";

            lblBuoi.Text = "Buổi học: " + BUOIHOC;
            lblTongTiet.Text = "Tổng tiết: " + TONGTIET;
            lblTongViPham.Text = "Vi phạm: " + lop.TongTietViPham.ToString();
            lblTongHopLe.Text = "Hợp lệ: " + lop.TongTietHopLe.ToString();
            lblGVCN.Text = "GVCN: " + tenGVCN;

            if (lop.TongTietViPham >0 ) lblTongViPham.ForeColor =Color.Red;
            else lblTongViPham.ForeColor = Color.Black;

            ShowDSGV(lop);

            ShowThu(lop.Thu[c.Thu2], listBox1, listErr1);
            ShowThu(lop.Thu[c.Thu3], listBox2, listErr2);
            ShowThu(lop.Thu[c.Thu4], listBox3, listErr3);
            ShowThu(lop.Thu[c.Thu5], listBox4, listErr4);
            ShowThu(lop.Thu[c.Thu6], listBox5, listErr5);
            ShowThu(lop.Thu[c.Thu7], listBox6, listErr6);
          }
        }
      }
    }

    private void ShowDSGV(LopHoc lop)
    {
        dtGVLop = new DataTable();
        dtGVLop.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
        dtGVLop.Columns.Add("MonHoc", System.Type.GetType("System.String"));
        gridGVLop.DataSource = dtGVLop;
        gridGVLop.Columns["GiaoVien"].HeaderText = "Giáo viên";
        gridGVLop.Columns["MonHoc"].HeaderText = "Môn học";
        gridGVLop.Columns["GiaoVien"].Width = 160;
        gridGVLop.Columns["MonHoc"].Width = 100;

        foreach (GVDayMonHoc day in lop.DSDayHoc.GetDanhSach())
        {
            DataRow row = dtGVLop.NewRow();
            row["GiaoVien"] = day.TenGV;
            row["MonHoc"] = day.TenMon;
            dtGVLop.Rows.Add(row);
        }
    }

    private void ShowDSGV()
    {
        dtGVs = new DataTable();
        dtGVs.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
        dtGVs.Columns.Add("MonHoc", System.Type.GetType("System.String"));
        dtGVs.Columns.Add("Lop", System.Type.GetType("System.String"));
        dataGridView1.DataSource = dtGVs;
        dataGridView1.Columns["GiaoVien"].HeaderText = "Giáo viên";
        dataGridView1.Columns["MonHoc"].HeaderText = "Môn học";
        dataGridView1.Columns["Lop"].HeaderText = "Lớp";
        dataGridView1.Columns["GiaoVien"].Width = 160;
        dataGridView1.Columns["MonHoc"].Width = 100;
        dataGridView1.Columns["Lop"].Width = 60;

        foreach (GVDayMonHoc day in nst.DSDayHoc.GetDanhSach())
        {
            DataRow row = dtGVs.NewRow();
            row["GiaoVien"] = day.TenGV;
            row["MonHoc"] = day.TenMon;
            row["Lop"] = day.TenLop;
            dtGVs.Rows.Add(row);
      }
    }

    private void ShowThu(Thu thu, ListBox listTKB, ListBox listErr)
    {
        
      foreach (Tiet tiet in thu.Tiet)
      {
        if (tiet.IDMon > 0) listTKB.Items.Add(tiet.TenMon);
        else if (tiet.Loai == LoaiTiet.ChaoCo) listTKB.Items.Add("Chào cờ");
        else if (tiet.Loai == LoaiTiet.SinhHoat) listTKB.Items.Add("Sinh hoạt");
        else listTKB.Items.Add("---");

        if (tiet.LoaiViPham == LoaiViPham.KhongViPham)
        {
            listErr.Items.Add("");
        }
        else if (tiet.LoaiViPham == LoaiViPham.TrungLichGiaoVien)
        {
            listErr.Items.Add("G");
            listErr.ForeColor = Color.Red;
        }
        else if (tiet.LoaiViPham == LoaiViPham.ThieuGiaoVien)
        {
            listErr.ForeColor = Color.Red;
            listErr.Items.Add("V");
        }

        else if (tiet.LoaiViPham == LoaiViPham.ThieuSoBuoi || tiet.LoaiViPham == LoaiViPham.QuaSoBuoi)
        {
            listErr.ForeColor = Color.Red;
            listErr.Items.Add("B");
        }
        else if (tiet.LoaiViPham == LoaiViPham.QuaSoTiet)
        {
            listErr.ForeColor = Color.Red;
            listErr.Items.Add("T");
        }
        else
        {
            listErr.ForeColor = Color.Red;
            listErr.Items.Add("X");
        }
      }
    }

    
    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            try
            {
                Item itm = (Item)cmbLophoc.SelectedItem;
                LoadTKB(itm.Value);
                this.lb_lop.Text = itm.ToString();
                this.lb_lop.ForeColor = Color.LimeGreen;
                string str = lblTongViPham.Text;
                char char9 = str[9];
                //int abc = Convert.ToInt32(char9);
                lblkytu.Text = char9.ToString();
                if (lblkytu.Text == "0")
                {
                    lb_thongBao.ForeColor = Color.LimeGreen;
                    lb_thongBao.Text = "Hết vi phạm có thể in dữ liệu";
                    this.btn_continue.Cursor = System.Windows.Forms.Cursors.No;
                    btn_continue.Enabled = false;

                }
                else
                {
                    lb_thongBao.ForeColor = Color.Red;
                    lb_thongBao.Text = "Còn vi phạm về tiết học vui lòng click tiến hóa tiếp";
                    btn_continue.Enabled = true;
                    this.btn_continue.Cursor = System.Windows.Forms.Cursors.Hand;
                }
            }
            catch (Exception)
            {

            }
    }

    private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex >= 0) ClearSelected(1);
      listErr1.SelectedIndex = listBox1.SelectedIndex;
    }
    private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox2.SelectedIndex >= 0) ClearSelected(2);
      listErr2.SelectedIndex = listBox2.SelectedIndex;
    }

    private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox3.SelectedIndex >= 0) ClearSelected(3);
      listErr3.SelectedIndex = listBox3.SelectedIndex;
    }

    private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox4.SelectedIndex >= 0) ClearSelected(4);
      listErr4.SelectedIndex = listBox4.SelectedIndex;
    }

    private void ListBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox5.SelectedIndex >= 0) ClearSelected(5);
      listErr5.SelectedIndex = listBox5.SelectedIndex;
    }

    private void ListBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox6.SelectedIndex >= 0) ClearSelected(6);
      listErr6.SelectedIndex = listBox6.SelectedIndex;
    }

    private void ClearSelected(int Index)
    {
      if (Index != 1) { listBox1.ClearSelected(); listErr1.ClearSelected(); }
      if (Index != 2) { listBox2.ClearSelected(); listErr2.ClearSelected(); }
      if (Index != 3) { listBox3.ClearSelected(); listErr3.ClearSelected(); }
      if (Index != 4) { listBox4.ClearSelected(); listErr4.ClearSelected(); }
      if (Index != 5) { listBox5.ClearSelected(); listErr5.ClearSelected(); }
      if (Index != 6) { listBox6.ClearSelected(); listErr6.ClearSelected(); }
    }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            frmMain fMain = (frmMain)this.MdiParent;
            if (fMain != null)
                fMain.ShowTienhoa();
        }

        //Bunifu btn
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

                    xlWorkSheet.Cells[1, 4] = "TRƯỜNG " + txt_Truong.Text;
                    xlWorkSheet.Rows["1"].Font.Size = 18;
                    xlWorkSheet.Cells[3, 4] = "THỜI KHÓA BIỂU - " + " HỌC KỲ " + cmbHocky.Text + " NĂM HỌC " + txt_Namhoc.Text;
                    xlWorkSheet.Rows["3"].Font.Size = 15;

                    xlWorkSheet.Cells[5, 4] = "Lớp: ";
                    xlWorkSheet.Cells[5, 5] = cmbLophoc.Text.Split(' ')[1];
                    xlWorkSheet.Cells[6, 4] = "Buổi học: ";
                    xlWorkSheet.Cells[6, 5] = BUOIHOC;
                    xlWorkSheet.Cells[7, 4] = lblTongTiet.Text + " Tiết";
                    xlWorkSheet.Cells[8, 4] = lblGVCN.Text;


                    xlWorkSheet.Rows["10"].Font.Color = Color.Red;


                    xlWorkSheet.Cells[10, 4] = "TIẾT";
                    xlWorkSheet.Cells[10, 5] = "THỨ HAI";
                    xlWorkSheet.Cells[10, 6] = "THỨ BA";
                    xlWorkSheet.Cells[10, 7] = "THỨ TƯ";
                    xlWorkSheet.Cells[10, 8] = "THỨ NĂM";
                    xlWorkSheet.Cells[10, 9] = "THỨ SÁU";
                    xlWorkSheet.Cells[10, 10] = "THỨ BẢY";

                    // TIẾT
                    for (int i = 1; i < 6; i++)
                    {
                        xlWorkSheet.Cells[10 + i, 4] = i.ToString();
                    }
                    // thứ 2
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

                    Microsoft.Office.Interop.Excel.Range chartRange = xlWorkSheet.get_Range("D10", "J15");
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

        private void FrmTKB1_Activated(object sender, EventArgs e)
    {
      cmbLophoc.SelectedIndex = -1;
    }
  }
}

