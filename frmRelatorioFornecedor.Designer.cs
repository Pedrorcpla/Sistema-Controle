
namespace ProjetoBancoDados
{
    partial class frmRelatorioFornecedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label titulo;
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CadastroDataSet = new ProjetoBancoDados.CadastroDataSet();
            this.tbFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFornecedorTableAdapter = new ProjetoBancoDados.CadastroDataSetTableAdapters.tbFornecedorTableAdapter();
            titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DadosFornecedor";
            reportDataSource3.Value = this.tbFornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoBancoDados.ReportFornecedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(563, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // CadastroDataSet
            // 
            this.CadastroDataSet.DataSetName = "CadastroDataSet";
            this.CadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedorBindingSource
            // 
            this.tbFornecedorBindingSource.DataMember = "tbFornecedor";
            this.tbFornecedorBindingSource.DataSource = this.CadastroDataSet;
            // 
            // tbFornecedorTableAdapter
            // 
            this.tbFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            titulo.Location = new System.Drawing.Point(177, 9);
            titulo.Name = "titulo";
            titulo.Size = new System.Drawing.Size(267, 25);
            titulo.TabIndex = 4;
            titulo.Text = "Relatório de Fornecedor";
            // 
            // frmRelatorioFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(titulo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioFornecedor";
            this.Text = "frmRelatorioFornecedor";
            this.Load += new System.EventHandler(this.frmRelatorioFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbFornecedorBindingSource;
        private CadastroDataSet CadastroDataSet;
        private CadastroDataSetTableAdapters.tbFornecedorTableAdapter tbFornecedorTableAdapter;
    }
}