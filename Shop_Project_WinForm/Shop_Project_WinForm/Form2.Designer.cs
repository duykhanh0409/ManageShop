namespace Shop_Project_WinForm
{
    partial class Form2
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
            this.thongtinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCHQADataSet5 = new Shop_Project_WinForm.QLCHQADataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongtinTableAdapter = new Shop_Project_WinForm.QLCHQADataSet5TableAdapters.thongtinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // thongtinBindingSource
            // 
            this.thongtinBindingSource.DataMember = "thongtin";
            this.thongtinBindingSource.DataSource = this.QLCHQADataSet5;
            // 
            // QLCHQADataSet5
            // 
            this.QLCHQADataSet5.DataSetName = "QLCHQADataSet5";
            this.QLCHQADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongtinBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shop_Project_WinForm.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // thongtinTableAdapter
            // 
            this.thongtinTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongtinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHQADataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thongtinBindingSource;
        private QLCHQADataSet5 QLCHQADataSet5;
        private QLCHQADataSet5TableAdapters.thongtinTableAdapter thongtinTableAdapter;
    }
}