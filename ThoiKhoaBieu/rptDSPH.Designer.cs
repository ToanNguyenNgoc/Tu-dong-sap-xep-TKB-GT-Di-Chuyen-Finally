namespace ThoiKhoaBieu
{
    partial class rptDSPH
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
            this.PhongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDSPH = new ThoiKhoaBieu.DataSetDSPH();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhongHocTableAdapter = new ThoiKhoaBieu.DataSetDSPHTableAdapters.PhongHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PhongHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSPH)).BeginInit();
            this.SuspendLayout();
            // 
            // PhongHocBindingSource
            // 
            this.PhongHocBindingSource.DataMember = "PhongHoc";
            this.PhongHocBindingSource.DataSource = this.DataSetDSPH;
            // 
            // DataSetDSPH
            // 
            this.DataSetDSPH.DataSetName = "DataSetDSPH";
            this.DataSetDSPH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhongHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThoiKhoaBieu.ReportDSPH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // PhongHocTableAdapter
            // 
            this.PhongHocTableAdapter.ClearBeforeFill = true;
            // 
            // rptDSPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 405);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDSPH";
            this.Text = "rptDSPH";
            this.Load += new System.EventHandler(this.rptDSPH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhongHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSPH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhongHocBindingSource;
        private DataSetDSPH DataSetDSPH;
        private DataSetDSPHTableAdapters.PhongHocTableAdapter PhongHocTableAdapter;
    }
}