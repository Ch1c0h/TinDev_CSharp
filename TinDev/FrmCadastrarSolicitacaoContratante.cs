using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static TinDev.frmLogin;

namespace TinDev
{
    public partial class FrmCadastrarSolicitacaoContratante : Form
    {
        public FrmCadastrarSolicitacaoContratante()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        private string strcon = TinDev.Program.conexao;
        private string strsql = string.Empty;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            strsql = "insert into TinDevVagas (descricaoTrabalho, tituloTrabalho, tipoSistema, idContratante) " +
                "values (@DESCRICAO_TRABALHO, @TITULO_TRABALHO, @TIPO_SISTEMA, @CONTRATANTE)";
            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@descricao_trabalho", SqlDbType.VarChar).Value = campoDescricaoTrabalho.Text;
            comando.Parameters.Add("@titulo_trabalho", SqlDbType.VarChar).Value = campoTituloTrabalho.Text;

            if (rdbNaoInformaContratante.Checked)
            {
                comando.Parameters.Add("@TIPO_SISTEMA", SqlDbType.VarChar).Value = "Tipo de sistema não informado";
            }
            else if (rdbFront.Checked)
            {
                comando.Parameters.Add("@TIPO_SISTEMA", SqlDbType.VarChar).Value = "Front-End";
            }
            else if (rdbBack.Checked)
            {
                comando.Parameters.Add("@TIPO_SISTEMA", SqlDbType.VarChar).Value = "Back-End";
            }
            else if (rdbInfra.Checked)
            {
                comando.Parameters.Add("@TIPO_SISTEMA", SqlDbType.VarChar).Value = "Infraestrutura / Redes";
            }
            else if (rdbHibrido.Checked)
            {
                comando.Parameters.Add("@TIPO_SISTEMA", SqlDbType.VarChar).Value = "Sistema Híbrido";
            }

            if (rdbInformaContratante.Checked)
            {
                comando.Parameters.Add("@CONTRATANTE", SqlDbType.Int).Value = Sessao.Instance.CodUsuario;
            }
            else if (rdbNaoInformaContratante.Checked)
            {
                comando.Parameters.Add("@CONTRATANTE", SqlDbType.Int).Value = Sessao.Instance.CodUsuario;
            }

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro de trabalho realizado com sucesso");
                this.Close();
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
