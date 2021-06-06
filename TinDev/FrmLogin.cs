using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinDev
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public string FNomeUsuario
        {
            get { return "Francisco"; }
        }

        public string FPerfilUsuario
        {
            get { return "DEV"; }
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            using (var formPrincipal = new FrmMenuPrincipal())
            {
                this.Hide();
                formPrincipal.Closed += (s, args) => this.Close();
                formPrincipal.FNomeUsuario = "Francisco";
                formPrincipal.FPerfilUsuario = "DEVs";
                formPrincipal.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void chkExibirSenha_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmCadastroPerfil();
            f.Closed += (s, args) => this.Show();
            f.Show();
        }
    }
}
