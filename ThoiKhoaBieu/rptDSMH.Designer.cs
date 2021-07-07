namespace ThoiKhoaBieu
{
    partial class rptDSMH
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
            this.MonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDSMH = new ThoiKhoaBieu.DataSetDSMH();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MonHocTableAdapter = new ThoiKhoaBieu.DataSetDSMHTableAdapters.MonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // MonHocBindingSource
            // 
            this.MonHocBindingSource.DataMember = "MonHoc";
            this.MonHocBindingSource.DataSource = this.DataSetDSMH;
            // 
            // DataSetDSMH
            // 
            this.DataSetDSMH.DataSetName = "DataSetDSMH";
            this.DataSetDSMH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MonHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThoiKhoaBieu.ReportDSMH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(817, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // MonHocTableAdapter
            // 
            this.MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // rptDSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDSMH";
            this.Text = "frmDSMH";
            this.Load += new System.EventHandler(this.frmDSMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDSMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MonHocBindingSource;
        private DataSetDSMH DataSetDSMH;
        private DataSetDSMHTableAdapters.MonHocTableAdapter MonHocTableAdapter;
    }
}