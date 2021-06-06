using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TinDev
{
    public partial class FrmCadastroPerfil : Form
    {
        public FrmCadastroPerfil()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        private string strcon = TinDev.Program.conexao;
        private string strsql = string.Empty;

        public void AnalisaPerfil()
        {
            if (rdbContratante.Checked)
            {
                if (pnlPerfilContratante.Visible == false)
                {
                    pnlPerfilDev.Visible = false;
                    pnlPerfilContratante.Visible = true;

                    pnlPerfilContratante.Dock = DockStyle.Fill;
                    pnlPerfilDev.Dock = DockStyle.None;

                    Size = new Size(464, 593);                    
                }
            }
            else
            {
                if (pnlPerfilDev.Visible == false)
                {
                    pnlPerfilContratante.Visible = false;
                    pnlPerfilDev.Visible = true;

                    pnlPerfilContratante.Dock = DockStyle.None;
                    pnlPerfilDev.Dock = DockStyle.Fill;
                    Size = new Size(610, 730);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbColaborador_Click(object sender, EventArgs e)
        {
            AnalisaPerfil();
        }

        private void rdbDesenvolvedor_Click(object sender, EventArgs e)
        {
            AnalisaPerfil();
        }

        private void grpPerfilUsuario_MouseCaptureChanged(object sender, EventArgs e)
        {
            AnalisaPerfil();
        }

        private void FrmCadastroPerfil_Shown(object sender, EventArgs e)
        {
            AnalisaPerfil();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarContratante_Click(object sender, EventArgs e)
        {
            if (rdbContratante.Checked)
            {
                InserirContratante();
            }
            else
            {
                InserirDev();
            }            
        }

        public void InserirContratante()
        {
            strsql = "insert into USUARIOS (TIPO_USUARIO, NOME, EMAIL, USUARIO, SENHA) " +
                "values (@TIPO_USUARIO, @NOME, @EMAIL, @USUARIO, @SENHA)";
            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@TIPO_USUARIO", SqlDbType.VarChar).Value = "Contratante";
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txbNomeEmpresaContratante.Text;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txbEmailContratante.Text;
            comando.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txbUsuarioContratante.Text;
            comando.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txbSenhaContratante.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void InserirDev()
        {
            strsql = "insert into USUARIOS (TIPO_USUARIO, NOME, EMAIL, FONE, USUARIO, SENHA, PERFIL, APRESENTACAO) " +
                "values (@TIPO_USUARIO, @NOME, @EMAIL, @FONE, @USUARIO, @SENHA, @PERFIL, @APRESENTACAO)";
            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@TIPO_USUARIO", SqlDbType.VarChar).Value = "DEV";
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txbNomeDev.Text;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txbEmailDev.Text;
            comando.Parameters.Add("@FONE", SqlDbType.VarChar).Value = mtxTelefoneDev.Text;
            comando.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txbUsuarioDev.Text;
            comando.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txbSenhaDev.Text;

            if (rdbFrontEnd.Checked)
                comando.Parameters.Add("@PERFIL", SqlDbType.VarChar).Value = "FRONTEND";
            else if (rdbBackEnd.Checked)
                comando.Parameters.Add("@PERFIL", SqlDbType.VarChar).Value = "BACKEND";
            else if (rdbFullStack.Checked)
                comando.Parameters.Add("@PERFIL", SqlDbType.VarChar).Value = "FULLSTACK";
            else
                comando.Parameters.Add("@PERFIL", SqlDbType.VarChar).Value = "INFRA";

            comando.Parameters.Add("@APRESENTACAO", SqlDbType.VarChar).Value = rtbApresentacaoDev.Text;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
