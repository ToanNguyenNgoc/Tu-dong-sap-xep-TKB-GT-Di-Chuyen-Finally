    using System;
using System.Linq;
using System.Windows.Forms;

namespace ThoiKhoaBieu
{
    public partial class frmMain : Form
    {
        //------------------

        //------------------
        public frmMain()
        {
            InitializeComponent();
            this.label1.Text = userName;
            this.lb_quyen.Text = "Quyền truy cập : " + quyen;
            this.lb_fullName.Text = "Họ và tên : " + fullName;
        }
        frmPhanLich fPhanLich;
        frmGiaoVien fGiaoVien;
        frmLop fLop;
        frmMonhoc fMonHoc;
        frmPhongHoc fPhong;
        frmTKB1 fTKB;
        frmTKBGV fTKBGV;
        DataBase cn = new DataBase();
        public static string quyen;
        public static string userName;
        public static string fullName;
        
        //-------------------------
        
        //--------------------------

        public void ShowTKB()
        {
            if (fTKB == null || fTKB.IsDisposed) fTKB = new frmTKB1(Program.nst);
            else fTKB.NST = Program.nst;
            ShowFormChild(fTKB);
        }
        public void ShowTienhoa()
        {
            if (fPhanLich == null || fPhanLich.IsDisposed) fPhanLich = new frmPhanLich();
            ShowFormChild(fPhanLich);
        }
        public void ShowTKBGV()
        {
            if (fTKBGV == null || fTKBGV.IsDisposed) fTKBGV = new frmTKBGV(Program.nst);
            else fTKBGV.NST = Program.nst;
            ShowFormChild(fTKBGV);
        }

        private void ShowFormChild(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
            frm.Size = this.Size;
            this.Width += 1;
            this.Width += -1;
            mdiTabStrip1.Refresh();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
        }

        

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //------------------------------
        //========================================
        private void btn_lop_Click(object sender, EventArgs e)
        {
            if (fLop == null || fLop.IsDisposed) fLop = new frmLop();
            ShowFormChild(fLop);
        }

        private void btn_mon_Click(object sender, EventArgs e)
        {
            if (fMonHoc == null || fMonHoc.IsDisposed) fMonHoc = new frmMonhoc();
            ShowFormChild(fMonHoc);
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            if (fPhong == null || fPhong.IsDisposed) fPhong = new frmPhongHoc();
            ShowFormChild(fPhong);
        }

        private void btn_giaoVien_Click(object sender, EventArgs e)
        {
            if (fGiaoVien == null || fGiaoVien.IsDisposed) fGiaoVien = new frmGiaoVien();
            ShowFormChild(fGiaoVien);
        }

        private void btn_phanLich_Click(object sender, EventArgs e)
        {
            if (fPhanLich == null || fPhanLich.IsDisposed) fPhanLich = new frmPhanLich();
            ShowFormChild(fPhanLich);
        }

        private void btn_tkb_Click(object sender, EventArgs e)
        {
            if (fTKB == null || fTKB.IsDisposed) fTKB = new frmTKB1(Program.nst);
            ShowFormChild(fTKB);
            ShowTKB();
        }

        private void btn_tkbGiaoVien_Click(object sender, EventArgs e)
        {
            if (fTKBGV == null || fTKBGV.IsDisposed) fTKBGV = new frmTKBGV(Program.nst);
            ShowFormChild(fTKBGV);
        }
        //open close nav_________________
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            for (int i = 70; i <= 280; i += 21)
            {

                bunifuPanel1.Width = i;
            }

            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel7.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            //btn
            btn_add.Visible = true;
            btn_lop.Visible = true;
            btn_mon.Visible = true;
            btn_phong.Visible = true;
            btn_giaoVien.Visible = true;
            btn_tkb.Visible = true;
            btn_tkbGiaoVien.Visible = true;
            btn_phanLich.Visible = true;
            btn_logOut.Visible = true;
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 280; i >= 70; i -= 21)
            {

                bunifuPanel1.Width = i;
            }

            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel7.BackgroundColor = System.Drawing.Color.White;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            //btn
            btn_add.Visible = false;
            btn_lop.Visible = false;
            btn_mon.Visible = false;
            btn_phong.Visible = false;
            btn_giaoVien.Visible = false;
            btn_tkb.Visible = false;
            btn_tkbGiaoVien.Visible = false;
            btn_phanLich.Visible = false;
            btn_logOut.Visible = false;
            
        }
        //===============================
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                frmDangKy frmdk = new frmDangKy
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                frmdk.Show();
            }
            else
            {
                frmError frme = new frmError
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                frme.Show();
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmDN frm = new frmDN
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                frm.Show();
                this.Hide();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPanel6.Visible = true;
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bunifuPanel6.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.lb_info.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.lb_info.Visible = false;
        }
    }
}
