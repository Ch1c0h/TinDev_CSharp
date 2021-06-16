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
            string strProvider = @"Data Source=DESKTOP-396MMQQ\SQLEXPRESS;
                                    Integrated Security=True;Connect Timeout=30;
                                    Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";

            string strSql = @"SELECT v.tituloTrabalho, v.descricaoTrabalho
                            FROM [dbo].[USUARIOS] as u, [dbo].[Interessados_vagas] as i, [dbo].[TinDevVagas] as v WHERE u.ID = i.codInteressado AND i.CodVaga = v.idVagas AND i.Aprovado = 'sim'";

            SqlConnection con = new SqlConnection(strProvider);

            SqlCommand comando = new SqlCommand(strSql, con);

            con.Open();


            comando.CommandType = CommandType.Text;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

          

            DataTable notificacao = new DataTable();

            adaptador.Fill(notificacao);

            dtgNotificacao.DataSource = notificacao;

        }
    }
}

     
    

