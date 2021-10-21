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
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }


        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);
            }
            else
            {
                this.tbClienteTableAdapter.FillByNomeCliente(this.cadastroDataSet.tbCliente, "%" + txtNome.Text + "%");
            }
        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbClienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
