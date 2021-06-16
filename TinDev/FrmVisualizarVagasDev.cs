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
    public partial class FrmVisualizarVagasDev : Form
    {
        SqlConnection conexao = new SqlConnection(TinDev.Program.conexao);
        public FrmVisualizarVagasDev()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand("SELECT tituloTrabalho, descricaoTrabalho, tipoSistema FROM TinDevVagas", conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dataGridView1.DataSource = tabela;

            dataGridView1.Columns[0].HeaderText = "Título";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Tipo";

        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            
                
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
            
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
        
        }
}
