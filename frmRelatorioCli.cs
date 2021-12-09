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
    public partial class frmRelatorioCli : Form
    {
        public frmRelatorioCli()
        {
            InitializeComponent();
        }

        private void frmRelatorioCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'CadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.CadastroDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
