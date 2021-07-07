namespace ThoiKhoaBieu
{
  partial class frmPhanLich
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
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLich));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tkbGV = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_tkb = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_tienHoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_dung = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_tienHoa100 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_tienHoaAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_success = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.56069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.43931F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 675);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.83673F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.16327F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 12);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // chart1
            // 
            textAnnotation3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation3.IsSizeAlwaysRelative = false;
            textAnnotation3.Name = "TextAnnotation2";
            textAnnotation3.Text = "Độ thích nghi (%)";
            textAnnotation3.X = 4D;
            textAnnotation3.Y = 4D;
            textAnnotation4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation4.Name = "TextAnnotation1";
            textAnnotation4.Text = "Thế hệ";
            textAnnotation4.X = 90D;
            textAnnotation4.Y = 94D;
            this.chart1.Annotations.Add(textAnnotation3);
            this.chart1.Annotations.Add(textAnnotation4);
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(10, 92);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Độ thích nghi";
            series2.YValuesPerPoint = 3;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(722, 494);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Độ thích nghi của Nhiễm sắc thể";
            this.chart1.Titles.Add(title2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(738, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 494);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_tkbGV);
            this.panel1.Controls.Add(this.btn_tkb);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 86);
            this.panel1.TabIndex = 8;
            // 
            // btn_tkbGV
            // 
            this.btn_tkbGV.AllowAnimations = true;
            this.btn_tkbGV.AllowMouseEffects = true;
            this.btn_tkbGV.AllowToggling = false;
            this.btn_tkbGV.AnimationSpeed = 200;
            this.btn_tkbGV.AutoGenerateColors = false;
            this.btn_tkbGV.AutoRoundBorders = false;
            this.btn_tkbGV.AutoSizeLeftIcon = true;
            this.btn_tkbGV.AutoSizeRightIcon = true;
            this.btn_tkbGV.BackColor = System.Drawing.Color.Transparent;
            this.btn_tkbGV.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkbGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tkbGV.BackgroundImage")));
            this.btn_tkbGV.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkbGV.ButtonText = "Thời khóa biểu giáo viên";
            this.btn_tkbGV.ButtonTextMarginLeft = 0;
            this.btn_tkbGV.ColorContrastOnClick = 45;
            this.btn_tkbGV.ColorContrastOnHover = 45;
            this.btn_tkbGV.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btn_tkbGV.CustomizableEdges = borderEdges7;
            this.btn_tkbGV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tkbGV.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tkbGV.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tkbGV.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tkbGV.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tkbGV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tkbGV.ForeColor = System.Drawing.Color.Gray;
            this.btn_tkbGV.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tkbGV.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tkbGV.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_tkbGV.IconMarginLeft = 11;
            this.btn_tkbGV.IconPadding = 10;
            this.btn_tkbGV.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tkbGV.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tkbGV.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_tkbGV.IconSize = 25;
            this.btn_tkbGV.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkbGV.IdleBorderRadius = 32;
            this.btn_tkbGV.IdleBorderThickness = 1;
            this.btn_tkbGV.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkbGV.IdleIconLeftImage = null;
            this.btn_tkbGV.IdleIconRightImage = null;
            this.btn_tkbGV.IndicateFocus = false;
            this.btn_tkbGV.Location = new System.Drawing.Point(817, 44);
            this.btn_tkbGV.Name = "btn_tkbGV";
            this.btn_tkbGV.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tkbGV.OnDisabledState.BorderRadius = 32;
            this.btn_tkbGV.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkbGV.OnDisabledState.BorderThickness = 1;
            this.btn_tkbGV.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tkbGV.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tkbGV.OnDisabledState.IconLeftImage = null;
            this.btn_tkbGV.OnDisabledState.IconRightImage = null;
            this.btn_tkbGV.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_tkbGV.onHoverState.BorderRadius = 32;
            this.btn_tkbGV.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkbGV.onHoverState.BorderThickness = 1;
            this.btn_tkbGV.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_tkbGV.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tkbGV.onHoverState.IconLeftImage = null;
            this.btn_tkbGV.onHoverState.IconRightImage = null;
            this.btn_tkbGV.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkbGV.OnIdleState.BorderRadius = 32;
            this.btn_tkbGV.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkbGV.OnIdleState.BorderThickness = 1;
            this.btn_tkbGV.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkbGV.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_tkbGV.OnIdleState.IconLeftImage = null;
            this.btn_tkbGV.OnIdleState.IconRightImage = null;
            this.btn_tkbGV.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tkbGV.OnPressedState.BorderRadius = 32;
            this.btn_tkbGV.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkbGV.OnPressedState.BorderThickness = 1;
            this.btn_tkbGV.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_tkbGV.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_tkbGV.OnPressedState.IconLeftImage = null;
            this.btn_tkbGV.OnPressedState.IconRightImage = null;
            this.btn_tkbGV.Size = new System.Drawing.Size(196, 35);
            this.btn_tkbGV.TabIndex = 65;
            this.btn_tkbGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tkbGV.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tkbGV.TextMarginLeft = 0;
            this.btn_tkbGV.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_tkbGV.UseDefaultRadiusAndThickness = true;
            this.btn_tkbGV.Click += new System.EventHandler(this.btn_tkbGV_Click);
            // 
            // btn_tkb
            // 
            this.btn_tkb.AllowAnimations = true;
            this.btn_tkb.AllowMouseEffects = true;
            this.btn_tkb.AllowToggling = false;
            this.btn_tkb.AnimationSpeed = 200;
            this.btn_tkb.AutoGenerateColors = false;
            this.btn_tkb.AutoRoundBorders = false;
            this.btn_tkb.AutoSizeLeftIcon = true;
            this.btn_tkb.AutoSizeRightIcon = true;
            this.btn_tkb.BackColor = System.Drawing.Color.Transparent;
            this.btn_tkb.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tkb.BackgroundImage")));
            this.btn_tkb.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkb.ButtonText = "Thời khóa biểu";
            this.btn_tkb.ButtonTextMarginLeft = 0;
            this.btn_tkb.ColorContrastOnClick = 45;
            this.btn_tkb.ColorContrastOnHover = 45;
            this.btn_tkb.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btn_tkb.CustomizableEdges = borderEdges8;
            this.btn_tkb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tkb.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tkb.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tkb.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tkb.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tkb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tkb.ForeColor = System.Drawing.Color.Gray;
            this.btn_tkb.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tkb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tkb.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_tkb.IconMarginLeft = 11;
            this.btn_tkb.IconPadding = 10;
            this.btn_tkb.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tkb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tkb.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_tkb.IconSize = 25;
            this.btn_tkb.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkb.IdleBorderRadius = 32;
            this.btn_tkb.IdleBorderThickness = 1;
            this.btn_tkb.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkb.IdleIconLeftImage = null;
            this.btn_tkb.IdleIconRightImage = null;
            this.btn_tkb.IndicateFocus = false;
            this.btn_tkb.Location = new System.Drawing.Point(664, 44);
            this.btn_tkb.Name = "btn_tkb";
            this.btn_tkb.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tkb.OnDisabledState.BorderRadius = 32;
            this.btn_tkb.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkb.OnDisabledState.BorderThickness = 1;
            this.btn_tkb.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tkb.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tkb.OnDisabledState.IconLeftImage = null;
            this.btn_tkb.OnDisabledState.IconRightImage = null;
            this.btn_tkb.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_tkb.onHoverState.BorderRadius = 32;
            this.btn_tkb.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkb.onHoverState.BorderThickness = 1;
            this.btn_tkb.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_tkb.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tkb.onHoverState.IconLeftImage = null;
            this.btn_tkb.onHoverState.IconRightImage = null;
            this.btn_tkb.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkb.OnIdleState.BorderRadius = 32;
            this.btn_tkb.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkb.OnIdleState.BorderThickness = 1;
            this.btn_tkb.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tkb.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_tkb.OnIdleState.IconLeftImage = null;
            this.btn_tkb.OnIdleState.IconRightImage = null;
            this.btn_tkb.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tkb.OnPressedState.BorderRadius = 32;
            this.btn_tkb.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tkb.OnPressedState.BorderThickness = 1;
            this.btn_tkb.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_tkb.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_tkb.OnPressedState.IconLeftImage = null;
            this.btn_tkb.OnPressedState.IconRightImage = null;
            this.btn_tkb.Size = new System.Drawing.Size(147, 35);
            this.btn_tkb.TabIndex = 64;
            this.btn_tkb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tkb.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tkb.TextMarginLeft = 0;
            this.btn_tkb.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_tkb.UseDefaultRadiusAndThickness = true;
            this.btn_tkb.Click += new System.EventHandler(this.btn_tkb_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel1.BorderRadius = 40;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btn_tienHoa);
            this.bunifuPanel1.Controls.Add(this.btn_dung);
            this.bunifuPanel1.Controls.Add(this.btn_tienHoa100);
            this.bunifuPanel1.Controls.Add(this.btn_tienHoaAll);
            this.bunifuPanel1.Location = new System.Drawing.Point(48, 40);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(529, 43);
            this.bunifuPanel1.TabIndex = 64;
            // 
            // btn_tienHoa
            // 
            this.btn_tienHoa.AllowAnimations = true;
            this.btn_tienHoa.AllowMouseEffects = true;
            this.btn_tienHoa.AllowToggling = false;
            this.btn_tienHoa.AnimationSpeed = 200;
            this.btn_tienHoa.AutoGenerateColors = false;
            this.btn_tienHoa.AutoRoundBorders = false;
            this.btn_tienHoa.AutoSizeLeftIcon = true;
            this.btn_tienHoa.AutoSizeRightIcon = true;
            this.btn_tienHoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_tienHoa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tienHoa.BackgroundImage")));
            this.btn_tienHoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa.ButtonText = "Tiến hóa";
            this.btn_tienHoa.ButtonTextMarginLeft = 0;
            this.btn_tienHoa.ColorContrastOnClick = 45;
            this.btn_tienHoa.ColorContrastOnHover = 45;
            this.btn_tienHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btn_tienHoa.CustomizableEdges = borderEdges9;
            this.btn_tienHoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tienHoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tienHoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tienHoa.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tienHoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_tienHoa.IconMarginLeft = 11;
            this.btn_tienHoa.IconPadding = 10;
            this.btn_tienHoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tienHoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_tienHoa.IconSize = 25;
            this.btn_tienHoa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa.IdleBorderRadius = 32;
            this.btn_tienHoa.IdleBorderThickness = 1;
            this.btn_tienHoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa.IdleIconLeftImage = null;
            this.btn_tienHoa.IdleIconRightImage = null;
            this.btn_tienHoa.IndicateFocus = false;
            this.btn_tienHoa.Location = new System.Drawing.Point(5, 4);
            this.btn_tienHoa.Name = "btn_tienHoa";
            this.btn_tienHoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoa.OnDisabledState.BorderRadius = 32;
            this.btn_tienHoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa.OnDisabledState.BorderThickness = 1;
            this.btn_tienHoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoa.OnDisabledState.IconLeftImage = null;
            this.btn_tienHoa.OnDisabledState.IconRightImage = null;
            this.btn_tienHoa.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_tienHoa.onHoverState.BorderRadius = 32;
            this.btn_tienHoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa.onHoverState.BorderThickness = 1;
            this.btn_tienHoa.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_tienHoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoa.onHoverState.IconLeftImage = null;
            this.btn_tienHoa.onHoverState.IconRightImage = null;
            this.btn_tienHoa.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa.OnIdleState.BorderRadius = 32;
            this.btn_tienHoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa.OnIdleState.BorderThickness = 1;
            this.btn_tienHoa.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoa.OnIdleState.IconLeftImage = null;
            this.btn_tienHoa.OnIdleState.IconRightImage = null;
            this.btn_tienHoa.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoa.OnPressedState.BorderRadius = 32;
            this.btn_tienHoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa.OnPressedState.BorderThickness = 1;
            this.btn_tienHoa.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoa.OnPressedState.IconLeftImage = null;
            this.btn_tienHoa.OnPressedState.IconRightImage = null;
            this.btn_tienHoa.Size = new System.Drawing.Size(95, 35);
            this.btn_tienHoa.TabIndex = 60;
            this.btn_tienHoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tienHoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tienHoa.TextMarginLeft = 0;
            this.btn_tienHoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_tienHoa.UseDefaultRadiusAndThickness = true;
            this.btn_tienHoa.Click += new System.EventHandler(this.btn_tienHoa_Click);
            // 
            // btn_dung
            // 
            this.btn_dung.AllowAnimations = true;
            this.btn_dung.AllowMouseEffects = true;
            this.btn_dung.AllowToggling = false;
            this.btn_dung.AnimationSpeed = 200;
            this.btn_dung.AutoGenerateColors = false;
            this.btn_dung.AutoRoundBorders = false;
            this.btn_dung.AutoSizeLeftIcon = true;
            this.btn_dung.AutoSizeRightIcon = true;
            this.btn_dung.BackColor = System.Drawing.Color.Transparent;
            this.btn_dung.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dung.BackgroundImage")));
            this.btn_dung.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dung.ButtonText = "Dừng";
            this.btn_dung.ButtonTextMarginLeft = 0;
            this.btn_dung.ColorContrastOnClick = 45;
            this.btn_dung.ColorContrastOnHover = 45;
            this.btn_dung.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btn_dung.CustomizableEdges = borderEdges10;
            this.btn_dung.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dung.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dung.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dung.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dung.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_dung.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dung.ForeColor = System.Drawing.Color.Gray;
            this.btn_dung.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dung.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dung.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_dung.IconMarginLeft = 11;
            this.btn_dung.IconPadding = 10;
            this.btn_dung.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dung.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_dung.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_dung.IconSize = 25;
            this.btn_dung.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dung.IdleBorderRadius = 32;
            this.btn_dung.IdleBorderThickness = 1;
            this.btn_dung.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dung.IdleIconLeftImage = null;
            this.btn_dung.IdleIconRightImage = null;
            this.btn_dung.IndicateFocus = false;
            this.btn_dung.Location = new System.Drawing.Point(397, 4);
            this.btn_dung.Name = "btn_dung";
            this.btn_dung.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_dung.OnDisabledState.BorderRadius = 32;
            this.btn_dung.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dung.OnDisabledState.BorderThickness = 1;
            this.btn_dung.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dung.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dung.OnDisabledState.IconLeftImage = null;
            this.btn_dung.OnDisabledState.IconRightImage = null;
            this.btn_dung.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_dung.onHoverState.BorderRadius = 32;
            this.btn_dung.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dung.onHoverState.BorderThickness = 1;
            this.btn_dung.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_dung.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dung.onHoverState.IconLeftImage = null;
            this.btn_dung.onHoverState.IconRightImage = null;
            this.btn_dung.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dung.OnIdleState.BorderRadius = 32;
            this.btn_dung.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dung.OnIdleState.BorderThickness = 1;
            this.btn_dung.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dung.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_dung.OnIdleState.IconLeftImage = null;
            this.btn_dung.OnIdleState.IconRightImage = null;
            this.btn_dung.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dung.OnPressedState.BorderRadius = 32;
            this.btn_dung.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dung.OnPressedState.BorderThickness = 1;
            this.btn_dung.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_dung.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_dung.OnPressedState.IconLeftImage = null;
            this.btn_dung.OnPressedState.IconRightImage = null;
            this.btn_dung.Size = new System.Drawing.Size(126, 35);
            this.btn_dung.TabIndex = 63;
            this.btn_dung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dung.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dung.TextMarginLeft = 0;
            this.btn_dung.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_dung.UseDefaultRadiusAndThickness = true;
            this.btn_dung.Click += new System.EventHandler(this.btn_dung_Click);
            // 
            // btn_tienHoa100
            // 
            this.btn_tienHoa100.AllowAnimations = true;
            this.btn_tienHoa100.AllowMouseEffects = true;
            this.btn_tienHoa100.AllowToggling = false;
            this.btn_tienHoa100.AnimationSpeed = 200;
            this.btn_tienHoa100.AutoGenerateColors = false;
            this.btn_tienHoa100.AutoRoundBorders = false;
            this.btn_tienHoa100.AutoSizeLeftIcon = true;
            this.btn_tienHoa100.AutoSizeRightIcon = true;
            this.btn_tienHoa100.BackColor = System.Drawing.Color.Transparent;
            this.btn_tienHoa100.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tienHoa100.BackgroundImage")));
            this.btn_tienHoa100.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa100.ButtonText = "Tiến hóa 100 thế hệ";
            this.btn_tienHoa100.ButtonTextMarginLeft = 0;
            this.btn_tienHoa100.ColorContrastOnClick = 45;
            this.btn_tienHoa100.ColorContrastOnHover = 45;
            this.btn_tienHoa100.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btn_tienHoa100.CustomizableEdges = borderEdges11;
            this.btn_tienHoa100.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tienHoa100.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoa100.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoa100.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoa100.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tienHoa100.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tienHoa100.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoa100.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tienHoa100.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoa100.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_tienHoa100.IconMarginLeft = 11;
            this.btn_tienHoa100.IconPadding = 10;
            this.btn_tienHoa100.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tienHoa100.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoa100.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_tienHoa100.IconSize = 25;
            this.btn_tienHoa100.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa100.IdleBorderRadius = 32;
            this.btn_tienHoa100.IdleBorderThickness = 1;
            this.btn_tienHoa100.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa100.IdleIconLeftImage = null;
            this.btn_tienHoa100.IdleIconRightImage = null;
            this.btn_tienHoa100.IndicateFocus = false;
            this.btn_tienHoa100.Location = new System.Drawing.Point(104, 4);
            this.btn_tienHoa100.Name = "btn_tienHoa100";
            this.btn_tienHoa100.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoa100.OnDisabledState.BorderRadius = 32;
            this.btn_tienHoa100.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa100.OnDisabledState.BorderThickness = 1;
            this.btn_tienHoa100.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoa100.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoa100.OnDisabledState.IconLeftImage = null;
            this.btn_tienHoa100.OnDisabledState.IconRightImage = null;
            this.btn_tienHoa100.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_tienHoa100.onHoverState.BorderRadius = 32;
            this.btn_tienHoa100.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa100.onHoverState.BorderThickness = 1;
            this.btn_tienHoa100.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_tienHoa100.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoa100.onHoverState.IconLeftImage = null;
            this.btn_tienHoa100.onHoverState.IconRightImage = null;
            this.btn_tienHoa100.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa100.OnIdleState.BorderRadius = 32;
            this.btn_tienHoa100.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa100.OnIdleState.BorderThickness = 1;
            this.btn_tienHoa100.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoa100.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoa100.OnIdleState.IconLeftImage = null;
            this.btn_tienHoa100.OnIdleState.IconRightImage = null;
            this.btn_tienHoa100.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoa100.OnPressedState.BorderRadius = 32;
            this.btn_tienHoa100.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoa100.OnPressedState.BorderThickness = 1;
            this.btn_tienHoa100.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoa100.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoa100.OnPressedState.IconLeftImage = null;
            this.btn_tienHoa100.OnPressedState.IconRightImage = null;
            this.btn_tienHoa100.Size = new System.Drawing.Size(159, 35);
            this.btn_tienHoa100.TabIndex = 61;
            this.btn_tienHoa100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tienHoa100.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tienHoa100.TextMarginLeft = 0;
            this.btn_tienHoa100.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_tienHoa100.UseDefaultRadiusAndThickness = true;
            this.btn_tienHoa100.Click += new System.EventHandler(this.btn_tienHoa100_Click);
            // 
            // btn_tienHoaAll
            // 
            this.btn_tienHoaAll.AllowAnimations = true;
            this.btn_tienHoaAll.AllowMouseEffects = true;
            this.btn_tienHoaAll.AllowToggling = false;
            this.btn_tienHoaAll.AnimationSpeed = 200;
            this.btn_tienHoaAll.AutoGenerateColors = false;
            this.btn_tienHoaAll.AutoRoundBorders = false;
            this.btn_tienHoaAll.AutoSizeLeftIcon = true;
            this.btn_tienHoaAll.AutoSizeRightIcon = true;
            this.btn_tienHoaAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_tienHoaAll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoaAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tienHoaAll.BackgroundImage")));
            this.btn_tienHoaAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoaAll.ButtonText = "Tiến hóa tất cả";
            this.btn_tienHoaAll.ButtonTextMarginLeft = 0;
            this.btn_tienHoaAll.ColorContrastOnClick = 45;
            this.btn_tienHoaAll.ColorContrastOnHover = 45;
            this.btn_tienHoaAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btn_tienHoaAll.CustomizableEdges = borderEdges12;
            this.btn_tienHoaAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tienHoaAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoaAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoaAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoaAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tienHoaAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tienHoaAll.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoaAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tienHoaAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoaAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_tienHoaAll.IconMarginLeft = 11;
            this.btn_tienHoaAll.IconPadding = 10;
            this.btn_tienHoaAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tienHoaAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_tienHoaAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_tienHoaAll.IconSize = 25;
            this.btn_tienHoaAll.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoaAll.IdleBorderRadius = 32;
            this.btn_tienHoaAll.IdleBorderThickness = 1;
            this.btn_tienHoaAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoaAll.IdleIconLeftImage = null;
            this.btn_tienHoaAll.IdleIconRightImage = null;
            this.btn_tienHoaAll.IndicateFocus = false;
            this.btn_tienHoaAll.Location = new System.Drawing.Point(269, 4);
            this.btn_tienHoaAll.Name = "btn_tienHoaAll";
            this.btn_tienHoaAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_tienHoaAll.OnDisabledState.BorderRadius = 32;
            this.btn_tienHoaAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoaAll.OnDisabledState.BorderThickness = 1;
            this.btn_tienHoaAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tienHoaAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tienHoaAll.OnDisabledState.IconLeftImage = null;
            this.btn_tienHoaAll.OnDisabledState.IconRightImage = null;
            this.btn_tienHoaAll.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_tienHoaAll.onHoverState.BorderRadius = 32;
            this.btn_tienHoaAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoaAll.onHoverState.BorderThickness = 1;
            this.btn_tienHoaAll.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_tienHoaAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoaAll.onHoverState.IconLeftImage = null;
            this.btn_tienHoaAll.onHoverState.IconRightImage = null;
            this.btn_tienHoaAll.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoaAll.OnIdleState.BorderRadius = 32;
            this.btn_tienHoaAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoaAll.OnIdleState.BorderThickness = 1;
            this.btn_tienHoaAll.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tienHoaAll.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btn_tienHoaAll.OnIdleState.IconLeftImage = null;
            this.btn_tienHoaAll.OnIdleState.IconRightImage = null;
            this.btn_tienHoaAll.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoaAll.OnPressedState.BorderRadius = 32;
            this.btn_tienHoaAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tienHoaAll.OnPressedState.BorderThickness = 1;
            this.btn_tienHoaAll.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_tienHoaAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_tienHoaAll.OnPressedState.IconLeftImage = null;
            this.btn_tienHoaAll.OnPressedState.IconRightImage = null;
            this.btn_tienHoaAll.Size = new System.Drawing.Size(126, 35);
            this.btn_tienHoaAll.TabIndex = 62;
            this.btn_tienHoaAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tienHoaAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_tienHoaAll.TextMarginLeft = 0;
            this.btn_tienHoaAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_tienHoaAll.UseDefaultRadiusAndThickness = true;
            this.btn_tienHoaAll.Click += new System.EventHandler(this.btn_tienHoaAll_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lb_success
            // 
            this.lb_success.AutoSize = true;
            this.lb_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_success.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_success.Location = new System.Drawing.Point(75, 602);
            this.lb_success.Name = "lb_success";
            this.lb_success.Size = new System.Drawing.Size(0, 20);
            this.lb_success.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmPhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 687);
            this.Controls.Add(this.lb_success);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanLich";
            this.Text = "Phân lịch";
            this.Load += new System.EventHandler(this.FrmPhanLich_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPhanLich_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_success;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dung;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tienHoaAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tienHoa100;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tienHoa;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tkb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tkbGV;
        private System.Windows.Forms.Timer timer2;
    }
}