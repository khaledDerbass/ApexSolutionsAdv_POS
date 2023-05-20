namespace supershop.Report
{
    partial class SaleReportRdlc
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
            this.salespaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psodbDataSet = new supershop.SalesRagister.psodbDataSet();
            this.sales_paymentTableAdapter = new supershop.SalesRagister.psodbDataSetTableAdapters.sales_paymentTableAdapter();
            this.rptSalesreport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sales_paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salespaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salespaymentBindingSource
            // 
            this.salespaymentBindingSource.DataMember = "sales_payment";
            this.salespaymentBindingSource.DataSource = this.psodbDataSet;
            // 
            // psodbDataSet
            // 
            this.psodbDataSet.DataSetName = "psodbDataSet";
            this.psodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_paymentTableAdapter
            // 
            this.sales_paymentTableAdapter.ClearBeforeFill = true;
            // 
            // rptSalesreport
            // 
            this.rptSalesreport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sales_paymentBindingSource;
            this.rptSalesreport.LocalReport.DataSources.Add(reportDataSource1);
            this.rptSalesreport.LocalReport.ReportEmbeddedResource = "supershop.Report.ReportSales.rdlc";
            this.rptSalesreport.Location = new System.Drawing.Point(0, 0);
            this.rptSalesreport.Name = "rptSalesreport";
            this.rptSalesreport.Size = new System.Drawing.Size(841, 741);
            this.rptSalesreport.TabIndex = 1;
            // 
            // sales_paymentBindingSource
            // 
            this.sales_paymentBindingSource.DataMember = "sales_payment";
            this.sales_paymentBindingSource.DataSource = this.psodbDataSet;
            // 
            // SaleReportRdlc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 741);
            this.Controls.Add(this.rptSalesreport);
            this.MinimizeBox = false;
            this.Name = "SaleReportRdlc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report ";
            this.Load += new System.EventHandler(this.SaleReportRdlc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salespaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SalesRagister.psodbDataSet psodbDataSet;
        private System.Windows.Forms.BindingSource salespaymentBindingSource;
        private SalesRagister.psodbDataSetTableAdapters.sales_paymentTableAdapter sales_paymentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptSalesreport;
        private System.Windows.Forms.BindingSource sales_paymentBindingSource;
    }
}