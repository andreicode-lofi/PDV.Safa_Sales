
namespace PdvSafeSales
{
    partial class frm_RelatorioProduto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_Pvd_SafeSalesDataSet1 = new PdvSafeSales.db_Pvd_SafeSalesDataSet1();
            this.tb_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ProdutoTableAdapter = new PdvSafeSales.db_Pvd_SafeSalesDataSet1TableAdapters.tb_ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_Pvd_SafeSalesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_ProdutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PdvSafeSales.Rel_Produto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_Pvd_SafeSalesDataSet1
            // 
            this.db_Pvd_SafeSalesDataSet1.DataSetName = "db_Pvd_SafeSalesDataSet1";
            this.db_Pvd_SafeSalesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ProdutoBindingSource
            // 
            this.tb_ProdutoBindingSource.DataMember = "tb_Produto";
            this.tb_ProdutoBindingSource.DataSource = this.db_Pvd_SafeSalesDataSet1;
            // 
            // tb_ProdutoTableAdapter
            // 
            this.tb_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelatorioProduto";
            this.Text = "frm_RelatorioProduto";
            this.Load += new System.EventHandler(this.frm_RelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_Pvd_SafeSalesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_ProdutoBindingSource;
        private db_Pvd_SafeSalesDataSet1 db_Pvd_SafeSalesDataSet1;
        private db_Pvd_SafeSalesDataSet1TableAdapters.tb_ProdutoTableAdapter tb_ProdutoTableAdapter;
    }
}