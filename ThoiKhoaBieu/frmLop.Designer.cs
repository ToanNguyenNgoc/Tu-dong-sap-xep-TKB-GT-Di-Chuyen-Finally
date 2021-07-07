namespace ThoiKhoaBieu
{
  partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_print = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_update = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txt_seach = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 677);
            this.panel1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(58, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 637);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(331, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 30);
            this.btn_search.TabIndex = 50;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuPanel5);
            this.panel2.Controls.Add(this.txt_seach);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(1366, 86);
            this.panel2.TabIndex = 49;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel5.BorderRadius = 40;
            this.bunifuPanel5.BorderThickness = 0;
            this.bunifuPanel5.Controls.Add(this.btn_delete);
            this.bunifuPanel5.Controls.Add(this.btn_print);
            this.bunifuPanel5.Controls.Add(this.btn_update);
            this.bunifuPanel5.Location = new System.Drawing.Point(550, 37);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(408, 43);
            this.bunifuPanel5.TabIndex = 67;
            // 
            // btn_delete
            // 
            this.btn_delete.AllowAnimations = true;
            this.btn_delete.AllowMouseEffects = true;
            this.btn_delete.AllowToggling = false;
            this.btn_delete.AnimationSpeed = 200;
            this.btn_delete.AutoGenerateColors = false;
            this.btn_delete.AutoRoundBorders = false;
            this.btn_delete.AutoSizeLeftIcon = true;
            this.btn_delete.AutoSizeRightIcon = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.ButtonText = "Xóa";
            this.btn_delete.ButtonTextMarginLeft = 0;
            this.btn_delete.ColorContrastOnClick = 45;
            this.btn_delete.ColorContrastOnHover = 45;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btn_delete.CustomizableEdges = borderEdges13;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Gray;
            this.btn_delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_delete.IconMarginLeft = 11;
            this.btn_delete.IconPadding = 10;
            this.btn_delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_delete.IconSize = 25;
            this.btn_delete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.IdleBorderRadius = 32;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.IdleIconLeftImage = null;
            this.btn_delete.IdleIconRightImage = null;
            this.btn_delete.IndicateFocus = false;
            this.btn_delete.Location = new System.Drawing.Point(276, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.OnDisabledState.BorderRadius = 32;
            this.btn_delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnDisabledState.BorderThickness = 1;
            this.btn_delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.OnDisabledState.IconLeftImage = null;
            this.btn_delete.OnDisabledState.IconRightImage = null;
            this.btn_delete.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_delete.onHoverState.BorderRadius = 32;
            this.btn_delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.onHoverState.BorderThickness = 1;
            this.btn_delete.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.onHoverState.IconLeftImage = null;
            this.btn_delete.onHoverState.IconRightImage = null;
            this.btn_delete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.OnIdleState.BorderRadius = 32;
            this.btn_delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnIdleState.BorderThickness = 1;
            this.btn_delete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_delete.OnIdleState.IconLeftImage = null;
            this.btn_delete.OnIdleState.IconRightImage = null;
            this.btn_delete.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.OnPressedState.BorderRadius = 32;
            this.btn_delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnPressedState.BorderThickness = 1;
            this.btn_delete.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_delete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.OnPressedState.IconLeftImage = null;
            this.btn_delete.OnPressedState.IconRightImage = null;
            this.btn_delete.Size = new System.Drawing.Size(126, 35);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.TextMarginLeft = 0;
            this.btn_delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_delete.UseDefaultRadiusAndThickness = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_print
            // 
            this.btn_print.AllowAnimations = true;
            this.btn_print.AllowMouseEffects = true;
            this.btn_print.AllowToggling = false;
            this.btn_print.AnimationSpeed = 200;
            this.btn_print.AutoGenerateColors = false;
            this.btn_print.AutoRoundBorders = false;
            this.btn_print.AutoSizeLeftIcon = true;
            this.btn_print.AutoSizeRightIcon = true;
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_print.ButtonText = "In danh sách";
            this.btn_print.ButtonTextMarginLeft = 0;
            this.btn_print.ColorContrastOnClick = 45;
            this.btn_print.ColorContrastOnHover = 45;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btn_print.CustomizableEdges = borderEdges14;
            this.btn_print.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_print.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_print.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_print.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_print.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Gray;
            this.btn_print.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_print.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_print.IconMarginLeft = 11;
            this.btn_print.IconPadding = 10;
            this.btn_print.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_print.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_print.IconSize = 25;
            this.btn_print.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_print.IdleBorderRadius = 32;
            this.btn_print.IdleBorderThickness = 1;
            this.btn_print.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_print.IdleIconLeftImage = null;
            this.btn_print.IdleIconRightImage = null;
            this.btn_print.IndicateFocus = false;
            this.btn_print.Location = new System.Drawing.Point(140, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_print.OnDisabledState.BorderRadius = 32;
            this.btn_print.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_print.OnDisabledState.BorderThickness = 1;
            this.btn_print.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_print.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_print.OnDisabledState.IconLeftImage = null;
            this.btn_print.OnDisabledState.IconRightImage = null;
            this.btn_print.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_print.onHoverState.BorderRadius = 32;
            this.btn_print.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_print.onHoverState.BorderThickness = 1;
            this.btn_print.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_print.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_print.onHoverState.IconLeftImage = null;
            this.btn_print.onHoverState.IconRightImage = null;
            this.btn_print.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_print.OnIdleState.BorderRadius = 32;
            this.btn_print.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_print.OnIdleState.BorderThickness = 1;
            this.btn_print.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_print.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_print.OnIdleState.IconLeftImage = null;
            this.btn_print.OnIdleState.IconRightImage = null;
            this.btn_print.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.OnPressedState.BorderRadius = 32;
            this.btn_print.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_print.OnPressedState.BorderThickness = 1;
            this.btn_print.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_print.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_print.OnPressedState.IconLeftImage = null;
            this.btn_print.OnPressedState.IconRightImage = null;
            this.btn_print.Size = new System.Drawing.Size(126, 35);
            this.btn_print.TabIndex = 58;
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_print.TextMarginLeft = 0;
            this.btn_print.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_print.UseDefaultRadiusAndThickness = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.AllowAnimations = true;
            this.btn_update.AllowMouseEffects = true;
            this.btn_update.AllowToggling = false;
            this.btn_update.AnimationSpeed = 200;
            this.btn_update.AutoGenerateColors = false;
            this.btn_update.AutoRoundBorders = false;
            this.btn_update.AutoSizeLeftIcon = true;
            this.btn_update.AutoSizeRightIcon = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.ButtonText = "Cập nhật";
            this.btn_update.ButtonTextMarginLeft = 0;
            this.btn_update.ColorContrastOnClick = 45;
            this.btn_update.ColorContrastOnHover = 45;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btn_update.CustomizableEdges = borderEdges15;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_update.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_update.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_update.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_update.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Gray;
            this.btn_update.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_update.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_update.IconMarginLeft = 11;
            this.btn_update.IconPadding = 10;
            this.btn_update.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_update.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_update.IconSize = 25;
            this.btn_update.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.IdleBorderRadius = 32;
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.IdleIconLeftImage = null;
            this.btn_update.IdleIconRightImage = null;
            this.btn_update.IndicateFocus = false;
            this.btn_update.Location = new System.Drawing.Point(6, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_update.OnDisabledState.BorderRadius = 32;
            this.btn_update.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnDisabledState.BorderThickness = 1;
            this.btn_update.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_update.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_update.OnDisabledState.IconLeftImage = null;
            this.btn_update.OnDisabledState.IconRightImage = null;
            this.btn_update.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_update.onHoverState.BorderRadius = 32;
            this.btn_update.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.onHoverState.BorderThickness = 1;
            this.btn_update.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_update.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_update.onHoverState.IconLeftImage = null;
            this.btn_update.onHoverState.IconRightImage = null;
            this.btn_update.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.OnIdleState.BorderRadius = 32;
            this.btn_update.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnIdleState.BorderThickness = 1;
            this.btn_update.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_update.OnIdleState.IconLeftImage = null;
            this.btn_update.OnIdleState.IconRightImage = null;
            this.btn_update.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.OnPressedState.BorderRadius = 32;
            this.btn_update.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_update.OnPressedState.BorderThickness = 1;
            this.btn_update.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_update.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_update.OnPressedState.IconLeftImage = null;
            this.btn_update.OnPressedState.IconRightImage = null;
            this.btn_update.Size = new System.Drawing.Size(126, 35);
            this.btn_update.TabIndex = 57;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_update.TextMarginLeft = 0;
            this.btn_update.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_update.UseDefaultRadiusAndThickness = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_seach
            // 
            this.txt_seach.AcceptsReturn = false;
            this.txt_seach.AcceptsTab = false;
            this.txt_seach.AnimationSpeed = 200;
            this.txt_seach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_seach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_seach.BackColor = System.Drawing.Color.Transparent;
            this.txt_seach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_seach.BackgroundImage")));
            this.txt_seach.BorderColorActive = System.Drawing.Color.White;
            this.txt_seach.BorderColorDisabled = System.Drawing.Color.White;
            this.txt_seach.BorderColorHover = System.Drawing.Color.WhiteSmoke;
            this.txt_seach.BorderColorIdle = System.Drawing.Color.White;
            this.txt_seach.BorderRadius = 32;
            this.txt_seach.BorderThickness = 1;
            this.txt_seach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_seach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_seach.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seach.DefaultText = "";
            this.txt_seach.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_seach.ForeColor = System.Drawing.Color.Black;
            this.txt_seach.HideSelection = true;
            this.txt_seach.IconLeft = null;
            this.txt_seach.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_seach.IconPadding = 10;
            this.txt_seach.IconRight = null;
            this.txt_seach.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_seach.Lines = new string[0];
            this.txt_seach.Location = new System.Drawing.Point(77, 41);
            this.txt_seach.MaxLength = 32767;
            this.txt_seach.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_seach.Modified = false;
            this.txt_seach.Multiline = false;
            this.txt_seach.Name = "txt_seach";
            stateProperties17.BorderColor = System.Drawing.Color.White;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_seach.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.White;
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_seach.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_seach.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.White;
            stateProperties20.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties20.ForeColor = System.Drawing.Color.Black;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_seach.OnIdleState = stateProperties20;
            this.txt_seach.Padding = new System.Windows.Forms.Padding(3);
            this.txt_seach.PasswordChar = '\0';
            this.txt_seach.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_seach.PlaceholderText = "Tên lớp học";
            this.txt_seach.ReadOnly = false;
            this.txt_seach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_seach.SelectedText = "";
            this.txt_seach.SelectionLength = 0;
            this.txt_seach.SelectionStart = 0;
            this.txt_seach.ShortcutsEnabled = true;
            this.txt_seach.Size = new System.Drawing.Size(251, 35);
            this.txt_seach.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_seach.TabIndex = 61;
            this.txt_seach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_seach.TextMarginBottom = 0;
            this.txt_seach.TextMarginLeft = 3;
            this.txt_seach.TextMarginTop = 0;
            this.txt_seach.TextPlaceholder = "Tên lớp học";
            this.txt_seach.UseSystemPasswordChar = false;
            this.txt_seach.WordWrap = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLop";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Danh sách lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.SizeChanged += new System.EventHandler(this.frmLop_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.bunifuPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    //private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn khoiDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn buoiHocDataGridViewTextBoxColumn;
    private System.Windows.Forms.RibbonTab ribbonTab1;
    private System.Windows.Forms.RibbonPanel ribbonPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private Bunifu.UI.WinForms.BunifuTextBox txt_seach;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_delete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_print;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_update;
    }
}