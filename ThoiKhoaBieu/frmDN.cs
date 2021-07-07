using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoiKhoaBieu.AppCode;

namespace ThoiKhoaBieu
{
    public partial class frmDN : Form
    {
        DataBase cn = new DataBase();
        hashCode hc = new hashCode();
        public frmDN()
        {
            InitializeComponent();
        }
        //Placeholder----
        private void txt_userName_Enter(object sender, EventArgs e)
        {
            if (txt_userName.Text == "Tên tài khoản")
            {
                txt_userName.Text = "";
                txt_userName.ForeColor = Color.Black;
                this.fail.Text = "";
            }
        }
        private void txt_userName_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "Tên tài khoản";
                txt_userName.ForeColor = Color.Silver;
                this.fail.Text = "";
            }
        }
        private void txt_passWord_Enter(object sender, EventArgs e)
        {
            if (txt_passWord.Text == "Mật khẩu")
            {
                txt_passWord.Text = "";
                txt_passWord.ForeColor = Color.Black;
                txt_passWord.UseSystemPasswordChar = true;
                this.fail.Text = "";
            }
        }
        private void txt_passWord_Leave(object sender, EventArgs e)
        {
            if (txt_passWord.Text == "")
            {
                txt_passWord.Text = "Mật khẩu";
                txt_passWord.ForeColor = Color.Silver;
                txt_passWord.UseSystemPasswordChar = false;
                this.fail.Text = "";
            }
        }
        //---------------

        private void lb_exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txt_passWord.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if(txt_passWord.Text != "Mật khẩu")
            txt_passWord.UseSystemPasswordChar = true;
        }
        private void pic_close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        private void pic_hide_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text.Trim();
            string passWord = txt_passWord.Text.Trim();
            string sql = "select * from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'";
            if (userName != "Tên tài khoản" || passWord != "Mật khẩu")
            {
                if (cn.XemDL(sql).Rows.Count != 0)
                {
                    frmMain.userName = cn.XemDL("select userName from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    frmMain.quyen = cn.XemDL("select id_role from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    frmMain.fullName = cn.XemDL("select fullName from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    //___________________________
                    frmLop.role = cn.XemDL("select id_role from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    frmMonhoc.role = cn.XemDL("select id_role from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    frmPhongHoc.role = cn.XemDL("select id_role from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                    frmGiaoVien.role = cn.XemDL("select id_role from NguoiDung where userName='" + userName + "' and passWord='" + hc.PassHash(passWord) + "'").Rows[0][0].ToString().Trim();
                   
                    frmMain frm = new frmMain
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    this.fail.Text = "Tài khoản hoặc mật khẩu không đúng !";
                    txt_userName.Text = "Tên tài khoản";
                    txt_userName.ForeColor = Color.Silver;
                    txt_passWord.Text = "Mật khẩu";
                    txt_passWord.ForeColor = Color.Silver;
                    txt_passWord.UseSystemPasswordChar = false;

                }
            }
            else
            {
                this.fail.Text = "Vui lòng nhập đủ các thông tin !";
            }
        }
    }
}
