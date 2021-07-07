using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThoiKhoaBieu.AppCode;

namespace ThoiKhoaBieu
{
    public partial class frmDangKy : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=TKB_v2;Integrated Security=True");
        SqlCommand cmd;
        hashCode hc = new hashCode();
        
        public frmDangKy()
        {
            InitializeComponent();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Quyen", sqlconn);
            sqlconn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                cmb_role.Items.Add(row["id_role"].ToString());
            }
           
        }

        private void resgiterButton1_Click(object sender, EventArgs e)
        {
            if(txt_fullName.Text=="" || txt_userName.Text =="" || txt_passWord.Text=="" || cmb_role.Text == ""
                || txt_fullName.Text=="Tên người dùng" || txt_userName.Text=="Tên tài khoản" || txt_passWord.Text=="Mật khẩu"
                )
            {
                this.label2.Text = "Đăng ký thất bại! Vui lòng điền đủa các thông tin";
                this.label2.ForeColor = Color.Red;
            }
            else
            {
                if (txt_passWord.Text == txt_confirmPass.Text)
                {
                    string sqlQuery = "insert into NguoiDung(fullName, userName, passWord, id_role) values('" + txt_fullName.Text + "','" + txt_userName.Text + "','" + hc.PassHash(txt_passWord.Text) + "','" + cmb_role.Text + "')";
                    cmd = new SqlCommand(sqlQuery, sqlconn);
                    cmd.ExecuteNonQuery();
                    this.label2.Text = "Đăng ký thành công !";
                    txt_fullName.Text = "Tên người dùng";
                    txt_fullName.ForeColor = Color.Gray;

                    txt_userName.Text = "Tên tài khoản";
                    txt_userName.ForeColor = Color.Gray;

                    txt_passWord.Text = "Mật khẩu";
                    txt_passWord.ForeColor = Color.Gray;
                    txt_passWord.UseSystemPasswordChar = false;

                    txt_confirmPass.Text = "Nhập lại mật khẩu";
                    txt_confirmPass.ForeColor = Color.Gray;
                    txt_confirmPass.UseSystemPasswordChar = false;

                    this.label2.ForeColor = Color.Green;
                    this.confirmPassText.Hide();
                }
                else
                {
                    this.confirmPassText.Text = "Mật khẩu nhập lại chưa đúng !";
                    this.txt_confirmPass.Clear();
                }
            }
        }
        private void lb_exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc muốn hủy đăng ký không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
               
        }




        //PlaceHolder
        private void txt_fullName_Enter(object sender, EventArgs e)
        {
            if(txt_fullName.Text== "Tên người dùng")
            {
                txt_fullName.Text = "";
                txt_fullName.ForeColor = Color.Black;
            }
        }

        private void txt_fullName_Leave(object sender, EventArgs e)
        {
            if (txt_fullName.Text == "")
            {
                txt_fullName.Text = "Tên người dùng";
                txt_fullName.ForeColor = Color.Silver;
            }
        }

        private void txt_userName_Enter(object sender, EventArgs e)
        {
            if (txt_userName.Text == "Tên tài khoản")
            {
                txt_userName.Text = "";
                txt_userName.ForeColor = Color.Black;
            }
        }

        private void txt_userName_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "Tên tài khoản";
                txt_userName.ForeColor = Color.Silver;
            }
        }

        private void txt_passWord_Enter(object sender, EventArgs e)
        {
            if (txt_passWord.Text == "Mật khẩu")
            {
                txt_passWord.Text = "";
                txt_passWord.ForeColor = Color.Black;
                txt_passWord.UseSystemPasswordChar = true;
            }
        }

        private void txt_passWord_Leave(object sender, EventArgs e)
        {
            if (txt_passWord.Text == "")
            {
                txt_passWord.Text = "Mật khẩu";
                txt_passWord.ForeColor = Color.Silver;
                txt_passWord.UseSystemPasswordChar = false;
            }
        }

        private void txt_confirmPass_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPass.Text == "Nhập lại mật khẩu")
            {
                txt_confirmPass.Text = "";
                txt_confirmPass.ForeColor = Color.Black;
                txt_confirmPass.UseSystemPasswordChar = true;
            }
        }

        private void txt_confirmPass_Leave(object sender, EventArgs e)
        {
            if (txt_confirmPass.Text == "")
            {
                txt_confirmPass.Text = "Nhập lại mật khẩu";
                txt_confirmPass.ForeColor = Color.Silver;
                txt_confirmPass.UseSystemPasswordChar = false;
            }
        }

       
    }
}
