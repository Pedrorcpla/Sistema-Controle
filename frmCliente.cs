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
    public partial class frmCliente : Form
    {
        private void Habilita()
        {
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_telefoneMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
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
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_telefoneMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
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
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);
            Desabilita();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool valida = true;
            int soma = 0, dig;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;
            dig = soma % 11;

            if(dig < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - dig;
            }

            if(int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) == dig)
            {
                soma = 0;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;
                dig = soma % 11;

                if (dig < 2)
                {
                    dig = 0;
                }
                else
                {
                    dig = 11 - dig;
                }

                if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(13, 1)) != dig)
                {
                    MessageBox.Show("CPF Inválido!");
                    cd_cpfMaskedTextBox.Focus();
                    valida = false;
                }
            }
            else
            {
                MessageBox.Show("CPF Inválido!");
                cd_cpfMaskedTextBox.Focus();
            }
            if(valida == true)
            {
                Validate();
                tbClienteBindingSource.EndEdit();
                tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
                Desabilita();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            Desabilita();
        }
    }
}
