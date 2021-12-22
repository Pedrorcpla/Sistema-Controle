using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDados
{
    public partial class frmProduto : Form
    {
        private void Habilita()
        {
            nm_produtoTextBox.Enabled = true;
            nm_categoriaTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }
        private void Desabilita()
        {
            nm_produtoTextBox.Enabled = false;
            nm_categoriaTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);
            Desabilita();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.RemoveCurrent();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbProdutoBindingSource.EndEdit();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaProduto fpp = new frmPesquisaProduto();
            fpp.ShowDialog();
            cod = fpp.getCodigo();
            if (cod >= 0)
            {
                reg = tbProdutoBindingSource.Find("cd_produto", cod);
                tbProdutoBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE PRODUTO" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cd_produtoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nm_produtoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Categoria: " + nm_categoriaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Quantidade: " + qt_estoqueTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor de custo: " + vl_custoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor de venda: " + vl_vendaTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
        }
    }
}
