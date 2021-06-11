using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;using System.Data.SqlClient;

namespace TinDev
{
    public partial class FrmVisualizarInteressadosContratante : Form
    {
        public FrmVisualizarInteressadosContratante()
        {
            InitializeComponent();
            listBox();
        }
        
        void listBox()
        {
            SqlConnection sqlcon = null;
            string strcon = TinDev.Program.conexao;
            string strsql = string.Empty;
            strsql = "select tituloTrabalho from TinDevVagas"; //em vez de tituloTrabalho vai ser Nome. E em vez do TiDevVagas vai ser a sua tabela.
            sqlcon = new SqlConnection(strcon);
            SqlCommand comando = new SqlCommand(strsql, sqlcon);
            SqlDataReader dbr;

            try

            {

                sqlcon.Open();
                dbr = comando.ExecuteReader();
                               
                while (dbr.Read())

                {
                    string sname = (string) dbr.GetString(0);
                    listBox1.Items.Add(sname);                    
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }          
 }
    

