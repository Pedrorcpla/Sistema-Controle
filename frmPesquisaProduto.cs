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
    public partial class frmPesquisaProduto : Form
    {
        private int codigo;
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);

        }

        private void tbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbProdutoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);
            }
            else
            {
                this.tbProdutoTableAdapter.FillByNomeProd(this.cadastroDataSet.tbProduto, "%" + txtNome.Text + "%");
            }
        }
    }
}
