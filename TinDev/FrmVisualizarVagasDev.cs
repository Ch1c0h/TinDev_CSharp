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
using static TinDev.frmLogin;

namespace TinDev
{
    public partial class FrmVisualizarVagasDev : Form
    {
        SqlConnection sqlcon = null;
        private string strcon = TinDev.Program.conexao;
        private string strsql = string.Empty;

        private string str2 = string.Empty;

        String id;
        int codUser = Sessao.Instance.CodUsuario;

        SqlConnection conexao = new SqlConnection(TinDev.Program.conexao);
        public FrmVisualizarVagasDev()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand("SELECT idVagas, tituloTrabalho, descricaoTrabalho, tipoSistema FROM TinDevVagas", conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns[0].HeaderText = "Id Vaga";
            dataGridView1.Columns[1].HeaderText = "Título";
            dataGridView1.Columns[2].HeaderText = "Descrição";
            dataGridView1.Columns[3].HeaderText = "Tipo";

            this.dataGridView1.Columns[0].Visible = false;

        }
     
        private void button2_Click(object sender, EventArgs e)
        {
           str2 = "insert into Interessados_vagas (CodVaga, CodInteressado)" +
                "values (@CodVaga, @CodInteressado)";
            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(str2, sqlcon);


            comando.Parameters.Add("@CodVaga", SqlDbType.VarChar).Value = id;
            comando.Parameters.Add("@CodInteressado", SqlDbType.VarChar).Value = Sessao.Instance.CodUsuario;
            

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
                this.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                MessageBox.Show("abriu");
            }
            catch (Exception)
            {
                conexao.Close();
                MessageBox.Show("fechou");
                throw;
            }
        }

        private void FrmVisualizarVagasDev_Load(object sender, EventArgs e)
        {
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
