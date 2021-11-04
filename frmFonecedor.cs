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
    public partial class frmFornecedor : Form
    {
        private void Habilita()
        {
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_telefoneMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
            nm_contatoTextBox.Enabled = true;
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
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_telefoneMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            nm_contatoTextBox.Enabled = false;
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
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFonecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            Desabilita();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.RemoveCurrent();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
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

            if (dig < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - dig;
            }

            if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) == dig)
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
            if (valida == true)
            {
                Validate();
                tbFornecedorBindingSource.EndEdit();
                tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
                Desabilita();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaFornecedor fpf = new frmPesquisaFornecedor();
            fpf.ShowDialog();
            cod = fpf.getCodigo();
            if (cod >= 0)
            {
                reg = tbFornecedorBindingSource.Find("cd_fornecedor", cod);
                tbFornecedorBindingSource.Position = reg;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE FORECEDOR" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cd_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nm_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Endereço: " + ds_enderecoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Número: " + nr_enderecoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + nm_cidadeTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Estado: " + sg_estadoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + cd_cepMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + cd_telefoneMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CPF: " + cd_cpfMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "RG: " + cd_rgTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CNPJ: " + cd_cnpjMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "IE: " + cd_ieTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Tipo: " + sg_tipoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Email: " + ds_emailTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome de Contato: " + nm_contatoTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
