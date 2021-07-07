namespace ThoiKhoaBieu
{
    partial class rptDSGV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDSGV = new ThoiKhoaBieu.DataSetDSGV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GiaoVienTableAdapter = new ThoiKhoaBieu.DataSetDSGVTableAdapters.GiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GiaoVienBindingSource
            // 
            this.GiaoVienBindingSource.DataMember = "GiaoVien";
            this.GiaoVienBindingSource.DataSource = this.DataSetDSGV;
            // 
            // DataSetDSGV
            // 
            this.DataSetDSGV.DataSetName = "DataSetDSGV";
            this.DataSetDSGV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GiaoVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThoiKhoaBieu.ReportDSGV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(848, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // GiaoVienTableAdapter
            // 
            this.GiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // rptDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDSGV";
            this.Text = "rptDSGV";
            this.Load += new System.EventHandler(this.rptDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GiaoVienBindingSource;
        private DataSetDSGV DataSetDSGV;
        private DataSetDSGVTableAdapters.GiaoVienTableAdapter GiaoVienTableAdapter;
    }
}