namespace Shop_Project_WinForm
{
    partial class slton3thang
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
            this.quanlihangtonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCHQADataSet6 = new Shop_Project_WinForm.QLCHQADataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanlihangtonTableAdapter = new Shop_Project_WinForm.QLCHQADataSet6TableAdapters.quanlihangtonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanlihangtonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlihangtonBindingSource
            // 
            this.quanlihangtonBindingSource.DataMember = "quanlihangton";
            this.quanlihangtonBindingSource.DataSource = this.QLCHQADataSet6;
            // 
            // QLCHQADataSet6
            // 
            this.QLCHQADataSet6.DataSetName = "QLCHQADataSet6";
            this.QLCHQADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.quanlihangtonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shop_Project_WinForm.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // quanlihangtonTableAdapter
            // 
            this.quanlihangtonTableAdapter.ClearBeforeFill = true;
            // 
            // slton3thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "slton3thang";
            this.Text = "slton3thang";
            this.Load += new System.EventHandler(this.slton3thang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlihangtonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource quanlihangtonBindingSource;
        private QLCHQADataSet6 QLCHQADataSet6;
        private QLCHQADataSet6TableAdapters.quanlihangtonTableAdapter quanlihangtonTableAdapter;
    }
}