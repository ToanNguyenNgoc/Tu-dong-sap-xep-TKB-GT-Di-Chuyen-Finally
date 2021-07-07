namespace ThoiKhoaBieu
{
    partial class rptDSLH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDSLH = new ThoiKhoaBieu.DataSetDSLH();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LopHocTableAdapter = new ThoiKhoaBieu.DataSetDSLHTableAdapters.LopHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // LopHocBindingSource
            // 
            this.LopHocBindingSource.DataMember = "LopHoc";
            this.LopHocBindingSource.DataSource = this.DataSetDSLH;
            // 
            // DataSetDSLH
            // 
            this.DataSetDSLH.DataSetName = "DataSetDSLH";
            this.DataSetDSLH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LopHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThoiKhoaBieu.ReportDSLH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(623, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // LopHocTableAdapter
            // 
            this.LopHocTableAdapter.ClearBeforeFill = true;
            // 
            // rptDSLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 371);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDSLH";
            this.Text = "rptDSLH";
            this.Load += new System.EventHandler(this.rptDSLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LopHocBindingSource;
        private DataSetDSLH DataSetDSLH;
        private DataSetDSLHTableAdapters.LopHocTableAdapter LopHocTableAdapter;
    }
}