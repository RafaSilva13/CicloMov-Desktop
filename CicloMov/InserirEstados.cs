using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicloMov
{
    public partial class frmInserirEstados : Form
    {
        public frmInserirEstados()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarEstados area_ListarEstados = new frmListarEstados();

            area_ListarEstados.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(txtNomeEstado.Text != "" && txtSiglaEstado.Text != "")
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("INSERT INTO estados (descricao_estado, sigla) VALUES (@nomeEstado, @siglaEstado);", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@nomeEstado", txtNomeEstado.Text);
                    comando.Parameters.AddWithValue("@siglaEstado", txtSiglaEstado.Text);

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Estado inserido com sucesso!");

                        txtNomeEstado.Text = "";
                        txtSiglaEstado.Text = "";
                        
                    }
                    finally
                    {
                        myReader.Close();
                        cnn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }
    }
}
