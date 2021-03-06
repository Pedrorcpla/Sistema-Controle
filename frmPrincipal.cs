using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoBancoDados
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            //Projeto feito por Pedro Nascimento
            InitializeComponent();
            SlashScreen splash = new SlashScreen();
            splash.Show();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto fp = new frmProduto();
            fp.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin.nivel != "1")
            {
                usuárioToolStripMenuItem.Enabled = false;
            }
            else 
            {
                usuárioToolStripMenuItem.Enabled = true;   
            }
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioUsu ru = new frmRelatorioUsu();
            ru.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCli rc = new frmRelatorioCli();
            rc.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor rf = new frmRelatorioFornecedor();
            rf.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto rp = new frmRelatorioProduto();
            rp.ShowDialog();
        }
    }
}
