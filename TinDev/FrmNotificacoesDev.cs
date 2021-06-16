using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static TinDev.frmLogin;

namespace TinDev
{
    public partial class FrmNotificacoesDev : Form
    {
        
       

        public FrmNotificacoesDev()
        {
            InitializeComponent();
        }

        public void FrmNotificacoesDev_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        public void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();

            this.WindowState = FormWindowState.Normal;

            this.notifyIcon1.Visible = false;
        }



        public void Atualizar_Notificacoes(object sender, EventArgs e)
        {
            string strProvider = TinDev.Program.conexao;

            string strSql = " SELECT " +
                            "  tituloTrabalho, " +
                            "  descricaoTrabalho " +
                            " FROM " +
                            "  Interessados_vagas " +
                            "  join USUARIOS on " +
                            "    USUARIOS.ID = Interessados_vagas.codInteressado  " +
                            "  join TinDevVagas on " +
                            "    TinDevVagas.idvagas = codvaga " +
                            " WHERE " +
                            "   Interessados_vagas.codinteressado = @USUARIO and " +
                            "  interessados_vagas.Aprovado = 'SIM' ";

            SqlConnection con = new SqlConnection(strProvider);

            SqlCommand comando = new SqlCommand(strSql, con);

            comando.Parameters.Add("@USUARIO", SqlDbType.Int).Value = Sessao.Instance.CodUsuario;

            con.Open();

            comando.CommandType = CommandType.Text;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

          

            DataTable notificacao = new DataTable();

            adaptador.Fill(notificacao);

            dtgNotificacao.DataSource = notificacao;

        }
    }
}

     
    

