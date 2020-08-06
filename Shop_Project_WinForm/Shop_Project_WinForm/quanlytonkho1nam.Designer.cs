namespace Shop_Project_WinForm
{
    partial class quanlytonkho1nam
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
            this.quanlihangtonnamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCHQADataSet8 = new Shop_Project_WinForm.QLCHQADataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanlihangtonnamTableAdapter = new Shop_Project_WinForm.QLCHQADataSet8TableAdapters.quanlihangtonnamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanlihangtonnamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlihangtonnamBindingSource
            // 
            this.quanlihangtonnamBindingSource.DataMember = "quanlihangtonnam";
            this.quanlihangtonnamBindingSource.DataSource = this.QLCHQADataSet8;
            // 
            // QLCHQADataSet8
            // 
            this.QLCHQADataSet8.DataSetName = "QLCHQADataSet8";
            this.QLCHQADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.quanlihangtonnamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shop_Project_WinForm.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // quanlihangtonnamTableAdapter
            // 
            this.quanlihangtonnamTableAdapter.ClearBeforeFill = true;
            // 
            // quanlytonkho1nam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "quanlytonkho1nam";
            this.Text = "quanlytonkho1nam";
            this.Load += new System.EventHandler(this.quanlytonkho1nam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlihangtonnamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource quanlihangtonnamBindingSource;
        private QLCHQADataSet8 QLCHQADataSet8;
        private QLCHQADataSet8TableAdapters.quanlihangtonnamTableAdapter quanlihangtonnamTableAdapter;
    }
}