namespace ThoiKhoaBieu
{
    partial class frmDN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.fail_2 = new System.Windows.Forms.Label();
            this.fail = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pic_hide = new System.Windows.Forms.PictureBox();
            this.btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(501, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng nhập";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(507, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(507, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 1);
            this.panel2.TabIndex = 13;
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.White;
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.ForeColor = System.Drawing.Color.Silver;
            this.txt_userName.Location = new System.Drawing.Point(535, 136);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(255, 19);
            this.txt_userName.TabIndex = 12;
            this.txt_userName.Text = "Tên tài khoản";
            this.txt_userName.Enter += new System.EventHandler(this.txt_userName_Enter);
            this.txt_userName.Leave += new System.EventHandler(this.txt_userName_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(507, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(507, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 1);
            this.panel3.TabIndex = 16;
            // 
            // txt_passWord
            // 
            this.txt_passWord.BackColor = System.Drawing.Color.White;
            this.txt_passWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passWord.ForeColor = System.Drawing.Color.Silver;
            this.txt_passWord.Location = new System.Drawing.Point(535, 192);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(227, 19);
            this.txt_passWord.TabIndex = 15;
            this.txt_passWord.Text = "Mật khẩu";
            this.txt_passWord.Enter += new System.EventHandler(this.txt_passWord_Enter);
            this.txt_passWord.Leave += new System.EventHandler(this.txt_passWord_Leave);
            // 
            // fail_2
            // 
            this.fail_2.AutoSize = true;
            this.fail_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fail_2.ForeColor = System.Drawing.Color.Red;
            this.fail_2.Location = new System.Drawing.Point(507, 240);
            this.fail_2.Name = "fail_2";
            this.fail_2.Size = new System.Drawing.Size(0, 19);
            this.fail_2.TabIndex = 22;
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fail.ForeColor = System.Drawing.Color.Red;
            this.fail.Location = new System.Drawing.Point(507, 98);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(0, 19);
            this.fail.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(768, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(818, 13);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(14, 14);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 27;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pic_hide);
            this.panel4.Controls.Add(this.pic_close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 13, 15, 0);
            this.panel4.Size = new System.Drawing.Size(847, 27);
            this.panel4.TabIndex = 31;
            // 
            // pic_hide
            // 
            this.pic_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_hide.Image = ((System.Drawing.Image)(resources.GetObject("pic_hide.Image")));
            this.pic_hide.Location = new System.Drawing.Point(804, 13);
            this.pic_hide.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pic_hide.Name = "pic_hide";
            this.pic_hide.Size = new System.Drawing.Size(14, 14);
            this.pic_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hide.TabIndex = 32;
            this.pic_hide.TabStop = false;
            this.pic_hide.Click += new System.EventHandler(this.pic_hide_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.AllowAnimations = true;
            this.btn_login.AllowMouseEffects = true;
            this.btn_login.AllowToggling = false;
            this.btn_login.AnimationSpeed = 200;
            this.btn_login.AutoGenerateColors = false;
            this.btn_login.AutoRoundBorders = false;
            this.btn_login.AutoSizeLeftIcon = true;
            this.btn_login.AutoSizeRightIcon = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.ButtonText = "Đăng nhập";
            this.btn_login.ButtonTextMarginLeft = 0;
            this.btn_login.ColorContrastOnClick = 45;
            this.btn_login.ColorContrastOnHover = 45;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_login.CustomizableEdges = borderEdges1;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_login.IconMarginLeft = 11;
            this.btn_login.IconPadding = 10;
            this.btn_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_login.IconSize = 25;
            this.btn_login.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_login.IdleBorderRadius = 35;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_login.IdleIconLeftImage = null;
            this.btn_login.IdleIconRightImage = null;
            this.btn_login.IndicateFocus = false;
            this.btn_login.Location = new System.Drawing.Point(505, 262);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.OnDisabledState.BorderRadius = 35;
            this.btn_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnDisabledState.BorderThickness = 1;
            this.btn_login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.OnDisabledState.IconLeftImage = null;
            this.btn_login.OnDisabledState.IconRightImage = null;
            this.btn_login.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_login.onHoverState.BorderRadius = 35;
            this.btn_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.onHoverState.BorderThickness = 1;
            this.btn_login.onHoverState.FillColor = System.Drawing.Color.Red;
            this.btn_login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_login.onHoverState.IconLeftImage = null;
            this.btn_login.onHoverState.IconRightImage = null;
            this.btn_login.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_login.OnIdleState.BorderRadius = 35;
            this.btn_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnIdleState.BorderThickness = 1;
            this.btn_login.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnIdleState.IconLeftImage = null;
            this.btn_login.OnIdleState.IconRightImage = null;
            this.btn_login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.OnPressedState.BorderRadius = 35;
            this.btn_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnPressedState.BorderThickness = 1;
            this.btn_login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnPressedState.IconLeftImage = null;
            this.btn_login.OnPressedState.IconRightImage = null;
            this.btn_login.Size = new System.Drawing.Size(150, 35);
            this.btn_login.TabIndex = 32;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.TextMarginLeft = 0;
            this.btn_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_login.UseDefaultRadiusAndThickness = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 460);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.fail_2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_passWord);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.Label fail;
        private System.Windows.Forms.Label fail_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_hide;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
    }
}