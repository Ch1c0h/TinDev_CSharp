using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TinDev
{
    public partial class FrmMenuPrincipal : Form
    {
        public string NomeUsuario;
        public string PerfilUsuario;

        public string FNomeUsuario
        {
            set { NomeUsuario = value; }
        }

        public string FPerfilUsuario
        {
            set { PerfilUsuario = value; }
        }

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public void CarregarTela()
        {
            lblUsuario.Text = NomeUsuario;
            lblPerfilUsuario.Text = PerfilUsuario;

            Size = new Size(1024, 408);

            if (PerfilUsuario == "DEV")
            {
                pnlMenuPrincipalContratante.Visible = false;
                pnlMenuPrincipalContratante.Dock = DockStyle.None;

                pnlMenuPrincipalDev.Visible = true;
                pnlMenuPrincipalDev.Dock = DockStyle.Fill;
            }
            else
            {
                pnlMenuPrincipalDev.Visible = false;
                pnlMenuPrincipalDev.Dock = DockStyle.None;

                pnlMenuPrincipalContratante.Visible = true;
                pnlMenuPrincipalContratante.Dock = DockStyle.Fill;
            }

        }

        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            CarregarTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVisualizarVagasDisponíveis_Click(object sender, EventArgs e)
        {
            using (var formPrincipal = new FrmVisualizarVagasDev())
            {
                this.Hide();
                formPrincipal.Closed += (s, args) => this.Show();
                formPrincipal.ShowDialog();
            }
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            using (var formPrincipal = new FrmNotificacoesDev())
            {
                this.Hide();
                formPrincipal.Closed += (s, args) => this.Show();
                formPrincipal.ShowDialog();
            }
        }

        private void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            using (var formPrincipal = new FrmCadastrarSolicitacaoContratante())
            {
                this.Hide();
                formPrincipal.Closed += (s, args) => this.Show();
                formPrincipal.ShowDialog();
            }
        }

        private void btnVisualizarInteressados_Click(object sender, EventArgs e)
        {
            using (var formPrincipal = new FrmVisualizarInteressadosContratante())
            {
                this.Hide();
                formPrincipal.Closed += (s, args) => this.Show();
                formPrincipal.ShowDialog();
            }
        }
    }
}
