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
    public partial class frmLogin : Form
    {
        public static string nivel;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbUsuarioTableAdapter.FillLogin(cadastroDataSet.tbUsuario,txtLogin.Text, txtSenha.Text);
            if((txtLogin.Text == "adm" && txtSenha.Text == "123") || tbUsuarioBindingSource.Count > 0)
            {
                if (tbUsuarioBindingSource.Count > 0)
                {
                    nivel = cadastroDataSet.tbUsuario.Rows[tbUsuarioBindingSource.Position][cadastroDataSet.tbUsuario.sg_nivelColumn].ToString();
                }
                else
                {
                    nivel = "1";
                }
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido!!!");
            }    
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
