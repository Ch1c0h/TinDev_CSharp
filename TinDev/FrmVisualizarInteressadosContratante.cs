using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TinDev
{
    public partial class FrmVisualizarInteressadosContratante : Form
    {


        


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

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void Apresentacao_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click_4(object sender, EventArgs e)
        {
            ClVagas.Visible = true;
            CInteressados.Visible = false;
            PeDev.Visible = false;
        }
    }
    }


