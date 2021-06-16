using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinDev
{
    public partial class frmLogin : Form
    {
        SqlConnection sqlcon = null;
        private string strcon = TinDev.Program.conexao;
        private string strsql = string.Empty;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarLogin();
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

        public sealed class Sessao
        {
            private static volatile Sessao instance;
            private static object sync = new Object();

            private Sessao() { }

            public static Sessao Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (sync)
                        {
                            if (instance == null)
                            {
                                instance = new Sessao();
                            }
                        }
                    }
                    return instance;
                }

            }

            public int CodUsuario { get; set; }
            public string NomeUsuario { get; set; }
            public string PerfilUsuario { get; set; }

        }

        public void RealizarLogin()
        {            
            strsql = "select    " +
                     "  ID," +
                     "  NOME," +
                     "  TIPO_USUARIO " +
                     "from " +
                     "  USUARIOS " +
                     "where " +
                     "  USUARIOS.USUARIO = @USUARIO and " +
                     "  USUARIOS.SENHA = @SENHA ";

            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = txbUsuario.Text;
            comando.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txbSenha.Text;

            try
            {
                sqlcon.Open();
                SqlDataReader dados = comando.ExecuteReader();

                if (dados.HasRows)
                {
                    dados.Read();    
                    Sessao.Instance.CodUsuario    = (int)dados["ID"];
                    Sessao.Instance.NomeUsuario   = (string)dados["NOME"];
                    Sessao.Instance.PerfilUsuario = (string)dados["TIPO_USUARIO"];

                    using (var formPrincipal = new FrmMenuPrincipal())
                    {
                        this.Hide();
                        formPrincipal.Closed += (s, args) => this.Close();
                        formPrincipal.ShowDialog();
                    }
                }
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
