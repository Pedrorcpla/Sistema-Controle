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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);

        }

        private void tbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbFornecedorDataGridView.CurrentRow.Cells[0].Value);
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
                this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            }
            else
            {
                this.tbFornecedorTableAdapter.FillByNomeFornecedor(this.cadastroDataSet.tbFornecedor, "%" + txtNome.Text + "%");
            }
        }
    }
}
