using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static TinDev.frmLogin;
using System.Threading.Tasks;
using System.Linq;

namespace TinDev
{
    public partial class FrmVisualizarInteressadosContratante : Form
    {
        SqlConnection conexao = new SqlConnection(TinDev.Program.conexao);

         

        public FrmVisualizarInteressadosContratante()
            {
                InitializeComponent();


            }

        

            private void TelaVagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

           

            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();

            }

            private void FrmVisualizarInteressadosContratante_Load(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {


            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void Proximo_Click(object sender, EventArgs e)
            {
                CInteressados.Visible = true;

            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                
            PeDev.Visible = true;
                
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_2(object sender, EventArgs e)
            {
                this.Close();
            }

            private void EmailDev_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_3(object sender, EventArgs e)
            {

            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {
            
            }

            private void BtVoltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

           public void Click()
            {
            String conexao = TinDev.Program.conexao;

            string Click = " select " +
                   " USUARIOS.ID, " +
                    " USUARIOS.NOME " +
                    " FROM " +
                       " USUARIOS " +
                 " JOIN Interessados_vagas ON " +
                     " Interessados_vagas.codInteressado = USUARIOS.ID " +
                        "where  Interessados_vagas.CodVaga = @USUARIO  ";


            SqlConnection con = new SqlConnection(conexao);

            SqlCommand comand = new SqlCommand(Click, con);

            comand.Parameters.Add("@USUARIO", SqlDbType.Int).Value = Sessao.Instance.CodUsuario;

            con.Open();

            comand.CommandType = CommandType.Text;

            SqlDataAdapter adapt = new SqlDataAdapter(comand);

            DataTable Interessado = new DataTable();

            adapt.Fill(Interessado);

            TelaInteressados.DataSource = Interessado;

            




        }

            private void Apresentacao_Click(object sender, EventArgs e)
            {

            }

        public void retornoBd() 
        {
            String conexao = TinDev.Program.conexao;

            string retornoBd = "select " +
                               "  idVagas, " +
                               "  tituloTrabalho " +
                               "from  " +
                               "  TinDevVagas  " +
                               "join Interessados_vagas on " +
                               "  TinDevVagas.CodVaga = Interessados_vagas.idContratante " +
                               "where  " +
                               "  Interessados_vagas.CodVaga  = @USUARIO  "; 
                            

     
            SqlConnection con = new SqlConnection(conexao);

            SqlCommand comand = new SqlCommand(retornoBd, con);

            comand.Parameters.Add("@USUARIO", SqlDbType.Int).Value = Sessao.Instance.CodUsuario;

            con.Open();

            comand.CommandType = CommandType.Text;

            SqlDataAdapter adapta = new SqlDataAdapter(comand);



            DataTable MostraVagas = new DataTable();

            adapta.Fill(MostraVagas);

            TelaVagas.DataSource = MostraVagas;


        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            retornoBd();
            ClVagas.Visible = true;         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = TelaInteressados.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = TelaInteressados.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = TelaInteressados.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = TelaInteressados.CurrentRow.Cells[3].Value.ToString();
        }

        private void TelaVagas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Interessado_Click(object sender, EventArgs e)
        {
            Click();
        }

        private void FrmVisualizarInteressadosContratante_Shown(object sender, EventArgs e)
        {
            retornoBd();
        }
    }
    }


