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
    public partial class frmRelatorioProduto : Form
    {
        public frmRelatorioProduto()
        {
            InitializeComponent();
        }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'CadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.CadastroDataSet.tbProduto);
            // TODO: esta linha de código carrega dados na tabela 'CadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.CadastroDataSet.tbFornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
